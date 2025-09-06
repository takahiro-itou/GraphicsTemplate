//  -*-  coding: utf-8-with-signature;  mode: c++  -*-  //
/*************************************************************************
**                                                                      **
**                  ---   Graphics Test Project.   ---                  **
**                                                                      **
**          Copyright (C), 2025-2025, Takahiro Itou                     **
**          All Rights Reserved.                                        **
**                                                                      **
**          License: (See COPYING or LICENSE files)                     **
**          GNU Affero General Public License (AGPL) version 3,         **
**          or (at your option) any later version.                      **
**                                                                      **
*************************************************************************/

/**
**      An Implementation of FullColorImage class.
**
**      @file       Images/FullColorImage.cpp
**/

#include "StdAfx.h"

#include "FullColorImage.h"

#include <string>

namespace  Sample  {
namespace  Images  {

//========================================================================
//
//    FullColorImage  class.
//

//========================================================================
//
//    Internal Type Definitions.
//

//========================================================================
//
//    Constructor(s) and Destructor.
//

//----------------------------------------------------------------
//    インスタンスを初期化する
//  （デフォルトコンストラクタ）。
//

FullColorImage::FullColorImage()
{
}

//----------------------------------------------------------------
//    インスタンスを破棄する
//  （デストラクタ）。
//

FullColorImage::~FullColorImage()
{
}

//========================================================================
//
//    Public Member Functions (Implement Pure Virtual).
//

//========================================================================
//
//    Public Member Functions (Overrides).
//

//========================================================================
//
//    Public Member Functions (Pure Virtual Functions).
//

//========================================================================
//
//    Public Member Functions (Virtual Functions).
//

//----------------------------------------------------------------
//    イメージを作成する。
//

int
FullColorImage::createImage(
        const  HDC  hDC,
        const  int  nWidth,
        const  int  nHeight)
{
    this->m_iW  = nWidth;
    this->m_iH  = nHeight;
    this->m_iD  = 24;

    this->m_bytesPerLine    = getBytesPerLine(nWidth, 24);
    this->m_bytesPerPixel   = getBytesPerPixel(24);

    this->m_bInfoHeader.biSize          = sizeof(BITMAPINFOHEADER);
    this->m_bInfoHeader.biWidth         = nWidth;
    this->m_bInfoHeader.biHeight        = nHeight;
    this->m_bInfoHeader.biBitCount      = 24;
    this->m_bInfoHeader.biPlanes        = 1;
    this->m_bInfoHeader.biXPelsPerMeter = 0;
    this->m_bInfoHeader.biYPelsPerMeter = 0;
    this->m_bInfoHeader.biClrUsed       = 0;
    this->m_bInfoHeader.biClrImportant  = 0;
    this->m_bInfoHeader.biCompression   = BI_RGB;
    this->m_bInfoHeader.biSizeImage     = this->m_bytesPerLine * nHeight;

    this->m_Info    = (BITMAPINFO *)(this->m_InfoHeader);
    this->m_hBitmap = CreateDIBSection(
                            hDC, this->m_Info, DIB_RGB_COLORS,
                            (&m_lpBits), NULL, 0);

    return ( this->m_hBitmap != 0 );
}

//----------------------------------------------------------------
//    イメージをデバイスに表示する。
//

int
FullColorImage::drawImage(
        const  HDC  hDC,
        const  int  dx,
        const  int  dy,
        const  int  w,
        const  int  h,
        const  int  sx,
        const  int  sy)
{
    return ( 0 );
}

//========================================================================
//
//    Public Member Functions.
//

//========================================================================
//
//    Accessors.
//

//========================================================================
//
//    Protected Member Functions.
//

//========================================================================
//
//    For Internal Use Only.
//

}   //  End of namespace  Common
}   //  End of namespace  Sample


namespace  SampleWrapper  {
namespace  Images  {

namespace  {

}   //  End of (Unnamed) namespace


//========================================================================
//
//    FullColorImage  class.
//

//========================================================================
//
//    Constructor(s) and Destructor.
//

//----------------------------------------------------------------
//    インスタンスを初期化する
//  （デフォルトコンストラクタ）。
//

FullColorImage::FullColorImage()
    : m_ptrObj { new WrapTarget() }
{
}

//----------------------------------------------------------------
//    インスタンスを破棄する
//  （デストラクタ）。
//

FullColorImage::~FullColorImage()
{
    //  マネージドリソースを破棄する。              //

    //  続いて、アンマネージドリソースも破棄する。  //
    this->!FullColorImage();
}

//----------------------------------------------------------------
//    インスタンスを破棄する
//  （ファイナライザ）。
//

FullColorImage::!FullColorImage()
{
    delete  this->m_ptrObj;
    this->m_ptrObj  = nullptr;
}

//========================================================================
//
//    Public Member Functions (Implement Pure Virtual).
//

//========================================================================
//
//    Public Member Functions (Overrides).
//

//========================================================================
//
//    Public Member Functions (Pure Virtual Functions).
//

//========================================================================
//
//    Public Member Functions (Virtual Functions).
//

//----------------------------------------------------------------
//    イメージを作成する。
//

int
FullColorImage::createImage(
        const  HDC  hDC,
        const  int  nWidth,
        const  int  nHeight)
{
    return  this->m_ptrObj->createImage(hDC, nWidth, nHeight);
}

//----------------------------------------------------------------
//    イメージをデバイスに表示する。
//

int
FullColorImage::drawImage(
        const  HDC  hDC,
        const  int  dx,
        const  int  dy,
        const  int  w,
        const  int  h,
        const  int  sx,
        const  int  sy)
{
    return  this->m_ptrObj->drawImage(hDC, dx, dy, w, h, sx, sy);
}

//========================================================================
//
//    Public Member Functions.
//

//========================================================================
//
//    Accessors.
//

//========================================================================
//
//    Protected Member Functions.
//

//========================================================================
//
//    For Internal Use Only.
//

}   //  End of namespace  Common
}   //  End of namespace  SampleWrapper
