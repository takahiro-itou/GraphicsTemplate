<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = _
            New System.ComponentModel.ComponentResourceManager(GetType(MainView))

        mnuMain = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuFileExit = New ToolStripMenuItem()
        mnuRun = New ToolStripMenuItem()
        mnuRunCount = New ToolStripMenuItem()

        OpenFileDialog1 = New OpenFileDialog()
        SampleControl1 = New WinFormsControl.SampleControl()
        mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        ' mnuMain
        '
        resources.ApplyResources(mnuMain, "mnuMain")
        mnuMain.Items.AddRange(New ToolStripItem() {mnuFile, mnuRun})
        mnuMain.Name = "mnuMain"
        '
        ' mnuFile
        '
        resources.ApplyResources(mnuFile, "mnuFile")
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuFileExit})
        mnuFile.Name = "mnuFilem"
        '
        ' mnuFileExit
        '
        resources.ApplyResources(mnuFileExit, "mnuFileExit")
        mnuFileExit.Name = "mnuFileExit"
        '
        ' mnuRun
        '
        resources.ApplyResources(mnuRun, "mnuRun")
        mnuRun.DropDownItems.AddRange(New ToolStripItem() {mnuRunCount})
        mnuRun.Name = "mnuRun"
        '
        ' mnuRunCount
        '
        resources.ApplyResources(mnuRunCount, "mnuRunCount")
        mnuRunCount.Name = "mnuRunCount"

        '
        ' OpenFileDialog1
        '
        OpenFileDialog1.FileName = "OpenFileDialog1"
        resources.ApplyResources(OpenFileDialog1, "OpenFileDialog1")

        '
        ' SampleControl1
        '
        resources.ApplyResources(SampleControl1, "SampleControl1")
        SampleControl1.Name = "SampleControl1"

        '
        ' MainView
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = AutoScaleMode.None
        Me.Controls.Add(SampleControl1)
        Me.Controls.Add(mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "MainView"
        mnuMain.ResumeLayout(False)
        mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SampleControl1 As WinFormsControl.SampleControl
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuRun As ToolStripMenuItem
    Friend WithEvents mnuRunCount As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog

End Class
