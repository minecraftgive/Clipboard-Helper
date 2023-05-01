Imports MaterialSkin

Public Class Developer_Form
    Private Sub Developer_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OverWrite_To_Defalut_Config_Click(sender As Object, e As EventArgs) Handles OverWrite_To_Defalut_Config.Click
        'WriteTextToFile(MainForm.ConfigPath, My.Resources.config_original)
    End Sub

    Private Sub Open_With_Notepad_Click(sender As Object, e As EventArgs) Handles Open_With_Notepad.Click

    End Sub

    Private Sub Show_Me_CB_Click(sender As Object, e As EventArgs) Handles Show_Me_CB.Click
        Dim ClipboardContent As String = Clipboard.GetText()
        MsgBox(ClipboardContent)
    End Sub

    Private Sub MDUI_TEST_FORM_Botton_Click(sender As Object, e As EventArgs) Handles MDUI_TEST_FORM_Botton.Click
        MDUI_TEST_FORM.Show()
    End Sub
End Class