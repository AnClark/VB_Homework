Public Class Form1

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        On Error GoTo ErrProcess

        Dim l_Split As Integer, r_Split As Integer
        l_Split = Val(txtLeftSplitPoint.Text) : r_Split = Val(txtRightSplitPoint.Text)

        If (Not IsBetween(0, Len(txtOriginalString.Text), l_Split) Or (Not IsBetween(0, Len(txtOriginalString.Text), r_Split))) Then
            MsgBox("输入值非法", vbExclamation)
            txtLeftSplitPoint.Focus()
            Exit Sub
        End If

        'If Not (l_Split <= r_split) Then
        '    MsgBox("左右截取字符串弄反，现在交换", vbExclamation)

        '    Swap(l_Split, r_split)

        '    txtLeftSplitPoint.Text = l_Split : txtRightSplitPoint.Text = r_split

        'End If

        '左边部分字符串
        txtLPart.Text = Microsoft.VisualBasic.Left(txtOriginalString.Text, l_Split)
        '右边部分字符串
        txtRPart.Text = Microsoft.VisualBasic.Right(txtOriginalString.Text, r_Split)
        '中间部分字符串
        txtMPart.Text = Mid(txtOriginalString.Text, l_Split + 1, Len(txtOriginalString.Text) - r_Split - l_Split)

        Exit Sub
ErrProcess:
        MsgBox("出现错误：" + vbCrLf + Err.Description, vbExclamation)
    End Sub


    Private Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim buff As Integer
        buff = a
        a = b
        b = buff
    End Sub

    Private Function IsBetween(ByVal l_bound As Integer, ByVal r_bound As Integer, ByVal NumForTest As Integer) As Boolean
        If (l_bound <= NumForTest) And (NumForTest <= r_bound) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
