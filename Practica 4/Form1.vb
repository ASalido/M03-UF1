Public Class Form1

    Dim Op1 As Integer = 0
    Dim Op2 As Integer = 0
    Dim res As Integer = 0

    Private Sub SumaBtn_Click(sender As Object, e As EventArgs) Handles SumaBtn.Click

        'CInt sirve para convertir a entero textos.'

        Op1 = CInt(TextBox1.Text)
        Op2 = CInt(TextBox2.Text)

        res = Op1 + Op2

        Label1.Text = res.ToString()
    End Sub
    Private Sub RestarBtn_Click(sender As Object, e As EventArgs) Handles RestarBtn.Click

        Op1 = CInt(TextBox1.Text)
        Op2 = CInt(TextBox2.Text)
        res = Op1 - Op2

        Label1.Text = res.ToString()
    End Sub

    Private Sub SumaBtn_DoubleClick(sender As Object, e As EventArgs) Handles SumaBtn.DoubleClick

        Op1 = CInt(TextBox1.Text)
        Op2 = CInt(TextBox2.Text)

        res = Op1 * Op2

        Label1.Text = res.ToString()
    End Sub

    Private Sub RestarBtn_DoubleClick(sender As Object, e As EventArgs) Handles RestarBtn.DoubleClick

        Op1 = CInt(TextBox1.Text)
        Op2 = CInt(TextBox2.Text)

        res = Op1 / Op2

        Label1.Text = res.ToString()
    End Sub
End Class