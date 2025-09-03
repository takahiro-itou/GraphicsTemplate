
namespace ViewCs
{

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void runCount(System.String message)
    {
        int result;
        SampleWrapper.Common.SampleDocument objWrapper = new SampleWrapper.Common.SampleDocument();

        objWrapper.setMessage(message);
        result = objWrapper.countAlphabet();
        System.String outText = "文字列中のアルファベットの個数は " + result;
        SampleControl1.OutputText = outText;
        MessageBox.Show(outText);
    }

    private void SampleControl1_RunButtonClick(object sender, EventArgs e)
    {
        runCount(SampleControl1.InputText);
    }
}

}