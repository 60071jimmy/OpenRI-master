// ur_dll.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "ur_dll.h"
#include <Windows.h>
#include "ur.h"
#include <winsock2.h>
#include <windows.h>
#include <ws2tcpip.h>
#include "gt_dbg.h"


static int aoiIsInited = 0;
static WSADATA aoiwsaData;
static SOCKET urSocketControl[2] = {INVALID_SOCKET};
static struct addrinfo *urResult = NULL;
static struct addrinfo *urPtr = NULL;
static struct addrinfo urHints;
static HANDLE ReadMessageFromUR[2] = {INVALID_HANDLE_VALUE};

static HANDLE urTaskThreadCreateEvent[2] = {INVALID_HANDLE_VALUE};
struct aoiInfo {
    double aoiMotorAng[6];
    double aoiURPose[6];
    float aoiMotorVolt[6];
    float aoiMotorTemp[6];	
    float aoiMotorCurrent[6];
    int aoiDigitalInputBits[8];
    int aoiDigitalOutputBits[8];
    int aoiAnalogInputUnit[2];
    double aoiAnalogInput[2];
    int aoiAnalogOutputUnit[2] ;
    double aoiAnalogOutput[2];
};
static aoiMotorData motorData[2] ;
static HWND urWindowHandle; 
static HDC  urDeviceContext;
static HGLRC urResourceContext; 

#pragma comment (lib, "Ws2_32.lib")
#pragma comment (lib, "Mswsock.lib")
#pragma comment (lib, "AdvApi32.lib")


#ifdef __cplusplus
extern "C" 
{
#endif
  
     int Ur_Window(HANDLE data) {

        urWindowHandle = (HWND)data;
        urDeviceContext = GetDC(urWindowHandle);
        SwapBuffers(urDeviceContext);        

        return 1;
    }

	GT_API int Ur_DrawUr(void) {   
		PIXELFORMATDESCRIPTOR pfd;
        pfd.nVersion   = 1; 
        pfd.dwFlags    = PFD_DRAW_TO_WINDOW | PFD_SUPPORT_OPENGL | PFD_DOUBLEBUFFER; 
        pfd.iPixelType = (unsigned char)(PFD_TYPE_RGBA);
        pfd.cColorBits = 32;
        pfd.cDepthBits = 32;
        pfd.iLayerType = (unsigned char)(PFD_MAIN_PLANE);

        int nFormat = ChoosePixelFormat(urDeviceContext, &pfd);
        BOOL pixel =SetPixelFormat(urDeviceContext, nFormat, &pfd);
		if(!pixel) {
			dbg("pixel");
		}

        urResourceContext = (wglCreateContext(urDeviceContext));
        if (urResourceContext == 0) {
			dbg("urResourceContext");
            return -1;// -1;
        }
        if (wglMakeCurrent(urDeviceContext, urResourceContext ) == false) {
			dbg("urDeviceContext");
            return -2;// -2;
        }

        glClearColor(0.0f,0.0f,0.0f,0.0f);   
        glEnable(GL_COLOR_MATERIAL);
        glEnable(GL_LIGHTING);
        glEnable(GL_LIGHT0);
        glEnable(GL_NORMALIZE);
        glEnable(GL_CULL_FACE);
        glEnable(GL_DEPTH_TEST);


        wglMakeCurrent(urDeviceContext, urResourceContext);
        glClearColor( 0.0f, 0.0f, 0.0f, 1.0f );
        glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT) ;

        glMatrixMode(GL_PROJECTION);
        glLoadIdentity();
        gluPerspective(30,1, 0.1, 1000);

        glMatrixMode(GL_MODELVIEW);
        glLoadIdentity();       
		initilize();
		setJointAngle(motorData[0].aoiMotorAng);		
			
        gluLookAt(0, 2, 4, 0, 0.5f, 0, 0, 1, 0);
        DrawGroundPlane();
        DrawRobotArm();
        SwapBuffers( urDeviceContext); 

		wglDeleteContext(urResourceContext);
		return 1;
    } 

	 GT_API int Ur_urModel(HANDLE aoiHandle)
    {
        MSG msg;          
        if(Ur_Window(aoiHandle) != 1)
        {
            return -1;
        }

		return 1;

    }

     GT_API int Ur_Init () {
        dbg("Ur_Init() ++");
      
        int ret = WSAStartup(MAKEWORD(2,2), &aoiwsaData);

        if (ret != 0) {
            dbg("WSAStartup failed with error: %d\n", ret);
            return -1;
        }

        urTaskThreadCreateEvent[0] = CreateEvent(NULL, false, false, NULL);
        urTaskThreadCreateEvent[1] = CreateEvent(NULL, false, false, NULL);

        dbg("Ur_Init() --");
        aoiIsInited = 1;

        return 1;
    }

    GT_API int Ur_Connect (int urSn, char *ip) {
        dbg("Ur_Connect() ++");

        ZeroMemory( &urHints, sizeof(urHints));
        urHints.ai_family = AF_UNSPEC;
        urHints.ai_socktype = SOCK_STREAM;
        urHints.ai_protocol = IPPROTO_TCP;

        int ret = getaddrinfo(ip, "30001", &urHints, &urResult);

        if ( ret != 0 ) {
            dbg("getaddrinfo failed with error: %d\n", ret);
            return -1;
        }

        urSocketControl[urSn] = socket(urResult->ai_family, urResult->ai_socktype, 
            urResult->ai_protocol);

        if (urSocketControl[urSn] == INVALID_SOCKET) {
            dbg("socket failed with error: %ld\n", WSAGetLastError());
            return -2;
        }

        ret = connect(urSocketControl[urSn], urResult->ai_addr, (int)urResult->ai_addrlen);

        if (ret == SOCKET_ERROR) {
            closesocket(urSocketControl[urSn]);
            urSocketControl[urSn] = INVALID_SOCKET;
            return -3;
        }

        freeaddrinfo(urResult);

        if (urSocketControl[urSn] == INVALID_SOCKET) {
            dbg("Unable to connect to server!\n");
            return -4;
        }	

        return 1;
    }

    GT_API int Ur_DisConnect (int urSn) {
        CloseHandle(ReadMessageFromUR[urSn]);
        ReadMessageFromUR[urSn] = INVALID_HANDLE_VALUE;

        if (urSocketControl[urSn] == INVALID_SOCKET) {
            return -1;
        }

        int ret =  closesocket(urSocketControl[urSn]);

        if (ret == SOCKET_ERROR) {
            return -2;
        }

        urSocketControl[urSn] = INVALID_SOCKET;

        return 1;
    }

    GT_API int Ur_Send (int urSn, char *str, int len) {
        if (urSocketControl[urSn] == INVALID_SOCKET) {
            return -1;
        }

        if (len <= 0) {
            return -2;
        }

        int ret = send(urSocketControl[urSn], str, len, 0);

        return ret;
    }

    GT_API int Ur_GetMotorData (aoiMotorData* motorInfo, int urSn) {
        *motorInfo = motorData[urSn];
        return 1;
    }

    DWORD WINAPI Ur_ThreadReadMessage(LPVOID lpParam) {   
        int urSn =  *(int *)lpParam;
        SetEvent(urTaskThreadCreateEvent[urSn]);	// Atom for parameter.

        char buffer[2048];
        char buf[8]; 	
        int ret =0;
        do{
            ret = recv(urSocketControl[urSn], buffer, 645, 0);
            if ( ret > 0 ) {
                BYTE * pByte;
                pByte = (BYTE*) buffer;
                int allLength;

                for (int i = 0; i < 4; i++) {
                    buf[3-i] = (int)*pByte;
                    pByte++;
                }
                memcpy(&allLength, buf, sizeof(int));
                unsigned char messageType = (unsigned char)*pByte;
                pByte++;
                if (messageType == 16) {
                    allLength -= 5;
                    while (allLength > 0) {	
                        int length;
                        for (int i = 0; i < 4; i++) {
                            buf[3-i] = (int)*pByte;
                            pByte++;
                        }
                        memcpy(&length, buf, sizeof(int));
                        allLength -= length;
                        unsigned char packageType = (unsigned char)*pByte;
                        pByte++;
                        switch (packageType) {
                        case 0: {
                            pByte += length-5;
                                }
                                break;
                        case 1: {
                            for (int i = 0; i < 6; i++){
                                for (int j = 0; j < 8; j++){
                                    buf[7-j] = (int)*pByte;
                                    pByte++;
                                    length--;
                                }
                                memcpy(&motorData[urSn].aoiMotorAng[i] ,buf, sizeof(double));
                                pByte += 16;
                                length -= 16;
                                for (int j = 0; j < 4; j++) {
                                    buf[3-j] = (int)*pByte;
                                    pByte++;
                                    length--;
                                }
                                memcpy(&motorData[urSn].aoiMotorCurrent[i], buf, sizeof(float));
                                for (int j = 0; j < 4; j++) {
                                    buf[3-j] = (int)*pByte;
                                    pByte++;
                                    length--;
                                }
                                memcpy(&motorData[urSn].aoiMotorVolt[i], buf, sizeof(float));
                                for (int j=0; j < 4; j++) {
                                    buf[3-j] = (int)*pByte;
                                    pByte++;
                                    length--;
                                }
                                memcpy(&motorData[urSn].aoiMotorTemp[i], buf, sizeof(float));
                                pByte += 5;
                                length -= 5;
                            }
                            pByte += length-5;
                                }
                                break;
                        case 2: {
                            pByte += length-5;
                                }
                                break;
                        case 3: {
                            for (int i = 0; i < 8; i++) {
                                motorData[urSn].aoiDigitalInputBits[i] = 0;
                                motorData[urSn].aoiDigitalOutputBits[i] = 0;
                            }
                            int digitalTotal = 0;
                            int index = 0;
                            for (int i=0; i < 4; i++) {
                                buf[3-i] = (int)*pByte;
                                pByte++;
                                length--;
                            }
                            memcpy(&digitalTotal, buf, sizeof(int));

                            while (digitalTotal > 0) {
                                motorData[urSn].aoiDigitalInputBits[index] = digitalTotal % 2;
                                digitalTotal = digitalTotal / 2;
                                index++;
                            }

                            for (int i=0; i < 4; i++) {
                                buf[3-i] = (int)*pByte;
                                pByte++;
                                length--;
                            }
                            memcpy(&digitalTotal, buf, sizeof(int));
                            index = 0;
                            while (digitalTotal > 0) {
                                motorData[urSn].aoiDigitalOutputBits[index] = digitalTotal % 2;
                                digitalTotal= digitalTotal / 2;
                                index++;
                            }

                            for(int i=0; i < 2; i++) {							 
                                motorData[urSn].aoiAnalogInputUnit[i] = (int)*pByte;
                                pByte++;
                                length--;
                            }

                            for (int i=0; i < 8; i++) {
                                buf[7-i] = (int)*pByte;
                                pByte++;
                                length--;
                            }
                            memcpy(&motorData[urSn].aoiAnalogInput[0], buf, sizeof(double));

                            for(int i=0; i < 8; i++) {
                                buf[7-i] = (int)*pByte;
                                pByte++;
                                length--;
                            }
                            memcpy(&motorData[urSn].aoiAnalogInput[1], buf, sizeof(double));
                            for(int i=0; i < 2; i++) {
                                motorData[urSn].aoiAnalogOutputUnit[i]= (int)*pByte;
                                pByte++;
                                length--;
                            }
                            for(int i=0; i<8; i++) {
                                buf[7-i] = (int)*pByte;
                                pByte++;
                                length--;
                            }
                            memcpy(&motorData[urSn].aoiAnalogOutput[0], buf, sizeof(double));

                            for(int i=0; i<8; i++) {
                                buf[7-i] = (int)*pByte;
                                pByte++;
                                length--;
                            }
                            memcpy(&motorData[urSn].aoiAnalogOutput[1], buf, sizeof(double));
                            pByte += length - 5;
                                }
                                break;
                        case 4: {
                            for (int i = 0; i < 6; i++) {
                                for (int j = 0; j < 8; j++) {
                                    buf[7-j] = (int)*pByte;
                                    pByte++;
                                    length--; 
                                }
                                memcpy(&motorData[urSn].aoiURPose[i], buf, sizeof(double));
                            }
                            pByte += length - 5;
                                }
                                break;
                        case 5: {
                            pByte += length-5;
                                }
                                break;
                        case 6: {
                            pByte += length-5;
                                }
                                break;
                        case 7: {
                            pByte += length-5;
                                }
                                break;
                        case 8: {
                            pByte += length-5;
                                }
                                break;
                        case 9: {
                            pByte += length-5;
                                }
                                break;
                        default:
                            pByte += length - 5;
                            break;
                        }
                    }
                }
            }
        } while (ret > 0);

        ret = closesocket(urSocketControl[urSn]);	

        if (ret = SOCKET_ERROR) {
            return -1;
        }

        return 1;
    }

    GT_API int Ur_Receive (int urSn) {
        if(urSocketControl[urSn] > 0) {
            ReadMessageFromUR[urSn] = CreateThread(NULL, 0, Ur_ThreadReadMessage, &urSn, 0, NULL);
            if (WaitForSingleObject(urTaskThreadCreateEvent[urSn], 10000) != WAIT_OBJECT_0) {
                return -1;
            }
        }

        return 1;
    }

    GT_API int Ur_Close () {
        WSACleanup();	

        return 1;
    }


#ifdef __cplusplus

}
#endif

