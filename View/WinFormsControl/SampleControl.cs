
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

    private System.Drawing.Color    m_marginColor;

}   //  End of class SampleControl

}   //  End of namespace WinFormsControl
