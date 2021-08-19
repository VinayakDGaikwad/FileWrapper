Public Class Status
    Dim StopWatch As New Diagnostics.Stopwatch
    Dim WindowExpaned As Boolean = False
    Private Sub Status_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        StopWatch.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ElaspedTime_Label.Text = CInt(StopWatch.Elapsed.TotalHours).ToString + ":" + CInt(StopWatch.Elapsed.TotalMinutes).ToString + ":" + CInt(StopWatch.Elapsed.TotalSeconds).ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SH_Button.Click
        If WindowExpaned = True Then
            SH_Button.Text = "q"
            WindowExpaned = False
            Me.Size = New System.Drawing.Size(531, 149)
        Else
            SH_Button.Text = "p"
            WindowExpaned = True
            Me.Size = New System.Drawing.Size(531, 219)
        End If
    End Sub
End Class