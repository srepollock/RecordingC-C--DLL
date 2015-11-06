#pragma once
#ifndef HEADER
#define HEADER

/*
	Spencer Pollock
	A00924319
*/

#include <windows.h>
#define INP_BUFFER_SIZE 16384
#define IDC_RECORD_BEG 1001
#define IDC_RECORD_END 1002
#define IDC_PLAY_BEG 1003
#define IDC_PLAY_PAUSE 1004
#define IDC_PLAY_END 1005
#define IDC_PLAY_REV 1006
#define IDC_PLAY_REP 1007
#define IDC_PLAY_SPEED 1008
#define IDC_VOLUME_UP 1009
#define IDC_VOLUME_DOWN 1010
#define IDC_VOLUME_MUTE 1011

#define EXPORT __declspec(dllexport)

struct windHandle {
	HWND hwnd;
};

struct Data {
	//pointer to data
	PBYTE* data;
	//size of data
	int n;
};

static TCHAR szAppName[] = TEXT("HelloWin");
static windHandle wndHwnd;
static Data data;
static DWORD dwDataLength;

LRESULT CALLBACK WndProc(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam);

extern "C" EXPORT int startProg(HINSTANCE hInstance);
extern "C" EXPORT int sendQuit();
extern "C" EXPORT int sendRec();
extern "C" EXPORT int sendStopRec();
extern "C" EXPORT int sendPlay();
extern "C" EXPORT int sendPlayStop();
extern "C" EXPORT int sendPlayPause();
extern "C" EXPORT void getByteData(BYTE *);
extern "C" EXPORT void setByteData(BYTE *);
extern "C" EXPORT int getDataSize();
extern "C" EXPORT int sendVolumeUp();
extern "C" EXPORT int sendVolumeDown();

static PBYTE pBuffer1, pBuffer2, pSaveBuffer, pNewBuffer;

#endif
