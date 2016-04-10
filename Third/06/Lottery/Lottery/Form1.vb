Public Class Form1

    Dim Prefix As String

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        If String.IsNullOrEmpty(txtPrefix.Text) Then
            MsgBox("输入不合法或未输入，请重试！", vbExclamation)
            txtPrefix.Focus()
            Exit Sub
        End If

        Prefix = Trim(txtPrefix.Text)
        tmrLottery.Start()

    End Sub

    Private Sub tmrLottery_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLottery.Tick
        Dim Suffix As String, Suffix_num As Integer
        Suffix_num = Int(Rnd() * 9999) + 1
        Suffix = String.Format("{0:0000}", Suffix_num)

        txtPhoneNumbers.Text = Prefix + "****" + Suffix
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        tmrLottery.Stop()
        MsgBox("恭喜！中奖号为：" & txtPhoneNumbers.Text, vbInformation)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
