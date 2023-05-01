<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Me.components = New System.ComponentModel.Container()
        Me.Tray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PingStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GUIConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerPing = New System.Windows.Forms.Timer(Me.components)
        Me.Hide_Botton = New System.Windows.Forms.Button()
        Me.Refresh_Botton = New System.Windows.Forms.Button()
        Me.Exit_Botton = New System.Windows.Forms.Button()
        Me.SaveConfig_Botton = New System.Windows.Forms.Button()
        Me.Ping_Show = New System.Windows.Forms.Label()
        Me.UserName_Input = New System.Windows.Forms.TextBox()
        Me.Password_Input = New System.Windows.Forms.TextBox()
        Me.ServerURL_Input = New System.Windows.Forms.TextBox()
        Me.UserName = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.ServerURL = New System.Windows.Forms.Label()
        Me.Key = New System.Windows.Forms.Label()
        Me.Key_Input = New System.Windows.Forms.TextBox()
        Me.Delevelop_Form_Show = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tray
        '
        Me.Tray.Text = "Clipboard Helper"
        Me.Tray.Visible = True
        '
        'ActionsToolStripMenuItem
        '
        Me.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem"
        Me.ActionsToolStripMenuItem.Size = New System.Drawing.Size(62, 21)
        Me.ActionsToolStripMenuItem.Text = "Actions"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(40, 21)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'TrayMenu
        '
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PingStatusToolStripMenuItem, Me.ActionsToolStripMenuItem1, Me.GUIConfigToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.TrayMenu.Name = "TrayMenu"
        Me.TrayMenu.Size = New System.Drawing.Size(218, 92)
        '
        'PingStatusToolStripMenuItem
        '
        Me.PingStatusToolStripMenuItem.Name = "PingStatusToolStripMenuItem"
        Me.PingStatusToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PingStatusToolStripMenuItem.Text = "_PingStatus_"
        '
        'ActionsToolStripMenuItem1
        '
        Me.ActionsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetToolStripMenuItem, Me.PutToolStripMenuItem, Me.DeleteToolStripMenuItem1})
        Me.ActionsToolStripMenuItem1.Name = "ActionsToolStripMenuItem1"
        Me.ActionsToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.ActionsToolStripMenuItem1.Text = "Actions"
        '
        'GetToolStripMenuItem
        '
        Me.GetToolStripMenuItem.Name = "GetToolStripMenuItem"
        Me.GetToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.GetToolStripMenuItem.Text = "Get"
        '
        'PutToolStripMenuItem
        '
        Me.PutToolStripMenuItem.Name = "PutToolStripMenuItem"
        Me.PutToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.PutToolStripMenuItem.Text = "Put"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'GUIConfigToolStripMenuItem
        '
        Me.GUIConfigToolStripMenuItem.Name = "GUIConfigToolStripMenuItem"
        Me.GUIConfigToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.GUIConfigToolStripMenuItem.Text = "GUI (Config and logger)"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'TimerPing
        '
        '
        'Hide_Botton
        '
        Me.Hide_Botton.Location = New System.Drawing.Point(13, 13)
        Me.Hide_Botton.Margin = New System.Windows.Forms.Padding(4)
        Me.Hide_Botton.Name = "Hide_Botton"
        Me.Hide_Botton.Size = New System.Drawing.Size(93, 61)
        Me.Hide_Botton.TabIndex = 0
        Me.Hide_Botton.Text = "Hide"
        Me.Hide_Botton.UseVisualStyleBackColor = True
        '
        'Refresh_Botton
        '
        Me.Refresh_Botton.Location = New System.Drawing.Point(114, 13)
        Me.Refresh_Botton.Margin = New System.Windows.Forms.Padding(4)
        Me.Refresh_Botton.Name = "Refresh_Botton"
        Me.Refresh_Botton.Size = New System.Drawing.Size(85, 61)
        Me.Refresh_Botton.TabIndex = 1
        Me.Refresh_Botton.Text = "Refresh"
        Me.Refresh_Botton.UseVisualStyleBackColor = True
        '
        'Exit_Botton
        '
        Me.Exit_Botton.Location = New System.Drawing.Point(12, 81)
        Me.Exit_Botton.Name = "Exit_Botton"
        Me.Exit_Botton.Size = New System.Drawing.Size(187, 61)
        Me.Exit_Botton.TabIndex = 2
        Me.Exit_Botton.Text = "Exit"
        Me.Exit_Botton.UseVisualStyleBackColor = True
        '
        'SaveConfig_Botton
        '
        Me.SaveConfig_Botton.Location = New System.Drawing.Point(13, 159)
        Me.SaveConfig_Botton.Name = "SaveConfig_Botton"
        Me.SaveConfig_Botton.Size = New System.Drawing.Size(106, 61)
        Me.SaveConfig_Botton.TabIndex = 3
        Me.SaveConfig_Botton.Text = "Save"
        Me.SaveConfig_Botton.UseVisualStyleBackColor = True
        '
        'Ping_Show
        '
        Me.Ping_Show.AutoSize = True
        Me.Ping_Show.Location = New System.Drawing.Point(125, 159)
        Me.Ping_Show.Name = "Ping_Show"
        Me.Ping_Show.Size = New System.Drawing.Size(56, 16)
        Me.Ping_Show.TabIndex = 4
        Me.Ping_Show.Text = "Unknown"
        '
        'UserName_Input
        '
        Me.UserName_Input.Location = New System.Drawing.Point(300, 10)
        Me.UserName_Input.Name = "UserName_Input"
        Me.UserName_Input.Size = New System.Drawing.Size(368, 23)
        Me.UserName_Input.TabIndex = 5
        '
        'Password_Input
        '
        Me.Password_Input.Location = New System.Drawing.Point(300, 54)
        Me.Password_Input.Name = "Password_Input"
        Me.Password_Input.Size = New System.Drawing.Size(368, 23)
        Me.Password_Input.TabIndex = 6
        '
        'ServerURL_Input
        '
        Me.ServerURL_Input.Location = New System.Drawing.Point(300, 105)
        Me.ServerURL_Input.Name = "ServerURL_Input"
        Me.ServerURL_Input.Size = New System.Drawing.Size(368, 23)
        Me.ServerURL_Input.TabIndex = 7
        '
        'UserName
        '
        Me.UserName.AutoSize = True
        Me.UserName.Location = New System.Drawing.Point(226, 13)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(63, 16)
        Me.UserName.TabIndex = 8
        Me.UserName.Text = "UserName"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(226, 61)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(63, 16)
        Me.Password.TabIndex = 9
        Me.Password.Text = "Password"
        '
        'ServerURL
        '
        Me.ServerURL.AutoSize = True
        Me.ServerURL.Location = New System.Drawing.Point(219, 113)
        Me.ServerURL.Name = "ServerURL"
        Me.ServerURL.Size = New System.Drawing.Size(70, 16)
        Me.ServerURL.TabIndex = 10
        Me.ServerURL.Text = "ServerURL"
        '
        'Key
        '
        Me.Key.AutoSize = True
        Me.Key.Location = New System.Drawing.Point(261, 156)
        Me.Key.Name = "Key"
        Me.Key.Size = New System.Drawing.Size(28, 16)
        Me.Key.TabIndex = 14
        Me.Key.Text = "Key"
        '
        'Key_Input
        '
        Me.Key_Input.Location = New System.Drawing.Point(300, 149)
        Me.Key_Input.Name = "Key_Input"
        Me.Key_Input.Size = New System.Drawing.Size(368, 23)
        Me.Key_Input.TabIndex = 13
        Me.Key_Input.WordWrap = False
        '
        'Delevelop_Form_Show
        '
        Me.Delevelop_Form_Show.Location = New System.Drawing.Point(311, 194)
        Me.Delevelop_Form_Show.Name = "Delevelop_Form_Show"
        Me.Delevelop_Form_Show.Size = New System.Drawing.Size(142, 54)
        Me.Delevelop_Form_Show.TabIndex = 23
        Me.Delevelop_Form_Show.Text = "Developer"
        Me.Delevelop_Form_Show.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(214, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 368)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Delevelop_Form_Show)
        Me.Controls.Add(Me.Key)
        Me.Controls.Add(Me.Key_Input)
        Me.Controls.Add(Me.ServerURL)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.ServerURL_Input)
        Me.Controls.Add(Me.Password_Input)
        Me.Controls.Add(Me.UserName_Input)
        Me.Controls.Add(Me.Ping_Show)
        Me.Controls.Add(Me.SaveConfig_Botton)
        Me.Controls.Add(Me.Exit_Botton)
        Me.Controls.Add(Me.Refresh_Botton)
        Me.Controls.Add(Me.Hide_Botton)
        Me.Font = New System.Drawing.Font("JetBrains Mono", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.Text = "CilpBoardHelper_GUI"
        Me.TrayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tray As NotifyIcon
    Friend WithEvents ActionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrayMenu As ContextMenuStrip
    Friend WithEvents ActionsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TimerPing As Timer
    Friend WithEvents PingStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GUIConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Hide_Botton As Button
    Friend WithEvents Refresh_Botton As Button
    Friend WithEvents Exit_Botton As Button
    Friend WithEvents SaveConfig_Botton As Button
    Friend WithEvents Ping_Show As Label
    Friend WithEvents UserName_Input As TextBox
    Friend WithEvents Password_Input As TextBox
    Friend WithEvents ServerURL_Input As TextBox
    Friend WithEvents UserName As Label
    Friend WithEvents Password As Label
    Friend WithEvents ServerURL As Label
    Friend WithEvents Key As Label
    Friend WithEvents Key_Input As TextBox
    Friend WithEvents Delevelop_Form_Show As Button
    Friend WithEvents Button1 As Button
End Class
