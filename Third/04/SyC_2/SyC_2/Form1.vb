Public Class Form1

    Private Sub txtCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCalc.Click
        Dim x As Integer, y As Integer
        x = Val(txtX.Text) : y = Val(txtY.Text)

        '第一个公式
        rsl_sinX.Text = Math.Sin(x) + Math.Cos(y)
        '第二个公式
        rsl_sqrt.Text = ((x ^ 2 + y ^ 2) / Math.Abs(y)) ^ (1 / 3)
        '第三个公式
        rsl_larger.Text = (x + y) > (x ^ 2 - 10 * x)
    End Sub
End Class
