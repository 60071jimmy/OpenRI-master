/*
 Copyright (c) LEADERG INC. All rights reserved.
 */
#pragma once
#ifndef __UR_DLL_H__
#define __UR_DLL_H__

#include <gl/GLU.h>

#include "freeglut.h"


#define GT_API __declspec(dllexport)

#ifdef __cplusplus
extern "C" 
{
#endif

	GT_API int Ur_Plot(HANDLE urHandle);
    
	typedef struct aoiInfo aoiMotorData;
	//typedef struct _MyString MotorData;
	GT_API int Ur_Init();
	GT_API int Ur_Connect(int urSn, char *ip);
	GT_API int Ur_DisConnect(int urSn);
	GT_API int Ur_Send(int urSn, char *str, int len);	
	//GT_API int Ur_GetMotorData(double *URPose, double *MotorAng, int urSn);
	GT_API int Ur_GetMotorData(aoiMotorData* motorInfo, int urSn);
	GT_API int Ur_Receive(int urSn);
	GT_API int Ur_Close();    
	GT_API int Ur_urModel(HANDLE aoiHandle);
	GT_API int Ur_DrawUr(void);

#ifdef __cplusplus

}
#endif

#endif // __AOI_H__ 