Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)

        If a < b And a < c Then GoTo a_menor Else GoTo num_b
a_menor:
        If b < c Then GoTo abc Else GoTo acb
abc:
        TextBox4.Text = a.ToString + "   " + b.ToString + "   " + c.ToString
        GoTo final
acb:
        TextBox4.Text = a.ToString + "   " + c.ToString + "   " + b.ToString
        GoTo final
num_b:
        If b < a And b < c Then GoTo b_menor Else GoTo num_c
b_menor:
        If a < c Then GoTo bac Else GoTo bca
bac:
        TextBox4.Text = b.ToString + "   " + a.ToString + "   " + c.ToString
        GoTo final
bca:
        TextBox4.Text = b.ToString + "   " + c.ToString + "   " + a.ToString
        GoTo final

num_c:
        If a < b Then GoTo cab Else GoTo cba
cab:
        TextBox4.Text = c.ToString + "   " + a.ToString + "   " + b.ToString
        GoTo final
cba:
        TextBox4.Text = c.ToString + "   " + b.ToString + "   " + a.ToString
        GoTo final

final:

    End Sub
End Class
