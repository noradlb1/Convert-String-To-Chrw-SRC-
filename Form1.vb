Public Class Form1
    '###################
    'Coded By MONSTERMC
    '###################

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Plz Enter Valid Text", MsgBoxStyle.Critical, "Error")
        Else
            TextBox2.Text = AscW(TextBox1.Text)
        End If
    End Sub
End Class
