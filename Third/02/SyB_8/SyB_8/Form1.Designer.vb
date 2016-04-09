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
        Me.txtRoot = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnCheckYourResult = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRoot
        '
        Me.txtRoot.Font = New System.Drawing.Font("宋体", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtRoot.Location = New System.Drawing.Point(55, 59)
        Me.txtRoot.Name = "txtRoot"
        Me.txtRoot.Size = New System.Drawing.Size(165, 34)
        Me.txtRoot.TabIndex = 0
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("宋体", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtResult.Location = New System.Drawing.Point(433, 59)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(158, 34)
        Me.txtResult.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "的平方为："
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("宋体", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(55, 139)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(165, 45)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "="
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnCheckYourResult
        '
        Me.btnCheckYourResult.Font = New System.Drawing.Font("宋体", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCheckYourResult.Location = New System.Drawing.Point(433, 139)
        Me.btnCheckYourResult.Name = "btnCheckYourResult"
        Me.btnCheckYourResult.Size = New System.Drawing.Size(158, 46)
        Me.btnCheckYourResult.TabIndex = 3
        Me.btnCheckYourResult.Text = "判断结果"
        Me.btnCheckYourResult.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 293)
        Me.Controls.Add(Me.btnCheckYourResult)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtRoot)
        Me.Name = "Form1"
        Me.Text = "SyB_8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRoot As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnCheckYourResult As System.Windows.Forms.Button

End Class
