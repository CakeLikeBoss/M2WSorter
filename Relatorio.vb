Public Class FormRelatorio
    Private Sub ButtonInicio_Click(sender As Object, e As EventArgs) Handles ButtonInicio.Click
        Me.Close()
    End Sub

    Private Sub FormRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregarOperadores()
    End Sub


    Private Sub TextBoxPesquisa_KeyPress(sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(13) Then
            Pesquisar()
        End If

    End Sub


    Private Sub Pesquisar()
        Dim x As Integer
        Dim operador As String
        Dim status As String
        Dim code As String

        operador = ComboBoxOperador.Text
        status = ComboBoxStatus.Text
        code = TextBoxCode.Text

        If status = "PENDENTE" Then
            status = ""
        End If

        DataGridViewRelatorio.Rows.Clear()

        For x = 1 To FormInicio.csvManager.colSeq.Length - 1 Step 1
            If FormInicio.csvManager.colSeq(x) = "" Then
                Continue For
            End If
            If status <> "TODOS" And status <> FormInicio.csvManager.colError(x) Then
                Continue For
            End If
            If operador <> "TODOS" And Not FormInicio.csvManager.colOperadorName(x).Contains(operador) Then
                Continue For
            End If
            If code <> "" And Not FormInicio.csvManager.colCodigo(x).Contains(code) Then
                Continue For
            End If

            If FormInicio.csvManager.colError(x) = "" Then
                DataGridViewRelatorio.Rows.Add(New Object() {
                    FormInicio.csvManager.colSeq(x),
                    FormInicio.csvManager.colCodigo(x),
                    "PENDENTE",
                    FormInicio.csvManager.colOperadorName(x)
                })
            Else
                DataGridViewRelatorio.Rows.Add(New Object() {
                    FormInicio.csvManager.colSeq(x),
                    FormInicio.csvManager.colCodigo(x),
                    FormInicio.csvManager.colError(x),
                    FormInicio.csvManager.colOperadorName(x)
                })
            End If
        Next

    End Sub

    Private Sub ButtonPesquisar_Click(sender As Object, e As EventArgs) Handles ButtonPesquisar.Click
        Pesquisar()
    End Sub

    Private Sub carregarOperadores()
        Dim configuracao As ConfigurationData
        configuracao = New ConfigurationData()
        configuracao.LoadConfigurations()
        For Each user As ConfigurationData.ConfigurationFileLayout.ConfigurationNode.UserNode In configuracao.fileData.configuration.users
            ComboBoxOperador.Items.Add(user.name)
        Next

    End Sub

End Class