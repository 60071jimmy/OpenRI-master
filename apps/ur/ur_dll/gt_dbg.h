/*
 Copyright (c) LEADERG INC. All rights reserved.
 */

#ifndef __GT_DBG_H__
#define __GT_DBG_H__

//#include "gt_lib.h"


#include <stdlib.h>
#include <stdio.h>
#include <stdarg.h>

#include <Windows.h>

#include <string>
#include <sstream>

#define GT_API __declspec(dllexport)
#ifdef __cplusplus
extern "C" 
{
#endif

	GT_API int GtDbg_Enable();

	GT_API int GtDbg_Disable();

	int dbg(char *format, ...);

#ifdef __cplusplus

}
#endif


#endif // __GT_DBG_H__ 

