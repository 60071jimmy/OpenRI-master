/*
Copyright 2016 Open Robot Club

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/


#include "openri.h"


#ifdef __cplusplus
extern "C" 
{
#endif


    RI_API int RiArray_Sort(RiArray_t  *riArray, RiCompare_f compareFunction) {
        if(riArray->length <= 1) return RI_OK;

        qsort(riArray->data, riArray->length, riArray->elementSize, compareFunction);

        return RI_OK;
    }

    RI_API RiArray_t *RiArray_New(ri_utf8 *elementType, int elementSize, int reservedLength)
    {
        //static RiLock_t lock = RI_LOCK_UNLOCKED;  
        RiArray_t *riArray;

        ////RiLock_Lock(&lock);

        riArray = (RiArray_t *)ri_calloc(1, sizeof(RiArray_t));

        //gt_strcpy_s(riArray->elementType, RI_PAGE_SIZE, elementType);

        //RI_LOCK_Init(&riArray->lock);
        riArray->elementSize = elementSize;
        riArray->length = 0;
        riArray->realLength = reservedLength;
        riArray->reservedLength = reservedLength;
        riArray->data = (ri_byte *)ri_calloc(reservedLength, elementSize);

        ////RiLock_Unlock(&lock);

        return riArray;
    }

    RI_API ri_utf8 *RiArray_GetElementType(RiArray_t *riArray)
    {
        ri_utf8 *elementType;
        

        //RiLock_Lock(&riArray->lock);

        elementType = riArray->elementType;

        //RiLock_Unlock(&riArray->lock);  
        return elementType;
    }

    RI_API int RiArray_GetElementSize(RiArray_t *riArray)
    {
        int elementSize;
        

        //RiLock_Lock(&riArray->lock);

        elementSize = riArray->elementSize;

        //RiLock_Unlock(&riArray->lock);  
        return elementSize;
    }

    RI_API int RiArray_Free(RiArray_t *riArray)
    {

        //RiLock_Lock(&riArray->lock);


        ri_free(riArray->data);    
        ri_free(riArray);

        return RI_OK;
    }

    RI_API ri_ptr RiArray_Get(RiArray_t *riArray, int index)
    {
        ri_ptr ptr;

        

        //RiLock_Lock(&riArray->lock);

        if(index >= riArray->length)
        {
            //RiLock_Unlock(&riArray->lock);
            return NULL;
        }

        ptr = (ri_ptr)(riArray->data + riArray->elementSize*index);
        //RiLock_Unlock(&riArray->lock);
        return ptr;
    }

    RI_API int RiArray_Copy(RiArray_t *riArray, int index, ri_ptr element)
    {
        if(element == NULL) return RI_ERROR_NULL_POINTER;
        if(index >= riArray->length)
        {
            ri_memset(element, 0, riArray->elementSize);
            return RI_ERROR_RANGE;
        }

        //RiLock_Lock(&riArray->lock);    
        ri_memcpy(element, riArray->data+riArray->elementSize*index, riArray->elementSize);
        //RiLock_Unlock(&riArray->lock);

        return RI_OK;
    }

    RI_API int RiArray_Set(RiArray_t *riArray, int index, ri_ptr element)
    {
        if(element == NULL) return RI_ERROR_NULL_POINTER;
        if(index >= riArray->length) return RI_ERROR_RANGE;

        //RiLock_Lock(&riArray->lock);    

        ri_memcpy(riArray->data+riArray->elementSize*index, element, riArray->elementSize);

        //RiLock_Unlock(&riArray->lock);  
        return RI_OK;
    }

    int riArray_SetRealLength(RiArray_t *riArray, int realLength)
    {
        //  ri_dbg("riArray_SetRealLength ++: realLength=%d" RI_NL, realLength);

        if(realLength > riArray->realLength)
        {
            ri_ptr data = (ri_ptr )ri_calloc(realLength, riArray->elementSize); 
            if(data == NULL)
            {      
                dbg("riArray_SetRealLength: RI_ERR_ENOMEM" RI_NL);
                return RI_ERROR_ENOMEM; 
            }
            ri_memcpy(data, riArray->data, riArray->realLength * riArray->elementSize);
            ri_free(riArray->data);
            riArray->data = (ri_byte *)data;    
            riArray->realLength = realLength;
        }
        else if(realLength < riArray->realLength)
        {
            ri_ptr data = (ri_ptr )ri_calloc(realLength, riArray->elementSize); 
            if(data == NULL)
            {      
                dbg("riArray_SetRealLength: RI_ERR_ENOMEM" RI_NL);
                return RI_ERROR_ENOMEM; 
            }
            ri_memcpy(data, riArray->data, realLength * riArray->elementSize);
            ri_free(riArray->data);
            riArray->data = (ri_byte *)data;
            riArray->realLength = realLength;
            if(riArray->length > riArray->realLength) riArray->length = riArray->realLength;
        }

        //  ri_dbg("riArray_SetRealLength --: realLength=%d" RI_NL, realLength);

        return RI_OK;
    }

    RI_API int RiArray_Append(RiArray_t *riArray, ri_ptr element)
    {
        int ret;

        if(element == NULL) return RI_ERROR_NULL_POINTER;  

        //RiLock_Lock(&riArray->lock);    

        //  ri_dbg("RiArray_Append: riArray->realLength=%d, riArray->reservedLength=%d, riArray->elementSize=%d" RI_NL,
        //          riArray->realLength,
        //          riArray->reservedLength,
        //          riArray->elementSize);

        if(riArray->realLength < (riArray->length + 1))
        {
            ret = riArray_SetRealLength(riArray, riArray->realLength + riArray->reservedLength + 1);  

            if(ret != RI_OK)
            {
                //RiLock_Unlock(&riArray->lock);
                return ret;
            }
        }

        ri_memcpy(riArray->data+(riArray->length)*(riArray->elementSize), element, riArray->elementSize);
        riArray->length ++;

        //RiLock_Unlock(&riArray->lock);
        return RI_OK;
    }

    RI_API int RiArray_Insert(RiArray_t *riArray, int index, ri_ptr element)
    {
        ri_byte *data;
        if(element == NULL) return RI_ERROR_NULL_POINTER;  
        if(index > riArray->length) return RI_ERROR_RANGE;  

        //RiLock_Lock(&riArray->lock);

        if(riArray->realLength < (riArray->length + 1))
        {
            riArray_SetRealLength(riArray, riArray->realLength + riArray->reservedLength + 1);  
        }

        data = (ri_byte *)ri_calloc(riArray->realLength, riArray->elementSize);

        if(index > 0)
            ri_memcpy(data, riArray->data, index * riArray->elementSize);

        ri_memcpy(data + index * riArray->elementSize, (ri_byte *)element, riArray->elementSize);

        if(index < riArray->length)
            ri_memcpy(data + (index + 1) * riArray->elementSize, riArray->data + index * riArray->elementSize, (riArray->length - index) * riArray->elementSize);

        ri_free(riArray->data);
        riArray->data = data;

        riArray->length ++;

        //RiLock_Unlock(&riArray->lock);  
        return RI_OK;
    }

    RI_API int RiArray_Remove(RiArray_t *riArray, int index)
    {
        ri_byte *data;
        if(index > riArray->length - 1) return RI_ERROR_RANGE;  

        //RiLock_Lock(&riArray->lock);

        data = (ri_byte *)ri_calloc(riArray->realLength, riArray->elementSize);

        if(index > 0)
            ri_memcpy(data, riArray->data, index * riArray->elementSize);

        if(index < riArray->length-1)
            ri_memcpy(data + index * riArray->elementSize, riArray->data + (index + 1) * riArray->elementSize, (riArray->length - index - 1) * riArray->elementSize);

        ri_free(riArray->data);
        riArray->data = data;

        riArray->length --;

        //RiLock_Unlock(&riArray->lock);  
        return RI_OK;
    }

    RI_API int RiArray_SetReservedLength(RiArray_t *riArray, int reservedLength)
    {

        //RiLock_Lock(&riArray->lock);

        riArray->reservedLength = reservedLength;

        if((riArray->realLength - riArray->length) < riArray->reservedLength) 
            riArray_SetRealLength(riArray, riArray->realLength + riArray->reservedLength);

        //RiLock_Unlock(&riArray->lock);

        return RI_OK;
    }

    RI_API int RiArray_SetRealLength(RiArray_t *riArray, int realLength)
    {

        //RiLock_Lock(&riArray->lock);

        if((realLength - riArray->length) > riArray->reservedLength) 
            riArray_SetRealLength(riArray, realLength);
        else
            riArray_SetRealLength(riArray, realLength + riArray->reservedLength);

        //RiLock_Unlock(&riArray->lock);
        return RI_OK;
    }

    RI_API int RiArray_SetLength(RiArray_t *riArray, int length)
    {

        //RiLock_Lock(&riArray->lock);

        riArray->length = length;
        riArray_SetRealLength(riArray, riArray->length + riArray->reservedLength);  

        //RiLock_Unlock(&riArray->lock);
        return RI_OK;
    }

    RI_API int RiArray_GetRealLength(RiArray_t *riArray)
    {
        int realLength;

        //RiLock_Lock(&riArray->lock);

        realLength = riArray->realLength;    

        //RiLock_Unlock(&riArray->lock);
        return realLength;
    }

    RI_API int RiArray_GetReservedLength(RiArray_t *riArray)
    {
        int reservedLength;

        reservedLength = riArray->reservedLength;    

        return reservedLength; 
    }

    RI_API int RiArray_GetLength(RiArray_t *riArray)
    {
        int length;

        length = riArray->length;    

        return length; 
    }

    RI_API int RiArray_CheckElementType(RiArray_t *riArray, ri_utf8 *elementType)
    {
        if(strcmp((const char *)riArray->elementType, (const char *)elementType) != 0) {
			return RI_ERROR;
        }

        return RI_OK;
    }

    RI_API int RiArray_Init(RiArray_t *riArray, ri_utf8 *elementType,
        int elementSize, int reservedLength) {
            if (riArray == NULL)
                return RI_ERROR_PARAMETER_0;
            if (elementSize <= 0)
                return RI_ERROR_PARAMETER_2;
            if (reservedLength <= 0)
                return RI_ERROR_PARAMETER_3;

            if (elementType != NULL) {
                strcpy((char*) riArray->elementType, (char*) elementType);
            }
            riArray->length = 0;
            riArray->elementSize = elementSize;
            riArray->realLength = reservedLength;
            riArray->reservedLength = reservedLength;
            riArray->data = (unsigned char*)ri_calloc(reservedLength, elementSize);

            return RI_OK;
    }

#ifdef __cplusplus
}
#endif

