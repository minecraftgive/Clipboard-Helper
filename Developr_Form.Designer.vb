<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Developer_Form
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
        Me.key_d = New System.Windows.Forms.Label()
        Me.key_d_l = New System.Windows.Forms.TextBox()
        Me.s_url_d = New System.Windows.Forms.Label()
        Me.pw_d = New System.Windows.Forms.Label()
        Me.un_d = New System.Windows.Forms.Label()
        Me.S_url_d_l = New System.Windows.Forms.TextBox()
        Me.pw_d_l = New System.Windows.Forms.TextBox()
        Me.un_d_l = New System.Windows.Forms.TextBox()
        Me.ConfigPath_Label = New System.Windows.Forms.Label()
        Me.OverWrite_To_Defalut_Config = New System.Windows.Forms.Button()
        Me.Open_With_Notepad = New System.Windows.Forms.Button()
        Me.Show_Me_CB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'key_d
        '
        Me.key_d.AutoSize = True
        Me.key_d.Location = New System.Drawing.Point(47, 166)
        Me.key_d.Name = "key_d"
        Me.key_d.Size = New System.Drawing.Size(23, 12)
        Me.key_d.TabIndex = 31
        Me.key_d.Text = "key"
        '
        'key_d_l
        '
        Me.key_d_l.Location = New System.Drawing.Point(86, 159)
        Me.key_d_l.Name = "key_d_l"
        Me.key_d_l.Size = New System.Drawing.Size(368, 21)
        Me.key_d_l.TabIndex = 30
        '
        's_url_d
        '
        Me.s_url_d.AutoSize = True
        Me.s_url_d.Location = New System.Drawing.Point(5, 123)
        Me.s_url_d.Name = "s_url_d"
        Me.s_url_d.Size = New System.Drawing.Size(35, 12)
        Me.s_url_d.TabIndex = 29
        Me.s_url_d.Text = "s_url"
        '
        'pw_d
        '
        Me.pw_d.AutoSize = True
        Me.pw_d.Location = New System.Drawing.Point(12, 71)
        Me.pw_d.Name = "pw_d"
        Me.pw_d.Size = New System.Drawing.Size(17, 12)
        Me.pw_d.TabIndex = 28
        Me.pw_d.Text = "pw"
        '
        'un_d
        '
        Me.un_d.AutoSize = True
        Me.un_d.Location = New System.Drawing.Point(12, 23)
        Me.un_d.Name = "un_d"
        Me.un_d.Size = New System.Drawing.Size(17, 12)
        Me.un_d.TabIndex = 27
        Me.un_d.Text = "un"
        '
        'S_url_d_l
        '
        Me.S_url_d_l.Location = New System.Drawing.Point(86, 116)
        Me.S_url_d_l.Name = "S_url_d_l"
        Me.S_url_d_l.Size = New System.Drawing.Size(368, 21)
        Me.S_url_d_l.TabIndex = 26
        '
        'pw_d_l
        '
        Me.pw_d_l.Location = New System.Drawing.Point(86, 64)
        Me.pw_d_l.Name = "pw_d_l"
        Me.pw_d_l.Size = New System.Drawing.Size(368, 21)
        Me.pw_d_l.TabIndex = 25
        '
        'un_d_l
        '
        Me.un_d_l.Location = New System.Drawing.Point(86, 20)
        Me.un_d_l.Name = "un_d_l"
        Me.un_d_l.Size = New System.Drawing.Size(368, 21)
        Me.un_d_l.TabIndex = 24
        '
        'ConfigPath_Label
        '
        Me.ConfigPath_Label.AutoSize = True
        Me.ConfigPath_Label.Location = New System.Drawing.Point(116, 205)
        Me.ConfigPath_Label.Name = "ConfigPath_Label"
        Me.ConfigPath_Label.Size = New System.Drawing.Size(47, 12)
        Me.ConfigPath_Label.TabIndex = 23
        Me.ConfigPath_Label.Text = "Unknown"
        '
        'OverWrite_To_Defalut_Config
        '
        Me.OverWrite_To_Defalut_Config.Cursor = System.Windows.Forms.Cursors.No
        Me.OverWrite_To_Defalut_Config.Location = New System.Drawing.Point(237, 207)
        Me.OverWrite_To_Defalut_Config.Name = "OverWrite_To_Defalut_Config"
        Me.OverWrite_To_Defalut_Config.Size = New System.Drawing.Size(107, 43)
        Me.OverWrite_To_Defalut_Config.TabIndex = 32
        Me.OverWrite_To_Defalut_Config.Text = "OverWrite"
        Me.OverWrite_To_Defalut_Config.UseVisualStyleBackColor = True
        '
        'Open_With_Notepad
        '
        Me.Open_With_Notepad.Location = New System.Drawing.Point(391, 211)
        Me.Open_With_Notepad.Name = "Open_With_Notepad"
        Me.Open_With_Notepad.Size = New System.Drawing.Size(96, 38)
        Me.Open_With_Notepad.TabIndex = 33
        Me.Open_With_Notepad.Text = "NotePad"
        Me.Open_With_Notepad.UseVisualStyleBackColor = True
        '
        'Show_Me_CB
        '
        Me.Show_Me_CB.Location = New System.Drawing.Point(28, 240)
        Me.Show_Me_CB.Name = "Show_Me_CB"
        Me.Show_Me_CB.Size = New System.Drawing.Size(80, 44)
        Me.Show_Me_CB.TabIndex = 34
        Me.Show_Me_CB.Text = "SHOWMECB"
        Me.Show_Me_CB.UseVisualStyleBackColor = True
        '
        'Developer_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 296)
        Me.Controls.Add(Me.Show_Me_CB)
        Me.Controls.Add(Me.Open_With_Notepad)
        Me.Controls.Add(Me.OverWrite_To_Defalut_Config)
        Me.Controls.Add(Me.key_d)
        Me.Controls.Add(Me.key_d_l)
        Me.Controls.Add(Me.s_url_d)
        Me.Controls.Add(Me.pw_d)
        Me.Controls.Add(Me.un_d)
        Me.Controls.Add(Me.S_url_d_l)
        Me.Controls.Add(Me.pw_d_l)
        Me.Controls.Add(Me.un_d_l)
        Me.Controls.Add(Me.ConfigPath_Label)
        Me.Name = "Developer_Form"
        Me.Text = "For Developer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents key_d As Label
    Friend WithEvents key_d_l As TextBox
    Friend WithEvents s_url_d As Label
    Friend WithEvents pw_d As Label
    Friend WithEvents un_d As Label
    Friend WithEvents S_url_d_l As TextBox
    Friend WithEvents pw_d_l As TextBox
    Friend WithEvents un_d_l As TextBox
    Friend WithEvents ConfigPath_Label As Label
    Friend WithEvents OverWrite_To_Defalut_Config As Button
    Friend WithEvents Open_With_Notepad As Button
    Friend WithEvents Show_Me_CB As Button
End Class
