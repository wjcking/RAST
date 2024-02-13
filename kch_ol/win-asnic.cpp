#include "StdAfx.h"
#include <windows.h>
#include<stdlib.h>
#include <iostream>   
#include<string.h>
using namespace std; 
/*
1 HANDLE是任意对象的句柄，
2 HINSTANCE是应用程序实例句柄，MSDN里面对于HINSTANCE的解释是"handle to an instance" 就是说是一个instance的句柄
3 HWND是窗口对象句柄，
	对于HWND的解释是“Handle to a window.”而对window的解释是"In a graphical 
	Windows-based application, a window is a rectangular area of the screen where 
	the application displays output and receives input from the user. Therefore, 
	one of the first tasks of a graphical Windows-based application is to create a 
	window. " 就是说是屏幕上的一块区域。

CWnd是MFC中的窗口类。
	CWnd是MFC的一个类了，它有窗体，几乎所有有图形显示的类都是从它派生的，它自己是从
	CCmdTarget类派生的，所以它可以接受消息。CCmdTarget类的爸爸可就是CObject了。
	msdn对于Handle的解释是"Handle to an object." ,简直是废话。自己怎么解释自己呢。
	 
ID--HANDLE--HWND三者之间的互相转换
	id->句柄-----------hWnd = ::GetDlgItem(hParentWnd,id);
	id->指针-----------CWnd::GetDlgItem();
	句柄->id-----------id = GetWindowLong(hWnd,GWL_ID);
	句柄->指针--------CWnd *pWnd=CWnd::FromHandle(hWnd);
	指针->ID----------id = GetWindowLong(pWnd->GetSafeHwnd,GWL_ID);
	GetDlgCtrlID();
	指针->句柄--------hWnd=cWnd.GetSafeHandle() or mywnd->m_hWnd;
 


应用程序的一些HANDLE 
	// 得到窗口句柄
	HWND parenthwnd = ::FindWindowEx(NULL, parenthwnd, "#32770", NULL);
	// 得到此窗口的主线程ID
	DWORD dwThreadId = ::GetWindowThreadProcessId(parenthwnd, 0);
	// 得到当前进程的句柄
	HANDLE hApp = GetModuleHandle(NULL);
*/
//对话框
//int WINAPI WinMain(
//    HINSTANCE hInstance,
//    HINSTANCE hPrevInstance,
//    LPSTR lpCmdLine,
//    int nCmdShow
//)
//{
//    // 调用API 函数MessageBox
//    int nSelect = MessageBox(NULL, TEXT("你好，欢迎来到C语言中文网！"), TEXT("Welcome"), MB_OKCANCEL);
//    if(nSelect == IDOK){
//        MessageBox(NULL, TEXT("你点击了“确定”按钮"), TEXT("提示"), MB_OK);
//    }else{
//        MessageBox(NULL, TEXT("你点击了“取消”按钮"), TEXT("提示"), MB_OK);
//    }
//    return 0;
//}

 
LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);
int WINAPI WinMain(  HINSTANCE hInstance,  HINSTANCE hPrevInstance, PSTR szCmdLine,   int iCmdShow
){
    static TCHAR szClassName[] = TEXT("HelloWin");  //窗口类名
    HWND     hwnd;  //窗口句柄
    MSG      msg ;  //消息
    WNDCLASS wndclass;  //窗口类
    /**********第①步：注册窗口类**********/
    //为窗口类的各个字段赋值
    wndclass.style = CS_HREDRAW | CS_VREDRAW;  //窗口风格
    wndclass.lpfnWndProc  = WndProc;  //窗口过程
    wndclass.cbClsExtra   = 0;  //暂时不需要理解
    wndclass.cbWndExtra   = 0;  //暂时不需要理解
    wndclass.hInstance    = hInstance;  //当前窗口句柄
    wndclass.hIcon        = LoadIcon (NULL, IDI_APPLICATION);  //窗口图标
    wndclass.hCursor      = LoadCursor (NULL, IDC_ARROW);  //鼠标样式
    wndclass.hbrBackground= (HBRUSH) GetStockObject (WHITE_BRUSH);  //窗口背景画刷
    wndclass.lpszMenuName = NULL ;  //窗口菜单
    wndclass.lpszClassName= szClassName;  //窗口类名
    //注册窗口
    RegisterClass(&wndclass);
    /*****第②步：创建窗口(并让窗口显示出来)*****/
    hwnd = CreateWindow(
        szClassName,  //窗口类的名字
        TEXT("Welcome"),  //窗口标题（出现在标题栏）
        WS_OVERLAPPEDWINDOW,  //窗口风格
        CW_USEDEFAULT,  //初始化时x轴的位置
        CW_USEDEFAULT,  //初始化时y轴的位置
        500,  //窗口宽度
        300,  //窗口高度
        NULL,  //父窗口句柄
        NULL,  //窗口菜单句柄
        hInstance,  //当前窗口的句柄
        NULL  //不使用该值
    );
    //显示窗口
    ShowWindow (hwnd, iCmdShow);
    //更新（绘制）窗口
    UpdateWindow (hwnd);
    /**********第③步：消息循环**********/
    while( GetMessage(&msg, NULL, 0, 0) ){
        TranslateMessage(&msg);  //翻译消息
        DispatchMessage (&msg);  //分派消息
    }
	//msg.wParam=0;
    return msg.wParam;
}

/**********第④步：窗口过程**********/
LRESULT CALLBACK WndProc(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam){
    HDC         hdc;  //设备环境句柄
    PAINTSTRUCT ps;
    RECT        rect;

	//if ( message != 0 )
	//{
	//	if( message == WM_PAINT) 
	//	{
	//		unsigned int m = message;
	//		wchar_t chr[255];
	//		_itow_s( m, chr, 10, 10);
	//		hdc = BeginPaint (hwnd, &ps) ;
	//		GetClientRect (hwnd, &rect) ;
	//		DrawText(  hdc,  chr, -1, &rect,  DT_SINGLELINE | DT_CENTER | DT_VCENTER );
	//		
	//	}//更新（绘制）窗口
	//		UpdateWindow (hwnd);
	//}

    switch (message){
        //窗口绘制消息
        case WM_PAINT:
            hdc = BeginPaint (hwnd, &ps) ;
            GetClientRect (hwnd, &rect) ;
     //       DrawText(  hdc,  TEXT("Hellow Device. Draw"), -1, &rect,  DT_SINGLELINE | DT_CENTER | DT_VCENTER );
			int i,r,g,b;
				i=1,r=1;g=1;b=1;
	/*	 do  
		 {*/
			SetPixel(hdc, i,1, RGB(r,g,b));
			SetPixel(hdc, i,2, RGB(r,g,b));
			SetPixel(hdc, i,3, RGB(r,g,b));
			SetPixel(hdc, i,4, RGB(r,g,b));

			SetPixel(hdc, i,5, RGB(r,g,b));
			SetPixel(hdc, i,6, RGB(r,g,b));
			SetPixel(hdc, i,7, RGB(r,g,b));
			SetPixel(hdc, i,8, RGB(r,g,b));

			SetPixel(hdc, 20,1, RGB(100,100,100));
			SetPixel(hdc, 20,2, RGB(100,100,100));
			SetPixel(hdc, 20,3, RGB(100,100,100));
			SetPixel(hdc, 20,4, RGB(100,100,100));
			SetPixel(hdc, 20,5, RGB(100,100,100));
			SetPixel(hdc, 20,6, RGB(100,100,100));
			SetPixel(hdc, 20,7, RGB(100,100,100));
			SetPixel(hdc, 20,8, RGB(100,100,100));

			SetPixel(hdc, 30,1, RGB(80,90,11));
			SetPixel(hdc, 30,2, RGB(80,90,11));
			SetPixel(hdc, 30,3, RGB(80,90,11));
			SetPixel(hdc, 30,4, RGB(80,90,11));
			SetPixel(hdc, 30,5, RGB(80,90,11));
			SetPixel(hdc, 30,6, RGB(80,90,11));
			SetPixel(hdc, 30,7, RGB(80,90,11));
			SetPixel(hdc, 30,8, RGB(80,90,11));
									 
			SetPixel(hdc, 40,1, RGB(10,22,33));
			SetPixel(hdc, 40,2, RGB(10,22,33));
			SetPixel(hdc, 40,3, RGB(10,22,33));
			SetPixel(hdc, 40,4, RGB(10,22,33));
			SetPixel(hdc, 40,5, RGB(10,22,33));
			SetPixel(hdc, 40,6, RGB(10,22,33));
			SetPixel(hdc, 40,7, RGB(10,22,33));
			SetPixel(hdc, 40,8, RGB(10,22,33));

			//SetPixel(hdc, 11,10, RGB(5,5,50));
			//SetPixel(hdc, 10,11, RGB(255,0,0));
			//SetPixel(hdc, 11,11, RGB(5,50,50));

		//	wstring wst;
			 
			r++;g++;b++;
			i++;
		 //}
		 //while(i<rect.right);
   //         EndPaint (hwnd, &ps);
            return 0 ;
        //窗口销毁消息
        case WM_DESTROY:
            PostQuitMessage(0) ;
            return 0 ;
    }
    return DefWindowProc(hwnd, message, wParam, lParam) ;
}