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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.rsl_a_and_b = New System.Windows.Forms.Label()
        Me.rsl_a_and_not_b = New System.Windows.Forms.Label()
        Me.rsl_a_lgr_b_or_b = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "a And b"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "a And Not b"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "a > b Or b"
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(222, 269)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(171, 44)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "计算"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'rsl_a_and_b
        '
        Me.rsl_a_and_b.BackColor = System.Drawing.Color.White
        Me.rsl_a_and_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rsl_a_and_b.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rsl_a_and_b.Location = New System.Drawing.Point(222, 35)
        Me.rsl_a_and_b.Name = "rsl_a_and_b"
        Me.rsl_a_and_b.Size = New System.Drawing.Size(320, 33)
        Me.rsl_a_and_b.TabIndex = 4
        Me.rsl_a_and_b.Text = "  "
        '
        'rsl_a_and_not_b
        '
        Me.rsl_a_and_not_b.BackColor = System.Drawing.Color.White
        Me.rsl_a_and_not_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rsl_a_and_not_b.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rsl_a_and_not_b.Location = New System.Drawing.Point(222, 114)
        Me.rsl_a_and_not_b.Name = "rsl_a_and_not_b"
        Me.rsl_a_and_not_b.Size = New System.Drawing.Size(320, 33)
        Me.rsl_a_and_not_b.TabIndex = 5
        Me.rsl_a_and_not_b.Text = "  "
        '
        'rsl_a_lgr_b_or_b
        '
        Me.rsl_a_lgr_b_or_b.BackColor = System.Drawing.Color.White
        Me.rsl_a_lgr_b_or_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rsl_a_lgr_b_or_b.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rsl_a_lgr_b_or_b.Location = New System.Drawing.Point(222, 188)
        Me.rsl_a_lgr_b_or_b.Name = "rsl_a_lgr_b_or_b"
        Me.rsl_a_lgr_b_or_b.Size = New System.Drawing.Size(320, 33)
        Me.rsl_a_lgr_b_or_b.TabIndex = 6
        Me.rsl_a_lgr_b_or_b.Text = "  "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 358)
        Me.Controls.Add(Me.rsl_a_lgr_b_or_b)
        Me.Controls.Add(Me.rsl_a_and_not_b)
        Me.Controls.Add(Me.rsl_a_and_b)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "SyC_1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents rsl_a_and_b As System.Windows.Forms.Label
    Friend WithEvents rsl_a_and_not_b As System.Windows.Forms.Label
    Friend WithEvents rsl_a_lgr_b_or_b As System.Windows.Forms.Label

End Class
