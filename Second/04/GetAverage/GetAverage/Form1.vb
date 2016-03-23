Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GetAverage()
        Dim sglNum1, sglNum2, sglNum3, sglNumAver As Single
        sglNum1 = Val(txtNum1.Text)
        sglNum2 = Val(txtNum2.Text)
        sglNum3 = Val(txtNum3.Text)
        sglNumAver = (sglNum1 + sglNum2 + sglNum3) / 3
        txtAver.Text = sglNumAver
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        GetAverage()

    End Sub
End Class
