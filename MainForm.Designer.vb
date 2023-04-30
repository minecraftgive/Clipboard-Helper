<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Hide_Botton.Location = New System.Drawing.Point(14, 32)
        Me.Hide_Botton.Margin = New System.Windows.Forms.Padding(4)
        Me.Hide_Botton.Name = "Hide_Botton"
        Me.Hide_Botton.Size = New System.Drawing.Size(145, 61)
        Me.Hide_Botton.TabIndex = 0
        Me.Hide_Botton.Text = "Hide"
        Me.Hide_Botton.UseVisualStyleBackColor = True
        '
        'Refresh_Botton
        '
        Me.Refresh_Botton.Location = New System.Drawing.Point(225, 36)
        Me.Refresh_Botton.Margin = New System.Windows.Forms.Padding(4)
        Me.Refresh_Botton.Name = "Refresh_Botton"
        Me.Refresh_Botton.Size = New System.Drawing.Size(111, 56)
        Me.Refresh_Botton.TabIndex = 1
        Me.Refresh_Botton.Text = "Refresh"
        Me.Refresh_Botton.UseVisualStyleBackColor = True
        '
        'Exit_Botton
        '
        Me.Exit_Botton.Location = New System.Drawing.Point(72, 149)
        Me.Exit_Botton.Name = "Exit_Botton"
        Me.Exit_Botton.Size = New System.Drawing.Size(192, 68)
        Me.Exit_Botton.TabIndex = 2
        Me.Exit_Botton.Text = "Exit"
        Me.Exit_Botton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 244)
        Me.ControlBox = False
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
End Class
