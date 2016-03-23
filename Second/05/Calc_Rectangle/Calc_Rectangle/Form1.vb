Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim a, b, square As Single
        a = Val(txtWidth.Text)
        b = Val(txtHeight.Text)
        square = a * b
        lblSquare.Text = square
    End Sub
End Class
