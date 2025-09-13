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

using System.ComponentModel;

namespace WinFormsControl
{

public partial class SampleControl : UserControl
{
    public SampleControl()
    {
        InitializeComponent();
    }

    //----------------------------------------------------------------
    /**   画像をクリアする。
    **
    **/
    public virtual void clearGraphics()
    {
        System.Drawing.Bitmap   imgCanvas;
        System.Drawing.Graphics grpCanvas;

        imgCanvas = new System.Drawing.Bitmap(picView.Width, picView.Height);
        grpCanvas = System.Drawing.Graphics.FromImage(imgCanvas);

        grpCanvas.FillRectangle(Brushes.White, grpCanvas.VisibleClipBounds);
        grpCanvas.Dispose();

        picView.Image = imgCanvas;
    }

    //----------------------------------------------------------------
    /**   デフォルトの描画処理を行う。
    **
    **/
    public virtual void drawGraphics()
    {
        System.Drawing.Bitmap   imgCanvas, imgBuffer;
        System.Drawing.Graphics grpCanvas, grpBuffer;
        IntPtr  hDisplayDC, hDC;
        System.Drawing.Brush    brushBG;
        System.Drawing.Color    colorBG;

        hDisplayDC = WinAPI.GetDC(IntPtr.Zero);

        imgBuffer = new System.Drawing.Bitmap(200, 100);
        grpBuffer = System.Drawing.Graphics.FromImage(imgBuffer);

        colorBG = System.Drawing.Color.FromArgb(0xFF, 0xFE, 0xF0, 0xBA);
        brushBG = new System.Drawing.SolidBrush(colorBG);
        grpBuffer.FillRectangle(brushBG, grpBuffer.VisibleClipBounds);

        hDC = grpBuffer.GetHdc();
        if ( m_image == null ) {
            m_image = m_bitmapRenderer.createImage(hDC, 200, 100);
        }
        m_image.drawSample();
        m_bitmapRenderer.drawImage(hDC, 0, 0, 200, 100, 0, 0);
        grpBuffer.ReleaseHdc(hDC);

        grpBuffer.DrawPie(Pens.Red, 60, 10, 80, 80, 30, 300);
        grpBuffer.DrawRectangle(Pens.Yellow, 50, 30, 100, 60);
        grpBuffer.Dispose();

        imgCanvas = new System.Drawing.Bitmap(picView.Width, picView.Height);
        grpCanvas = System.Drawing.Graphics.FromImage(imgCanvas);

        colorBG = System.Drawing.Color.FromArgb(0xFF, 0xFF, 0x00, 0x00);
        brushBG = new System.Drawing.SolidBrush(colorBG);
        grpCanvas.FillRectangle(brushBG, grpCanvas.VisibleClipBounds);

        hDC = grpCanvas.GetHdc();
        WinAPI.BitBlt(hDC, 8, 8, 284, 284, hDisplayDC, 0, 0, WinAPI.SRCCOPY);
        grpCanvas.ReleaseHdc(hDC);

        WinAPI.ReleaseDC(IntPtr.Zero, hDisplayDC);

        colorBG = System.Drawing.Color.FromArgb(0x40, 0x00, 0xFF, 0x00);
        brushBG = new System.Drawing.SolidBrush(colorBG);
        grpCanvas.FillRectangle(brushBG, grpCanvas.VisibleClipBounds);

        grpCanvas.DrawImage(imgBuffer, 50, 100, 200, 100);
        grpCanvas.Dispose();

        picView.Image = imgCanvas;
    }

    //----------------------------------------------------------------
    /**   MarginAreaColor プロパティ
    **
    **/
    [Browsable(true)
      , Description("余白部分の背景色")
      , Category("表示")
    ]
    public System.Drawing.Color MarginAreaColor
    {
        get { return  this.m_marginColor; }
        set { this.m_marginColor = value; }
    }

    //----------------------------------------------------------------
    /**   SourcePicture プロパティ
    **
    **/
    [Browsable(true)
      , Description("描画領域")
      , Category("表示")
    ]
    public System.Windows.Forms.PictureBox SourcePicture
    {
        get { return  this.picView; }
    }

    //----------------------------------------------------------------
    /**   RunButtonClick イベント
    **
    **/
    [Browsable(true)
      , Description("実行ボタンがクリックされた時に発生します")
      , Category("アクション")
    ]
    public event EventHandler<EventArgs>? RunButtonClick;

    //----------------------------------------------------------------
    /**   イベントハンドラを呼び出すメソッド
    **
    **/
    protected virtual void OnRunButtonClick(EventArgs e)
    {
        var eventHandler = RunButtonClick;
        if (eventHandler != null) {
            eventHandler(this, e);
        }
    }

    //----------------------------------------------------------------
    /**   イベントハンドラ
    **
    **    「クリア」ボタンのクリックイベント
    **/
    private void btnClear_Click(object sender, EventArgs e)
    {
        clearGraphics();
    }

    //----------------------------------------------------------------
    /**   イベントハンドラ
    **
    **    「実行」ボタンのクリックイベント
    **/
    private void btnRun_Click(object sender, EventArgs e)
    {
        OnRunButtonClick(e);
    }

    private SampleWrapper.Images.FullColorImage?    m_image;
    private SampleWrapper.Images.BitmapRenderer     m_bitmapRenderer
        = new SampleWrapper.Images.BitmapRenderer();

    private System.Drawing.Color    m_marginColor;

}   //  End of class SampleControl

}   //  End of namespace WinFormsControl
