Public Class Form1

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        txtResult.Text = Val(txtRoot.Text) ^ 2
    End Sub

    Private Sub btnCheckYourResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckYourResult.Click
        If Val(txtResult.Text) = Val(txtRoot.Text) ^ 2 Then
            MsgBox("结果正确", MsgBoxStyle.Information)
        Else
            MsgBox("结果错误", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class
