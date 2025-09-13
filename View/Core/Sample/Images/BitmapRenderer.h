﻿//  -*-  coding: utf-8-with-signature;  mode: c++  -*-  //
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
**      An Interface of BitmapRenderer class.
**
**      @file       Images/BitmapRenderer.h
**/

#pragma once

#if !defined( SAMPLE_IMAGES_INCLUDED_BITMAP_RENDERER_H )
#    define   SAMPLE_IMAGES_INCLUDED_BITMAP_RENDERER_H

#include    "Sample/Common/SampleSettings.h"

#if !defined( SAMPLE_SYS_INCLUDED_WINDOWS_H )
#    include    <windows.h>
#    define   SAMPLE_SYS_INCLUDED_WINDOWS_H
#endif


SAMPLE_NAMESPACE_BEGIN
namespace  Images  {

//========================================================================
//
//    BitmapRenderer  class.
//

class  BitmapRenderer
{

//========================================================================
//
//    Internal Type Definitions.
//

//========================================================================
//
//    Constructor(s) and Destructor.
//
public:

    //----------------------------------------------------------------
    /**   インスタンスを初期化する
    **  （デフォルトコンストラクタ）。
    **
    **/
    BitmapRenderer();

    //----------------------------------------------------------------
    /**   インスタンスを破棄する
    **  （デストラクタ）。
    **
    **/
    virtual  ~BitmapRenderer();

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
public:

    //----------------------------------------------------------------
    /**   イメージを作成する。
    **
    **/
    virtual  int
    createImage(
            const  HDC  hDC,
            const  int  nWidth,
            const  int  nHeight);

    //----------------------------------------------------------------
    /**   イメージをデバイスに表示する。
    **
    **/
    virtual  int
    drawImage(
            const  HDC  hDC,
            const  int  dx,
            const  int  dy,
            const  int  w,
            const  int  h,
            const  int  sx,
            const  int  sy);

//========================================================================
//
//    Public Member Functions.
//

//========================================================================
//
//    Accessors.
//
public:

    //----------------------------------------------------------------
    /**
    **
    **/
    void  *
    getImage()
    {
        return ( this->m_lpBits );
    }

//========================================================================
//
//    Protected Member Functions.
//

//========================================================================
//
//    For Internal Use Only.
//
private:

    //----------------------------------------------------------------
    /**
    **
    **/
    inline  static  unsigned
    computeBytesPerLine(
            const  int  nWidth,
            const  int  nDepth)
    {
        return  static_cast<unsigned>(
            (((long)nWidth * nDepth + 31) / 32) * 4
        );
    }

    //----------------------------------------------------------------
    /**
    **
    **/
    inline  static  unsigned
    computeBytesPerPixel(
            const  int  nDepth)
    {
        return  static_cast<unsigned>((nDepth + 7) / 8);
    }

//========================================================================
//
//    Member Variables.
//
private:

    int                 m_iW;
    int                 m_iH;
    int                 m_iD;

    unsigned            m_bytesPerLine;
    unsigned            m_bytesPerPixel;

    void *              m_lpBits;
    BITMAPINFO *        m_Info;
    BITMAPINFOHEADER    m_bInfoHeader;
    HBITMAP             m_hBitmap;

//========================================================================
//
//    Other Features.
//
private:
    typedef     BitmapRenderer      This;
    BitmapRenderer      (const  This  &);
    This &  operator =  (const  This  &);
public:
    //  テストクラス。  //
    friend  class   BitmapRendererTest;
};

}   //  End of namespace  Images
SAMPLE_NAMESPACE_END

#endif
