#ifndef _INTERFACE_DATA_DEF_
#define _INTERFACE_DATA_DEF_
#define __stdcall



typedef enum{
	FAILED_RET =0,
	SUCC_RET = 1,
	FAILED_IP_NULL =2,
	FAILED_LOCALID_NULL,
	FAILED_SENDID_NULL,
	FAILED_RECVFOLDER_NULL,
	FAILED_SENDFILENAME_NULL
}ENUM_RET;

typedef void(__stdcall *OnStreamConnect)(int erro);  //链接成功
typedef void(__stdcall *OnStreamBroken)(int erro); //链接断开
typedef void(__stdcall *OnP2pTsFaild)(int erro); //P2PTS请求失败
typedef void(__stdcall *FileTransmitDone)(char* filename,bool bSend);//bSend = false时为接收，当收到此事件时，表示文件接收完成,不能立即stop

#pragma pack()

#pragma warning(pop)

#endif
