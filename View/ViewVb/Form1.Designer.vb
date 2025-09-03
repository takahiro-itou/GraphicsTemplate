<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))

        Me.DataGridView1 = New DataGridView()
        Me.mnuMain = New MenuStrip()
        Me.mnuFile = New ToolStripMenuItem()
        Me.mnuFileExit = New ToolStripMenuItem()
        Me.mnuRun = New ToolStripMenuItem()
        Me.mnuRunCount = New ToolStripMenuItem()

        Me.OpenFileDialog1 = New OpenFileDialog()
        Me.SampleControl1 = New WinFormsControl.SampleControl()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        ' mnuMain
        '
        resources.ApplyResources(Me.mnuMain, "mnuMain")
        Me.mnuMain.Items.AddRange(New ToolStripItem() {mnuFile, mnuRun})
        Me.mnuMain.Name = "mnuMain"
        '
        ' mnuFile
        '
        resources.ApplyResources(Me.mnuFile, "mnuFile")
        Me.mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuFileExit})
        Me.mnuFile.Name = "mnuFilem"
        '
        ' mnuFileExit
        '
        resources.ApplyResources(Me.mnuFileExit, "mnuFileExit")
        Me.mnuFileExit.Name = "mnuFileExit"
        '
        ' mnuRun
        '
        resources.ApplyResources(Me.mnuRun, "mnuRun")
        Me.mnuRun.DropDownItems.AddRange(New ToolStripItem() {mnuRunCount})
        Me.mnuRun.Name = "mnuRun"
        '
        ' mnuRunCount
        '
        resources.ApplyResources(Me.mnuRunCount, "mnuRunCount")
        Me.mnuRunCount.Name = "mnuRunCount"

        '
        ' OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        resources.ApplyResources(Me.OpenFileDialog1, "OpenFileDialog1")

        '
        ' SampleControl1
        '
        resources.ApplyResources(SampleControl1, "SampleControl1")
        SampleControl1.InputText = ""
        SampleControl1.Name = "SampleControl1"
        SampleControl1.OutputText = ""
        '
        ' DataGridView1
        '
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25

        '
        ' Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = AutoScaleMode.None
        Me.Controls.Add(Me.SampleControl1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SampleControl1 As WinFormsControl.SampleControl
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuRun As ToolStripMenuItem
    Friend WithEvents mnuRunCount As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog

End Class
