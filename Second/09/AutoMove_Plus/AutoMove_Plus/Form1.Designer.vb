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
        Me.components = New System.ComponentModel.Container()
        Me.btnController = New System.Windows.Forms.Button()
        Me.tmrMover = New System.Windows.Forms.Timer(Me.components)
        Me.picCar = New System.Windows.Forms.PictureBox()
        Me.chkReversePosition = New System.Windows.Forms.CheckBox()
        CType(Me.picCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnController
        '
        Me.btnController.Location = New System.Drawing.Point(475, 490)
        Me.btnController.Name = "btnController"
        Me.btnController.Size = New System.Drawing.Size(293, 47)
        Me.btnController.TabIndex = 0
        Me.btnController.Text = "Button1"
        Me.btnController.UseVisualStyleBackColor = True
        '
        'tmrMover
        '
        Me.tmrMover.Interval = 10
        '
        'picCar
        '
        Me.picCar.Image = Global.WindowsApplication1.My.Resources.Resources._3d936e086e061d95ba62b4857ef40ad163d9cafe
        Me.picCar.Location = New System.Drawing.Point(282, 42)
        Me.picCar.Name = "picCar"
        Me.picCar.Size = New System.Drawing.Size(585, 373)
        Me.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCar.TabIndex = 1
        Me.picCar.TabStop = False
        '
        'chkReversePosition
        '
        Me.chkReversePosition.AutoSize = True
        Me.chkReversePosition.Location = New System.Drawing.Point(150, 505)
        Me.chkReversePosition.Name = "chkReversePosition"
        Me.chkReversePosition.Size = New System.Drawing.Size(59, 19)
        Me.chkReversePosition.TabIndex = 2
        Me.chkReversePosition.Text = "逆向"
        Me.chkReversePosition.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 583)
        Me.Controls.Add(Me.chkReversePosition)
        Me.Controls.Add(Me.picCar)
        Me.Controls.Add(Me.btnController)
        Me.Name = "Form1"
        Me.Text = "SyB_7"
        CType(Me.picCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnController As System.Windows.Forms.Button
    Friend WithEvents tmrMover As System.Windows.Forms.Timer
    Friend WithEvents picCar As System.Windows.Forms.PictureBox
    Friend WithEvents chkReversePosition As System.Windows.Forms.CheckBox

End Class
