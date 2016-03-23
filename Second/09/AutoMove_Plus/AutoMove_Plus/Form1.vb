Public Class Form1

    Private Const _start As String = "启动"
    Private Const _pause As String = "暂停"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnController.Text = _start
    End Sub

    Private Sub btnController_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnController.Click
        Select Case btnController.Text
            Case _start
                btnController.Text = _pause

                tmrMover.Start()

            Case _pause
                btnController.Text = _start

                tmrMover.Stop()
        End Select
    End Sub

    Private Sub tmrMover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMover.Tick
        Select Case chkReversePosition.Checked
            Case True
                picCar.Left -= 2
                If picCar.Left <= -picCar.Width Then
                    picCar.Left = Me.Width
                End If
            Case Else
                picCar.Left += 2
                If picCar.Left >= Me.Width Then
                    picCar.Left = -picCar.Width
                End If
        End Select

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCar.Click

    End Sub
End Class
