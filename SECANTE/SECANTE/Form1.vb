Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Single
        a = Val(TextBox1.Text)
        Dim b As Single
        b = Val(TextBox2.Text)
        TextBox3.Text = (2 * (a ^ 3)) + (3 * a) - 3
        TextBox4.Text = (2 * (b ^ 3)) + (3 * b) - 3
        TextBox5.Text = ((b * TextBox3.Text) - (a * TextBox4.Text)) / (TextBox3.Text - TextBox4.Text)
        TextBox6.Text = (2 * (TextBox5.Text ^ 3)) + (3 * TextBox5.Text) - 3
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
