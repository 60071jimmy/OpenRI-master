/*
 Copyright (c) LEADERG INC. All rights reserved.
 */


#include "gt_dbg.h"
#


static int gtdbgIsEnabled = 1;


#ifdef __cplusplus
extern "C" 
{
#endif


	GT_API int GtDbg_Enable() {
		gtdbgIsEnabled = 1;

		return 1;
	}

	GT_API int GtDbg_Disable() {
		gtdbgIsEnabled = 0;

		return 1;
	}


// Note: To get dbg message to work, you need to enable: C# property->debug-> Enable unmanaged code debugging
int dbg(char *format, ...) {
	if (gtdbgIsEnabled <= 0) {
		return 2;
	}
	
	//if (gtdbgIsEnabled == 1) {
		//return 2;
	//}

	char    str[4096];//GT_PAGE_SIZE
	wchar_t strw[4096];//GT_PAGE_SIZE

	va_list args;
	va_start(args, format);
	vsprintf_s(str, 4096, format, args);

	MultiByteToWideChar(CP_UTF8, 
		0,         
		str, 
		-1,  // Byte length.       
		strw,  
		4096 * sizeof(wchar_t));

	OutputDebugString(strw);
	OutputDebugStringA("\r\n");
	va_end(args);

	return 1;
}


#ifdef __cplusplus

}
#endif


