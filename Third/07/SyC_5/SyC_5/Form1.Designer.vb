<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOriginalString = New System.Windows.Forms.TextBox()
        Me.txtLeftSplitPoint = New System.Windows.Forms.TextBox()
        Me.txtRightSplitPoint = New System.Windows.Forms.TextBox()
        Me.txtLPart = New System.Windows.Forms.TextBox()
        Me.txtMPart = New System.Windows.Forms.TextBox()
        Me.txtRPart = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "原始字符串"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "从左边开始截取的字符串"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(290, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "从右边开始截取的字符串"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "左边部分字符串"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "中间部分字符串"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(88, 429)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 32)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "右边部分字符串"
        '
        'txtOriginalString
        '
        Me.txtOriginalString.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtOriginalString.Location = New System.Drawing.Point(418, 54)
        Me.txtOriginalString.Name = "txtOriginalString"
        Me.txtOriginalString.Size = New System.Drawing.Size(626, 40)
        Me.txtOriginalString.TabIndex = 6
        '
        'txtLeftSplitPoint
        '
        Me.txtLeftSplitPoint.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtLeftSplitPoint.Location = New System.Drawing.Point(418, 131)
        Me.txtLeftSplitPoint.Name = "txtLeftSplitPoint"
        Me.txtLeftSplitPoint.Size = New System.Drawing.Size(626, 40)
        Me.txtLeftSplitPoint.TabIndex = 7
        '
        'txtRightSplitPoint
        '
        Me.txtRightSplitPoint.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtRightSplitPoint.Location = New System.Drawing.Point(418, 202)
        Me.txtRightSplitPoint.Name = "txtRightSplitPoint"
        Me.txtRightSplitPoint.Size = New System.Drawing.Size(626, 40)
        Me.txtRightSplitPoint.TabIndex = 8
        '
        'txtLPart
        '
        Me.txtLPart.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtLPart.Location = New System.Drawing.Point(418, 273)
        Me.txtLPart.Name = "txtLPart"
        Me.txtLPart.Size = New System.Drawing.Size(626, 40)
        Me.txtLPart.TabIndex = 9
        '
        'txtMPart
        '
        Me.txtMPart.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtMPart.Location = New System.Drawing.Point(418, 350)
        Me.txtMPart.Name = "txtMPart"
        Me.txtMPart.Size = New System.Drawing.Size(626, 40)
        Me.txtMPart.TabIndex = 10
        '
        'txtRPart
        '
        Me.txtRPart.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtRPart.Location = New System.Drawing.Point(418, 429)
        Me.txtRPart.Name = "txtRPart"
        Me.txtRPart.Size = New System.Drawing.Size(626, 40)
        Me.txtRPart.TabIndex = 11
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnGo.Location = New System.Drawing.Point(351, 546)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(360, 63)
        Me.btnGo.TabIndex = 12
        Me.btnGo.Text = "单     击"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 646)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtRPart)
        Me.Controls.Add(Me.txtMPart)
        Me.Controls.Add(Me.txtLPart)
        Me.Controls.Add(Me.txtRightSplitPoint)
        Me.Controls.Add(Me.txtLeftSplitPoint)
        Me.Controls.Add(Me.txtOriginalString)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "SyC_5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtOriginalString As System.Windows.Forms.TextBox
    Friend WithEvents txtLeftSplitPoint As System.Windows.Forms.TextBox
    Friend WithEvents txtRightSplitPoint As System.Windows.Forms.TextBox
    Friend WithEvents txtLPart As System.Windows.Forms.TextBox
    Friend WithEvents txtMPart As System.Windows.Forms.TextBox
    Friend WithEvents txtRPart As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button

End Class
