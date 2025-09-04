namespace ViewCs
{

partial class MainView
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources =
            new System.ComponentModel.ComponentResourceManager(typeof(MainView));

        this.SampleControl1 = new WinFormsControl.SampleControl();
        this.DataGridView1 = new System.Windows.Forms.DataGridView();

        ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
        this.SuspendLayout();

        //
        // SampleControl1
        //
        resources.ApplyResources(SampleControl1, "SampleControl1");
        this.SampleControl1.Name = "SampleControl1";
        this.SampleControl1.RunButtonClick += this.SampleControl1_RunButtonClick;
        //
        // DataGridView1
        //
        this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        resources.ApplyResources(this.DataGridView1, "DataGridView1");
        this.DataGridView1.Name = "DataGridView1";
        this.DataGridView1.RowTemplate.Height = 25;

        //
        // MainView
        //
        this.AutoScaleMode = AutoScaleMode.None;
        resources.ApplyResources(this, "$this");
        this.Controls.Add(this.SampleControl1);
        this.Controls.Add(this.DataGridView1);
        this.Name = "MainView";

        ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    internal WinFormsControl.SampleControl SampleControl1;
    internal DataGridView DataGridView1;
}

}
