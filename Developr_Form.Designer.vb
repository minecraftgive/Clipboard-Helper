<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Developer_Form
    Inherits MaterialSkin.Controls.MaterialForm
    'Inherits System.Windows.Forms.Form

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
        Me.MDUI_TEST_FORM_Botton = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        Me.Theme_Config_Botton = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialCard1.SuspendLayout()
        Me.SuspendLayout()
        '
        'key_d
        '
        Me.key_d.AutoSize = True
        Me.key_d.Location = New System.Drawing.Point(16, 93)
        Me.key_d.Name = "key_d"
        Me.key_d.Size = New System.Drawing.Size(23, 12)
        Me.key_d.TabIndex = 31
        Me.key_d.Text = "key"
        '
        'key_d_l
        '
        Me.key_d_l.Location = New System.Drawing.Point(45, 84)
        Me.key_d_l.Name = "key_d_l"
        Me.key_d_l.Size = New System.Drawing.Size(368, 21)
        Me.key_d_l.TabIndex = 30
        '
        's_url_d
        '
        Me.s_url_d.AutoSize = True
        Me.s_url_d.Location = New System.Drawing.Point(4, 66)
        Me.s_url_d.Name = "s_url_d"
        Me.s_url_d.Size = New System.Drawing.Size(35, 12)
        Me.s_url_d.TabIndex = 29
        Me.s_url_d.Text = "s_url"
        '
        'pw_d
        '
        Me.pw_d.AutoSize = True
        Me.pw_d.Location = New System.Drawing.Point(22, 39)
        Me.pw_d.Name = "pw_d"
        Me.pw_d.Size = New System.Drawing.Size(17, 12)
        Me.pw_d.TabIndex = 28
        Me.pw_d.Text = "pw"
        '
        'un_d
        '
        Me.un_d.AutoSize = True
        Me.un_d.Location = New System.Drawing.Point(22, 12)
        Me.un_d.Name = "un_d"
        Me.un_d.Size = New System.Drawing.Size(17, 12)
        Me.un_d.TabIndex = 27
        Me.un_d.Text = "un"
        '
        'S_url_d_l
        '
        Me.S_url_d_l.Location = New System.Drawing.Point(45, 57)
        Me.S_url_d_l.Name = "S_url_d_l"
        Me.S_url_d_l.Size = New System.Drawing.Size(368, 21)
        Me.S_url_d_l.TabIndex = 26
        '
        'pw_d_l
        '
        Me.pw_d_l.Location = New System.Drawing.Point(45, 30)
        Me.pw_d_l.Name = "pw_d_l"
        Me.pw_d_l.Size = New System.Drawing.Size(368, 21)
        Me.pw_d_l.TabIndex = 25
        '
        'un_d_l
        '
        Me.un_d_l.Location = New System.Drawing.Point(45, 3)
        Me.un_d_l.Name = "un_d_l"
        Me.un_d_l.Size = New System.Drawing.Size(368, 21)
        Me.un_d_l.TabIndex = 24
        '
        'ConfigPath_Label
        '
        Me.ConfigPath_Label.AutoSize = True
        Me.ConfigPath_Label.Location = New System.Drawing.Point(6, 154)
        Me.ConfigPath_Label.Name = "ConfigPath_Label"
        Me.ConfigPath_Label.Size = New System.Drawing.Size(47, 12)
        Me.ConfigPath_Label.TabIndex = 23
        Me.ConfigPath_Label.Text = "Unknown"
        '
        'OverWrite_To_Defalut_Config
        '
        Me.OverWrite_To_Defalut_Config.Cursor = System.Windows.Forms.Cursors.No
        Me.OverWrite_To_Defalut_Config.Location = New System.Drawing.Point(229, 169)
        Me.OverWrite_To_Defalut_Config.Name = "OverWrite_To_Defalut_Config"
        Me.OverWrite_To_Defalut_Config.Size = New System.Drawing.Size(107, 43)
        Me.OverWrite_To_Defalut_Config.TabIndex = 32
        Me.OverWrite_To_Defalut_Config.Text = "OverWrite"
        Me.OverWrite_To_Defalut_Config.UseVisualStyleBackColor = True
        '
        'Open_With_Notepad
        '
        Me.Open_With_Notepad.Location = New System.Drawing.Point(342, 172)
        Me.Open_With_Notepad.Name = "Open_With_Notepad"
        Me.Open_With_Notepad.Size = New System.Drawing.Size(96, 38)
        Me.Open_With_Notepad.TabIndex = 33
        Me.Open_With_Notepad.Text = "NotePad"
        Me.Open_With_Notepad.UseVisualStyleBackColor = True
        '
        'Show_Me_CB
        '
        Me.Show_Me_CB.Location = New System.Drawing.Point(0, 169)
        Me.Show_Me_CB.Name = "Show_Me_CB"
        Me.Show_Me_CB.Size = New System.Drawing.Size(80, 44)
        Me.Show_Me_CB.TabIndex = 34
        Me.Show_Me_CB.Text = "SHOWMECB"
        Me.Show_Me_CB.UseVisualStyleBackColor = True
        '
        'MDUI_TEST_FORM_Botton
        '
        Me.MDUI_TEST_FORM_Botton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MDUI_TEST_FORM_Botton.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title
        Me.MDUI_TEST_FORM_Botton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MDUI_TEST_FORM_Botton.Depth = 0
        Me.MDUI_TEST_FORM_Botton.HighEmphasis = True
        Me.MDUI_TEST_FORM_Botton.Icon = Nothing
        Me.MDUI_TEST_FORM_Botton.Location = New System.Drawing.Point(87, 177)
        Me.MDUI_TEST_FORM_Botton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MDUI_TEST_FORM_Botton.MouseState = MaterialSkin.MouseState.HOVER
        Me.MDUI_TEST_FORM_Botton.Name = "MDUI_TEST_FORM_Botton"
        Me.MDUI_TEST_FORM_Botton.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MDUI_TEST_FORM_Botton.Size = New System.Drawing.Size(135, 36)
        Me.MDUI_TEST_FORM_Botton.TabIndex = 35
        Me.MDUI_TEST_FORM_Botton.Text = "MDUITESTSHOW"
        Me.MDUI_TEST_FORM_Botton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MDUI_TEST_FORM_Botton.UseAccentColor = False
        Me.MDUI_TEST_FORM_Botton.UseVisualStyleBackColor = True
        '
        'MaterialCard1
        '
        Me.MaterialCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialCard1.Controls.Add(Me.key_d)
        Me.MaterialCard1.Controls.Add(Me.key_d_l)
        Me.MaterialCard1.Controls.Add(Me.s_url_d)
        Me.MaterialCard1.Controls.Add(Me.pw_d)
        Me.MaterialCard1.Controls.Add(Me.un_d)
        Me.MaterialCard1.Controls.Add(Me.S_url_d_l)
        Me.MaterialCard1.Controls.Add(Me.pw_d_l)
        Me.MaterialCard1.Controls.Add(Me.un_d_l)
        Me.MaterialCard1.Depth = 0
        Me.MaterialCard1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialCard1.Location = New System.Drawing.Point(0, 24)
        Me.MaterialCard1.Margin = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCard1.Name = "MaterialCard1"
        Me.MaterialCard1.Padding = New System.Windows.Forms.Padding(14)
        Me.MaterialCard1.Size = New System.Drawing.Size(428, 116)
        Me.MaterialCard1.TabIndex = 36
        '
        'Theme_Config_Botton
        '
        Me.Theme_Config_Botton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Theme_Config_Botton.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title
        Me.Theme_Config_Botton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.Theme_Config_Botton.Depth = 0
        Me.Theme_Config_Botton.HighEmphasis = True
        Me.Theme_Config_Botton.Icon = Nothing
        Me.Theme_Config_Botton.Location = New System.Drawing.Point(6, 225)
        Me.Theme_Config_Botton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Theme_Config_Botton.MouseState = MaterialSkin.MouseState.HOVER
        Me.Theme_Config_Botton.Name = "Theme_Config_Botton"
        Me.Theme_Config_Botton.NoAccentTextColor = System.Drawing.Color.Empty
        Me.Theme_Config_Botton.Size = New System.Drawing.Size(158, 36)
        Me.Theme_Config_Botton.TabIndex = 37
        Me.Theme_Config_Botton.Text = "Theme_Config"
        Me.Theme_Config_Botton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.Theme_Config_Botton.UseAccentColor = False
        Me.Theme_Config_Botton.UseVisualStyleBackColor = True
        '
        'Developer_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 482)
        Me.Controls.Add(Me.Theme_Config_Botton)
        Me.Controls.Add(Me.MaterialCard1)
        Me.Controls.Add(Me.MDUI_TEST_FORM_Botton)
        Me.Controls.Add(Me.Show_Me_CB)
        Me.Controls.Add(Me.Open_With_Notepad)
        Me.Controls.Add(Me.OverWrite_To_Defalut_Config)
        Me.Controls.Add(Me.ConfigPath_Label)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None
        Me.Name = "Developer_Form"
        Me.Padding = New System.Windows.Forms.Padding(3, 24, 3, 3)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "For Developer"
        Me.MaterialCard1.ResumeLayout(False)
        Me.MaterialCard1.PerformLayout()
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
    Friend WithEvents MDUI_TEST_FORM_Botton As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents Theme_Config_Botton As MaterialSkin.Controls.MaterialButton
End Class
