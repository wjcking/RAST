//--------------------------------------------------------------------------------------
// File: SimpleSample.cpp
//
// Copyright (c) Microsoft Corporation. All rights reserved.
//--------------------------------------------------------------------------------------
#include "DXUT.h"
#include "DXUTgui.h"
#include "DXUTmisc.h"
#include "DXUTCamera.h"
#include "DXUTSettingsDlg.h"
#include "SDKmisc.h"
#include "SDKmesh.h"
#include "resource.h"

#include "HyperRanket.h"
//#define DEBUG_VS   // Uncomment this line to debug D3D9 vertex shaders 
//#define DEBUG_PS   // Uncomment this line to debug D3D9 pixel shaders 


//--------------------------------------------------------------------------------------
// Global variables
//--------------------------------------------------------------------------------------
ModelViewerCamera          Camera;               // A model viewing camera
DialogResourceManager  resourceManager; // manager for shared resources of dialogs
SettingsDialog             settingDialog;          // Device settings dialog
TextHelper            textHelper = nullptr;
DirectUtilityDialog                 HUD;                  // dialog for standard controls
DirectUtilityDialog                AUI;             // dialog for sample specific controls

// Direct3D 9 resources
FontPointer     Font =  nullptr;
SpritePointer   Sprite = nullptr;
EffectPointer   Effect = nullptr;

Handle WorldProjection;
Handle World;
Handle TimeHandler;

//--------------------------------------------------------------------------------------
// UI control IDs
//--------------------------------------------------------------------------------------
#define IDC_TOGGLEFULLSCREEN    1
#define IDC_TOGGLEREF           2
#define IDC_CHANGEDEVICE        3


//--------------------------------------------------------------------------------------
// Forward declarations 
//--------------------------------------------------------------------------------------
LRESULT callback MsgProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam, bool* pbNoFurtherProcessing,
	void* pUserContext);
void callback OnKeyboard(UINT nChar, bool bKeyDown, bool bAltDown, void* pUserContext);
void callback OnGUIEvent(UINT nEvent, int nControlID, CDXUTControl* pControl, void* pUserContext);
void callback OnFrameMove(double fTime, float fElapsedTime, void* pUserContext);
bool callback ModifyDeviceSettings(DXUTDeviceSettings* pDeviceSettings, void* pUserContext);

bool callback IsD3D9DeviceAcceptable(D3DCAPS9* pCaps, D3DFORMAT AdapterFormat, D3DFORMAT BackBufferFormat,
	bool bWindowed, void* pUserContext);
HRESULT callback OnD3D9CreateDevice(IDirect3DDevice9* pd3dDevice, const D3DSURFACE_DESC* pBackBufferSurfaceDesc,
	void* pUserContext);
HRESULT callback OnD3D9ResetDevice(IDirect3DDevice9* pd3dDevice, const D3DSURFACE_DESC* pBackBufferSurfaceDesc,
	void* pUserContext);
void callback OnD3D9FrameRender(IDirect3DDevice9* pd3dDevice, double fTime, float fElapsedTime, void* pUserContext);
void callback OnD3D9LostDevice(void* pUserContext);
void callback OnD3D9DestroyDevice(void* pUserContext);

void Initialize();
void RenderText();


//--------------------------------------------------------------------------------------
// Entry point to the program. Initializes everything and goes into a message processing 
// loop. Idle time is used to render the scene.
//--------------------------------------------------------------------------------------
int WINAPI wWinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPWSTR lpCmdLine, int nCmdShow)
{
	// Enable run-time memory check for debug builds.
#if defined(DEBUG) | defined(_DEBUG)
	_CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
#endif

	// DXUT will create and use the best device (either D3D9 or D3D10) 
	// that is available on the system depending on which D3D callbacks are set below

	// Set DXUT callbacks
	DXUTSetCallbackMsgProc(MsgProc);
	DXUTSetCallbackKeyboard(OnKeyboard);
	DXUTSetCallbackFrameMove(OnFrameMove);
	DXUTSetCallbackDeviceChanging(ModifyDeviceSettings);

	DXUTSetCallbackD3D9DeviceAcceptable(IsD3D9DeviceAcceptable);
	DXUTSetCallbackD3D9DeviceCreated(OnD3D9CreateDevice);
	DXUTSetCallbackD3D9DeviceReset(OnD3D9ResetDevice);
	DXUTSetCallbackD3D9DeviceLost(OnD3D9LostDevice);
	DXUTSetCallbackD3D9DeviceDestroyed(OnD3D9DestroyDevice);
	DXUTSetCallbackD3D9FrameRender(OnD3D9FrameRender);

	Initialize();
	InitDirectUtility(true, true, NULL); // Parse the command line, show msgboxes on error, no extra command line params
	SetDirectCursor(true, true);
	CreateDirectWindow(L"整理过的函数定义");
	CreateDirectDevice(true, 1280, 780);
	RenderLoopMain(); // Enter into the DXUT render loop	//	DXUTMainLoop();  

	return DXUTGetExitCode();
}


//--------------------------------------------------------------------------------------
// Initialize the app 
//--------------------------------------------------------------------------------------
void Initialize()
{
	settingDialog.Init(&resourceManager);
	HUD.Init(&resourceManager);
	AUI.Init(&resourceManager);

	HUD.SetCallback(OnGUIEvent); int iY = 10;
	HUD.AddButton(IDC_TOGGLEFULLSCREEN, L"Toggle full screen", 35, iY, 125, 22);
	HUD.AddButton(IDC_TOGGLEREF, L"Toggle REF (F3)", 35, iY += 24, 125, 22, VK_F3);
	HUD.AddButton(IDC_CHANGEDEVICE, L"Change device (F2)", 35, iY += 24, 125, 22, VK_F2);

	AUI.SetCallback(OnGUIEvent); iY = 10;
}


//--------------------------------------------------------------------------------------
// Render the help and statistics text. This function uses the ID3DXFont interface for 
// efficient text rendering.
//--------------------------------------------------------------------------------------
void RenderText()
{
	textHelper->Begin();
	textHelper->SetInsertionPos(5, 5);
	textHelper->SetForegroundColor(Color(1.0f, 1.0f, 0.0f, 1.0f));
	textHelper->DrawTextLine(DXUTGetFrameStats(DXUTIsVsyncEnabled()));
	textHelper->DrawTextLine(DXUTGetDeviceStats());
	textHelper->End();
}


//--------------------------------------------------------------------------------------
// Rejects any D3D9 devices that aren't acceptable to the app by returning false
//--------------------------------------------------------------------------------------
bool callback IsD3D9DeviceAcceptable(D3DCAPS9* pCaps, D3DFORMAT AdapterFormat,
	D3DFORMAT BackBufferFormat, bool bWindowed, void* pUserContext)
{
	// Skip backbuffer formats that don't support alpha blending
	IDirect3D9* pD3D = DXUTGetD3D9Object();
	if (FAILED(pD3D->CheckDeviceFormat(pCaps->AdapterOrdinal, pCaps->DeviceType,
		AdapterFormat, D3DUSAGE_QUERY_POSTPIXELSHADER_BLENDING,
		D3DRTYPE_TEXTURE, BackBufferFormat)))
		return false;

	// No fallback defined by this app, so reject any device that 
	// doesn't support at least ps2.0
	if (pCaps->PixelShaderVersion < D3DPS_VERSION(2, 0))
		return false;

	return true;
}


//--------------------------------------------------------------------------------------
// Called right before creating a D3D9 or D3D10 device, allowing the app to modify the device settings as needed
//--------------------------------------------------------------------------------------
bool callback ModifyDeviceSettings(DXUTDeviceSettings* pDeviceSettings, void* pUserContext)
{
	if (pDeviceSettings->ver == DXUT_D3D9_DEVICE)
	{
		IDirect3D9* pD3D = DXUTGetD3D9Object();
		D3DCAPS9 Caps;
		pD3D->GetDeviceCaps(pDeviceSettings->d3d9.AdapterOrdinal, pDeviceSettings->d3d9.DeviceType, &Caps);

		// If device doesn't support HW T&L or doesn't support 1.1 vertex shaders in HW 
		// then switch to SWVP.
		if ((Caps.DevCaps & D3DDEVCAPS_HWTRANSFORMANDLIGHT) == 0 ||
			Caps.VertexShaderVersion < D3DVS_VERSION(1, 1))
		{
			pDeviceSettings->d3d9.BehaviorFlags = D3DCREATE_SOFTWARE_VERTEXPROCESSING;
		}

		// Debugging vertex shaders requires either REF or software vertex processing 
		// and debugging pixel shaders requires REF.  
#ifdef DEBUG_VS
		if (pDeviceSettings->d3d9.DeviceType != D3DDEVTYPE_REF)
		{
			pDeviceSettings->d3d9.BehaviorFlags &= ~D3DCREATE_HARDWARE_VERTEXPROCESSING;
			pDeviceSettings->d3d9.BehaviorFlags &= ~D3DCREATE_PUREDEVICE;
			pDeviceSettings->d3d9.BehaviorFlags |= D3DCREATE_SOFTWARE_VERTEXPROCESSING;
		}
#endif
#ifdef DEBUG_PS
		pDeviceSettings->d3d9.DeviceType = D3DDEVTYPE_REF;
#endif
	}

	// For the first device created if its a REF device, optionally display a warning dialog box
	static bool firstTime = true;
	if (firstTime)
	{
		firstTime = false;
		if ((DXUT_D3D9_DEVICE == pDeviceSettings->ver && pDeviceSettings->d3d9.DeviceType == D3DDEVTYPE_REF) ||
			(DXUT_D3D10_DEVICE == pDeviceSettings->ver &&
				pDeviceSettings->d3d10.DriverType == D3D10_DRIVER_TYPE_REFERENCE))
			DXUTDisplaySwitchingToREFWarning(pDeviceSettings->ver);
	}

	return true;
}


//--------------------------------------------------------------------------------------
// Create any D3D9 resources that will live through a device reset (D3DPOOL_MANAGED)
// and aren't tied to the back buffer size
//--------------------------------------------------------------------------------------
HRESULT callback OnD3D9CreateDevice(IDirect3DDevice9* pd3dDevice, const D3DSURFACE_DESC* pBackBufferSurfaceDesc,
	void* pUserContext)
{
	HRESULT hr;

	TraceBack(resourceManager.OnD3D9CreateDevice(pd3dDevice));
	TraceBack(settingDialog.OnD3D9CreateDevice(pd3dDevice));

	TraceBack(D3DXCreateFont(pd3dDevice, 15, 0, FW_BOLD, 1, FALSE, DEFAULT_CHARSET,
		OUT_DEFAULT_PRECIS, DEFAULT_QUALITY, DEFAULT_PITCH | FF_DONTCARE,
		L"Arial", &Font));

	// Read the D3DX effect file
	WCHAR str[MAX_PATH];
	DWORD dwShaderFlags = D3DXFX_NOT_CLONEABLE;

#ifdef DEBUG_VS
	dwShaderFlags |= D3DXSHADER_FORCE_VS_SOFTWARE_NOOPT;
#endif
#ifdef DEBUG_PS
	dwShaderFlags |= D3DXSHADER_FORCE_PS_SOFTWARE_NOOPT;
#endif
#ifdef D3DXFX_LARGEADDRESS_HANDLE
	dwShaderFlags |= D3DXFX_LARGEADDRESSAWARE;
#endif

	TraceBack(DXUTFindDXSDKMediaFileCch(str, MAX_PATH, L"SimpleSample.fx"));
	TraceBack(D3DXCreateEffectFromFile(pd3dDevice, str, NULL, NULL, dwShaderFlags,
		NULL, &Effect, NULL));

	WorldProjection = Effect->GetParameterByName(NULL, "g_mWorldViewProjection");
	World = Effect->GetParameterByName(NULL, "g_mWorld");
	TimeHandler = Effect->GetParameterByName(NULL, "g_fTime");

	// Setup the camera's view parameters
	Vector3 vecEye(0.0f, 0.0f, -5.0f);
	Vector3 vecAt(0.0f, 0.0f, -0.0f);
	Camera.SetViewParams(&vecEye, &vecAt);

	return S_OK;
}


//--------------------------------------------------------------------------------------
// Create any D3D9 resources that won't live through a device reset (D3DPOOL_DEFAULT) 
// or that are tied to the back buffer size 
//--------------------------------------------------------------------------------------
HRESULT callback OnD3D9ResetDevice(IDirect3DDevice9* pd3dDevice,
	const D3DSURFACE_DESC* pBackBufferSurfaceDesc, void* pUserContext)
{
	HRESULT hr;

	TraceBack(resourceManager.OnD3D9ResetDevice());
	TraceBack(settingDialog.OnD3D9ResetDevice());

	if (Font)
		TraceBack(Font->OnResetDevice());

	if (Effect)
		TraceBack(Effect->OnResetDevice());

	TraceBack(D3DXCreateSprite(pd3dDevice, &Sprite));
	textHelper = new CDXUTTextHelper(Font, Sprite, NULL, NULL, 15);

	// Setup the camera's projection parameters
	float fAspectRatio = pBackBufferSurfaceDesc->Width / (FLOAT)pBackBufferSurfaceDesc->Height;
	Camera.SetProjParams(D3DX_PI / 4, fAspectRatio, 0.1f, 1000.0f);
	Camera.SetWindow(pBackBufferSurfaceDesc->Width, pBackBufferSurfaceDesc->Height);

	HUD.SetLocation(pBackBufferSurfaceDesc->Width - 170, 0);
	HUD.SetSize(170, 170);
	AUI.SetLocation(pBackBufferSurfaceDesc->Width - 170, pBackBufferSurfaceDesc->Height - 350);
	AUI.SetSize(170, 300);

	return S_OK;
}


//--------------------------------------------------------------------------------------
// Handle updates to the scene.  This is called regardless of which D3D API is used
//--------------------------------------------------------------------------------------
void callback OnFrameMove(double fTime, float fElapsedTime, void* pUserContext)
{
	// Update the camera's position based on user input 
	Camera.FrameMove(fElapsedTime);
}


//--------------------------------------------------------------------------------------
// Render the scene using the D3D9 device
//--------------------------------------------------------------------------------------
void callback OnD3D9FrameRender(IDirect3DDevice9* device, double fTime, float fElapsedTime, void* userContext)
{
	HRESULT hr;
	D3DXMATRIXA16 mWorld;
	D3DXMATRIXA16 mView;
	D3DXMATRIXA16 mProj;
	D3DXMATRIXA16 mWorldViewProjection;

	// If the settings dialog is being shown, then render it instead of rendering the app's scene
	if (settingDialog.IsActive())
	{
		settingDialog.OnRender(fElapsedTime);
		return;
	}

	// Clear the render target and the zbuffer 
	Trace(device->Clear(0, NULL, D3DCLEAR_TARGET | D3DCLEAR_ZBUFFER, D3DCOLOR_ARGB(0, 145, 210, 120), 1.0f, 0));

	// Render the scene
	if (SUCCEEDED(device->BeginScene()))
	{
		// Get the projection & view matrix from the camera class
		mWorld = *Camera.GetWorldMatrix();
		mProj = *Camera.GetProjMatrix();
		mView = *Camera.GetViewMatrix();

		mWorldViewProjection = mWorld * mView * mProj;

		// Update the effect's variables.  Instead of using strings, it would 
		// be more efficient to cache a handle to the parameter by calling 
		// ID3DXEffect::GetParameterByName
		Trace(Effect->SetMatrix(WorldProjection, &mWorldViewProjection));
		Trace(Effect->SetMatrix(World, &mWorld));
		Trace(Effect->SetFloat(TimeHandler, (float)fTime));

		DXUT_BeginPerfEvent(DXUT_PERFEVENTCOLOR, L"HUD / Stats"); // These events are to help PIX identify what the code is doing
		RenderText();
		Trace(HUD.OnRender(fElapsedTime));
		Trace(AUI.OnRender(fElapsedTime));
		DXUT_EndPerfEvent();

		Trace(device->EndScene());
	}
}


//--------------------------------------------------------------------------------------
// Handle messages to the application
//--------------------------------------------------------------------------------------
LRESULT callback MsgProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam, bool* noFurtherProcessing,
	void* pUserContext)
{
	// Pass messages to dialog resource manager calls so GUI state is updated correctly
	*noFurtherProcessing = resourceManager.MsgProc(hWnd, uMsg, wParam, lParam);
	if (*noFurtherProcessing)
		return 0;

	// Pass messages to settings dialog if its active
	if (settingDialog.IsActive())
	{
		settingDialog.MsgProc(hWnd, uMsg, wParam, lParam);
		return 0;
	}

	// Give the dialogs a chance to handle the message first
	*noFurtherProcessing = HUD.MsgProc(hWnd, uMsg, wParam, lParam);
	if (*noFurtherProcessing)
		return 0;
	*noFurtherProcessing = AUI.MsgProc(hWnd, uMsg, wParam, lParam);
	if (*noFurtherProcessing)
		return 0;

	// Pass all remaining windows messages to camera so it can respond to user input
	Camera.HandleMessages(hWnd, uMsg, wParam, lParam);

	return 0;
}


//--------------------------------------------------------------------------------------
// Handle key presses
//--------------------------------------------------------------------------------------
void callback OnKeyboard(UINT nChar, bool bKeyDown, bool bAltDown, void* pUserContext)
{
}


//--------------------------------------------------------------------------------------
// Handles the GUI events
//--------------------------------------------------------------------------------------
void callback OnGUIEvent(UINT nEvent, int nControlID, CDXUTControl* pControl, void* pUserContext)
{
	switch (nControlID)
	{
	case IDC_TOGGLEFULLSCREEN:
		DXUTToggleFullScreen(); break;
	case IDC_TOGGLEREF:
		DXUTToggleREF(); break;
	case IDC_CHANGEDEVICE:
		settingDialog.SetActive(!settingDialog.IsActive()); break;
	}
}


//--------------------------------------------------------------------------------------
// Release D3D9 resources created in the OnD3D9ResetDevice callback 
//--------------------------------------------------------------------------------------
void callback OnD3D9LostDevice(void* pUserContext)
{
	resourceManager.OnD3D9LostDevice();
	settingDialog.OnD3D9LostDevice();
	if (Font)
		Font->OnLostDevice();
	if (Effect)
		Effect->OnLostDevice();
	ReleaseObject(Sprite);
	DeleteObject(textHelper);
}


//--------------------------------------------------------------------------------------
// Release D3D9 resources created in the OnD3D9CreateDevice callback 
//--------------------------------------------------------------------------------------
void callback OnD3D9DestroyDevice(void* pUserContext)
{
	resourceManager.OnD3D9DestroyDevice();
	settingDialog.OnD3D9DestroyDevice();
	ReleaseObject(Effect);
	ReleaseObject(Font);
}


