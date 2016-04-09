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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUpperResult = New System.Windows.Forms.TextBox()
        Me.range_0_99 = New System.Windows.Forms.Button()
        Me.range_m50_p50 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtGenerate = New System.Windows.Forms.Button()
        Me.txtDownerResult = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUpperResult)
        Me.GroupBox1.Controls.Add(Me.range_0_99)
        Me.GroupBox1.Controls.Add(Me.range_m50_p50)
        Me.GroupBox1.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1159, 240)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "给定范围"
        '
        'txtUpperResult
        '
        Me.txtUpperResult.Font = New System.Drawing.Font("微软雅黑", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtUpperResult.Location = New System.Drawing.Point(360, 143)
        Me.txtUpperResult.Name = "txtUpperResult"
        Me.txtUpperResult.ReadOnly = True
        Me.txtUpperResult.Size = New System.Drawing.Size(378, 56)
        Me.txtUpperResult.TabIndex = 2
        Me.txtUpperResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'range_0_99
        '
        Me.range_0_99.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.range_0_99.Location = New System.Drawing.Point(737, 47)
        Me.range_0_99.Name = "range_0_99"
        Me.range_0_99.Size = New System.Drawing.Size(283, 51)
        Me.range_0_99.TabIndex = 1
        Me.range_0_99.Text = "( 0 , 99.99 )"
        Me.range_0_99.UseVisualStyleBackColor = True
        '
        'range_m50_p50
        '
        Me.range_m50_p50.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.range_m50_p50.Location = New System.Drawing.Point(63, 47)
        Me.range_m50_p50.Name = "range_m50_p50"
        Me.range_m50_p50.Size = New System.Drawing.Size(294, 51)
        Me.range_m50_p50.TabIndex = 0
        Me.range_m50_p50.Text = "( -50 , 50 ]"
        Me.range_m50_p50.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtGenerate)
        Me.GroupBox2.Controls.Add(Me.txtDownerResult)
        Me.GroupBox2.Controls.Add(Me.txtMin)
        Me.GroupBox2.Controls.Add(Me.txtMax)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(45, 321)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1159, 332)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "你自定义的范围"
        '
        'txtGenerate
        '
        Me.txtGenerate.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtGenerate.Location = New System.Drawing.Point(360, 242)
        Me.txtGenerate.Name = "txtGenerate"
        Me.txtGenerate.Size = New System.Drawing.Size(378, 56)
        Me.txtGenerate.TabIndex = 5
        Me.txtGenerate.Text = "单击生成随机数"
        Me.txtGenerate.UseVisualStyleBackColor = True
        '
        'txtDownerResult
        '
        Me.txtDownerResult.Font = New System.Drawing.Font("微软雅黑", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtDownerResult.Location = New System.Drawing.Point(360, 152)
        Me.txtDownerResult.Name = "txtDownerResult"
        Me.txtDownerResult.ReadOnly = True
        Me.txtDownerResult.Size = New System.Drawing.Size(378, 56)
        Me.txtDownerResult.TabIndex = 4
        Me.txtDownerResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMin
        '
        Me.txtMin.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtMin.Location = New System.Drawing.Point(835, 53)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(185, 38)
        Me.txtMin.TabIndex = 3
        '
        'txtMax
        '
        Me.txtMax.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtMax.Location = New System.Drawing.Point(172, 50)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(185, 38)
        Me.txtMax.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(731, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "最小值"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "最大值"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 735)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "SyC_3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUpperResult As System.Windows.Forms.TextBox
    Friend WithEvents range_0_99 As System.Windows.Forms.Button
    Friend WithEvents range_m50_p50 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGenerate As System.Windows.Forms.Button
    Friend WithEvents txtDownerResult As System.Windows.Forms.TextBox
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents txtMax As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
