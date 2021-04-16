Public Class FormInicio
    Dim fileLocation As String
    Dim fileName As String
    Dim fileQtdRegistros As String
    Dim fileQtdDuplicados As String
    Dim fileInfo As String

    Dim coletaInfo As String

    Private Sub ButtonSair_Click(sender As Object, e As EventArgs) Handles ButtonSair.Click
        Close()
    End Sub



    Private Sub ButtonCarregarArquivo_Click(sender As Object, e As EventArgs) Handles ButtonCarregarArquivo.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim csvManager = New CSVManager
        fd.Title = "Localizar arquivo Coleta"
        fd.InitialDirectory = "C:\"
        fd.Filter = "Csv files (*.csv)|*.csv|Text files (*.txt)|*.txt"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            fileLocation = fd.FileName
            fileName = csvManager.getFileName(fileLocation)
            fileQtdRegistros = csvManager.getLineQTD(fileLocation)
            fileQtdDuplicados = csvManager.getQTDDuplicatedLines(fileLocation)
            fileInfo = "Arquivo lido com Sucesso!"
            ShowFileInfo()
            SetDadosDoArquivo()
        Else
            ErrorConsole("Arquivo não Selecionado")
        End If
    End Sub

    Private Sub ErrorConsole(message As String)
        Console.WriteLine("::ERROR::")
        Console.WriteLine(message)
    End Sub
    Private Sub SuccessConsole(message As String)
        Console.WriteLine("::SUCCESS::")
        Console.WriteLine(message)
    End Sub

    Private Sub ShowFileInfo()
        MessageBox.Show(fileInfo)
    End Sub

    Private Sub ShowColetaInfo()
        MessageBox.Show(coletaInfo)
    End Sub

    Private Sub SetDadosDoArquivo()
        LabelNomeArquivo.Text = fileName
        LabelQtdRegistros.Text = fileQtdRegistros
        LabelQtdDuplicadosArquivo.Text = fileQtdDuplicados
        LabelInfo.Text = fileInfo
    End Sub

    Private Sub ButtonConfiguracoes_Click(sender As Object, e As EventArgs) Handles ButtonConfiguracoes.Click
        Dim formConfiguracoes = New Configuracoes()
        formConfiguracoes.Show()
    End Sub

End Class
