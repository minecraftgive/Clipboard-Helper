Imports IniParser
Imports IniParser.Model
Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class MainForm

    'Inherits MaterialForm
    Public ConfigPath As String = Application.StartupPath() & "\config.ini"
    Public PingStatus As Boolean = False
    Public Show_ As Boolean = False
    Public AllowInsecure_Bool As Boolean = False
    Public Develop_Click_Count As Int16 = 0


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue300, Accent.LightBlue200, TextShade.WHITE)

        Develop_Form_Show.BackColor = Color.Transparent
        Develop_Form_Show.FlatAppearance.MouseOverBackColor = Color.Transparent








        'HideMainForm()
        'Me.Visible = False
        'Try
        '    Tray.ContextMenuStrip = TrayMenu
        '    Tray.Visible = True
        '    SetTrayStatus("Waiting")
        '    If Not My.Computer.FileSystem.FileExists(ConfigPath) Then
        '        WriteTextToFile(ConfigPath, My.Resources.config_original)
        '    End If
        '    Dim ConfigParser As FileIniDataParser = New FileIniDataParser
        '    Dim Config As IniData

        '    Config = ConfigParser.ReadFile(ConfigPath)

        '    ModuleCBH.WebDAV_URL = Config.GetKey("WebDAV.URL")
        '    ModuleCBH.WebDAV_User = Config.GetKey("WebDAV.User")
        '    ModuleCBH.WebDAV_Password = Config.GetKey("WebDAV.Password")
        '    ModuleCBH.DES_Key = Config.GetKey("DES.Key")

        '    If isEmpty(ModuleCBH.WebDAV_URL) Or isEmpty(ModuleCBH.WebDAV_User) Or isEmpty(ModuleCBH.WebDAV_Password) Or isEmpty(ModuleCBH.DES_Key) Then
        '        SetTrayStatus("Error")
        '        MsgBox("Error: config.ini is not configured properly. Exiting...")

        '        'ExitApp()
        '    End If

        '    ' Test WebDAV

        '    '    Try
        '    '    Dim Result As String = CBH_Get()
        '    '    'MsgBox(Result)
        '    'Catch ex As Exception
        '    '    ShowTrayTip("Error while testing WebDAV: " & ex.Message)
        '    'End Try
        '    PingStatusToolStripMenuItem_Click(Nothing, Nothing)

        'Catch ex As Exception
        '    SetTrayStatus("Fatel Error!!!")
        '    MsgBox("Error: " & ex.Message)
        '    ExitApp()
        'End Try

        'SetTrayStatus("Normal")
        'MainForm_Shown()
        'Me.Visible = True
        'Me.Show()

        Me.Hide()
        Main_Function()
        'MaterialSnackBar.ActiveForm = True


    End Sub

    Public Sub Main_Function()
        'Me.Show()
        Try
            Tray.ContextMenuStrip = TrayMenu
            Tray.Visible = True
            SetTrayStatus("Waiting")
            If Not My.Computer.FileSystem.FileExists(ConfigPath) Then
                WriteTextToFile(ConfigPath, My.Resources.config_original)
                'ConfigPath_Label.Text = "" Me.ConfigPath
            End If
            Developer_Form.ConfigPath_Label.Text = ConfigPath
            Dim ConfigParser As FileIniDataParser = New FileIniDataParser
            Dim Config As IniData
            Try
                Config = ConfigParser.ReadFile(ConfigPath)

            Catch ex As Exception
                SetTrayStatus("Error")
                MsgBox(ex.Message)
                Show_ = True
                Me.Show()
            End Try



            ModuleCBH.WebDAV_URL = Config.GetKey("WebDAV.URL")
            ModuleCBH.WebDAV_User = Config.GetKey("WebDAV.User")
            ModuleCBH.WebDAV_Password = Config.GetKey("WebDAV.Password")
            ModuleCBH.DES_Key = Config.GetKey("DES.Key")

            ModuleCBH.Settings_AllowEmptyKey = IIf(Config.GetKey("Settings.AllowEmptyKey") = "true", True, False)
            'MsgBox(Config.GetKey("Test.test"))

            ModuleCBH.Experimental_AutoCreateStorageFile = IIf(Config.GetKey("Experimental.AutoCreateStorageFile") = "true", True, False)

            ModuleCBH.timeout_ = TimeSpan.FromSeconds(Val(Config.GetKey("Settings.Timeout")))
            Developer_Form.TimeOut_Slider.Value = Val(Config.GetKey("Settings.Timeout"))

            UserName_Input.Text = ModuleCBH.WebDAV_User
            Password_Input.Text = ModuleCBH.WebDAV_Password
            ServerURL_Input.Text = ModuleCBH.WebDAV_URL
            Key_Input.Text = DES_Key

            'If isEmpty(ModuleCBH.WebDAV_URL) Or isEmpty(ModuleCBH.WebDAV_User) Or isEmpty(ModuleCBH.WebDAV_Password) Or isEmpty(ModuleCBH.DES_Key) Then
            If isEmpty(ModuleCBH.WebDAV_URL) Or isEmpty(ModuleCBH.WebDAV_User) Then
                SetTrayStatus("Error")
                MsgBox("Error: config.ini is not configured properly.")
                Show_ = True
                Me.Show()
                'Me.Visible = False
                'Me.Hide()
                'ExitApp()
                'Else
                'Me.Hide()
            End If

            If isEmpty(ModuleCBH.WebDAV_Password) Or isEmpty(ModuleCBH.DES_Key) Then

            End If
            ' Test WebDAV

            '    Try
            '    Dim Result As String = CBH_Get()
            '    'MsgBox(Result)
            'Catch ex As Exception
            '    ShowTrayTip("Error while testing WebDAV: " & ex.Message)
            'End Try

            Dim IsSuccessful = CBH_Ping()
            If Not IsSuccessful Then
                If ModuleCBH.Experimental_AutoCreateStorageFile Then
                    CBH_Put("")
                End If

            End If



            PingStatusToolStripMenuItem_Click(Nothing, Nothing)

        Catch ex As Exception
            SetTrayStatus("Error")
            MsgBox("Fatel Error!!!  " & ex.Message & "Please Check Your Config.ini !!!")
            'ExitApp()
        End Try

        SetTrayStatus("Normal")

        update_RAW_Config_Display()
    End Sub

    Private Sub MainForm_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Show_ = True Then
            Me.Show()
        ElseIf Show_ = False Then
            Me.Hide()
        End If

    End Sub

    Private Sub Tray_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Tray.MouseDoubleClick
        PutToolStripMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub Tray_MouseClick(sender As Object, e As MouseEventArgs) Handles Tray.MouseClick
        If e.Button = MouseButtons.Left Then
            GetToolStripMenuItem_Click(Nothing, Nothing)

        End If



    End Sub


    Public Sub SetTrayStatus(ByVal status As String)

        Select Case status
            Case "Normal"
                Tray.Icon = My.Resources.clipboard_outline
            Case "Waiting"
                Tray.Icon = My.Resources.clipboard_clock_outline
            Case "Error"
                Tray.Icon = My.Resources.clipboard_alert_outline
        End Select

    End Sub

    Public Sub ShowTrayTip(content As String, Optional title As String = "ClipboardHelper", Optional timeout As Integer = 5000)
        Tray.BalloonTipTitle = title
        Tray.BalloonTipText = content
        Tray.ShowBalloonTip(timeout)
    End Sub

    Public Sub ExitApp()
        Tray.Visible = False
        End
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        ExitApp()
    End Sub

    Private Sub TimerPing_Tick(sender As Object, e As EventArgs) Handles TimerPing.Tick
        Dim IsSuccessful = CBH_Ping()
        PingStatusToolStripMenuItem.Text = "Ping: " & IIf(IsSuccessful, "Successful", "Failed")
        SetTrayStatus(IIf(IsSuccessful, "Normal", "Error"))
        PingStatus = IsSuccessful

        If IsSuccessful Then
            Ping_Show.Text = "Connected !"
        Else
            Ping_Show.Text = "DisConnected !"
        End If

    End Sub

    Private Sub PingStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PingStatusToolStripMenuItem.Click
        TimerPing.Stop()
        TimerPing.Interval = 10000
        TimerPing.Start()
        TimerPing_Tick(Nothing, Nothing)
        If PingStatus Then
            ShowTrayTip("Successfully connected to server.")
        Else
            ShowTrayTip("Failed to connect to server.")
            Show_ = True
            Me.Show()
        End If

    End Sub

    Private Sub GetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetToolStripMenuItem.Click
        SetTrayStatus("Waiting")
        Try

            Dim RawString As String = CBH_Get()

            If isEmpty(RawString) Then
                ShowTrayTip("Error occured when getting clipboard content.")
            End If
            'MsgBox(RawString)

            Dim Decrypted As String = DecryptDes(RawString, DES_Key, "Clipboar")
            Clipboard.SetText(Decrypted)

            ShowTrayTip("Copied!")
        Catch ex As Exception
            ShowTrayTip("Error occured when getting clipboard content.: " & ex.Message)
        End Try
        SetTrayStatus("Normal")
    End Sub

    Private Sub PutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PutToolStripMenuItem.Click
        SetTrayStatus("Waiting")
        Try
            Dim ClipboardContent As String = Clipboard.GetText()

            Dim Encrypted As String = EncryptDes(ClipboardContent, DES_Key, "Clipboar")

            If Not CBH_Put(Encrypted) Then
                ShowTrayTip("Error occured when putting clipboard content.")
            End If
            ShowTrayTip("Uploaded!")
        Catch ex As Exception
            ShowTrayTip("Error occured when putting clipboard content.: " & ex.Message)
        End Try
        SetTrayStatus("Normal")
    End Sub

    Private Sub TrayMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TrayMenu.Opening

    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        SetTrayStatus("Waiting")
        Try
            Dim Encrypted As String = EncryptDes(" ", DES_Key, "Clipboar")

            If Not CBH_Put(Encrypted) Then
                ShowTrayTip("Error occured when putting clipboard content.")
            End If
            ShowTrayTip("Deleted!")
        Catch ex As Exception
            ShowTrayTip("Error occured when deleting clipboard content.: " & ex.Message)
        End Try
        SetTrayStatus("Normal")
    End Sub

    Private Sub GUIConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUIConfigToolStripMenuItem.Click
        Show_ = True
        Me.Show()
    End Sub

    Private Sub Hide_Botton_Click(sender As Object, e As EventArgs) Handles Hide_Botton.Click
        Show_ = False
        Me.Hide()
    End Sub

    Private Sub Exit_Botton_Click(sender As Object, e As EventArgs) Handles Exit_Botton.Click
        ExitApp()
    End Sub

    Private Sub Refresh_Botton_Click(sender As Object, e As EventArgs) Handles Refresh_Botton.Click
        Main_Function()
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Me.Hide()
        If Show_ = True Then
            Me.Show()
        ElseIf Show_ = False Then
            Me.Hide()
        End If
    End Sub

    Private Sub update_RAW_Config_Display()

        Developer_Form.un_d_l.Text = WebDAV_User
        Developer_Form.pw_d_l.Text = WebDAV_Password
        Developer_Form.S_url_d_l.Text = WebDAV_URL
        Developer_Form.key_d_l.Text = DES_Key + ""
    End Sub

    Private Sub Save_Config_Function()
        FileOpen(2, ConfigPath, OpenMode.Output)
        PrintLine(2, "[WebDAV]")
        PrintLine(2, "URL=" + ServerURL_Input.Text)
        PrintLine(2, "User=" + UserName_Input.Text)
        PrintLine(2, "Password=" + Password_Input.Text)
        PrintLine(2, "")
        PrintLine(2, "[DES]")
        PrintLine(2, "Key=" + Key_Input.Text)
        PrintLine(2, "")
        PrintLine(2, "[Settings]")
        PrintLine(2, "Timeout=" + CStr(Developer_Form.TimeOut_Slider.Value))

        FileClose(2)
        MsgBox("Save Config Success !")
    End Sub

    Private Sub SaveConfig_Botton_Click(sender As Object, e As EventArgs) Handles SaveConfig_Botton.Click
        'Dim Sure_ As Boolean = False
        'MsgBox("Are You Sure?", MsgBoxStyle.OkCancel, Sure_)
        'Dim IsReachable As Boolean = My.Computer.Network.Ping("10.0.0.123")
        Try
            'MsgBox(My.Computer.Network.Ping(ModuleCBH.WebDAV_URL))
            Dim IsReachable As Boolean = My.Computer.Network.Ping("10.0.0.123")
            'If My.Computer.Network.Ping(ModuleCBH.WebDAV_URL) = True Then
            'Save_Config_Function()
            If IsReachable = False Then
                If MsgBox("Cannot to your WebDAV Server ! ! !" & vbNewLine & "Are You Sure to save and apply config?", MsgBoxStyle.OkCancel + vbExclamation + vbApplicationModal + vbMsgBoxSetForeground) = MsgBoxResult.Ok Then
                    Save_Config_Function()
                Else

                End If
            Else
                Save_Config_Function()
            End If
            'Catch ex As Exception When My.Computer.Network.Ping("10.0.0.123") = True
            '    'MsgBox(My.Computer.Network.Ping("10.0.0.123"))
            '    Save_Config_Function()

            'Catch ex As Exception When My.Computer.Network.Ping("10.0.0.123") = False
            '    If MsgBox("Cannot to your WebDAV Server ! ! !" & vbNewLine & "Are You Sure to save and apply config?", MsgBoxStyle.OkCancel + vbExclamation + vbApplicationModal + vbMsgBoxSetForeground) = MsgBoxResult.Ok Then
            '        Save_Config_Function()
            '    End If
        Catch ex As Exception
            If MsgBox("Cannot to your WebDAV Server ! ! !" & vbNewLine & "Are You Sure to save and apply config?", MsgBoxStyle.OkCancel + vbExclamation + vbApplicationModal + vbMsgBoxSetForeground) = MsgBoxResult.Ok Then
                Save_Config_Function()
                'Else
                'MsgBox("no")
                'MsgBox(Sure_)
                'MsgBox()
            End If
            'MsgBox(ex.Message)
        End Try


        'If MsgBox("Are You Sure?", MsgBoxStyle.OkCancel + vbExclamation + vbApplicationModal + vbMsgBoxSetForeground) = MsgBoxResult.Ok Then
        '    MsgBox("yes")
        'Else
        '    MsgBox("no")
        '    'MsgBox(Sure_)
        '    'MsgBox()
        'End If
    End Sub

    Private Sub Delevelop_Form_Show_Click(sender As Object, e As EventArgs) Handles Develop_Form_Show.Click
        Develop_Click_Count += 1

        If Develop_Click_Count >= 3 Then
            Developer_Form.Show()
            'Developer_Form.setfocus = True
            'Key_Input.Focus()
            Developer_Form.Focus()
        End If

    End Sub

    Private Sub Key_Input_Leave(sender As Object, e As EventArgs) Handles Key_Input.Leave
        'MsgBox(CStr(Key_Input.Text.Length Mod 8) & "  " & Key_Input.Text.Length)
        If (Key_Input.Text.Length Mod 8.0 = 0) = False Then
            MsgBox("Key Length must mod 8 must be 0 !")
            Key_Input.Focus()

        End If
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Show_ = False
        Me.Hide()
    End Sub
End Class
