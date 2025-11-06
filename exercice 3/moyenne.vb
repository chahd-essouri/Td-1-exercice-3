Public Class moyenne
    Private Sub btnenvoyer_click(sender As Object, e As EventArgs) Handles btnenvoyer.Click
        Dim moyenne As Double
        moyenne = txt.Text
        If moyenne >= 10 And moyenne <= 20 Then
            MessageBox.Show("Admis")
        End If

        If (moyenne >= 8 And moyenne < 10) Then
            MessageBox.Show("rattrapage")
        End If

        If (moyenne < 8) Then
            MessageBox.Show("ajourne")
        End If
    End Sub

End Class
