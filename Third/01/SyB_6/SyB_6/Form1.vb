Public Class SyB_6


    Private Function Deg2Rad(ByVal Deg As Double)
        Return Deg * Math.PI / 180
    End Function


    Private Sub txtDeg_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDeg.TextChanged
        lblRad.Text = Deg2Rad(Val(txtDeg.Text))
    End Sub
End Class
