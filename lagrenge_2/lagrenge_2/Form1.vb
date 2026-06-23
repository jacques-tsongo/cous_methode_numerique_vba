Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Single
        a = Val(TextBox1.Text)
        Dim b As Single
        b = Val(TextBox2.Text)
        Dim c As Single
        c = Val(TextBox3.Text)

        TextBox4.Text = 1 / ((a - b) * (a * c))
        TextBox5.Text = (b * c) / ((a - b) * (a - c))
        TextBox6.Text = (b * c) / ((a - b) * (a - c))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

    End Sub
End Class
