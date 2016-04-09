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
        Me.txtCalc = New System.Windows.Forms.Button()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.rsl_sinX = New System.Windows.Forms.TextBox()
        Me.rsl_sqrt = New System.Windows.Forms.TextBox()
        Me.rsl_larger = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(457, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Y="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "sinX + cosY"
        '
        'txtCalc
        '
        Me.txtCalc.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtCalc.Location = New System.Drawing.Point(263, 517)
        Me.txtCalc.Name = "txtCalc"
        Me.txtCalc.Size = New System.Drawing.Size(230, 58)
        Me.txtCalc.TabIndex = 5
        Me.txtCalc.Text = "计算"
        Me.txtCalc.UseVisualStyleBackColor = True
        '
        'txtX
        '
        Me.txtX.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtX.Location = New System.Drawing.Point(167, 55)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(100, 40)
        Me.txtX.TabIndex = 6
        '
        'txtY
        '
        Me.txtY.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtY.Location = New System.Drawing.Point(548, 55)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(100, 40)
        Me.txtY.TabIndex = 7
        '
        'rsl_sinX
        '
        Me.rsl_sinX.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rsl_sinX.Location = New System.Drawing.Point(315, 174)
        Me.rsl_sinX.Name = "rsl_sinX"
        Me.rsl_sinX.ReadOnly = True
        Me.rsl_sinX.Size = New System.Drawing.Size(370, 40)
        Me.rsl_sinX.TabIndex = 8
        '
        'rsl_sqrt
        '
        Me.rsl_sqrt.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rsl_sqrt.Location = New System.Drawing.Point(315, 305)
        Me.rsl_sqrt.Name = "rsl_sqrt"
        Me.rsl_sqrt.ReadOnly = True
        Me.rsl_sqrt.Size = New System.Drawing.Size(370, 40)
        Me.rsl_sqrt.TabIndex = 9
        '
        'rsl_larger
        '
        Me.rsl_larger.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rsl_larger.Location = New System.Drawing.Point(315, 424)
        Me.rsl_larger.Name = "rsl_larger"
        Me.rsl_larger.ReadOnly = True
        Me.rsl_larger.Size = New System.Drawing.Size(370, 40)
        Me.rsl_larger.TabIndex = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.xyplus1
        Me.PictureBox2.InitialImage = Global.WindowsApplication1.My.Resources.Resources.xyplus1
        Me.PictureBox2.Location = New System.Drawing.Point(76, 398)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(179, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.xysquare
        Me.PictureBox1.InitialImage = Global.WindowsApplication1.My.Resources.Resources.xysquare
        Me.PictureBox1.Location = New System.Drawing.Point(76, 278)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 605)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rsl_larger)
        Me.Controls.Add(Me.rsl_sqrt)
        Me.Controls.Add(Me.rsl_sinX)
        Me.Controls.Add(Me.txtY)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.txtCalc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "SyC_2"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCalc As System.Windows.Forms.Button
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents txtY As System.Windows.Forms.TextBox
    Friend WithEvents rsl_sinX As System.Windows.Forms.TextBox
    Friend WithEvents rsl_sqrt As System.Windows.Forms.TextBox
    Friend WithEvents rsl_larger As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
