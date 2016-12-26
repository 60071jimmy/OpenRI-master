﻿/*
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

#ifndef __RI_HTTPD_H__
#define __RI_HTTPD_H__

#include "openri.h"

//#include <mysql.h>
//#include <mysql/mysql.h>


typedef int (*RiHttpdCallback_t)(void *sessionPtr);

#ifdef __cplusplus
extern "C"
{
#endif


typedef enum {
	RI_HTTPD_SESSION_STOP = 0,
	RI_HTTPD_SESSION_READY = 1,
	RI_HTTPD_SESSION_BUSY = 2
} RI_HTTPD_SESSION_t;

/**
 * 測試用功能，舊版的LocalServer用的。目前未使用
 */
typedef struct {
	ri_utf8 name[8192];
	ri_utf8 value[8192];
} RiHttpdGetParameter_t;

/**
 * 測試用功能，舊版的LocalServer用的。目前未使用
 */
typedef struct {
	ri_utf8 name[8192];
	ri_utf8 fileName[8192];
	ri_utf8 type[32];
	void *data;
	int dataLength;
} RiHttpdPostParameter_t;

/**
 * 測試用功能，舊版的LocalServer用的。目前未使用
 */
typedef struct {
	int sn;
	int status;
	int isSsl;

	void *sock;
	void *sem;
	void *thread;
	void *httpd;

	// Request header.
	int requestIsHeaderParsed;
	void *requestHeaderBuffer; // RiBuffer_t

	int requestMethod; // GET, POST, PUT, TRACE...
	//ri_utf8  requestMethod[8]; // GET, POST, PUT, TRACE...
	ri_utf8 requestUrl[8192]; // length of request url
	ri_utf8 requestHttpVersion[8]; // 1.0, 1.1
	ri_utf8 requestHost[256];
	int requestConnection; // Keep-Alive =1, close = 0.
	ri_utf8 requestUserAgent[256];
	ri_utf8 requestAcceptCharset[256]; // ISO-8859-1,UTF-8;q=0.7,*;q=0.7
	ri_utf8 requestCacheControl[128]; // no-cache
	ri_utf8 requestAcceptLanguage[256]; // de,en;q=0.7,en-us;q=0.3
	ri_utf8 requestReferer[256];
	ri_utf8 requestContentType[32]; // plain/text, application/json...
	int requestContentLength;
	void *requestGetParameters; // RiArray_t

	// Request content.
	int requestIsContentParsed;
	void *requestContentBuffer; // RiBuffer_t
	void *requestPostParameters; // RiArray_t


	// Response header.
	int responseIsHeaderSent;
	void *responseHeaderBuffer; // RiBuffer_t
	ri_utf8 responseHttpVersion[8]; // 1.0, 1.1
	int responseStatus; // 200
	ri_utf8 responseServer[32]; // RiHttpd
	int responseConnection; // KeepAlive =1, close = 0.
	ri_utf8 responseTransferEncoding; // chunked.
	ri_utf8 responseContentType[32];

	// Response content.
	void *responseContentBuffer; // RiBuffer_t

	// Custom session data
	void *data0;
	void *data1;
	void *data2;
	void *data3;
	void *data4;
	void *data5;
	void *data6;
	void *data7;
	void *data8;
	void *data9;

	//	// MySQL connection
	//	MYSQL *mysql;
	
} RiHttpdSession_t;

/**
 * 測試用功能，舊版的LocalServer用的。目前未使用
 */
typedef struct {
	int status;

	int toStop;

	int port;
	int portSsl;

	int backlog;
	ri_utf8 address[20];

	void *listenThread; // RiThread_t
	void *listenThreadSsl; // RiThread_t

	void *listenSock; // RiSocket_t
	void *listenSockSsl; // RiSocket_t

	void *sessions; // RiHttpdSession_t
	int sessionsLength;
	void *sessionsReady; // RiFifo_t
	void *sessionsLock; // RiLock_t

	void *callbacks; // RiArray_t
	void *callbackUrls; // RiArray_t


	// Custom server data
	void *data0;
	void *data1;
	void *data2;
	void *data3;
	void *data4;
	void *data5;
	void *data6;
	void *data7;
	void *data8;
	void *data9;
	
} RiHttpd_t;

/**
 * @brief 初始化此Library
 *
 * @return 成功回傳1，否則回傳錯誤碼
 */
RI_API int riHttpd_InitLib();

//20150116 add by leo
/**
 * 影片暫存檔存在SD卡的路徑
 */
extern const char *saveTo;
/**
 * 影片檔所在Server的IP(MinistationAir2的IP)
 */
extern const char *serverIP;
/**
 * 續傳功能使用。記錄各chunk的下載狀態
 */
extern char *chunksArray;
/**
 * 目標影片檔案有幾MB
 */
extern int howManyMb;
/**
 * 影片檔是新的，還是上次沒下載完的。1= 新檔案 0=有暫存檔
 */
extern int isNewFile; //1= 新檔案 0=有暫存檔
/**
 * 影片檔案有幾byte
 */
extern ri_int64 tarFileSize; //135824942  7880399 78324274 78643200
/**
 * 正在下載目標影片檔的第幾個chunk
 */
extern int downloadWhere;
/**
 * 避免同一檔案同時被讀寫產生error，在讀寫影片檔時使用的鎖
 */
extern RiLock_t *chunkLock;
/**
 * 影片檔所在server的port(MinistationAir2的port)
 */
extern int port; //這個port是遠端server的port
/**
 * 影片檔案在server上的路徑
 */
extern const char* address;




/**
 * LocalServer運作狀態，0=未啟動 1=啟動中 2=運行中 3=結束中
 */
extern int runningStatus;//0=未啟動 1=啟動中 2=運行中 3=結束中
/**
 * 影片暫存檔是否已設置完成(分配空間並以FILE指標開啟，處於可以讀寫的狀態)。
 */
extern int fileSetOK;//0115增加....file建立完成才能開始上傳
/**
 * LocalServer的Socket
 */
extern RiSocket_t *localSocket;

/**
 * LocalServerd開在哪個port
 */
extern int localServerPort;

/**
 * @brief 建立LocalServer
 * @param myLocalServerPort
 *       要把LocalServer的Port開在哪邊
 * @return 成功回傳1
 */
int initLocalServer(int myLocalServerPort);

/**
 * @brief 開始讓LocalServer下載影片檔。
 * @param isFileChange
 *         影片url是否有更換，更換=1，沒變=0。若此值為1，這邊會先把上次的影片暫存檔刪除再開始進行下載動作
 * @param myip
 *         影片檔案所在server的IP
 * @param myport
 *         影片檔案所在server的port
 * @param myaddress
 *         影片檔案在server上的路徑
 * @param mysaveTo
 *         暫存影片檔的本機路徑
 * @param fileSpace
 *         SD卡剩餘空間，單位為byte
 * @return 成功回傳1，否則回傳錯誤碼
 */
int runLocalServer(int isFileChange, const char* myip, int myport,
		const char* myaddress, const char* mysaveTo, long long fileSpace);

//short getChunk(int, RiSocket_t *, FILE *);
/**
 * @brief 讓LocalServer停止下載動作。
 *
 * @return 成功回傳1，否則回傳錯誤碼
 */
int stopLocalServer();
/**
 * @brief 回傳LocalServer的Port開在哪裡
 * @return LocalServer開啟的Port
 */
int getlocalServerPort();

/**
 * 測試用功能。切換LocalServer模式。0=中斷模式，1=連續運行模式。
 */
extern int initTest;
/**
 * 是否正在下載影片檔。1=正在下載 0=沒在下載
 */
extern int isFileDownloading;
/**
 * @brief 關閉LocalServer
 *
 * @return 成功回傳1，否則回傳錯誤碼
 */
int freeLocalServer();

int initLocalServer2(int myLocalServerPort);

//0306 add
int startSevro();

int startSensor();

//0313 test
int getjpg(char * jpg);

//0316 add
char * getjpg2(int & ss);
//0318 add
int clientSocket(char* tarIp,int port,char* msg,int size);


/* sensor data */
extern int fd_mpu6050;
extern int fd_ms5611;
extern int fd_hmc5883;
//extern XYZ_AXIS accel_xyz, gyro_xyz, mag_xyz;
//extern ACCELVAL ACCEL;
//extern GYROVAL GYRO;
//extern QUAD QUADCOPTER;
extern double magZ;
extern float tempc, press_now;
extern float baroH;

extern char* img_send_ip;

#ifdef __cplusplus
}
#endif

#endif /* __RI_HTTPD_H__ */
