Imports System.Net.NetworkInformation

Public Class FormInicio
    Dim fileLocation As String
    Dim fileName As String
    Dim fileOutName As String
    Dim fileQtdRegistros As Integer
    Dim fileQtdDuplicados As String
    Dim fileInfo As String
    Dim coletaInfo As String
    Dim StatusSorter As String

    Dim qtdFila As Integer
    Dim qtdDuplicadosColeta As Integer
    Dim qtdErro As Integer
    Public Shared totalRealizado As Integer
    Dim JaIniciado As Boolean

    Public Shared ConfigurationData As ConfigurationData
    Dim SerialController As SerialController
    Public Shared csvManager As CSVManager
    Private Sub ButtonSair_Click(sender As Object, e As EventArgs) Handles ButtonSair.Click
        Dim relatorioEnviado As Boolean

        If IsNothing(csvManager) Then
            Close()
            Return
        End If

        Try
            Dim fileToExport As String
            fileToExport = ConfigurationData.fileData.configuration.coleta.path + "\" + fileOutName
            csvManager.finishFileToRead(ConfigurationData.fileData.configuration.definedUser.name, ConfigurationData.fileData.configuration.definedUser.code, fileToExport)
            MessageBox.Show("Arquivo Enviado!")
            relatorioEnviado = True
        Catch ex As Exception
            relatorioEnviado = False
            MessageBox.Show(ex.ToString())

        End Try

        If relatorioEnviado Then
            Close()
        Else
            MessageBox.Show("O Relatório não pode ser enviado. Verifique o caminho a ser enviado em configurações!")
        End If

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
            fileOutName = "Coleta_" + fileName
            fileQtdRegistros = csvManager.getLineQTD(fileLocation)
            fileQtdDuplicados = 0
            ''fileQtdDuplicados = csvManager.getQTDDuplicatedLines(fileLocation)
            fileInfo = "Arquivo lido com Sucesso!"
            ShowFileInfo()
            SetDadosDoArquivo()
            ButtonIniciar.Enabled = True
        Else
            Debug.WriteLine("Arquivo não Selecionado")
            ButtonIniciar.Enabled = False
            ButtonParar.Enabled = False
            ButtonColetaManual.Enabled = False
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
        JaIniciado = False
        ConfigurationData = New ConfigurationData()
        SerialController = New SerialController()
        qtdFila = 0
        qtdDuplicadosColeta = 0
        qtdErro = 0
        totalRealizado = 0
        If Not verificarMac() Then
            MessageBox.Show("MAQUINA NAO AUTORIAZADA!")
            Close()
        End If
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
                ButtonIniciar.Enabled = False
                ButtonParar.Enabled = True
                ButtonColetaManual.Enabled = False
                ButtonCarregarArquivo.Enabled = False
                ButtonPendentes.Enabled = True

                If (JaIniciado = False) Then
                    csvManager.setFileToRead(fileLocation)
                    csvManager.verificarOperacaoAnterior(ConfigurationData.fileData.configuration.coleta.path + "\" + fileOutName)
                    SerialController.ConfigSerialPort(ConfigurationData.fileData.configuration.porta)
                    JaIniciado = True
                End If
                MessageBox.Show("Serviço Iniciado")
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
                        'SerialController.SendSerialData(ConfigurationData.fileData.configuration.solenoide.code)
                        qtdErro += 1
                    ElseIf index = -2 Then
                        qtdDuplicadosColeta += 1
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
        ButtonIniciar.Enabled = True
        ButtonParar.Enabled = False
        ButtonColetaManual.Enabled = True
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

    Private Sub ButtonColetaManual_Click(sender As Object, e As EventArgs) Handles ButtonColetaManual.Click
        Dim formColetaManual = New ColetaManual()
        Me.ButtonSair.Enabled = False
        formColetaManual.Show()
    End Sub

    Private Function verificarMac() As Boolean
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Dim macValue As String = nics(1).GetPhysicalAddress.ToString()
        Dim x As Integer
        Dim macList() As String = {
            "B8975AFB279B",
            "408D5CD976EC",
            "00215C5F8D7D",
            "002264E4F8A9",
            "9829A6E19D79"
        }

        For x = 0 To nics.Length - 1 Step 1
            macValue = nics(x).GetPhysicalAddress.ToString()
            If (macList.Contains(macValue)) Then
                Return True
            End If
        Next

        Return False

    End Function

    Private Sub ButtonPendentes_Click(sender As Object, e As EventArgs) Handles ButtonPendentes.Click
        Dim FormRelatorio = New FormRelatorio()
        FormRelatorio.Show()
    End Sub


End Class
