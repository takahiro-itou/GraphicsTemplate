Public Class MainView

Private Sub showGraphics()
''--------------------------------------------------------------------
''    画像を表示する
''--------------------------------------------------------------------
    SampleControl1.drawGraphics()
End Sub

Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles _
            mnuFileExit.Click
''--------------------------------------------------------------------
''    メニュー「ファイル」－「終了」
''--------------------------------------------------------------------
    Application.Exit()
End Sub

Private Sub mnuRunCount_Click(sender As Object, e As EventArgs) Handles _
            mnuRunCount.Click
''--------------------------------------------------------------------
''    メニュー「実行」－「カウント」
''--------------------------------------------------------------------
    System.Threading.Thread.Sleep(100)
    showGraphics()
End Sub

Private Sub SampleControl1_RunButtonClick(sender As Object, e As EventArgs) _
    Handles SampleControl1.RunButtonClick
''--------------------------------------------------------------------
''    イベントハンドラ
''
''    ユーザーコントロールの「実行ボタンクリック」
''--------------------------------------------------------------------
    System.Threading.Thread.Sleep(100)
    showGraphics()
End Sub

End Class
