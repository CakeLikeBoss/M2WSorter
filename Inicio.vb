

Public Class FormInicio
    Dim fileLocation As String
    Dim fileName As String
    Dim fileQtdRegistros As Integer
    Dim fileQtdDuplicados As String
    Dim fileInfo As String
    Dim coletaInfo As String
    Dim StatusSorter As String

    Dim qtdFila As Integer
    Dim qtdDuplicadosColeta As Integer
    Dim qtdErro As Integer
    Dim totalRealizado As Integer

    Public Shared ConfigurationData As ConfigurationData
    Dim SerialController As SerialController
    Public Shared csvManager As CSVManager
    Private Sub ButtonSair_Click(sender As Object, e As EventArgs) Handles ButtonSair.Click
        Close()
    End Sub

    Private Sub ButtonCarregarArquivo_Click(sender As Object, e As EventArgs) Handles ButtonCarregarArquivo.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        csvManager = New CSVManager()
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
            Debug.WriteLine("Arquivo não Selecionado")
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

    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatusSorter = "Parada"
        ConfigurationData = New ConfigurationData()
        SerialController = New SerialController()
        qtdFila = 0
        qtdDuplicadosColeta = 0
        qtdErro = 0
        totalRealizado = 0
    End Sub

    Private Sub TimerVerificarOperador_Tick(sender As Object, e As EventArgs) Handles TimerVerificarOperador.Tick
        ConfigurationData.LoadConfigurations()
        If ConfigurationData.fileData.configuration.definedUser.name <> "" Then
            LabelOperador.Text = ConfigurationData.fileData.configuration.definedUser.name
        End If
    End Sub

    Private Sub ButtonIniciar_Click(sender As Object, e As EventArgs) Handles ButtonIniciar.Click
        If fileInfo <> "Arquivo lido com Sucesso!" Then
            MessageBox.Show("O arquivo Ainda não Foi carregado!")
        ElseIf ConfigurationData.fileData.configuration.porta <> "" Then
            Try
                csvManager.setFileToRead(fileLocation)
                MessageBox.Show("Serviço Iniciado")
                SerialController.ConfigSerialPort(ConfigurationData.fileData.configuration.porta)
                StatusSorter = "Processar"
                If BackgroundWorkerSerialListener.IsBusy <> True Then
                    BackgroundWorkerSerialListener.RunWorkerAsync()
                End If
                qtdFila = fileQtdRegistros
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Não há uma porta configurada!")
        End If
    End Sub

    Private Sub BackgroundWorkerSerialListener_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerSerialListener.DoWork

        Dim readText As String
        Dim index As Integer
        Do
            Try
                Do

                    readText = SerialController.ReceiveSerialData()
                    index = csvManager.searchFileToRead(readText, ConfigurationData.fileData.configuration.definedUser.name, ConfigurationData.fileData.configuration.definedUser.code)
                    If index = -1 Then
                        SerialController.SendSerialData(ConfigurationData.fileData.configuration.solenoide.code)
                    End If
                    If BackgroundWorkerSerialListener.CancellationPending Then
                        e.Cancel = True
                        Exit Do
                    End If

                Loop Until StatusSorter = "Parada"
            Catch ex As Exception
                Debug.WriteLine(ex.Message)
                SerialController.CloseConnection()
            End Try
        Loop Until StatusSorter = "Parada"
    End Sub

    Private Sub BackgroundWorkerSerialListener_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerSerialListener.RunWorkerCompleted
        Try
            MessageBox.Show("Sorter Finalizada!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonParar_Click(sender As Object, e As EventArgs) Handles ButtonParar.Click
        StatusSorter = "Parada"
        If BackgroundWorkerSerialListener.IsBusy() Then
            If BackgroundWorkerSerialListener.WorkerSupportsCancellation Then
                BackgroundWorkerSerialListener.CancelAsync()
            End If
        End If
        MessageBox.Show("Sinal de cancelamento enviado!")
    End Sub

    Private Sub TimerControleDeOperacao_Tick(sender As Object, e As EventArgs) Handles TimerControleDeOperacao.Tick
        LabelQtdFila.Text = qtdFila.ToString()
        LabelQtdDuplicadosColeta.Text = qtdDuplicadosColeta.ToString()
        LabelQtdErro.Text = qtdErro.ToString()
        If qtdFila <> 0 Then
            ProgressBarProgressoDaColeta.Value = Math.Round((totalRealizado * 100) / qtdFila)
            If StatusSorter = "Processar" Then
                coletaInfo = "Processando...   Conferidos " + totalRealizado.ToString() + " de " + qtdFila.ToString()
            End If
        End If
        LabelColetaInfo.Text = coletaInfo
    End Sub

    Private Sub ButtonEnviarRelatorio_Click(sender As Object, e As EventArgs) Handles ButtonEnviarRelatorio.Click
        Dim fileToExport As String
        fileToExport = ConfigurationData.fileData.configuration.coleta.path + "Coleta_" + System.DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".csv"
        csvManager.finishFileToRead(ConfigurationData.fileData.configuration.definedUser.name, ConfigurationData.fileData.configuration.definedUser.code, fileToExport)
        MessageBox.Show("Arquivo Enviado!")
    End Sub

    Private Sub ButtonColetaManual_Click(sender As Object, e As EventArgs) Handles ButtonColetaManual.Click
        Dim formColetaManual = New ColetaManual()
        formColetaManual.Show()
    End Sub
End Class
