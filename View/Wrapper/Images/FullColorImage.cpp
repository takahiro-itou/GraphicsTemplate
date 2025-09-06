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
    return ( 0 );
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
