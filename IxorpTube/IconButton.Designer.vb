<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IconButton
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.LblText.AutoSize = True
        Me.LblText.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.LblText.ForeColor = System.Drawing.Color.Gray
        Me.LblText.Location = New System.Drawing.Point(13, 49)
        Me.LblText.Name = "lblText"
        Me.LblText.Size = New System.Drawing.Size(40, 17)
        Me.LblText.TabIndex = 1
        Me.LblText.Text = "TextIt"
        '
        'IconButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.LblText)
        Me.Name = "IconButton"
        Me.Size = New System.Drawing.Size(72, 72)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblText As Label
End Class
