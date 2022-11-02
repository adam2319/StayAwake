
Public Class Form1
    Dim number_of_ticks As Integer = 0
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Timer1.Start()
    End Sub

    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(Sender As Object, e As EventArgs) Handles Timer1.Tick
        Threading.Thread.Sleep(500)
        SendKeys.Send("{NUMLOCK}")
        Application.DoEvents()
    End Sub

End Class
