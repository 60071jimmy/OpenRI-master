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

// Image API for C# APP.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;

namespace app
{
    class Vision
    {
        // Please don't save any data in C#.
        // If you want to set and get data, please use Vision_SetXxx and Vision_GetXxx.

        [StructLayout(LayoutKind.Sequential)]
        public struct ImageInfo
        {
            public int width;
            public int height;
            public int channel;
        }

        [DllImport("vision.dll", EntryPoint = "Vision_InitLib")]
        public static extern int InitLib();

        [DllImport("vision.dll", EntryPoint = "Vision_CloseLib")]
        public static extern int CloseLib();

        [DllImport("vision.dll", EntryPoint = "Vision_BasicProcess")]
        public static extern int BasicProcess(int imageSn, int type, int var1, int var2);

        [DllImport("vision.dll", EntryPoint = "Vision_Threshold")]
        public static extern int Threshold(int imageSn, int threshold, int thresholdType, int type, int variables1, int variables2);

        [DllImport("vision.dll", EntryPoint = "Vision_EdgeCanny")]
        public static extern int EdgeCanny(int imageSn, int kernalSize, int threshValue);

        [DllImport("vision.dll", EntryPoint = "Vision_EdgeSobel")]
        public static extern int EdgeSobel(int imageSn, int ksize, int scale);

        [DllImport("vision.dll", EntryPoint = "Vision_EdgeLaplace")]
        public static extern int EdgeLaplace(int imageSn, int ksize, int scale);

        [DllImport("vision.dll", EntryPoint = "Vision_EntryDilate")]
        public static extern int EntryDilate(int imageSn, int type, int eleHeight, int eleWeight);

        [DllImport("vision.dll", EntryPoint = "Vision_EntryErode")]
        public static extern int EntryErode(int imageSn, int type, int eleHeight, int eleWeight);

        [DllImport("vision.dll", EntryPoint = "Vision_EntryOpen")]
        public static extern int EntryOpen(int imageSn, int type, int eleHeight, int eleWeight);

        [DllImport("vision.dll", EntryPoint = "Vision_EntryClose")]
        public static extern int EntryClose(int imageSn, int type, int eleHeight, int eleWeight);

        [DllImport("vision.dll", EntryPoint = "Vision_SmoothBlur")]
        public static extern int SmoothBlur(int imageSn, int kernalSize);

        [DllImport("vision.dll", EntryPoint = "Vision_SmoothGaussian")]
        public static extern int SmoothGaussian(int imageSn, int kernalSize);

        [DllImport("vision.dll", EntryPoint = "Vision_SmoothMedian")]
        public static extern int SmoothMedian(int imageSn, int kernalSize);

        [DllImport("vision.dll", EntryPoint = "Vision_SmoothBilateral")]
        public static extern int SmoothBilateral(int imageSn, int kernalSize);

        [DllImport("vision.dll", EntryPoint = "Vision_FFT")]
        public static extern int FFT(int imageSnSrc, int imageSnDst, int type);

        [DllImport("vision.dll", EntryPoint = "Vision_IFFT")]
        public static extern int IFFT(int imageSn, int color_space, int type1, int type2, int radius, int n);

        [DllImport("vision.dll", EntryPoint = "Vision_Sharpen")]
        public static extern int Sharpen(int imageSn, float k1, float k2, int sigma);

        [DllImport("vision.dll", EntryPoint = "Vision_MaskSharpen")]
        public static extern int MaskSharpen(int imageSn);

        [DllImport("vision.dll", EntryPoint = "Vision_NormalNoise")]
        public static extern int NormalNoise(int imageSn, float mean, float stddev);

        [DllImport("vision.dll", EntryPoint = "Vision_UniformNoise")]
        public static extern int UniformNoise(int imageSn, float low, float high);

        [DllImport("vision.dll", EntryPoint = "Vision_CvHaarWavelet")]
        public static extern int CvHaarWavelet(int imageSnSrc, int imageSnDst, int type, int number, float hp, float lp);

        [DllImport("vision.dll", EntryPoint = "Vision_CvInvHaarWavelet")]
        public static extern int CvInvHaarWavelet(int imageSnSrc, int imageSnDst, int type, int number, float hp, float lp);

        //  [DllImport("vision.dll", EntryPoint = "Vision_Contour")]
        //  public static extern int Contour(byte[] dstData, byte[] srcData, int width, int heigh, int thresh);

        [DllImport("vision.dll", EntryPoint = "Vision_Sketch")]
        public static extern int Sketch(int imageSn);

        //[DllImport("vision.dll", EntryPoint = "Vision_Sculpture")]
        //public static extern int Sculpture(byte[] dstData, byte[] srcData, int width, int heigh);

        [DllImport("vision.dll", EntryPoint = "Vision_BrightnessContrast")]
        public static extern int BrightnessContrast(int imageSn, float contrast, float brightness);

        [DllImport("vision.dll", EntryPoint = "Vision_Cartoon")]
        public static extern int Cartoon(int imageSn);

        [DllImport("vision.dll", EntryPoint = "Vision_GroundGlass")]
        public static extern int GroundGlass(int imageSn);

        //[DllImport("vision.dll", EntryPoint = "Vision_FishLens")]
        //public static extern int FishLens(byte[] dstData, byte[] srcData, int width, int heigh);

        [DllImport("vision.dll", EntryPoint = "RiDbg_Enable")]
        public static extern int EnableDbg();

        [DllImport("vision.dll", EntryPoint = "RiDbg_Disable")]
        public static extern int DisableDbg();

        [DllImport("vision.dll", EntryPoint = "RiLog_Open")]
        public static extern int OpenLog(string fileName);

        [DllImport("vision.dll", EntryPoint = "RiLog_Log")]
        public static extern int Log(string MessageString);

        [DllImport("vision.dll", EntryPoint = "RiLog_Close")]
        public static extern int CloseLog();

        //[DllImport("vision.dll", EntryPoint = "Vision_Test1")]
        //public static extern int Test1();

        //[DllImport("vision.dll", EntryPoint = "Vision_Test2")]
        //public static extern int Test2(IntPtr Handle);
        //public static extern int Test2(int data);

        //[DllImport("vision.dll", EntryPoint = "Vision_Test3")]
        //public static extern int Test3(string fileName, int len);

        //[DllImport("vision.dll", EntryPoint = "Vision_Test4")]
        //public static extern int Test4(string MessageString, int len);

        //[DllImport("vision.dll", EntryPoint = "Vision_Test5")]
        //public static extern int Test5(byte[] ptr);

        [DllImport("vision.dll", EntryPoint = "Vision_StartWebCam")]
        public static extern int StartWebCam(IntPtr Handle);

        [DllImport("vision.dll", EntryPoint = "Vision_ResizeWebCam")]
        public static extern int ResizeWebCam();

        //[DllImport("vision.dll", EntryPoint = "Vision_webcamCaptureClose")]
        //public static extern int webcamCaptureClose();

        //[DllImport("vision.dll", EntryPoint = "Vision_DisplayWebCam")]
        //public static extern int DisplayWebCam(IntPtr Handle);

        [DllImport("vision.dll", EntryPoint = "Vision_StopWebCam")]
        public static extern int StopWebCam();

        [DllImport("vision.dll", EntryPoint = "Vision_LoadImage")]
        public static extern int LoadImage(int imageSn, string imagePath);

        [DllImport("vision.dll", EntryPoint = "Vision_FreeImage")]
        public static extern int FreeImage(int imageSn);

        [DllImport("vision.dll", EntryPoint = "Vision_CloneImage")]
        public static extern int CloneImage(int imageSnSrc, int imageSnDst);

        [DllImport("vision.dll", EntryPoint = "Vision_NewImage")]
        public static extern int NewImage();

        [DllImport("vision.dll", EntryPoint = "Vision_SaveImage")]
        public static extern int SaveImage(int imageSn, string imagePath);

        [DllImport("vision.dll", EntryPoint = "Vision_GetImageInfo")]
        public static extern int GetImageInfo(int imageSn, out ImageInfo visionInfo);

        [DllImport("vision.dll", EntryPoint = "Vision_GetBitmapData")]
        public static extern int GetBitmapData(int imageSn, IntPtr scan, int stride);

        [DllImport("vision.dll", EntryPoint = "Vision_GetBitmapChannelData")]
        public static extern int GetBitmapChannelData(int imageSn, int channel, IntPtr scan, int stride);

        //[DllImport("vision.dll", EntryPoint = "RiCom_Open")]
        //public static extern int RiCom_Open(string name, int baudRate, char parity, int databits, int stopBits);

        //[DllImport("vision.dll", EntryPoint = "RiCom_Write")]
        //public static extern int RiCom_Write(string buf, int bufLen);

        //[DllImport("vision.dll", EntryPoint = "RiCom_Read")]
        //public static extern int RiCom_Read(StringBuilder buf, int bufSize);

        //[DllImport("vision.dll", EntryPoint = "RiCom_Close")]
        //public static extern int RiCom_Close();

        public static Bitmap GetBitmap(int imageSn)
        {
            Vision.ImageInfo imageInfo = new Vision.ImageInfo();
            Vision.GetImageInfo(imageSn, out imageInfo);
            Bitmap bitMap = null;

            switch (imageInfo.channel)
            {
                default:
                    return null;

                case 1:
                    bitMap = new Bitmap(imageInfo.width, imageInfo.height, PixelFormat.Format8bppIndexed);
                    ColorPalette colorPalette = bitMap.Palette;
                    Color[] c = colorPalette.Entries;
                    for (int i = 0; i < 256; i++) c[i] = Color.FromArgb(i, i, i);
                    bitMap.Palette = colorPalette;
                    break;
                case 3:
                    bitMap = new Bitmap(imageInfo.width, imageInfo.height, PixelFormat.Format24bppRgb);
                    break;
            }
            
            BitmapData bitmapData = bitMap.LockBits(new Rectangle(0, 0, bitMap.Width, bitMap.Height), ImageLockMode.WriteOnly, bitMap.PixelFormat);
            Vision.GetBitmapData(imageSn, bitmapData.Scan0, bitmapData.Stride);
            bitMap.UnlockBits(bitmapData);

            return bitMap;
        }

        public static Bitmap GetBitmap(int imageSn, int channel)
        {
            Vision.ImageInfo imageInfo = new Vision.ImageInfo();
            Vision.GetImageInfo(imageSn, out imageInfo);

            if (imageInfo.channel <= channel) return null;

            Bitmap bitMap = new Bitmap(imageInfo.width, imageInfo.height, PixelFormat.Format8bppIndexed);
            ColorPalette colorPalette = bitMap.Palette;
            Color[] c = colorPalette.Entries;
            for (int i = 0; i < 256; i++) c[i] = Color.FromArgb(i, i, i);
            bitMap.Palette = colorPalette;

            BitmapData bitmapData = bitMap.LockBits(new Rectangle(0, 0, bitMap.Width, bitMap.Height), ImageLockMode.WriteOnly, bitMap.PixelFormat);
            Vision.GetBitmapChannelData(imageSn, channel, bitmapData.Scan0, bitmapData.Stride);
            bitMap.UnlockBits(bitmapData);

            return bitMap;
        }
    }
}
