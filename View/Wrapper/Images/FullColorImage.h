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
**      An Interface of FullColorImage class.
**
**      @file       Images/FullColorImage.h
**/

#pragma once

namespace  Sample  {
namespace  Images  {

//========================================================================
//
//    FullColorImage  class.
//

class  FullColorImage
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
    FullColorImage();

    //----------------------------------------------------------------
    /**   インスタンスを破棄する
    **  （デストラクタ）。
    **
    **/
    virtual  ~FullColorImage();

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

    //----------------------------------------------------------------
    /**   サンプル画像を描画する。
    **
    **/
    virtual  void
    drawSample();

//========================================================================
//
//    Public Member Functions.
//
public:

    //----------------------------------------------------------------
    /**
    **
    **/
    void
    fillRectanble(
            const  int  x1,
            const  int  y1,
            const  int  x2,
            const  int  y2,
            const  int  color);

//========================================================================
//
//    Accessors.
//
public:

    const  void  *  getBits()  const { return ( this->m_lpBits ); }
    void  * getBits() { return ( this->m_lpBits ); }

    const  unsigned
    getOffset(const int x, const int y) const
    {
        return ( (this->m_iH - y - 1) * this->m_bytesPerLine
                 + (x * this->m_bytesPerPixel)
        );
    }

    const  void  *  getBits(const int x, const int y) const
    {
        return ( static_cast<const char *>(getBits())
                 + getOffset(x, y)
        );
    }

    void  *  getBits(const int x, const int y)
    {
        return ( static_cast<char *>(getBits())
                 + getOffset(x, y)
        );
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

    inline  static  unsigned
    getBytesPerLine(
            const  int  nWidth,
            const  int  nDepth)
    {
        return  static_cast<unsigned>(
            (((long)nWidth * nDepth + 31) / 32) * 4
        );
    }

    inline  static  unsigned
    getBytesPerPixel(
            const  int  nDepth)
    {
        return  static_cast<unsigned>((nDepth + 7) / 8);
    }

//========================================================================
//
//    Member Variables.
//
private:

    int         m_iW;
    int         m_iH;
    int         m_iD;

    unsigned            m_bytesPerLine;
    unsigned            m_bytesPerPixel;

    void *              m_lpBits;
    BITMAPINFO *        m_Info;
    BITMAPINFOHEADER    m_bInfoHeader;
    HBITMAP             m_hBitmap;
};

}   //  End of namespace  Common
}   //  End of namespace  Sample

using namespace System;

namespace  SampleWrapper  {
namespace  Images  {

//========================================================================
//
//    FullColorImage  class.
//

public ref  class  FullColorImage
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
    FullColorImage();

    //----------------------------------------------------------------
    /**   インスタンスを破棄する
    **  （デストラクタ）。
    **
    **/
    virtual  ~FullColorImage();

    //----------------------------------------------------------------
    /**   インスタンスを破棄する
    **  （ファイナライザ）。
    **
    **/
    !FullColorImage();

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

    //----------------------------------------------------------------
    /**   サンプル画像を描画する。
    **
    **/
    virtual  void
    drawSample();

//========================================================================
//
//    Public Member Functions.
//
public:

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

//========================================================================
//
//    Member Variables.
//
private:

    typedef     Sample::Images::FullColorImage  WrapTarget;

    WrapTarget  *   m_ptrObj;
};

}   //  End of namespace  Common
}   //  End of namespace  SampleWrapper
