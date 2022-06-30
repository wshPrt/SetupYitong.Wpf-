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

typedef void(__stdcall *OnStreamConnect)(int erro);  //���ӳɹ�
typedef void(__stdcall *OnStreamBroken)(int erro); //���ӶϿ�
typedef void(__stdcall *OnP2pTsFaild)(int erro); //P2PTS����ʧ��
typedef void(__stdcall *FileTransmitDone)(char* filename,bool bSend);//bSend = falseʱΪ���գ����յ����¼�ʱ����ʾ�ļ��������,��������stop

#pragma pack()

#pragma warning(pop)

#endif
