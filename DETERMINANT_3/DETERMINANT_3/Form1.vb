Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Single
        Dim b As Single
        Dim c As Single
        Dim d As Single
        Dim p As Single
        Dim q As Single
        Dim r As Single
        Dim s As Single
        Dim t As Single

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)
        d = Val(TextBox4.Text)
        p = Val(TextBox5.Text)
        q = Val(TextBox6.Text)
        r = Val(TextBox7.Text)
        s = Val(TextBox8.Text)
        t = Val(TextBox9.Text)

        TextBox10.Text = ((a * p * t) + (b * q * r) + (c * d * s)) - ((r * p * c) + (s * q * a) + (t * d * b))
    End Sub
End Class
