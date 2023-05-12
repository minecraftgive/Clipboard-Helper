Imports MaterialSkin

Public Class Developer_Form
    Private Sub Developer_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeOut_Slider.Value = timeout_.Seconds
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

    Private Sub Theme_Config_Botton_Click(sender As Object, e As EventArgs) Handles Theme_Config_Botton.Click
        Theme_Config.Show()
    End Sub

    Private Sub TimeOut_Slider_onValueChanged(sender As Object, newValue As Integer) Handles TimeOut_Slider.onValueChanged
        ModuleCBH.timeout_ = TimeSpan.FromSeconds(TimeOut_Slider.Value)
    End Sub


End Class