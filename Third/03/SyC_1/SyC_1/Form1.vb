Public Class Form1
    Const a As Boolean = True
    Const b As Boolean = False


    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        '计算 a And b
        rsl_a_and_b.Text = a And b
        rsl_a_and_not_b.Text = a And Not b
        rsl_a_lgr_b_or_b.Text = a > b Or b
    End Sub
End Class
