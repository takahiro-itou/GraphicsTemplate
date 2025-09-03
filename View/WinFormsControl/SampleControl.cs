
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
