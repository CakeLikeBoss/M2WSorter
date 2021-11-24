Public Class ColetaManual


    Private Sub ButtonInicio_Click(sender As Object, e As EventArgs) Handles ButtonInicio.Click
        FormInicio.ButtonSair.Enabled = True
        Me.Close()
    End Sub

    Private Sub TextBoxCodigo_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCodigo.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            Dim i As Integer
            Dim texto As String
            texto = TextBoxCodigo.Text
            i = FormInicio.csvManager.searchFileToManualRead(texto, FormInicio.ConfigurationData.fileData.configuration.definedUser.name, FormInicio.ConfigurationData.fileData.configuration.definedUser.code)
            If i = -1 Then
                LabelColetaInfo.Text = "INEXISTENTE"
                LabelColetaInfo.BackColor = Color.LightCoral

            ElseIf i = -2 Then
                LabelColetaInfo.Text = "DUPLICADO"
                LabelColetaInfo.BackColor = Color.Yellow
            Else
                LabelColetaInfo.Text = "SUCESSO"
                LabelColetaInfo.BackColor = Color.LightGreen
            End If

            LabelColetaInfo.Text = LabelColetaInfo.Text + vbCr + vbLf + TextBoxCodigo.Text
            TextBoxCodigo.Text = ""
        End If

    End Sub

    Private Sub ColetaManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxCodigo.Select()
    End Sub

    Private Sub ButtonColetar_Click(sender As Object, e As EventArgs) Handles ButtonColetar.Click
        Dim i As Integer
        Dim texto As String
        texto = TextBoxCodigo.Text
        i = FormInicio.csvManager.searchFileToManualRead(texto, FormInicio.ConfigurationData.fileData.configuration.definedUser.name, FormInicio.ConfigurationData.fileData.configuration.definedUser.code)
        If i = -1 Then
            LabelColetaInfo.Text = "INEXISTENTE"
            LabelColetaInfo.BackColor = Color.LightCoral
        ElseIf i = -2 Then
            LabelColetaInfo.Text = "DUPLICADO"
            LabelColetaInfo.BackColor = Color.Yellow
        Else
            LabelColetaInfo.Text = "SUCESSO"
            LabelColetaInfo.BackColor = Color.LightGreen
        End If

        LabelColetaInfo.Text = LabelColetaInfo.Text + vbCr + vbLf + TextBoxCodigo.Text
        TextBoxCodigo.Text = ""
    End Sub
End Class