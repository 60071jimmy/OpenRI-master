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

#ifndef __VISION_H__
#define __VISION_H__


#include "openri.h"

#define VISION_IMAGE_COUNT_MAX 128

using namespace cv;
using namespace std;

typedef struct {
	int sn;
	int isInUse;
	RiLock_t *lock;
	cv::Mat *mat;
	// TODO: 2
	//cv::Mat *matImage;
	//cv::Mat *matImageDisplay;

	// TODO: 3
	// Undo fifo.
} VisionImage_t;


typedef struct {
	int width;
	int height;
	int channel;
} VisionImageInfo_t;


#ifdef __cplusplus
extern "C" 
{
#endif

    RI_API int Vision_InitLib();
    RI_API int Vision_CloseLib();

	RI_API int Vision_NewImage();
	RI_API int Vision_CloneImage(int imageSnSrc, int imageSnDst);
	RI_API int Vision_FreeImage(int imageSn);

	RI_API int Vision_SetImage(int width, int height, int type);
	RI_API int Vision_LoadImage(int imageSn, char *imagePath);
	//RI_API int Vision_DrawImage(HANDLE data, int imageSn);
	RI_API int Vision_GetImageInfo(int imageSn, VisionImageInfo_t *imageInfo);
	RI_API int Vision_GetBitmapData(int imageSn, HANDLE scan, int stride);
	RI_API int Vision_GetBitmapChannelData(int imageSn, int channel, HANDLE scan, int stride);
	
	RI_API int Vision_BasicProcess(int imageSn, int type, int var1, int var2);
	RI_API int Vision_Threshold(int imageSn, int threshold, int thresholdType, int type, int variables1, int variables2);
    RI_API int Vision_EdgeCanny(int imageSn, int kernalSize, int threshValue);
    RI_API int Vision_EdgeSobel(int imageSn, int ksize, int scale);
	RI_API int Vision_EdgeLaplace(int imageSn, int ksize, int scale);
    RI_API int Vision_EntryDilate(int imageSn, int type, int eleHeight, int eleWeight);
    RI_API int Vision_EntryErode(int imageSn, int type, int eleHeight, int eleWeight);
	RI_API int Vision_EntryOpen(int imageSn, int type, int eleHeight, int eleWeight);
	RI_API int Vision_EntryClose(int imageSn, int type, int eleHeight, int eleWeight);
    RI_API int Vision_SmoothBlur(int imageSn, int ksize);
	RI_API int Vision_SmoothGaussian(int imageSn, int ksize);
	RI_API int Vision_SmoothMedian(int imageSn, int ksize);
	RI_API int Vision_SmoothBilateral(int imageSn, int ksize);

	RI_API int Vision_FFT(int imageSnSrc, int imageSnDst, int channel);
	RI_API int Vision_IFFT(int imageSn, int color_space, int type1, int type2, int radius, int n);
	RI_API int Vision_Sharpen(int imageSn, float k1, float k2, int sigma);
	RI_API int Vision_MaskSharpen(int imageSn);
    RI_API int Vision_NormalNoise(int imageSn, float mean, float stddev);
	RI_API int Vision_UniformNoise(int imageSn, float low, float high);
	RI_API int Vision_CvHaarWavelet(int imageSnSrc, int imageSnDst, int type, int number, float hp, float lp);
	RI_API int Vision_CvInvHaarWavelet(int imageSnSrc, int imageSnDst, int type, int number, float hp, float lp);
	RI_API int Vision_BrightnessContrast(int imageSn, float contrast, float brightness);

	RI_API int Vision_Sketch(int imageSn);
	RI_API int Vision_Cartoon(int imageSn);
	RI_API int Vision_GroundGlass(int imageSn);

	RI_API int Vision_StartWebCam(HANDLE data);
	RI_API int Vision_StopWebCam();
	RI_API int Vision_ResizeWebCam();


#ifdef __cplusplus
}
#endif

#endif /* __VISION_H__ */ 
