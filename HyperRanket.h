#pragma once
/*
*Basic typedef oragnizing
*/
/*
*minwindef.h
*/
#ifdef _MINWINDEF_
//#define CALLBACK CallStandard
#endif

/*
*The DirectX Utility Library DXUT
*/
#ifdef DXUT_H

typedef CModelViewerCamera    ModelViewerCamera;
typedef CDXUTDialogResourceManager   DialogResourceManager;
typedef CD3DSettingsDlg        SettingsDialog;
#define CreateDirectDevice DXUTCreateDevice
#define InitDirectUtility DXUTInit // Parse the command line, show msgboxes on error, no extra command line params
#define SetDirectCursor DXUTSetCursorSettings
#define CreateDirectWindow DXUTCreateWindow
#define RenderLoopMain  DXUTMainLoop // Enter into the DXUT render loop

#define TraceBack V_RETURN
#define Trace V
#endif

////DXUT Optional SDKMISC_H sdkmisc.h
//typedef CDXUTTextHelper*   TextHelper
//typedef CDXUTDialog        Dialog
//
//  d3dx9.h resources 

/*
*d3dx9.h
*/

#ifdef __D3DX9CORE_H__
typedef ID3DXFont*  FontPointer;
typedef ID3DXSprite* SpritePointer;
typedef ID3DXEffect*  EffectPointer;

#endif

/*
*d3dx9shader.h included d3dx9.h
*/
#ifdef __D3DX9SHADER_H__
typedef D3DXHANDLE    Handle;
#endif
/*
*d3dx9math.h
*/
#ifdef __D3DX9MATH_H__
typedef D3DXVECTOR3 Vector3;
typedef D3DXCOLOR Color;
#endif
