<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonCarregarArquivo = New System.Windows.Forms.Button()
        Me.ButtonEnviarRelatório = New System.Windows.Forms.Button()
        Me.ButtonConfiguracoes = New System.Windows.Forms.Button()
        Me.ButtonIniciar = New System.Windows.Forms.Button()
        Me.ButtonParar = New System.Windows.Forms.Button()
        Me.ButtonSair = New System.Windows.Forms.Button()
        Me.LabelNomeArquivoRef = New System.Windows.Forms.Label()
        Me.GroupBoxDadosDoArquivo = New System.Windows.Forms.GroupBox()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.LabelQtdDuplicadosArquivo = New System.Windows.Forms.Label()
        Me.LabelQtdRegistros = New System.Windows.Forms.Label()
        Me.LabelInfoRef = New System.Windows.Forms.Label()
        Me.LabelNomeArquivo = New System.Windows.Forms.Label()
        Me.LabelQtdRegistrosRef = New System.Windows.Forms.Label()
        Me.LabelQtdDuplicadosArquivoRef = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelQtdErro = New System.Windows.Forms.Label()
        Me.LabelQtdErroRef = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelQtdDuplicadosColeta = New System.Windows.Forms.Label()
        Me.LabelQtdFila = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelOperador = New System.Windows.Forms.Label()
        Me.LabelQtdFilaRef = New System.Windows.Forms.Label()
        Me.LabelQtdDuplicadosColetaRef = New System.Windows.Forms.Label()
        Me.LabelOperadorRef = New System.Windows.Forms.Label()
        Me.GroupBoxProgressoDaColeta = New System.Windows.Forms.GroupBox()
        Me.ProgressBarProgressoDaColeta = New System.Windows.Forms.ProgressBar()
        Me.GroupBoxDadosDoArquivo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxProgressoDaColeta.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonCarregarArquivo
        '
        Me.ButtonCarregarArquivo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonCarregarArquivo.FlatAppearance.BorderSize = 0
        Me.ButtonCarregarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCarregarArquivo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonCarregarArquivo.Location = New System.Drawing.Point(12, 12)
        Me.ButtonCarregarArquivo.Name = "ButtonCarregarArquivo"
        Me.ButtonCarregarArquivo.Size = New System.Drawing.Size(258, 91)
        Me.ButtonCarregarArquivo.TabIndex = 0
        Me.ButtonCarregarArquivo.Text = "Carregar Arquivo"
        Me.ButtonCarregarArquivo.UseVisualStyleBackColor = False
        '
        'ButtonEnviarRelatório
        '
        Me.ButtonEnviarRelatório.BackColor = System.Drawing.Color.LemonChiffon
        Me.ButtonEnviarRelatório.FlatAppearance.BorderSize = 0
        Me.ButtonEnviarRelatório.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEnviarRelatório.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonEnviarRelatório.Location = New System.Drawing.Point(276, 12)
        Me.ButtonEnviarRelatório.Name = "ButtonEnviarRelatório"
        Me.ButtonEnviarRelatório.Size = New System.Drawing.Size(258, 91)
        Me.ButtonEnviarRelatório.TabIndex = 1
        Me.ButtonEnviarRelatório.Text = "Enviar Relatório"
        Me.ButtonEnviarRelatório.UseVisualStyleBackColor = False
        '
        'ButtonConfiguracoes
        '
        Me.ButtonConfiguracoes.BackColor = System.Drawing.Color.LightGray
        Me.ButtonConfiguracoes.FlatAppearance.BorderSize = 0
        Me.ButtonConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConfiguracoes.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonConfiguracoes.Location = New System.Drawing.Point(540, 12)
        Me.ButtonConfiguracoes.Name = "ButtonConfiguracoes"
        Me.ButtonConfiguracoes.Size = New System.Drawing.Size(258, 91)
        Me.ButtonConfiguracoes.TabIndex = 2
        Me.ButtonConfiguracoes.Text = "Configurações"
        Me.ButtonConfiguracoes.UseVisualStyleBackColor = False
        '
        'ButtonIniciar
        '
        Me.ButtonIniciar.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonIniciar.FlatAppearance.BorderSize = 0
        Me.ButtonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIniciar.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonIniciar.Location = New System.Drawing.Point(12, 109)
        Me.ButtonIniciar.Name = "ButtonIniciar"
        Me.ButtonIniciar.Size = New System.Drawing.Size(258, 91)
        Me.ButtonIniciar.TabIndex = 3
        Me.ButtonIniciar.Text = "Iniciar"
        Me.ButtonIniciar.UseVisualStyleBackColor = False
        '
        'ButtonParar
        '
        Me.ButtonParar.BackColor = System.Drawing.Color.Gold
        Me.ButtonParar.FlatAppearance.BorderSize = 0
        Me.ButtonParar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonParar.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonParar.Location = New System.Drawing.Point(276, 109)
        Me.ButtonParar.Name = "ButtonParar"
        Me.ButtonParar.Size = New System.Drawing.Size(258, 91)
        Me.ButtonParar.TabIndex = 4
        Me.ButtonParar.Text = "Parar"
        Me.ButtonParar.UseVisualStyleBackColor = False
        '
        'ButtonSair
        '
        Me.ButtonSair.BackColor = System.Drawing.Color.Coral
        Me.ButtonSair.FlatAppearance.BorderSize = 0
        Me.ButtonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSair.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonSair.Location = New System.Drawing.Point(541, 109)
        Me.ButtonSair.Name = "ButtonSair"
        Me.ButtonSair.Size = New System.Drawing.Size(258, 91)
        Me.ButtonSair.TabIndex = 5
        Me.ButtonSair.Text = "Sair"
        Me.ButtonSair.UseVisualStyleBackColor = False
        '
        'LabelNomeArquivoRef
        '
        Me.LabelNomeArquivoRef.AutoSize = True
        Me.LabelNomeArquivoRef.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNomeArquivoRef.Location = New System.Drawing.Point(6, 30)
        Me.LabelNomeArquivoRef.Name = "LabelNomeArquivoRef"
        Me.LabelNomeArquivoRef.Size = New System.Drawing.Size(70, 28)
        Me.LabelNomeArquivoRef.TabIndex = 6
        Me.LabelNomeArquivoRef.Text = "Nome:"
        '
        'GroupBoxDadosDoArquivo
        '
        Me.GroupBoxDadosDoArquivo.BackColor = System.Drawing.Color.White
        Me.GroupBoxDadosDoArquivo.Controls.Add(Me.LabelInfo)
        Me.GroupBoxDadosDoArquivo.Controls.Add(Me.LabelQtdDuplicadosArquivo)
        Me.GroupBoxDadosDoArquivo.Controls.Add(Me.LabelQtdRegistros)
        Me.GroupBoxDadosDoArquivo.Controls.Add(Me.LabelInfoRef)
        Me.GroupBoxDadosDoArquivo.Controls.Add(Me.LabelNomeArquivo)
        Me.GroupBoxDadosDoArquivo.Controls.Add(Me.LabelQtdRegistrosRef)
        Me.GroupBoxDadosDoArquivo.Controls.Add(Me.LabelQtdDuplicadosArquivoRef)
        Me.GroupBoxDadosDoArquivo.Controls.Add(Me.LabelNomeArquivoRef)
        Me.GroupBoxDadosDoArquivo.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBoxDadosDoArquivo.Location = New System.Drawing.Point(12, 206)
        Me.GroupBoxDadosDoArquivo.Name = "GroupBoxDadosDoArquivo"
        Me.GroupBoxDadosDoArquivo.Size = New System.Drawing.Size(786, 124)
        Me.GroupBoxDadosDoArquivo.TabIndex = 0
        Me.GroupBoxDadosDoArquivo.TabStop = False
        Me.GroupBoxDadosDoArquivo.Text = "Dados do Arquivo"
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelInfo.Location = New System.Drawing.Point(62, 86)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(356, 28)
        Me.LabelInfo.TabIndex = 14
        Me.LabelInfo.Text = "Aguardando Carregamento do Arquivo"
        '
        'LabelQtdDuplicadosArquivo
        '
        Me.LabelQtdDuplicadosArquivo.AutoSize = True
        Me.LabelQtdDuplicadosArquivo.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelQtdDuplicadosArquivo.Location = New System.Drawing.Point(427, 58)
        Me.LabelQtdDuplicadosArquivo.Name = "LabelQtdDuplicadosArquivo"
        Me.LabelQtdDuplicadosArquivo.Size = New System.Drawing.Size(23, 28)
        Me.LabelQtdDuplicadosArquivo.TabIndex = 13
        Me.LabelQtdDuplicadosArquivo.Text = "0"
        '
        'LabelQtdRegistros
        '
        Me.LabelQtdRegistros.AutoSize = True
        Me.LabelQtdRegistros.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelQtdRegistros.Location = New System.Drawing.Point(151, 58)
        Me.LabelQtdRegistros.Name = "LabelQtdRegistros"
        Me.LabelQtdRegistros.Size = New System.Drawing.Size(23, 28)
        Me.LabelQtdRegistros.TabIndex = 12
        Me.LabelQtdRegistros.Text = "0"
        '
        'LabelInfoRef
        '
        Me.LabelInfoRef.AutoSize = True
        Me.LabelInfoRef.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelInfoRef.Location = New System.Drawing.Point(6, 86)
        Me.LabelInfoRef.Name = "LabelInfoRef"
        Me.LabelInfoRef.Size = New System.Drawing.Size(50, 28)
        Me.LabelInfoRef.TabIndex = 11
        Me.LabelInfoRef.Text = "Info:"
        '
        'LabelNomeArquivo
        '
        Me.LabelNomeArquivo.AutoSize = True
        Me.LabelNomeArquivo.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNomeArquivo.Location = New System.Drawing.Point(82, 30)
        Me.LabelNomeArquivo.Name = "LabelNomeArquivo"
        Me.LabelNomeArquivo.Size = New System.Drawing.Size(245, 28)
        Me.LabelNomeArquivo.TabIndex = 10
        Me.LabelNomeArquivo.Text = "---Aguardando Arquivo---"
        '
        'LabelQtdRegistrosRef
        '
        Me.LabelQtdRegistrosRef.AutoSize = True
        Me.LabelQtdRegistrosRef.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelQtdRegistrosRef.Location = New System.Drawing.Point(6, 58)
        Me.LabelQtdRegistrosRef.Name = "LabelQtdRegistrosRef"
        Me.LabelQtdRegistrosRef.Size = New System.Drawing.Size(139, 28)
        Me.LabelQtdRegistrosRef.TabIndex = 8
        Me.LabelQtdRegistrosRef.Text = "Qtd. Registros:"
        '
        'LabelQtdDuplicadosArquivoRef
        '
        Me.LabelQtdDuplicadosArquivoRef.AutoSize = True
        Me.LabelQtdDuplicadosArquivoRef.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelQtdDuplicadosArquivoRef.Location = New System.Drawing.Point(264, 58)
        Me.LabelQtdDuplicadosArquivoRef.Name = "LabelQtdDuplicadosArquivoRef"
        Me.LabelQtdDuplicadosArquivoRef.Size = New System.Drawing.Size(157, 28)
        Me.LabelQtdDuplicadosArquivoRef.TabIndex = 7
        Me.LabelQtdDuplicadosArquivoRef.Text = "Qtd. Duplicados:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.LabelQtdErro)
        Me.GroupBox1.Controls.Add(Me.LabelQtdErroRef)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LabelQtdDuplicadosColeta)
        Me.GroupBox1.Controls.Add(Me.LabelQtdFila)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LabelOperador)
        Me.GroupBox1.Controls.Add(Me.LabelQtdFilaRef)
        Me.GroupBox1.Controls.Add(Me.LabelQtdDuplicadosColetaRef)
        Me.GroupBox1.Controls.Add(Me.LabelOperadorRef)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 336)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 124)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados da Coleta"
        '
        'LabelQtdErro
        '
        Me.LabelQtdErro.AutoSize = True
        Me.LabelQtdErro.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelQtdErro.Location = New System.Drawing.Point(628, 58)
        Me.LabelQtdErro.Name = "LabelQtdErro"
        Me.LabelQtdErro.Size = New System.Drawing.Size(23, 28)
        Me.LabelQtdErro.TabIndex = 16
        Me.LabelQtdErro.Text = "0"
        '
        'LabelQtdErroRef
        '
        Me.LabelQtdErroRef.AutoSize = True
        Me.LabelQtdErroRef.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelQtdErroRef.Location = New System.Drawing.Point(527, 58)
        Me.LabelQtdErroRef.Name = "LabelQtdErroRef"
        Me.LabelQtdErroRef.Size = New System.Drawing.Size(95, 28)
        Me.LabelQtdErroRef.TabIndex = 15
        Me.LabelQtdErroRef.Text = "Qtd. Erro:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(62, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 28)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Aguardando Carregamento do Arquivo"
        '
        'LabelQtdDuplicadosColeta
        '
        Me.LabelQtdDuplicadosColeta.AutoSize = True
        Me.LabelQtdDuplicadosColeta.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelQtdDuplicadosColeta.Location = New System.Drawing.Point(427, 58)
        Me.LabelQtdDuplicadosColeta.Name = "LabelQtdDuplicadosColeta"
        Me.LabelQtdDuplicadosColeta.Size = New System.Drawing.Size(23, 28)
        Me.LabelQtdDuplicadosColeta.TabIndex = 13
        Me.LabelQtdDuplicadosColeta.Text = "0"
        '
        'LabelQtdFila
        '
        Me.LabelQtdFila.AutoSize = True
        Me.LabelQtdFila.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelQtdFila.Location = New System.Drawing.Point(101, 58)
        Me.LabelQtdFila.Name = "LabelQtdFila"
        Me.LabelQtdFila.Size = New System.Drawing.Size(23, 28)
        Me.LabelQtdFila.TabIndex = 12
        Me.LabelQtdFila.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(6, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 28)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Info:"
        '
        'LabelOperador
        '
        Me.LabelOperador.AutoSize = True
        Me.LabelOperador.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelOperador.Location = New System.Drawing.Point(82, 30)
        Me.LabelOperador.Name = "LabelOperador"
        Me.LabelOperador.Size = New System.Drawing.Size(260, 28)
        Me.LabelOperador.TabIndex = 10
        Me.LabelOperador.Text = "---Aguardando Operador---"
        '
        'LabelQtdFilaRef
        '
        Me.LabelQtdFilaRef.AutoSize = True
        Me.LabelQtdFilaRef.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelQtdFilaRef.Location = New System.Drawing.Point(6, 58)
        Me.LabelQtdFilaRef.Name = "LabelQtdFilaRef"
        Me.LabelQtdFilaRef.Size = New System.Drawing.Size(89, 28)
        Me.LabelQtdFilaRef.TabIndex = 8
        Me.LabelQtdFilaRef.Text = "Qtd. Fila:"
        '
        'LabelQtdDuplicadosColetaRef
        '
        Me.LabelQtdDuplicadosColetaRef.AutoSize = True
        Me.LabelQtdDuplicadosColetaRef.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelQtdDuplicadosColetaRef.Location = New System.Drawing.Point(264, 58)
        Me.LabelQtdDuplicadosColetaRef.Name = "LabelQtdDuplicadosColetaRef"
        Me.LabelQtdDuplicadosColetaRef.Size = New System.Drawing.Size(157, 28)
        Me.LabelQtdDuplicadosColetaRef.TabIndex = 7
        Me.LabelQtdDuplicadosColetaRef.Text = "Qtd. Duplicados:"
        '
        'LabelOperadorRef
        '
        Me.LabelOperadorRef.AutoSize = True
        Me.LabelOperadorRef.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelOperadorRef.Location = New System.Drawing.Point(6, 30)
        Me.LabelOperadorRef.Name = "LabelOperadorRef"
        Me.LabelOperadorRef.Size = New System.Drawing.Size(70, 28)
        Me.LabelOperadorRef.TabIndex = 6
        Me.LabelOperadorRef.Text = "Nome:"
        '
        'GroupBoxProgressoDaColeta
        '
        Me.GroupBoxProgressoDaColeta.BackColor = System.Drawing.Color.White
        Me.GroupBoxProgressoDaColeta.Controls.Add(Me.ProgressBarProgressoDaColeta)
        Me.GroupBoxProgressoDaColeta.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBoxProgressoDaColeta.Location = New System.Drawing.Point(19, 466)
        Me.GroupBoxProgressoDaColeta.Name = "GroupBoxProgressoDaColeta"
        Me.GroupBoxProgressoDaColeta.Size = New System.Drawing.Size(780, 70)
        Me.GroupBoxProgressoDaColeta.TabIndex = 16
        Me.GroupBoxProgressoDaColeta.TabStop = False
        Me.GroupBoxProgressoDaColeta.Text = "Progresso da Coleta"
        '
        'ProgressBarProgressoDaColeta
        '
        Me.ProgressBarProgressoDaColeta.Location = New System.Drawing.Point(6, 33)
        Me.ProgressBarProgressoDaColeta.Name = "ProgressBarProgressoDaColeta"
        Me.ProgressBarProgressoDaColeta.Size = New System.Drawing.Size(768, 23)
        Me.ProgressBarProgressoDaColeta.TabIndex = 0
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 550)
        Me.Controls.Add(Me.GroupBoxProgressoDaColeta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxDadosDoArquivo)
        Me.Controls.Add(Me.ButtonSair)
        Me.Controls.Add(Me.ButtonParar)
        Me.Controls.Add(Me.ButtonIniciar)
        Me.Controls.Add(Me.ButtonConfiguracoes)
        Me.Controls.Add(Me.ButtonEnviarRelatório)
        Me.Controls.Add(Me.ButtonCarregarArquivo)
        Me.Name = "FormInicio"
        Me.Text = "Sorter"
        Me.GroupBoxDadosDoArquivo.ResumeLayout(False)
        Me.GroupBoxDadosDoArquivo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxProgressoDaColeta.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonCarregarArquivo As Button
    Friend WithEvents ButtonEnviarRelatório As Button
    Friend WithEvents ButtonConfiguracoes As Button
    Friend WithEvents ButtonIniciar As Button
    Friend WithEvents ButtonParar As Button
    Friend WithEvents ButtonSair As Button
    Friend WithEvents LabelNomeArquivoRef As Label
    Friend WithEvents GroupBoxDadosDoArquivo As GroupBox
    Friend WithEvents LabelInfo As Label
    Friend WithEvents LabelQtdDuplicadosArquivo As Label
    Friend WithEvents LabelQtdRegistros As Label
    Friend WithEvents LabelInfoRef As Label
    Friend WithEvents LabelNomeArquivo As Label
    Friend WithEvents LabelQtdRegistrosRef As Label
    Friend WithEvents LabelQtdDuplicadosArquivoRef As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelQtdErro As Label
    Friend WithEvents LabelQtdErroRef As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelQtdDuplicadosColeta As Label
    Friend WithEvents LabelQtdFila As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelOperador As Label
    Friend WithEvents LabelQtdFilaRef As Label
    Friend WithEvents LabelQtdDuplicadosColetaRef As Label
    Friend WithEvents LabelOperadorRef As Label
    Friend WithEvents GroupBoxProgressoDaColeta As GroupBox
    Friend WithEvents ProgressBarProgressoDaColeta As ProgressBar
End Class
