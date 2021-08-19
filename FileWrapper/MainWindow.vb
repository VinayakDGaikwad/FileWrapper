Public Class MainWindow

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WrppFile_BT.Click
        'In case already opened
        If WrapFile.Visible = True Then
            Return
        End If

        WrapFile.Show()
        WrapFile.SelectOutFileDialog.Filter = "Wrapped File|*.wppfile"
        WrapFile.SelectFolder_BT.Visible = False
    End Sub

    Private Sub About_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FWAboutBox.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        FWAboutBox.ShowDialog()
    End Sub

    Private Sub WrppFolder_BT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WrppFolder_BT.Click
        'In case already opened
        If WrapFile.Visible = True Then
            Return
        End If

        WrapFile.Show()
        WrapFile.SelectOutFileDialog.Filter = "Wrapped Folder|*.wppfolder"
        WrapFile.SelectFile_BT.Visible = False
    End Sub

    Private Sub Extract_BT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Extract_BT.Click
        ExtractDialog.Show()
    End Sub

    Private Sub WrappedFolderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WrappedFolderToolStripMenuItem.Click
        WrppFolder_BT.PerformClick()
    End Sub

    Private Sub WrappedFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WrappedFileToolStripMenuItem.Click
        WrppFile_BT.PerformClick()
    End Sub
End Class
