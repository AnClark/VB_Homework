Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Private Sub Init()
        Me.Text = "SyB_2"

        With Label1
            .Text = "学习使用 VB.NET"
            .Font = New Font("宋体", 15, FontStyle.Bold)
        End With
        With Label2
            .Text = "请输入你的专业"
            .Font = New Font("宋体", 12)
        End With
        With Label3
            .Text = ""
            .AutoSize = False
            .BorderStyle = BorderStyle.Fixed3D
            .ForeColor = Color.Red
            .Font = New Font("宋体", 12, FontStyle.Bold)
            .Height = 30
            .Width = 130
        End With
        With TextBox1
            .Font = New Font("宋体", 12)
            .Top = Label2.Top
            .Left = Label2.Left + Label2.Width + 50
            .Width = Label2.Width
        End With
        With btnSpecialty
            .Text = "你的专业是"
            .Font = New Font("宋体", 12)
        End With
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnSpecialty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpecialty.Click
        Label3.Text = TextBox1.Text
    End Sub
End Class
