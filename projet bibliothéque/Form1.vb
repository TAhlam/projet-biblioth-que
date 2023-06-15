Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.PasswordChar = "*"
        If TextBox1.Text = "123@" And TextBox2.Text = "Admine" Then
            Dim Obj = New Form2
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("wrong Username or Password")
        End If


    End Sub


End Class
