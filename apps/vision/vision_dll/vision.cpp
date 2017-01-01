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

#include <Windows.h>
#include <regex>
#include <vector>

#include <GL/GL.h>
#include <GL/GLU.h>
#include <GL/freeglut.h>

#include <opencv2\opencv.hpp>
#include <opencv2\core\core.hpp>
#include <opencv2\highgui\highgui.hpp>
#include <opencv2\imgproc\imgproc.hpp>
#include <opencv2\video\video.hpp>

#include "openri.h"
#include "vision.h"

using namespace cv;
using namespace std;

static int visionIsInited = 0;

static VisionImage_t *visionImages;

static HWND visionWebCamWindowHandle;
static HDC  visionWebCamDeviceContextHandle;
static HGLRC visionWebCamRenderingContextHandle;
static RECT visionWebCamRect;
static RiLock_t* visionWebCamLock = NULL;

static HANDLE visionWebCamThread = INVALID_HANDLE_VALUE;
static int visionWebCamThreadIsClosed = 1;
static int visionWebCamThreadToClose = 0;
static VideoCapture visionVideoCapture;
static Mat visionWebCamMat;
static int thresholdVal = 0;

Mat vision_WDT (const Mat &_src, int _wname, const int _level, const int THID_ERR_NONE, float HP, float LP);
Mat vision_IWDT (const Mat &_src, int _wname, const int _level, const int THID_ERR_NONE, float HP, float LP);
int vision_Wavelet (int _wname, Mat &_lowFilter, Mat &_highFilter, float HP, float LP);
Mat vision_WaveletDecompose (const Mat &_src, const Mat &_lowFilter, const Mat &_highFilter);
Mat vision_WaveletReconstruct (const Mat &_src, const Mat &_lowFilter, const Mat &_highFilter);

int vision_Wavelet (int _wname, Mat &_lowFilter, Mat &_highFilter, float HP, float LP) {
    if (_wname == 1) {
        int N = 2;
        _lowFilter = Mat::zeros(1, (int)LP, CV_32F);
        _highFilter = Mat::zeros(1, (int)HP , CV_32F);

        _lowFilter.at<float>(0, 0) = 1 / sqrtf(LP); 
        _lowFilter.at<float>(0, 1) = 1 / sqrtf(LP); 


        _highFilter.at<float>(0, 0) = -1 / sqrtf(HP); 
        _highFilter.at<float>(0, 1) = 1 / sqrtf(HP); 
    }

    if (_wname == 2) {
        int N = 4;
        float h[] = {(float)-0.483, (float)0.836, (float)-0.224, (float)-0.129};
        float l[] = {(float)-0.129, (float)0.224, (float)0.837, (float)0.483};

        _lowFilter = Mat::zeros(1, N, CV_32F);
        _highFilter = Mat::zeros(1, N, CV_32F);

        int i;
        for (i = 0; i < N; i++) {
            _lowFilter.at<float>(0, i) = l[i]; 
            _highFilter.at<float>(0, i) = h[i]; 
        }
    }

    return 1;
}

Mat vision_WaveletDecompose (const Mat &_src, const Mat &_lowFilter, const Mat &_highFilter) {
    assert(_src.rows ==1 && _lowFilter.rows == 1 && _highFilter.rows == 1);
    assert(_src.cols >= _lowFilter.cols && _src.cols >= _highFilter.cols);
    Mat &src = Mat_<float>(_src);

    int D = src.cols;

    Mat &lowFilter = Mat_<float>(_lowFilter);
    Mat &highFilter = Mat_<float>(_highFilter);


    Mat dst1 = Mat::zeros(1, D, src.type());
    Mat dst2 = Mat::zeros(1, D, src.type());

    filter2D(src, dst1, -1, lowFilter);
    filter2D(src, dst2, -1, highFilter);

    Mat downDst1 = Mat::zeros(1, D/2, src.type());
    Mat downDst2 = Mat::zeros(1, D/2, src.type());

    resize(dst1, downDst1, downDst1.size());
    resize(dst2, downDst2, downDst2.size());

    int i;
    for (i = 0; i < D / 2; i++) {
        src.at<float>(0, i) = downDst1.at<float>(0, i);
        src.at<float>(0, i + D / 2) = downDst2.at<float>(0, i);
    }

    return src;
}

Mat vision_WaveletReconstruct (const Mat &_src, const Mat &_lowFilter, const Mat &_highFilter) {
    assert(_src.rows == 1 && _lowFilter.rows == 1 && _highFilter.rows == 1);
    assert(_src.cols >= _lowFilter.cols && _src.cols >= _highFilter.cols);
    Mat &src = Mat_<float>(_src);

    int D = src.cols;

    Mat &lowFilter = Mat_<float>(_lowFilter);
    Mat &highFilter = Mat_<float>(_highFilter);

    Mat Up1 = Mat::zeros(1, D, src.type());
    Mat Up2 = Mat::zeros(1, D, src.type());

    Mat roi1(src, Rect(0, 0, D / 2, 1));
    Mat roi2(src, Rect(D / 2, 0, D / 2, 1));
    resize(roi1, Up1, Up1.size(), 0, 0, INTER_CUBIC);
    resize(roi2, Up2, Up2.size(), 0, 0, INTER_CUBIC);

    Mat dst1 = Mat::zeros(1, D, src.type());
    Mat dst2= Mat::zeros(1, D, src.type());
    filter2D(Up1, dst1, dst1.depth(), lowFilter);
    filter2D(Up2, dst2, dst2.depth(), highFilter);

    dst1 = dst1 + dst2;

    return dst1;
}

Mat vision_WDT (const Mat &_src, int _wname, const int _level, const int THID_ERR_NONE, float HP, float LP) {
    int reValue = THID_ERR_NONE;
    Mat src = Mat_<float>(_src);
    Mat dst = Mat::zeros(src.rows, src.cols, src.type()); 
    int N = src.rows;
    int D = src.cols;

    /// High pass and low pass filter.
    Mat lowFilter; 
    Mat highFilter;
    vision_Wavelet(_wname, lowFilter, highFilter, HP, LP);

    /// Wavelet.
    int t = 1;
    int row = N;
    int col = D;

    int i, j;
    while(t <= _level) {
        for(i = 0; i < row; i++) {
            Mat oneRow = Mat::zeros(1, col, src.type());

            for (j = 0; j < col; j++) {
                oneRow.at<float>(0,j) = src.at<float>(i, j);
            }

            oneRow = vision_WaveletDecompose(oneRow, lowFilter, highFilter);

            for (j = 0; j < col; j++) {
                dst.at<float>(i, j) = oneRow.at<float>(0, j);
            }
        }

        for (j = 0; j < col; j++) {
            Mat oneCol = Mat::zeros(row, 1, src.type());

            for (i = 0; i < row; i++) {
                oneCol.at<float>(i, 0) = dst.at<float>(i, j);
            }

            oneCol = (vision_WaveletDecompose(oneCol.t(), lowFilter, highFilter)).t();

            for (i = 0; i < row; i++) {
                dst.at<float>(i, j) = oneCol.at<float>(i, 0);
            }
        }

        row /= 2;
        col /= 2;
        t++;
        src = dst;
    }
    //normalize( dst, dst, 0, 255, NORM_MINMAX);

    return dst;
}

Mat vision_IWDT (const Mat &_src, int _wname, const int _level, const int THID_ERR_NONE, float HP, float LP) {
    int reValue = THID_ERR_NONE;
    Mat src = Mat_<float>(_src);
    Mat dst = Mat::zeros(src.rows, src.cols, src.type()); 
    int N = src.rows;
    int D = src.cols;

    Mat lowFilter; 
    Mat highFilter;
    vision_Wavelet(_wname, lowFilter, highFilter, HP, LP);

    int t = 1;
    int row =  (int)(N / std::pow(2., _level - 1));
    int col = (int)(D / std::pow(2., _level - 1));

    int i, j;
    while (row <= N && col <= D) {
        for (j = 0; j < col; j++) {
            Mat oneCol = Mat::zeros(row, 1, src.type());

            for (i = 0; i < row; i++) {
                oneCol.at<float>(i, 0) = src.at<float>(i, j);
            }

            oneCol = (vision_WaveletReconstruct(oneCol.t(), lowFilter, highFilter)).t();

            for (i = 0; i < row; i++) {
                dst.at<float>(i, j) = oneCol.at<float>(i, 0);
            }
        }

        for(i = 0; i < row; i++) {
            Mat oneRow = Mat::zeros(1, col, src.type());
            for (j = 0; j < col; j++) {
                oneRow.at<float>(0, j) = dst.at<float>(i, j);
            }

            oneRow = vision_WaveletReconstruct( oneRow, lowFilter, highFilter );

            for (j = 0; j < col; j++) {
                dst.at<float>(i, j) = oneRow.at<float>(0, j);
            }
        }

        row *= 2;
        col *= 2;
        src = dst;
    }
    //normalize( dst, dst, 0, 255, NORM_MINMAX );

    return dst;
}  

Mat vision_ideal (Mat &inimg, int flag, float radius, int colorspace) {

    Mat image_dtft, complexImg, tmp, magI;
    image_dtft.create(inimg.rows, inimg.cols, CV_8UC1);
    int nr, nc;
    double dist;
    nr = inimg.rows;
    nc = inimg.cols;
	dbg("nr=%d", nr);
	dbg("nc=%d", nc);

    Mat padded;
    // expand input image to optimal size
    int m = getOptimalDFTSize(inimg.rows);
    int n = getOptimalDFTSize(inimg.cols);
	dbg("m=%d", m);
	dbg("n=%d", n);

    // on the border add zero values
    copyMakeBorder(inimg, padded, 0, m - inimg.rows, 0, n - inimg.cols, BORDER_CONSTANT, Scalar::all(0));
	
	
	Mat channels[3];

	split(padded, channels);


    Mat planes[] = {Mat_<float>(channels[0]), Mat::zeros(padded.size(), CV_32F)};
    merge(planes, 2, complexImg); // merge into one Mat
	
    dft(complexImg, complexImg);// dtft

    int cx = complexImg.cols / 2;
    int cy = complexImg.rows / 2;

    // rearrange the quadrants of Fourier image so that the origin is at the image center

    Mat q0(complexImg, Rect(0, 0, cx, cy));
    Mat q1(complexImg, Rect(cx, 0, cx, cy));
    Mat q2(complexImg, Rect(0, cy, cx, cy));
    Mat q3(complexImg, Rect(cx, cy, cx, cy));

    q0.copyTo(tmp);
    q3.copyTo(q0);
    tmp.copyTo(q3);

    q1.copyTo(tmp);
    q2.copyTo(q1);
    tmp.copyTo(q2);

    // planes[0] = ¹ê³¡ planes[1] = µê³¡
    split(complexImg, planes);
    magnitude(planes[0], planes[1], planes[0]);// planes[0] = magnitude
    magI = planes[0];
    magI += Scalar::all(1);                    // switch to logarithmic scale
    log(magI, magI);

    normalize(magI, magI, 0, 255, CV_MINMAX);

    Mat Ideal_mask;
    Ideal_mask.create(padded.rows, padded.cols, CV_32F);
    int i, j;
    for (i = 0; i < Ideal_mask.rows; i++) {
        for (j = 0; j < Ideal_mask.cols; j++) {
            dist = sqrt(pow((float)(i - Ideal_mask.rows / 2), 2) + pow((float)(j - Ideal_mask.cols / 2), 2));
            //°ª³q
            if (dist < radius) {
                Ideal_mask.at<float>(i, j) = !flag;
            } else {
                Ideal_mask.at<float>(i, j) = (float)flag;
            }
        }
    }
    magI = Ideal_mask.mul(magI);
	
    Mat planes2[] = {Mat::zeros(Ideal_mask.size(), CV_32F), Mat::zeros(Ideal_mask.size(), CV_32F)};

    split(complexImg, planes2);
	
    planes2[0] = Ideal_mask.mul(planes2[0]);
    planes2[1] = Ideal_mask.mul(planes2[1]);
	
    merge(planes2, 2, complexImg);
    //magnitude(planes2[0], planes2[1], planes2[0]);// planes[0] = magnitude

    magI.convertTo(magI, CV_8U);
	
    if (colorspace == 0) {
        // return inverse picture
        Mat image_dtft_inverse;
        image_dtft_inverse.create(complexImg.rows, complexImg.cols, CV_8UC1);

        int cx =complexImg.cols / 2;
        int cy =complexImg.rows / 2;

        // rearrange the quadrants of Fourier image so that the origin is at the image center 
        Mat q0(complexImg, Rect(0, 0, cx, cy));
        Mat q1(complexImg, Rect(cx, 0, cx, cy));
        Mat q2(complexImg, Rect(0, cy, cx, cy));
        Mat q3(complexImg, Rect(cx, cy, cx, cy));

        q0.copyTo(tmp);
        q3.copyTo(q0);
        tmp.copyTo(q3);

        q1.copyTo(tmp);
        q2.copyTo(q1);
        tmp.copyTo(q2);

        idft(complexImg, image_dtft_inverse);  //idft

        Mat planes[] = {Mat::zeros(image_dtft_inverse.size(), CV_32F), Mat::zeros(image_dtft_inverse.size(), CV_32F)};
        split(image_dtft_inverse, planes);                   // planes[0] = ¹ê³¡, planes[1] = µê³¡
        magnitude(planes[0], planes[1], planes[0]);// planes[0] = magnitude
        Mat mag = planes[0];

        normalize(mag,image_dtft_inverse, 0, 255, CV_MINMAX,CV_8UC1);

		Rect roi = Rect(0, 0, nc, nr);
		image_dtft_inverse = Mat(image_dtft_inverse, roi);

        return image_dtft_inverse;
    } else {
        // return one color space preview
        return magI;
    }
}

Mat vision_butterworth (Mat &inimg, int flag, float radius, int n, int colorspace) {	
    Mat image_dtft, complexImg, tmp, magI;
    image_dtft.create(inimg.rows, inimg.cols, CV_8UC1);
    int nr, nc;
    double dist;
    nr = inimg.rows;
    nc = inimg.cols;

    Mat padded;
    //expand input image to optimal size
    int m = getOptimalDFTSize(inimg.rows);
    int n2 = getOptimalDFTSize(inimg.cols);
    // on the border add zero values
    copyMakeBorder(inimg, padded, 0, m - inimg.rows, 0, n2 - inimg.cols, BORDER_CONSTANT, Scalar::all(0));

    Mat planes[] = {Mat_<float>(padded), Mat::zeros(padded.size(), CV_32F)};
    merge(planes, 2, complexImg); // merge into one Mat

    dft(complexImg, complexImg);// dtft

    int cx = complexImg.cols / 2;
    int cy = complexImg.rows / 2; 
    // rearrange the quadrants of Fourier image so that the origin is at the image center

    Mat q0(complexImg, Rect(0, 0, cx, cy));
    Mat q1(complexImg, Rect(cx, 0, cx, cy));
    Mat q2(complexImg, Rect(0, cy, cx, cy));
    Mat q3(complexImg, Rect(cx, cy, cx, cy));

    q0.copyTo(tmp);
    q3.copyTo(q0);
    tmp.copyTo(q3);

    q1.copyTo(tmp);
    q2.copyTo(q1);
    tmp.copyTo(q2);

    // planes[0] = ¹ê³¡ planes[1] = µê³¡
    split(complexImg, planes);
    magnitude(planes[0], planes[1], planes[0]); // planes[0] = magnitude
    magI = planes[0];
    magI += Scalar::all(1);                     // switch to logarithmic scale
    log(magI, magI);

    normalize(magI, magI, 0, 255, CV_MINMAX);

    Mat Ideal_mask;
    Ideal_mask.create(padded.rows, padded.cols, CV_32F);

    int i, j;
    for (i = 0; i < nr; i++) {
        for (j = 0; j < nc; j++) {
            dist = sqrt((float)(i - nr / 2) * (i - nr / 2) + (j - nc / 2) * (j - nc / 2));
            if (flag == 1) {
                // highpass butterworth

                if (radius == 0) {
                    Ideal_mask.at<float>(i, j) = 1;
                } else {
                    Ideal_mask.at<float>(i, j) = (float)((1 / (1 + pow(radius / dist, (double)2 * n))));
                }
            } else {
                if (radius == 0) {
                    Ideal_mask.at<float>(i, j) = 0.0;
                } else {
                    Ideal_mask.at<float>(i,j) = (float)(sqrt(1 / (1 + pow(dist / radius, 2 * n))));
                }

            }
        }
    }

    magI = Ideal_mask.mul(magI);

    Mat planes2[] = {Mat::zeros(Ideal_mask.size(), CV_32F), Mat::zeros(Ideal_mask.size(), CV_32F)};

    split(complexImg, planes2);

    planes2[0] = Ideal_mask.mul(planes2[0]);
    planes2[1] = Ideal_mask.mul(planes2[1]);

    merge(planes2, 2, complexImg);
    //magnitude(planes2[0], planes2[1], planes2[0]);// planes[0] = magnitude

    magI.convertTo(magI, CV_8U);

    if (colorspace == 0) {
        // return inverse picture

        Mat image_dtft_inverse;
        image_dtft_inverse.create(complexImg.rows, complexImg.cols, CV_8UC1);

        int cx =complexImg.cols / 2;
        int cy =complexImg.rows / 2;

        // rearrange the quadrants of Fourier image so that the origin is at the image center

        Mat q0(complexImg, Rect(0, 0, cx, cy));
        Mat q1(complexImg, Rect(cx, 0, cx, cy));
        Mat q2(complexImg, Rect(0, cy, cx, cy));
        Mat q3(complexImg, Rect(cx, cy, cx, cy));

        q0.copyTo(tmp);
        q3.copyTo(q0);
        tmp.copyTo(q3);

        q1.copyTo(tmp);
        q2.copyTo(q1);
        tmp.copyTo(q2);

        idft(complexImg, image_dtft_inverse);  //idft

        Mat planes[] = {Mat::zeros(image_dtft_inverse.size(), CV_32F), Mat::zeros(image_dtft_inverse.size(), CV_32F)};
        split(image_dtft_inverse, planes);            // planes[0] = ¹ê³¡, planes[1] = µê³¡
        magnitude(planes[0], planes[1], planes[0]);   // planes[0] = magnitude
        Mat mag = planes[0];

        normalize(mag,image_dtft_inverse, 0, 255, CV_MINMAX,CV_8UC1);

		Rect roi = Rect(0, 0, nc, nr);
		image_dtft_inverse = Mat(image_dtft_inverse, roi);
        return image_dtft_inverse;
    } else {
        return magI;
    }
}

Mat vision_gaussianFreq (Mat &inimg, int flag, float std, int colorspace) { 
    Mat image_dtft, complexImg, tmp, magI;
    image_dtft.create(inimg.rows, inimg.cols, CV_8UC1);
    int nr, nc;
    double dist;
    nr = inimg.rows;
    nc = inimg.cols;

    Mat padded;
    //expand input image to optimal size
    int m = getOptimalDFTSize(inimg.rows);
    int n2 = getOptimalDFTSize(inimg.cols);
    // on the border add zero values
    copyMakeBorder(inimg, padded, 0, m - inimg.rows, 0, n2 - inimg.cols, BORDER_CONSTANT, Scalar::all(0));

    Mat planes[] = {Mat_<float>(padded), Mat::zeros(padded.size(), CV_32F)};
    merge(planes, 2, complexImg); // merge into one Mat

    dft(complexImg, complexImg);// dtft

    int cx = complexImg.cols / 2;
    int cy = complexImg.rows / 2;

    Mat q0(complexImg, Rect(0, 0, cx, cy));
    Mat q1(complexImg, Rect(cx, 0, cx, cy));
    Mat q2(complexImg, Rect(0, cy, cx, cy));
    Mat q3(complexImg, Rect(cx, cy, cx, cy));

    q0.copyTo(tmp);
    q3.copyTo(q0);
    tmp.copyTo(q3);

    q1.copyTo(tmp);
    q2.copyTo(q1);
    tmp.copyTo(q2);

    // planes[0] = ¹ê³¡ planes[1] = µê³¡
    split(complexImg, planes);
    magnitude(planes[0], planes[1], planes[0]);// planes[0] = magnitude
    magI = planes[0];
    magI += Scalar::all(1);                    // switch to logarithmic scale
    log(magI, magI);

    normalize(magI, magI, 0, 255, CV_MINMAX);

    Mat Ideal_mask;
    Ideal_mask.create(padded.rows, padded.cols, CV_32F);

    int i, j;
    for (i = 0; i < nr; i++) {
        for (j = 0; j < nc; j++) {
            dist = sqrt((float)(i - nr / 2) * (i - nr / 2) + (j - nc / 2) * (j - nc / 2));
            if (flag == 1) {
                if (std == 0) {
                    Ideal_mask.at<float>(i, j) = 1;
                } else {
                    Ideal_mask.at<float>(i, j) = (float)(1 - exp(-dist * dist / (2 * std * std)));
                }
            } else {
                if (std == 0) {
                    Ideal_mask.at<float>(i, j) = 0.0;
                } else {
                    Ideal_mask.at<float>(i, j) = (float)(exp(-dist * dist / (2 * std * std)));
                }

            }
        }
    }

    magI = Ideal_mask.mul(magI);

    Mat planes2[] = {Mat::zeros(Ideal_mask.size(), CV_32F), Mat::zeros(Ideal_mask.size(), CV_32F)};

    split(complexImg, planes2);

    planes2[0] = Ideal_mask.mul(planes2[0]);
    planes2[1] = Ideal_mask.mul(planes2[1]);

    merge(planes2, 2, complexImg);
    // magnitude(planes2[0], planes2[1], planes2[0]);// planes[0] = magnitude

    magI.convertTo(magI, CV_8U);

    if (colorspace == 0) {
        // return inverse picture
        Mat image_dtft_inverse;
        image_dtft_inverse.create(complexImg.rows, complexImg.cols, CV_8UC1);

        int cx =complexImg.cols/2;
        int cy =complexImg.rows/2;

        // rearrange the quadrants of Fourier image so that the origin is at the image center

        Mat q0(complexImg, Rect(0, 0, cx, cy));
        Mat q1(complexImg, Rect(cx, 0, cx, cy));
        Mat q2(complexImg, Rect(0, cy, cx, cy));
        Mat q3(complexImg, Rect(cx, cy, cx, cy));

        q0.copyTo(tmp);
        q3.copyTo(q0);
        tmp.copyTo(q3);

        q1.copyTo(tmp);
        q2.copyTo(q1);
        tmp.copyTo(q2);

        idft(complexImg,image_dtft_inverse);  //idft

        Mat planes[]={Mat::zeros(image_dtft_inverse.size(),CV_32F), Mat::zeros(image_dtft_inverse.size(), CV_32F)};
        split(image_dtft_inverse, planes);                   // planes[0] = ¹ê³¡, planes[1] = µê³¡
        magnitude(planes[0], planes[1], planes[0]);// planes[0] = magnitude
        Mat mag = planes[0];

        normalize(mag,image_dtft_inverse, 0, 255, CV_MINMAX,CV_8UC1);

		Rect roi = Rect(0, 0, nc, nr);
		image_dtft_inverse = Mat(image_dtft_inverse, roi);
        return image_dtft_inverse;
    } else {
        //return one color space preview
        return magI;
    }
}

#ifdef __cplusplus
extern "C" {
#endif
	inline int vision_DrawWebCam();

	DWORD __stdcall vision_WebCamThread(LPVOID parameter) {
		dbg("vision_WebCamThread ++");
		int nFormat;
		PIXELFORMATDESCRIPTOR pfd;
        pfd.nVersion   = 1;
        pfd.dwFlags    = PFD_DRAW_TO_WINDOW | PFD_SUPPORT_OPENGL | PFD_DOUBLEBUFFER; 
        pfd.iPixelType = (unsigned char)(PFD_TYPE_RGBA);
        pfd.cColorBits = 32;
        pfd.cDepthBits = 32;
        pfd.iLayerType = (unsigned char)(PFD_MAIN_PLANE);

		RiLock_Lock(visionWebCamLock);
        nFormat = ChoosePixelFormat(visionWebCamDeviceContextHandle, &pfd);
        SetPixelFormat(visionWebCamDeviceContextHandle, nFormat, &pfd);
		
        visionWebCamRenderingContextHandle = (wglCreateContext(visionWebCamDeviceContextHandle));
        if (visionWebCamRenderingContextHandle == 0) {
            dbg("wglCreateContext Error");
			RiLock_Unlock(visionWebCamLock);
			return -1;
		}
        if (wglMakeCurrent(visionWebCamDeviceContextHandle, visionWebCamRenderingContextHandle ) == false) {
            dbg("wglMakeCurrent Error");
			RiLock_Unlock(visionWebCamLock);
			return -2;
		}

		glEnable(GL_TEXTURE_2D);

		glTexParameterf(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_REPEAT);
		glTexParameterf(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_REPEAT);
		glTexParameterf(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_NEAREST);
		glTexParameterf(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_NEAREST);

		// Set Projection Matrix
		glMatrixMode (GL_PROJECTION);
		glLoadIdentity();
		visionWebCamThreadToClose = 0;
		visionWebCamThreadIsClosed = 0;
		int count = 0;

		RiLock_Unlock(visionWebCamLock);
		while (visionWebCamThreadToClose == 0) {
			if (visionWebCamThreadToClose == 1) {
				break;
			}

			if (!visionVideoCapture.retrieve(visionWebCamMat)) {
				count++;
				if (count == 5) {
					dbg("fail");
					count = 0;
					if (!visionVideoCapture.isOpened()) {
						visionVideoCapture.release();
						Sleep(20);
						visionVideoCapture.open(0);
					} else {
						visionVideoCapture.open(0);
					}
				}
				continue;
			} else {
				count = 0;
			}
			vision_DrawWebCam();
			//Sleep(30);
		}

		visionWebCamThreadIsClosed = 1;
		
		return 1;
	}

    RI_API int Vision_InitLib() 
	{
        dbg("Vision_InitLib ++");

		int ret;

        if (visionIsInited != 0) {
            return 3;
		}
		visionIsInited = 2;

		ret = OpenRI_InitLib();
		if (ret <= 0) {
			return ret;
		}

		visionWebCamLock = RiLock_New();
		if (visionWebCamLock == NULL) {
			return -2;
		}

		visionImages = (VisionImage_t *)ri_calloc(VISION_IMAGE_COUNT_MAX, sizeof(VisionImage_t));
		if (visionImages == NULL) {
			return -3;
		}

		if (SetConsoleOutputCP(65001)) {

			return -3;
		}

		for (int i = 0; i < VISION_IMAGE_COUNT_MAX; i ++) {
			visionImages[i].lock = RiLock_New();
			visionImages[i].sn = i;
			if (visionImages[i].lock == NULL) {
				return -4;
			}
		}


		visionIsInited = 1;

        dbg("Vision_InitLib --");
        return 1;
    }

    RI_API int Vision_CloseLib() {

        dbg("Vision_CloseLib ++");

        if (visionIsInited == 0)	{
            return -1;
        }
		
		Vision_StopWebCam();

        dbg("Vision_CloseLib --");
        return 1;
    }

	RI_API int Vision_BasicProcess(int imageSn, int type, int var1, int var2) {
        dbg("Vision_BasicProcess_New ++");
		if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);
        // Do your Image Processing ++.
        switch ((int)type) {
        case 1: {
			cvtColor(*visionImage->mat, *visionImage->mat, CV_BGR2GRAY);
            equalizeHist( *visionImage->mat, *visionImage->mat );
			dbg("equalizeHist--");
            break;
                } 
		case 2: { 
             // To Gray
             cvtColor(*visionImage->mat, *visionImage->mat, CV_BGR2GRAY);
			 //imshow("gray", *visionImage->mat);
			 //waitKey(0);
			 dbg("Gray--");
             break;
                }
		case 3: { 
             // Resize
             Size dsize = Size(var1, var2);
             cv::resize(*visionImage->mat, *visionImage->mat, dsize);
             break;
                } 
		case 4: {
			// Color Space Change
			// var1: color space
			// var2: channel (1-3)

			// var1
			// 1: RGB
			// 2: HSV
			// 3: XYZ

			// 4: HLS
			// 5: Lab
			// 6: LUV
			// 7: YCrCb
            switch (var1) {
            case 1:
                 cvtColor(*visionImage->mat, *visionImage->mat, CV_BGR2RGB);
                 break;
            case 2:
                cvtColor(*visionImage->mat, *visionImage->mat, CV_BGR2HSV);
                break;
            case 3:
                cvtColor(*visionImage->mat, *visionImage->mat, CV_BGR2XYZ);
                break;
            case 4:
                 cvtColor(*visionImage->mat, *visionImage->mat, CV_BGR2HLS);
                 break;
            case 5:
                 cvtColor(*visionImage->mat, *visionImage->mat, CV_BGR2Lab);
                 break;
            case 6:
                 cvtColor(*visionImage->mat, *visionImage->mat, CV_BGR2Luv);
                 break;
            case 7:
                 cvtColor(*visionImage->mat, *visionImage->mat, CV_BGR2YCrCb);
                 break;
			}
			
            break;
                }
        }
		RiLock_Unlock(visionImage->lock);
        dbg("Vision_BasicProcess_New --");

        return 1;
    }

	RI_API int Vision_Threshold(int imageSn, int threshold, int thresholdType, int type, int variables1, int variables2) {
        dbg("Vision_Threshold ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}
		thresholdVal = threshold;
		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);

		if (visionImage->mat->channels() != 1) {
			cvtColor(*visionImage->mat, *visionImage->mat, CV_BGR2GRAY);
		}
        // thresholdType = 1: Normal 
        // thresholdType = 2: otsu 
        // thresholdType = 3: adaptive
        // Do your Image Processing ++.
        switch (thresholdType) {	
        case 1:
            cv::threshold(*visionImage->mat, *visionImage->mat, threshold, 255.0 , type);
            break;
        case 2:
            cv::threshold(*visionImage->mat, *visionImage->mat, 0, 255, CV_THRESH_BINARY | CV_THRESH_OTSU);
            break;
        case 3:
            cv::adaptiveThreshold(*visionImage->mat, *visionImage->mat, 255, CV_ADAPTIVE_THRESH_MEAN_C, CV_THRESH_BINARY, variables1, variables2);
            break;
        }
		RiLock_Unlock(visionImage->lock);
        dbg("Vision_Threshold --");

        return 1;
    }

	RI_API int Vision_EdgeCanny(int imageSn, int kernalSize, int threshValue) {
        dbg("Vision_EdgeCanny ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);
		if (visionImage->mat->channels() > 1) {
			cvtColor(*visionImage->mat, *visionImage->mat, CV_BGR2GRAY);
		}
		cv::Canny(*visionImage->mat, *visionImage->mat, threshValue, threshValue * 3, kernalSize);

		RiLock_Unlock(visionImage->lock);
        dbg("Vision_EdgeCanny --");

        return 1;
    }

	RI_API int Vision_EdgeSobel(int imageSn, int ksize, int scale) {
        dbg("Vision_EdgeSobel ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);
        // Do your Image Processing ++.

        //blur(srcMat, dstMat, Size(3, 3));	
        Mat grad_x, grad_y; 
        Mat abs_grad_x, abs_grad_y;

		Sobel(*visionImage->mat, grad_x, CV_16S, 1, 0, ksize, scale, 0, BORDER_DEFAULT);	
        Sobel(*visionImage->mat, grad_y, CV_16S, 0, 1, ksize, scale, 0, BORDER_DEFAULT);  
        convertScaleAbs(grad_x, abs_grad_x);
        convertScaleAbs(grad_y, abs_grad_y);
        addWeighted(abs_grad_x, 0.5, abs_grad_y, 0.5, 0, *visionImage->mat);
		//addWeighted(abs_grad_x, 0.5, abs_grad_y, 0.5, 0, grad_x);

		//grad_x.convertTo(grad_y, CV_8UC1);
        // Do your Image Processing --.
		RiLock_Unlock(visionImage->lock);
		//imshow("sobel", grad_y);
		//waitKey(0);
        dbg("Vision_EdgeSobel --");

        return 1;
    }

	RI_API int Vision_EdgeLaplace(int imageSn, int ksize, int scale) {
        dbg("Vision_EdgeLaplace ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);
        // Do your Image Processing ++.

        //dstMat=srcMat.clone();
        //blur(srcMat, dstMat, Size(3, 3));
		//dbg("ksize = %d", ksize);
		//dbg("scale = %d", scale);
        Mat dst;

        Laplacian(*visionImage->mat, dst, CV_16S, ksize, scale, 0, BORDER_DEFAULT);

        convertScaleAbs(dst, *visionImage->mat);

        // Do your Image Processing --.
		RiLock_Unlock(visionImage->lock);
        dbg("Vision_EdgeLaplace --");

        return 1;
    }

	RI_API int Vision_EntryDilate(int imageSn, int type, int eleHeight, int eleWeight) {
        dbg("Vision_EntryDilate ++");

		if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);
        // Do your Image Processing ++.
        Mat element = getStructuringElement(type,
            Size(2 * eleHeight + 1, 2 * eleWeight + 1),
            Point(eleHeight, eleWeight));

        dilate(*visionImage->mat, *visionImage->mat, element);
        // Do your Image Processing --.
		RiLock_Unlock(visionImage->lock);
        dbg("Vision_EntryDilate --");

        return 1;
    }

	RI_API int Vision_EntryErode(int imageSn, int type, int eleHeight, int eleWeight) {
        dbg("Vision_EntryErode ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);
		// Do your Image Processing ++.
        Mat element = getStructuringElement(type,
            Size(2 * eleHeight + 1, 2 * eleWeight + 1),
            Point(eleHeight, eleWeight));
        
        erode(*visionImage->mat, *visionImage->mat, element);
        // Do your Image Processing --.
		RiLock_Unlock(visionImage->lock);
        dbg("Vision_EntryErode --");

        return 1;
    }

	RI_API int Vision_EntryOpen(int imageSn, int type, int eleHeight, int eleWeight) {
        dbg("Vision_EntryOpen ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);

        Mat element = getStructuringElement(type,
            Size(2 * eleHeight + 1, 2 * eleWeight + 1),
            Point(eleHeight, eleWeight));
        // Do your Image Processing ++.
        dilate(*visionImage->mat, *visionImage->mat, element);
        erode(*visionImage->mat, *visionImage->mat, element);
        // Do your Image Processing --.
		RiLock_Unlock(visionImage->lock);
        dbg("Vision_EntryOpen --");

        return 1;
    }

    RI_API int Vision_EntryClose(int imageSn, int type, int eleHeight, int eleWeight) {
        dbg("Vision_EntryClose ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);

        Mat element = getStructuringElement(type,
            Size(2 * eleHeight + 1, 2 * eleWeight + 1),
            Point(eleHeight, eleWeight));
        // Do your Image Processing ++.
        erode(*visionImage->mat, *visionImage->mat, element);
        dilate(*visionImage->mat, *visionImage->mat, element);
        // Do your Image Processing --.
		RiLock_Unlock(visionImage->lock);
        dbg("Vision_EntryClose --");

        return 1;
    }

	RI_API int Vision_SmoothBlur(int imageSn, int ksize) {
        dbg("Vision_SmoothBlur ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);

        // Do your Image Processing ++.
        blur(*visionImage->mat, *visionImage->mat, Size(ksize, ksize), Point(-1, -1));	
        // Do your Image Processing --.
		RiLock_Unlock(visionImage->lock);
        dbg("Vision_SmoothBlur --");

        return 1;
    }

	RI_API int Vision_SmoothGaussian(int imageSn, int ksize) {
        dbg("Vision_SmoothGaussian ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);
        // Do your Image Processing ++.
        GaussianBlur(*visionImage->mat, *visionImage->mat, Size(ksize, ksize), 0, 0);
        // Do your Image Processing --.
		RiLock_Unlock(visionImage->lock);
        dbg("Vision_SmoothGaussian --");

        return 1;
    }

	RI_API int Vision_SmoothMedian(int imageSn, int ksize) {
        dbg("Vision_SmoothMedian ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);
        // Do your Image Processing ++.
        medianBlur(*visionImage->mat, *visionImage->mat, ksize);
        // Do your Image Processing --.
        RiLock_Unlock(visionImage->lock);
        dbg("Vision_SmoothMedian --");

        return 1;
    }

	RI_API int Vision_SmoothBilateral(int imageSn, int ksize) {
        dbg("Vision_SmoothBilateral ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);
        // Do your Image Processing ++.
        bilateralFilter(*visionImage->mat, *visionImage->mat, ksize, ksize * 2, ksize / 2);
        // Do your Image Processing --.
		RiLock_Unlock(visionImage->lock);
        dbg("Vision_SmoothBilateral --");

        return 1;
    }

	RI_API int Vision_FFT(int imageSnSrc, int imageSnDst, int channel) {
		dbg("Vision_FFT ++");

		if (imageSnSrc >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImageSrc = visionImages + imageSnSrc;
		VisionImage_t *visionImageDst = visionImages + imageSnDst;

		RiLock_Lock(visionImageSrc->lock);

		Mat padded;                            // expand input image to optimal size
		int m = getOptimalDFTSize(visionImageSrc->mat->rows);
		int n = getOptimalDFTSize(visionImageSrc->mat->cols); // on the border add zero values
		copyMakeBorder(*visionImageSrc->mat, padded, 0, m - visionImageSrc->mat->rows, 0, n - visionImageSrc->mat->cols, BORDER_CONSTANT, Scalar::all(0));

		Mat channels[3];

		split(padded, channels);

		Mat planes[] = { Mat_<float>(channels[channel]), Mat::zeros(padded.size(), CV_32F) };
		Mat complexI;
		merge(planes, 2, complexI);   // Add to the expanded another plane with zeros
		dft(complexI, complexI);      // this way the result may fit in the source matrix
		split(complexI, planes);      // planes[0] = Re(DFT(I), planes[1] = Im(DFT(I))
		magnitude(planes[0], planes[1], planes[0]);// planes[0] = magnitude
		Mat magI = planes[0];
		magI += Scalar::all(1);                    // switch to logarithmic scale
		log(magI, magI);
		magI = magI(Rect(0, 0, magI.cols & -2, magI.rows & -2));
		int cx = magI.cols / 2;
		int cy = magI.rows / 2;
		Mat q0(magI, Rect(0, 0, cx, cy));   // Top-Left - Create a ROI per quadrant
		Mat q1(magI, Rect(cx, 0, cx, cy));  // Top-Right
		Mat q2(magI, Rect(0, cy, cx, cy));  // Bottom-Left
		Mat q3(magI, Rect(cx, cy, cx, cy)); // Bottom-Right
		Mat tmp;                           // swap quadrants (Top-Left with Bottom-Right)
		q0.copyTo(tmp);
		q3.copyTo(q0);
		tmp.copyTo(q3);
		q1.copyTo(tmp);                    // swap quadrant (Top-Right with Bottom-Left)
		q2.copyTo(q1);
		tmp.copyTo(q2);
		normalize(magI, magI, 0, 255, CV_MINMAX); // Transform the matrix with float values into a
		magI.convertTo(*visionImageDst->mat, CV_8UC1);

		RiLock_Unlock(visionImageSrc->lock);
		dbg("Vision_FFT --");
		return 1;
	}

	RI_API int Vision_IFFT(int imageSn, int color_space, int type1, int type2, int radius, int n) {
		dbg("Vision_IFFT ++");

		if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}
		VisionImage_t *visionImage = visionImages + imageSn;

		RiLock_Lock(visionImage->lock);

		Mat channels1[3];
		Mat channels2[3];
		split(*visionImage->mat, channels1);


		if (color_space == 0) {
			//Mat dstMat(visionImage->mat->rows, visionImage->mat->cols, CV_8UC3);

			if (type1 == 1) {
				channels2[0].push_back(vision_ideal(channels1[0], type2, (float)radius, 0));
				channels2[1].push_back(vision_ideal(channels1[1], type2, (float)radius, 0));
				channels2[2].push_back(vision_ideal(channels1[2], type2, (float)radius, 0));

				merge(channels2, 3, *visionImage->mat);

			}
			if (type1 == 2) {
				channels2[0].push_back(vision_butterworth(channels1[0], type2, (float)radius, n, 0));
				channels2[1].push_back(vision_butterworth(channels1[1], type2, (float)radius, n, 0));
				channels2[2].push_back(vision_butterworth(channels1[2], type2, (float)radius, n, 0));

				merge(channels2, 3, *visionImage->mat);
			}
			if (type1 == 3) {
				channels2[0].push_back(vision_gaussianFreq(channels1[0], type2, (float)radius, 0));
				channels2[1].push_back(vision_gaussianFreq(channels1[1], type2, (float)radius, 0));
				channels2[2].push_back(vision_gaussianFreq(channels1[2], type2, (float)radius, 0));

				merge(channels2, 3, *visionImage->mat);
			}


			/*else if (type1 == 2) {
			dstMat = butterworth(channels1[color_space - 1], type2, radius, 1);
			} else if (type1 == 3) {
			dstMat = gaussianFreq(channels1[color_space - 1], type2, radius);
			}*/

		} else {
			//Mat dstMat(srcHeight, srcWidth, CV_8UC1);

			if (type1 == 1) {
				*visionImage->mat = vision_ideal(channels1[color_space - 1], type2, (float)radius, 1);
			}
			else if (type1 == 2) {
				*visionImage->mat = vision_butterworth(channels1[color_space - 1], type2, (float)radius, n, 1);
			}
			else if (type1 == 3) {
				*visionImage->mat = vision_gaussianFreq(channels1[color_space - 1], type2, (float)radius, 1);
			}
		}

		RiLock_Unlock(visionImage->lock);
		dbg("Vision_IFFT --");
		return 1;
	}

	RI_API int Vision_Sharpen(int imageSn, float k1, float k2, int sigma) {
        dbg("Vision_Sharpen ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);

		Mat dstMat(visionImage->mat->rows, visionImage->mat->cols, CV_8UC3);
        cv::GaussianBlur(*visionImage->mat, dstMat, cv::Size(0, 0), sigma);
        cv::addWeighted(*visionImage->mat, k1, dstMat, k2, 0, *visionImage->mat);

        //cvtColor(inputMat,srcMat,CV_BGR2GRAY);
		RiLock_Unlock(visionImage->lock);
        dbg("Vision_Sharpen --");

        return 1;
    }

	RI_API int Vision_MaskSharpen (int imageSn) {
        dbg("Vision_MaskSharpen ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);

        Mat mask = (Mat_<char>(3,3) << 0,-1, 0,  
            -1, 5,-1,  
            0,-1, 0); 
        filter2D (*visionImage->mat, *visionImage->mat, visionImage->mat->depth(), mask);  

		RiLock_Unlock(visionImage->lock);
        dbg("Vision_MaskSharpen --");

        return 1;
    }

	RI_API int Vision_NormalNoise (int imageSn, float mean, float stddev) {	
        dbg("Vision_NormalNoise ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);

		Mat inputMat = Mat(visionImage->mat->rows, visionImage->mat->cols, CV_32FC3);
        Mat dstMat;
        dstMat.create(visionImage->mat->rows, visionImage->mat->cols, CV_32FC3);

		visionImage->mat->convertTo(inputMat, CV_32F);
        
		Mat noise = Mat(visionImage->mat->size(), CV_32F);
        Mat channels[3];
        split(inputMat, channels);

        randn(noise, mean, stddev);

        channels[0] += noise;
        channels[1] += noise;
        channels[2] += noise;

        merge(channels, 3, dstMat);

        //normalize(dstMat, dstMat, 0, 255, NORM_MINMAX, CV_32F);
        dstMat.convertTo(*visionImage->mat, CV_8UC3);

		RiLock_Unlock(visionImage->lock);
        dbg("Vision_NormalNoise --");
        return 1;
    }

	RI_API int Vision_UniformNoise (int imageSn, float low, float high) {	
        dbg("Vision_UniformNoise ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);

		Mat SrcMat(visionImage->mat->rows, visionImage->mat->cols, CV_32FC3);
        Mat DstMat(visionImage->mat->rows, visionImage->mat->cols, CV_32F);

		visionImage->mat->convertTo(SrcMat, CV_32F);

        Mat noise = Mat(visionImage->mat->size(), CV_32F);
        randu(noise, low * 10, high * 10);

        
        Mat channels[3];
        split(SrcMat, channels);

        channels[0] += noise;
        channels[1] += noise;
        channels[2] += noise;

        merge(channels, 3, DstMat);
        DstMat.convertTo(*visionImage->mat, CV_8U);

		RiLock_Unlock(visionImage->lock);
        dbg("Vision_UniformNoise --");

        return 1;
    }

	RI_API int Vision_CvHaarWavelet(int imageSnSrc, int imageSnDst, int type, int number, float hp, float lp) {
		dbg("Vision_CvHaarWavelet ++");

		if (imageSnSrc >= VISION_IMAGE_COUNT_MAX || imageSnDst >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}
		
		VisionImage_t *visionImageSrc = visionImages + imageSnSrc;
		VisionImage_t *visionImageDst = visionImages + imageSnDst;
		RiLock_Lock(visionImageSrc->lock);

		//Mat inputMat(srcHeight, srcWidth, CV_8UC3);
		Mat srcMat(visionImageSrc->mat->rows, visionImageSrc->mat->cols, CV_32FC1);
		Mat dstMat(visionImageSrc->mat->rows, visionImageSrc->mat->cols, CV_32FC1);
		//ri_memcpy(inputMat.data, srcData, srcHeight * srcWidth * 3);

		if (visionImageSrc->mat->channels() > 1) {
			cvtColor(*visionImageSrc->mat, srcMat, CV_BGR2GRAY);
		}
		srcMat.convertTo(srcMat, CV_32FC1);
		
		// type 1: haar
		// type 2: sym
		dstMat = vision_WDT(srcMat, type, number, 1, hp, lp);
		dstMat.convertTo(*visionImageDst->mat, CV_8UC1);
		//normalize(dstMat, dstMat, 0, 255, NORM_MINMAX);
		//ri_memcpy(dstData, dstMat.data, srcHeight * srcWidth);

		dbg("Vision_CvHaarWavelet --");

		return 1;
	}

	RI_API int Vision_CvInvHaarWavelet(int imageSnSrc, int imageSnDst, int type, int number, float hp, float lp) {
		dbg("Vision_CvInvHaarWavelet ++");

		if (imageSnSrc >= VISION_IMAGE_COUNT_MAX || imageSnDst >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImageSrc = visionImages + imageSnSrc;
		VisionImage_t *visionImageDst = visionImages + imageSnDst;
		RiLock_Lock(visionImageSrc->lock);

		Mat srcMat(visionImageSrc->mat->rows, visionImageSrc->mat->cols, CV_32FC1);
		Mat dstMat(visionImageSrc->mat->rows, visionImageSrc->mat->cols, CV_32FC1);
		//ri_memcpy(inputMat.data, srcData, srcHeight * srcWidth * 3);

		if (visionImageSrc->mat->channels() > 1) {
			cvtColor(*visionImageSrc->mat, srcMat, CV_BGR2GRAY);
			srcMat.convertTo(srcMat, CV_32FC1);
		} else {
			visionImageSrc->mat->convertTo(srcMat, CV_32FC1);
			//imshow("srcMat", srcMat);
			//waitKey(0);
		}
		//imshow("0", srcMat);
		dstMat = vision_WDT(srcMat, type, number, 1, hp, lp);
		//imshow("1", dstMat);
		dstMat = vision_IWDT(dstMat, type, number, 1, hp, lp);
		//imshow("DST", dstMat);
		//waitKey(30);
		dstMat.convertTo(dstMat, CV_8UC1);
		//imshow("DST2", dstMat);
		//waitKey(30);
		//imshow("dstmat", dstMat);
		normalize(dstMat, *visionImageDst->mat, 0, 255, NORM_MINMAX);

		dbg("Vision_CvInvHaarWavelet --");

		return 1;
	}

	RI_API int Vision_BrightnessContrast(int imageSn, float contrast, float brightness) {
        dbg("Vision_BrightnessContrast ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);

        visionImage->mat->convertTo(*visionImage->mat, -1, contrast, brightness);

		RiLock_Unlock(visionImage->lock);
        dbg("Vision_BrightnessContrast --");

        return 1;
    }

	RI_API int Vision_Sketch (int imageSn) {
        dbg("Vision_MaskSharpen ++");
		int channels = 1;

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);

        Mat inputMat(visionImage->mat->rows, visionImage->mat->cols, CV_8UC1);
        
		if (visionImage->mat->channels() > 1) {
			channels = 3;
			cvtColor(*visionImage->mat, inputMat, CV_BGR2GRAY);
		}
        addWeighted(inputMat, -1, NULL, 0, 255, inputMat);
        GaussianBlur(inputMat, inputMat, Size(7 , 7), 0);


        for (int y = 0; y < inputMat.rows - 1; y++) {
            uchar* P0  = inputMat.ptr<uchar>(y);  
            uchar* P1  = inputMat.ptr<uchar>(y + 1);  
			uchar* P  = visionImage->mat->ptr<uchar>(y);  
            for (int x = 0; x < inputMat.cols - 1; x++) {  
                int tmp0 = P0[x];  
                int tmp1 = P1[x + 1];  

                int diff = abs(tmp0 - tmp1);

                if(diff > 5) {
                    P[x * channels] = 0;
                }
                else {				
                    P[x * channels] = 255;
                }
            }  

        }
		RiLock_Unlock(visionImage->lock);
        dbg("Vision_MaskSharpen --");

        return 1;
    }

	RI_API int Vision_Cartoon (int imageSn) {
        dbg("Vision_Cartoon ++");
		int channels = 1;

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);


		Mat srcMat(visionImage->mat->rows, visionImage->mat->cols, CV_8UC3);
        Mat inputMat(visionImage->mat->rows, visionImage->mat->cols, CV_8UC1);
		srcMat = visionImage->mat->clone();

		if (visionImage->mat->channels() > 1) {
			channels = 3;
			cvtColor(*visionImage->mat, inputMat, CV_BGR2GRAY);
		}

        addWeighted(inputMat, -1, NULL, 0, 255, inputMat);
        GaussianBlur(inputMat, inputMat,Size(7, 7), 0);

        for (int y = 0; y < inputMat.rows - 1; y++) {  

            uchar* P0  = inputMat.ptr<uchar>(y);  
            uchar* P1  = inputMat.ptr<uchar>(y + 1);  
            uchar* P  = visionImage->mat->ptr<uchar>(y);  
            for (int x = 0; x < inputMat.cols - 1; x++) {  
                int tmp0 = P0[x];  
                int tmp1 = P1[x + 1];  

                int diff = abs(tmp0 - tmp1);

                if(diff > 5) {
                    P[x * channels] = 0;
                }
                else {				
                    P[x * channels] = 255;
                }
            }  
        }

        //cvtColor(*visionImage->mat, *visionImage->mat, CV_GRAY2BGR);
        Mat element = getStructuringElement(CV_SHAPE_ELLIPSE,
            Size(2 * 3 + 1, 2 * 3 + 1),
            Point(3, 3));	
		
        dilate(srcMat, srcMat, element);
        srcMat.copyTo(*visionImage->mat, *visionImage->mat);

		RiLock_Unlock(visionImage->lock);
        dbg("Vision_Cartoon --");
        return 1;
    }

	RI_API int Vision_GroundGlass (int imageSn) {	
        dbg("Vision_MaskSharpen ++");

        if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);


        //Mat srcMat(visionImage->mat->rows, visionImage->mat->cols, CV_8UC3);
		Mat srcMat(visionImage->mat->rows, visionImage->mat->cols, CV_RGB2YCrCb);
		srcMat = visionImage->mat->clone();

        for(int y = 0; y < srcMat.rows - 10; y++) {
            uchar *P1 = visionImage->mat->ptr<uchar>(y);
            for(int x = 0; x < srcMat.cols - 10; x++) {
                int point = rand() % 10 + 1;

                P1[3 * x] = srcMat.at<uchar>(y + point, 3 * (x + point));
                P1[(3 * x) + 1] = srcMat.at<uchar>(y + point, 3 * (x + point) + 1);
                P1[(3 * x) + 2] = srcMat.at<uchar>(y + point, 3 * (x + point) + 2);					

            }
        }

		RiLock_Unlock(visionImage->lock);
        return 1;
    }

	RI_API int Vision_StartWebCam(HANDLE data) {
		RiLock_Lock(visionWebCamLock);

		if (visionVideoCapture.isOpened()) {
			dbg("visionVideoCapture.isOpened");
			RiLock_Unlock(visionWebCamLock);
			return 2; //Already open camera.
		}

		dbg("StartCapture++");
		
		visionWebCamWindowHandle = (HWND)data;
		visionWebCamDeviceContextHandle = GetDC(visionWebCamWindowHandle);
		GetClientRect(visionWebCamWindowHandle, &visionWebCamRect);
		
		try {
			if (!visionVideoCapture.open(0)) {
				dbg("!visionVideoCapture.open(0)");
				RiLock_Unlock(visionWebCamLock);
				return -2;
			}
			if (!visionVideoCapture.isOpened()) {
				dbg("!visionVideoCapture.isOpened()");
				RiLock_Unlock(visionWebCamLock);
				return -3;
			}
		} catch (Exception e) {
			dbg("Exception");
			RiLock_Unlock(visionWebCamLock);
			return -4;
		}

		//Sleep(3000); // Wait for camera ready.

		RiLock_Unlock(visionWebCamLock);
		visionWebCamThread = CreateThread(NULL, 0, vision_WebCamThread, NULL, 0, NULL);
		return 1;
	}

	RI_API int Vision_ResizeWebCam() {
		RiLock_Lock(visionWebCamLock);
		GetClientRect(visionWebCamWindowHandle, &visionWebCamRect);
		RiLock_Unlock(visionWebCamLock);
		return 1;
	}

	RI_API int Vision_StopWebCam() {
		if (visionWebCamThread != INVALID_HANDLE_VALUE) {
			visionWebCamThreadToClose = 1;
			WaitForSingleObject(visionWebCamThread, INFINITE);
			CloseHandle(visionWebCamThread);
			visionWebCamThread = INVALID_HANDLE_VALUE;

			visionVideoCapture.release();

			//RiLock_Free(visionWebCamLock);
		}
		
		return 1;
	}
	
	inline int vision_DrawWebCam() {
		dbg("vision_DrawWebCam++");

		// Thresholding Demo
		// int c = visionWebCamMat.cols * visionWebCamMat.rows; for (int i = 0; i < c; i++) { int j = i * 3;if (visionWebCamMat.data[j] > 128){visionWebCamMat.data[j] = 255;visionWebCamMat.data[j+1] = 255;visionWebCamMat.data[j+2] = 255;} else{visionWebCamMat.data[j] = 0;visionWebCamMat.data[j + 1] = 0;visionWebCamMat.data[j + 2] = 0;}}

		RiLock_Lock(visionWebCamLock);
		
		glTexImage2D(GL_TEXTURE_2D, 0, GL_RGB, visionWebCamMat.cols, visionWebCamMat.rows, 0, 0x80E0, GL_UNSIGNED_BYTE, visionWebCamMat.ptr());
		glViewport(0, 0, visionWebCamRect.right - visionWebCamRect.left, visionWebCamRect.bottom - visionWebCamRect.top);
		
		// Draw a textured quad
		glBegin(GL_QUADS);
		glTexCoord2f(0.0f, 0.0f); glVertex2f(1, 1);
		glTexCoord2f(1.0f, 0.0f); glVertex2f(-1, 1);
		glTexCoord2f(1.0f, 1.0f); glVertex2f(-1, -1);
		glTexCoord2f(0.0f, 1.0f); glVertex2f(1, -1);
		glEnd();
		glFlush();

		SwapBuffers(visionWebCamDeviceContextHandle);

		RiLock_Unlock(visionWebCamLock);

		return 1;
	}

	RI_API int Vision_NewImage() {
		for (int i = 0; i < VISION_IMAGE_COUNT_MAX; i ++) {
			VisionImage_t *visionImage = visionImages + i;
			
			RiLock_Lock(visionImage->lock);
			if (visionImage->isInUse == 0) {
				if (visionImage->mat == NULL) {
					visionImage->mat = new cv::Mat();
					if (visionImage->mat == NULL) {
						RiLock_Unlock(visionImage->lock);
						return -2;
					}
				}
				visionImage->isInUse = 1;
				RiLock_Unlock(visionImage->lock);
				return visionImage->sn;
			}
			RiLock_Unlock(visionImage->lock);
		}
		dbg("Vision_NewImage--");
		return -1;
	}

	RI_API int Vision_FreeImage(int imageSn) {
		if (imageSn < 0 || imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -2;
		}

		VisionImage_t *visionImage = visionImages + imageSn;

		RiLock_Lock(visionImage->lock);
		visionImage->isInUse = 0;
		if (visionImage->mat != NULL) {
			visionImage->mat->release();
		}
		RiLock_Unlock(visionImage->lock);

		return 1;
	}

	RI_API int Vision_CloneImage(int imageSnSrc, int imageSnDst) {
		*(visionImages[imageSnDst].mat) = visionImages[imageSnSrc].mat->clone();
		return 1;
	}

	RI_API int Vision_LoadImage(int imageSn, char *imagePath) {
		dbg("Vision_LoadImage++");
		if (imagePath == NULL || imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}

		VisionImage_t *visionImage = visionImages + imageSn;
		RiLock_Lock(visionImage->lock);
		//if (FILE* img = fopen(imagePath, "r")) {
		//	fclose(img);
		//}
		//else {
		//	dbg("File paths");
		//	RiLock_Unlock(visionImage->lock);
		//	return -2;
		//}
		dbg(imagePath);
		*visionImage->mat = cv::imread(imagePath);

		RiLock_Unlock(visionImage->lock);
		dbg("Vision_LoadImage--");
		return 1;
	}

	RI_API int Vision_GetImageInfo(int imageSn, VisionImageInfo_t *imageInfo) {
		VisionImage_t *visionImage = visionImages + imageSn;
		int channel = visionImage->mat->channels();

		dbg("Vision_GetBitmapInformation++");
		dbg("channels:%d", visionImage->mat->channels());
		imageInfo->width = visionImage->mat->cols;
		imageInfo->height = visionImage->mat->rows;
		imageInfo->channel = visionImage->mat->channels();

		//memcpy(&imageInfo->width, &visionImage->mat->cols, sizeof(int));
		//memcpy(&imageInfo->height, &visionImage->mat->rows, sizeof(int));
		//memcpy(&imageInfo->channel, &channel, sizeof(int));
		return 1;
	}

	RI_API int Vision_GetBitmapData(int imageSn, HANDLE scan, int stride) {
		VisionImage_t *visionImage  = visionImages + imageSn;
		
		unsigned char *dst = (unsigned char *)scan;
		unsigned char *src = visionImage->mat->data;
		int rowSize = visionImage->mat->channels() * visionImage->mat->cols;

		for (int i = 0; i < visionImage->mat->rows; i++) {
			ri_memcpy(dst, src, rowSize);
			dst += stride;
			src += rowSize;
		}

		return 1;
	}

	RI_API int Vision_GetBitmapChannelData(int imageSn, int channel, HANDLE scan, int stride) {
		VisionImage_t *visionImage = visionImages + imageSn;
		
		unsigned char *dst = (unsigned char *)scan;
		unsigned char *src = visionImage->mat->data;
		int channels = visionImage->mat->channels();

		for (int i = 0; i < visionImage->mat->rows; i++) {
			for (int j = 0; j < visionImage->mat->cols; j++) {
				dst[j] = src[channel];
				src += channels;
			}
			dst += stride;
		}

		return 1;
	}

	/*RI_API int Vision_DrawImage(HANDLE data, int imageSn) {
		if (imageSn >= VISION_IMAGE_COUNT_MAX) {
			return -1;
		}
		VisionImage_t *visionImage = visionImages + imageSn;

		//cv::imshow("", *(visionImages + imageSn)->mat);
		//waitKey(0);

		HWND visionWindowHandle = (HWND)data;
		HDC visionDeviceContextHandle = GetDC(visionWindowHandle);
		//GetClientRect(visionWebCamWindowHandle, &visionWebCamRect);

		int nFormat;
		PIXELFORMATDESCRIPTOR pfd;
        pfd.nVersion   = 1;
        pfd.dwFlags    = PFD_DRAW_TO_WINDOW | PFD_SUPPORT_OPENGL | PFD_DOUBLEBUFFER; 
        pfd.iPixelType = (unsigned char)(PFD_TYPE_RGBA);
        pfd.cColorBits = 32;
        pfd.cDepthBits = 32;
        pfd.iLayerType = (unsigned char)(PFD_MAIN_PLANE);

		//RiLock_Lock(visionWebCamLock);
        nFormat = ChoosePixelFormat(visionDeviceContextHandle, &pfd);
        SetPixelFormat(visionDeviceContextHandle, nFormat, &pfd);
		
        HGLRC visionRenderingContextHandle = (wglCreateContext(visionDeviceContextHandle));
        if (visionRenderingContextHandle == 0) {
            dbg("wglCreateContext Error");
			//RiLock_Unlock(visionWebCamLock);
			return -1;
		}
        if (wglMakeCurrent(visionDeviceContextHandle, visionRenderingContextHandle ) == false) {
            dbg("wglMakeCurrent Error");
			//RiLock_Unlock(visionWebCamLock);
			return -2;
		}
		glEnable(GL_TEXTURE_2D);

		glTexParameterf(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_REPEAT);
		glTexParameterf(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_REPEAT);
		glTexParameterf(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_NEAREST);
		glTexParameterf(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_NEAREST);

		// Set Projection Matrix
		glMatrixMode (GL_PROJECTION);
		glLoadIdentity();


		//TODO:if is gray image,will crash. 0x80E0 GL_BGR
		RiLock_Lock(visionImage->lock);
		glTexImage2D(GL_TEXTURE_2D, 0, GL_RGB, visionImage->mat->cols, visionImage->mat->rows, 0, 0x80E0, GL_UNSIGNED_BYTE, visionImage->mat->ptr());
		RiLock_Unlock(visionImage->lock);
		//glViewport(0, 0, visionWebCamRect.right - visionWebCamRect.left, visionWebCamRect.bottom - visionWebCamRect.top);

		// Draw a textured quad
		glBegin(GL_QUADS);
		glTexCoord2f(0.0f, 0.0f); glVertex2f(-1, 1);
		glTexCoord2f(1.0f, 0.0f); glVertex2f(1, 1);
		glTexCoord2f(1.0f, 1.0f); glVertex2f(1, -1);
		glTexCoord2f(0.0f, 1.0f); glVertex2f(-1, -1);
		glEnd();
		glFlush();
		SwapBuffers(visionDeviceContextHandle);
		return 1;
	}*/


#ifdef __cplusplus
}
#endif
