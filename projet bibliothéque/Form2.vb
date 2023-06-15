Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "123" And TextBox1.Text = "123" Then
            Dim obj = New Form3
            obj.Show()
            Me.Hide()
        Else
            MsgBox("try again")


        End If
    End Sub
End Class