Public NotInheritable Class FWAboutBox

    Private Sub FWAboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)

    End Sub

    Private Sub OkButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click
        Me.Close()
    End Sub
End Class
