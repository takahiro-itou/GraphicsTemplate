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

//========================================================================
//
//    Public Member Functions.
//
public:

//========================================================================
//
//    Accessors.
//
public:

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

};

}   //  End of namespace  Common
}   //  End of namespace  SampleWrapper
