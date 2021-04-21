Public Class ColetaManual


    Private Sub ButtonInicio_Click(sender As Object, e As EventArgs) Handles ButtonInicio.Click
        Me.Close()
    End Sub

    Private Sub TextBoxCodigo_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCodigo.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            Dim i As Integer
            i = FormInicio.csvManager.searchFileToManualRead(TextBoxCodigo.Text, FormInicio.ConfigurationData.fileData.configuration.definedUser.name, FormInicio.ConfigurationData.fileData.configuration.definedUser.code)
            If i = -1 Then
                LabelColetaInfo.Text = "INEXISTENTE"
                LabelColetaInfo.BackColor = Color.LightCoral
            Else
                LabelColetaInfo.Text = "SUCESSO"
                LabelColetaInfo.BackColor = Color.LightGreen
            End If
        End If
    End Sub

    Private Sub ColetaManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxCodigo.Select()
    End Sub
End Class