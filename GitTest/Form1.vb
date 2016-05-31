Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Button clicked.")
        Dim i As Integer
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim test As Integer = 42
        MessageBox.Show(test.ToString)
    End Sub
End Class
