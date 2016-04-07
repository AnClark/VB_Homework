Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a%, b%, c%
        a = 15 : b = 8 : c = 7
        MsgBox("The value of 'a>b>c' is:" & (a > b > c))
        MsgBox("The value of 'a>b' And 'b>c' is:" & ((a > b) And (b > c)))
        End
    End Sub
End Class
