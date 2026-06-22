Public Class Form1

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Single
        a = Val(TextBox1.Text)
        Dim b As Single
        b = Val(TextBox2.Text)
        TextBox3.Text = (a + b) / 2
        TextBox4.Text = 2 * (TextBox3.Text) ^ 3 + 3 * TextBox3.Text - 3

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class
