Public Class Form1

    Private Sub range_m50_p50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles range_m50_p50.Click
        'Randomize()

        Dim RndNum As Integer

        RndNum = IIf(Rnd() > 0.5, -1 * Int(Rnd() * 50), Int(Rnd() * 50))
        txtUpperResult.Text = RndNum
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub range_0_99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles range_0_99.Click
        Dim RndNum As Single

        RndNum = (Int(Rnd() * 9999 + 1)) / 100
        txtUpperResult.Text = RndNum
    End Sub

    Private Sub txtMax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMax.TextChanged

    End Sub

    Private Sub txtGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGenerate.Click
        Dim l_Bound As Integer, r_Bound As Integer, RndNum As Integer
        l_Bound = Val(txtMin.Text) : r_Bound = Val(txtMax.Text)
        If Not (l_Bound <= r_Bound) Then
            MsgBox("最大值与最小值输反。现在纠正过来。", vbExclamation)

            Dim buff As Integer
            buff = l_Bound
            l_Bound = r_Bound
            r_Bound = buff

            txtMin.Text = l_Bound
            txtMax.Text = r_Bound
        End If


        Do While True
            RndNum = Int(Rnd() * r_Bound) + 1
            If RndNum > l_Bound Then Exit Do
        Loop

        txtDownerResult.Text = RndNum
    End Sub
End Class
