Imports IniParser
Imports IniParser.Model

Public Class MainForm

    Public ConfigPath As String = Application.StartupPath() & "\config.ini"
    Public PingStatus As Boolean = False

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Tray.ContextMenuStrip = TrayMenu
            Tray.Visible = True
            SetTrayStatus("Waiting")
            If Not My.Computer.FileSystem.FileExists(ConfigPath) Then
                WriteTextToFile(ConfigPath, My.Resources.config_original)
            End If
            Dim ConfigParser As FileIniDataParser = New FileIniDataParser
            Dim Config As IniData

            Config = ConfigParser.ReadFile(ConfigPath)

            ModuleCBH.WebDAV_URL = Config.GetKey("WebDAV.URL")
            ModuleCBH.WebDAV_User = Config.GetKey("WebDAV.User")
            ModuleCBH.WebDAV_Password = Config.GetKey("WebDAV.Password")
            ModuleCBH.DES_Key = Config.GetKey("DES.Key")

            If isEmpty(ModuleCBH.WebDAV_URL) Or isEmpty(ModuleCBH.WebDAV_User) Or isEmpty(ModuleCBH.WebDAV_Password) Or isEmpty(ModuleCBH.DES_Key) Then
                SetTrayStatus("Error")
                MsgBox("Error: config.ini is not configured properly. Exiting...")
                ExitApp()
            End If

            ' Test WebDAV

            '    Try
            '    Dim Result As String = CBH_Get()
            '    'MsgBox(Result)
            'Catch ex As Exception
            '    ShowTrayTip("Error while testing WebDAV: " & ex.Message)
            'End Try
            PingStatusToolStripMenuItem_Click(Nothing, Nothing)

        Catch ex As Exception
            SetTrayStatus("Error")
            MsgBox("Error: " & ex.Message)
            ExitApp()
        End Try

        SetTrayStatus("Normal")



    End Sub

    Private Sub MainForm_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        HideMainForm()

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
        End If

    End Sub

    Private Sub GetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetToolStripMenuItem.Click
        SetTrayStatus("Waiting")
        Try

            Dim RawString As String = CBH_Get()

            If isEmpty(RawString) Then
                ShowTrayTip("Error occured when getting clipboard content.")
            End If

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
End Class
