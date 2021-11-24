<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracoes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelNoReadCodeRef = New System.Windows.Forms.Label()
        Me.GroupBoxNoRead = New System.Windows.Forms.GroupBox()
        Me.CheckBoxNoReadRecuoDeLinha = New System.Windows.Forms.CheckBox()
        Me.CheckBoxNoReadQuebraDeLinha = New System.Windows.Forms.CheckBox()
        Me.TextBoxNoReadCode = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxSolenoideRecuoDeLinha = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSolenoideQuebraDeLinha = New System.Windows.Forms.CheckBox()
        Me.TextBoxSolenoideCode = New System.Windows.Forms.TextBox()
        Me.LabelSolenoideCodeRef = New System.Windows.Forms.Label()
        Me.ButtonConfiguracoesDeFabrica = New System.Windows.Forms.Button()
        Me.ButtonSalvar = New System.Windows.Forms.Button()
        Me.ButtonInicio = New System.Windows.Forms.Button()
        Me.GroupBoxColeta = New System.Windows.Forms.GroupBox()
        Me.LabelColetaPathRef = New System.Windows.Forms.Label()
        Me.TextBoxColetaPath = New System.Windows.Forms.TextBox()
        Me.CheckBoxColetaRecuoDeLinha = New System.Windows.Forms.CheckBox()
        Me.CheckBoxColetaQuebraDeLinha = New System.Windows.Forms.CheckBox()
        Me.GroupBoxOperador = New System.Windows.Forms.GroupBox()
        Me.ComboBoxPorta = New System.Windows.Forms.ComboBox()
        Me.ButtonOperadorExcluir = New System.Windows.Forms.Button()
        Me.ButtonOperadorAdicionar = New System.Windows.Forms.Button()
        Me.ComboBoxOperador = New System.Windows.Forms.ComboBox()
        Me.GroupBoxNoRead.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxColeta.SuspendLayout()
        Me.GroupBoxOperador.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelNoReadCodeRef
        '
        Me.LabelNoReadCodeRef.AutoSize = True
        Me.LabelNoReadCodeRef.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNoReadCodeRef.Location = New System.Drawing.Point(6, 36)
        Me.LabelNoReadCodeRef.Name = "LabelNoReadCodeRef"
        Me.LabelNoReadCodeRef.Size = New System.Drawing.Size(62, 28)
        Me.LabelNoReadCodeRef.TabIndex = 0
        Me.LabelNoReadCodeRef.Text = "Code:"
        '
        'GroupBoxNoRead
        '
        Me.GroupBoxNoRead.BackColor = System.Drawing.Color.White
        Me.GroupBoxNoRead.Controls.Add(Me.CheckBoxNoReadRecuoDeLinha)
        Me.GroupBoxNoRead.Controls.Add(Me.CheckBoxNoReadQuebraDeLinha)
        Me.GroupBoxNoRead.Controls.Add(Me.TextBoxNoReadCode)
        Me.GroupBoxNoRead.Controls.Add(Me.LabelNoReadCodeRef)
        Me.GroupBoxNoRead.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBoxNoRead.Location = New System.Drawing.Point(415, 270)
        Me.GroupBoxNoRead.Name = "GroupBoxNoRead"
        Me.GroupBoxNoRead.Size = New System.Drawing.Size(383, 155)
        Me.GroupBoxNoRead.TabIndex = 2
        Me.GroupBoxNoRead.TabStop = False
        Me.GroupBoxNoRead.Text = "No-Read"
        '
        'CheckBoxNoReadRecuoDeLinha
        '
        Me.CheckBoxNoReadRecuoDeLinha.AutoSize = True
        Me.CheckBoxNoReadRecuoDeLinha.Location = New System.Drawing.Point(13, 111)
        Me.CheckBoxNoReadRecuoDeLinha.Name = "CheckBoxNoReadRecuoDeLinha"
        Me.CheckBoxNoReadRecuoDeLinha.Size = New System.Drawing.Size(277, 32)
        Me.CheckBoxNoReadRecuoDeLinha.TabIndex = 4
        Me.CheckBoxNoReadRecuoDeLinha.Text = "Receber Recuo de Linha (CR)"
        Me.CheckBoxNoReadRecuoDeLinha.UseVisualStyleBackColor = True
        '
        'CheckBoxNoReadQuebraDeLinha
        '
        Me.CheckBoxNoReadQuebraDeLinha.AutoSize = True
        Me.CheckBoxNoReadQuebraDeLinha.Location = New System.Drawing.Point(13, 73)
        Me.CheckBoxNoReadQuebraDeLinha.Name = "CheckBoxNoReadQuebraDeLinha"
        Me.CheckBoxNoReadQuebraDeLinha.Size = New System.Drawing.Size(284, 32)
        Me.CheckBoxNoReadQuebraDeLinha.TabIndex = 3
        Me.CheckBoxNoReadQuebraDeLinha.Text = "Receber Quebra de Linha (LF)"
        Me.CheckBoxNoReadQuebraDeLinha.UseVisualStyleBackColor = True
        '
        'TextBoxNoReadCode
        '
        Me.TextBoxNoReadCode.Location = New System.Drawing.Point(68, 33)
        Me.TextBoxNoReadCode.Name = "TextBoxNoReadCode"
        Me.TextBoxNoReadCode.Size = New System.Drawing.Size(309, 34)
        Me.TextBoxNoReadCode.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.CheckBoxSolenoideRecuoDeLinha)
        Me.GroupBox1.Controls.Add(Me.CheckBoxSolenoideQuebraDeLinha)
        Me.GroupBox1.Controls.Add(Me.TextBoxSolenoideCode)
        Me.GroupBox1.Controls.Add(Me.LabelSolenoideCodeRef)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 270)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 155)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Solenoide"
        '
        'CheckBoxSolenoideRecuoDeLinha
        '
        Me.CheckBoxSolenoideRecuoDeLinha.AutoSize = True
        Me.CheckBoxSolenoideRecuoDeLinha.Location = New System.Drawing.Point(13, 111)
        Me.CheckBoxSolenoideRecuoDeLinha.Name = "CheckBoxSolenoideRecuoDeLinha"
        Me.CheckBoxSolenoideRecuoDeLinha.Size = New System.Drawing.Size(261, 32)
        Me.CheckBoxSolenoideRecuoDeLinha.TabIndex = 4
        Me.CheckBoxSolenoideRecuoDeLinha.Text = "Enviar Recuo de Linha (CR)"
        Me.CheckBoxSolenoideRecuoDeLinha.UseVisualStyleBackColor = True
        '
        'CheckBoxSolenoideQuebraDeLinha
        '
        Me.CheckBoxSolenoideQuebraDeLinha.AutoSize = True
        Me.CheckBoxSolenoideQuebraDeLinha.Location = New System.Drawing.Point(13, 73)
        Me.CheckBoxSolenoideQuebraDeLinha.Name = "CheckBoxSolenoideQuebraDeLinha"
        Me.CheckBoxSolenoideQuebraDeLinha.Size = New System.Drawing.Size(268, 32)
        Me.CheckBoxSolenoideQuebraDeLinha.TabIndex = 3
        Me.CheckBoxSolenoideQuebraDeLinha.Text = "Enviar Quebra de Linha (LF)"
        Me.CheckBoxSolenoideQuebraDeLinha.UseVisualStyleBackColor = True
        '
        'TextBoxSolenoideCode
        '
        Me.TextBoxSolenoideCode.Location = New System.Drawing.Point(68, 33)
        Me.TextBoxSolenoideCode.Name = "TextBoxSolenoideCode"
        Me.TextBoxSolenoideCode.Size = New System.Drawing.Size(318, 34)
        Me.TextBoxSolenoideCode.TabIndex = 1
        '
        'LabelSolenoideCodeRef
        '
        Me.LabelSolenoideCodeRef.AutoSize = True
        Me.LabelSolenoideCodeRef.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelSolenoideCodeRef.Location = New System.Drawing.Point(6, 36)
        Me.LabelSolenoideCodeRef.Name = "LabelSolenoideCodeRef"
        Me.LabelSolenoideCodeRef.Size = New System.Drawing.Size(62, 28)
        Me.LabelSolenoideCodeRef.TabIndex = 0
        Me.LabelSolenoideCodeRef.Text = "Code:"
        '
        'ButtonConfiguracoesDeFabrica
        '
        Me.ButtonConfiguracoesDeFabrica.BackColor = System.Drawing.Color.LightCoral
        Me.ButtonConfiguracoesDeFabrica.FlatAppearance.BorderSize = 0
        Me.ButtonConfiguracoesDeFabrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConfiguracoesDeFabrica.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonConfiguracoesDeFabrica.Location = New System.Drawing.Point(539, 12)
        Me.ButtonConfiguracoesDeFabrica.Name = "ButtonConfiguracoesDeFabrica"
        Me.ButtonConfiguracoesDeFabrica.Size = New System.Drawing.Size(258, 91)
        Me.ButtonConfiguracoesDeFabrica.TabIndex = 8
        Me.ButtonConfiguracoesDeFabrica.Text = "Configurações de Fábrica"
        Me.ButtonConfiguracoesDeFabrica.UseVisualStyleBackColor = False
        Me.ButtonConfiguracoesDeFabrica.Enabled = False
        '
        'ButtonSalvar
        '
        Me.ButtonSalvar.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonSalvar.FlatAppearance.BorderSize = 0
        Me.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalvar.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonSalvar.Location = New System.Drawing.Point(275, 12)
        Me.ButtonSalvar.Name = "ButtonSalvar"
        Me.ButtonSalvar.Size = New System.Drawing.Size(258, 91)
        Me.ButtonSalvar.TabIndex = 7
        Me.ButtonSalvar.Text = "Salvar"
        Me.ButtonSalvar.UseVisualStyleBackColor = False
        '
        'ButtonInicio
        '
        Me.ButtonInicio.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonInicio.FlatAppearance.BorderSize = 0
        Me.ButtonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInicio.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonInicio.Location = New System.Drawing.Point(11, 12)
        Me.ButtonInicio.Name = "ButtonInicio"
        Me.ButtonInicio.Size = New System.Drawing.Size(258, 91)
        Me.ButtonInicio.TabIndex = 6
        Me.ButtonInicio.Text = "Inicio"
        Me.ButtonInicio.UseVisualStyleBackColor = False
        '
        'GroupBoxColeta
        '
        Me.GroupBoxColeta.BackColor = System.Drawing.Color.White
        Me.GroupBoxColeta.Controls.Add(Me.LabelColetaPathRef)
        Me.GroupBoxColeta.Controls.Add(Me.TextBoxColetaPath)
        Me.GroupBoxColeta.Controls.Add(Me.CheckBoxColetaRecuoDeLinha)
        Me.GroupBoxColeta.Controls.Add(Me.CheckBoxColetaQuebraDeLinha)
        Me.GroupBoxColeta.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBoxColeta.Location = New System.Drawing.Point(415, 109)
        Me.GroupBoxColeta.Name = "GroupBoxColeta"
        Me.GroupBoxColeta.Size = New System.Drawing.Size(383, 155)
        Me.GroupBoxColeta.TabIndex = 6
        Me.GroupBoxColeta.TabStop = False
        Me.GroupBoxColeta.Text = "Coleta"
        '
        'LabelColetaPathRef
        '
        Me.LabelColetaPathRef.AutoSize = True
        Me.LabelColetaPathRef.Location = New System.Drawing.Point(6, 36)
        Me.LabelColetaPathRef.Name = "LabelColetaPathRef"
        Me.LabelColetaPathRef.Size = New System.Drawing.Size(54, 28)
        Me.LabelColetaPathRef.TabIndex = 6
        Me.LabelColetaPathRef.Text = "Path:"
        '
        'TextBoxColetaPath
        '
        Me.TextBoxColetaPath.Location = New System.Drawing.Point(68, 33)
        Me.TextBoxColetaPath.Name = "TextBoxColetaPath"
        Me.TextBoxColetaPath.Size = New System.Drawing.Size(309, 34)
        Me.TextBoxColetaPath.TabIndex = 5
        '
        'CheckBoxColetaRecuoDeLinha
        '
        Me.CheckBoxColetaRecuoDeLinha.AutoSize = True
        Me.CheckBoxColetaRecuoDeLinha.Location = New System.Drawing.Point(13, 113)
        Me.CheckBoxColetaRecuoDeLinha.Name = "CheckBoxColetaRecuoDeLinha"
        Me.CheckBoxColetaRecuoDeLinha.Size = New System.Drawing.Size(277, 32)
        Me.CheckBoxColetaRecuoDeLinha.TabIndex = 4
        Me.CheckBoxColetaRecuoDeLinha.Text = "Receber Recuo de Linha (CR)"
        Me.CheckBoxColetaRecuoDeLinha.UseVisualStyleBackColor = True
        '
        'CheckBoxColetaQuebraDeLinha
        '
        Me.CheckBoxColetaQuebraDeLinha.AutoSize = True
        Me.CheckBoxColetaQuebraDeLinha.Location = New System.Drawing.Point(13, 74)
        Me.CheckBoxColetaQuebraDeLinha.Name = "CheckBoxColetaQuebraDeLinha"
        Me.CheckBoxColetaQuebraDeLinha.Size = New System.Drawing.Size(284, 32)
        Me.CheckBoxColetaQuebraDeLinha.TabIndex = 3
        Me.CheckBoxColetaQuebraDeLinha.Text = "Receber Quebra de Linha (LF)"
        Me.CheckBoxColetaQuebraDeLinha.UseVisualStyleBackColor = True
        '
        'GroupBoxOperador
        '
        Me.GroupBoxOperador.BackColor = System.Drawing.Color.White
        Me.GroupBoxOperador.Controls.Add(Me.ComboBoxPorta)
        Me.GroupBoxOperador.Controls.Add(Me.ButtonOperadorExcluir)
        Me.GroupBoxOperador.Controls.Add(Me.ButtonOperadorAdicionar)
        Me.GroupBoxOperador.Controls.Add(Me.ComboBoxOperador)
        Me.GroupBoxOperador.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBoxOperador.Location = New System.Drawing.Point(11, 109)
        Me.GroupBoxOperador.Name = "GroupBoxOperador"
        Me.GroupBoxOperador.Size = New System.Drawing.Size(392, 155)
        Me.GroupBoxOperador.TabIndex = 7
        Me.GroupBoxOperador.TabStop = False
        Me.GroupBoxOperador.Text = "Operador"
        '
        'ComboBoxPorta
        '
        Me.ComboBoxPorta.DisplayMember = "Selecione o Operador"
        Me.ComboBoxPorta.FormattingEnabled = True
        Me.ComboBoxPorta.Items.AddRange(New Object() {"Selecione o Operador"})
        Me.ComboBoxPorta.Location = New System.Drawing.Point(13, 109)
        Me.ComboBoxPorta.Name = "ComboBoxPorta"
        Me.ComboBoxPorta.Size = New System.Drawing.Size(373, 36)
        Me.ComboBoxPorta.TabIndex = 10
        Me.ComboBoxPorta.Text = "Selecione a Porta"
        '
        'ButtonOperadorExcluir
        '
        Me.ButtonOperadorExcluir.BackColor = System.Drawing.Color.LightCoral
        Me.ButtonOperadorExcluir.FlatAppearance.BorderSize = 0
        Me.ButtonOperadorExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOperadorExcluir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonOperadorExcluir.Location = New System.Drawing.Point(215, 73)
        Me.ButtonOperadorExcluir.Name = "ButtonOperadorExcluir"
        Me.ButtonOperadorExcluir.Size = New System.Drawing.Size(171, 32)
        Me.ButtonOperadorExcluir.TabIndex = 9
        Me.ButtonOperadorExcluir.Text = "Excluir"
        Me.ButtonOperadorExcluir.UseVisualStyleBackColor = False
        '
        'ButtonOperadorAdicionar
        '
        Me.ButtonOperadorAdicionar.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonOperadorAdicionar.FlatAppearance.BorderSize = 0
        Me.ButtonOperadorAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOperadorAdicionar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonOperadorAdicionar.Location = New System.Drawing.Point(13, 73)
        Me.ButtonOperadorAdicionar.Name = "ButtonOperadorAdicionar"
        Me.ButtonOperadorAdicionar.Size = New System.Drawing.Size(196, 32)
        Me.ButtonOperadorAdicionar.TabIndex = 9
        Me.ButtonOperadorAdicionar.Text = "Adicionar"
        Me.ButtonOperadorAdicionar.UseVisualStyleBackColor = False
        '
        'ComboBoxOperador
        '
        Me.ComboBoxOperador.DisplayMember = "Selecione o Operador"
        Me.ComboBoxOperador.FormattingEnabled = True
        Me.ComboBoxOperador.Items.AddRange(New Object() {"Selecione o Operador"})
        Me.ComboBoxOperador.Location = New System.Drawing.Point(13, 33)
        Me.ComboBoxOperador.Name = "ComboBoxOperador"
        Me.ComboBoxOperador.Size = New System.Drawing.Size(373, 36)
        Me.ComboBoxOperador.TabIndex = 0
        Me.ComboBoxOperador.Text = "Selecione o Operador"
        '
        'Configuracoes
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(809, 436)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBoxOperador)
        Me.Controls.Add(Me.GroupBoxColeta)
        Me.Controls.Add(Me.ButtonConfiguracoesDeFabrica)
        Me.Controls.Add(Me.ButtonSalvar)
        Me.Controls.Add(Me.ButtonInicio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxNoRead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(825, 475)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(825, 475)
        Me.Name = "Configuracoes"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Configurações"
        Me.GroupBoxNoRead.ResumeLayout(False)
        Me.GroupBoxNoRead.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxColeta.ResumeLayout(False)
        Me.GroupBoxColeta.PerformLayout()
        Me.GroupBoxOperador.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelNoReadCodeRef As Label
    Friend WithEvents GroupBoxNoRead As GroupBox
    Friend WithEvents CheckBoxNoReadRecuoDeLinha As CheckBox
    Friend WithEvents CheckBoxNoReadQuebraDeLinha As CheckBox
    Friend WithEvents TextBoxNoReadCode As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxSolenoideRecuoDeLinha As CheckBox
    Friend WithEvents CheckBoxSolenoideQuebraDeLinha As CheckBox
    Friend WithEvents TextBoxSolenoideCode As TextBox
    Friend WithEvents LabelSolenoideCodeRef As Label
    Friend WithEvents ButtonConfiguracoesDeFabrica As Button
    Friend WithEvents ButtonSalvar As Button
    Friend WithEvents ButtonInicio As Button
    Friend WithEvents GroupBoxColeta As GroupBox
    Friend WithEvents CheckBoxColetaRecuoDeLinha As CheckBox
    Friend WithEvents CheckBoxColetaQuebraDeLinha As CheckBox
    Friend WithEvents GroupBoxOperador As GroupBox
    Friend WithEvents ComboBoxOperador As ComboBox
    Friend WithEvents LabelColetaPathRef As Label
    Friend WithEvents TextBoxColetaPath As TextBox
    Friend WithEvents ButtonOperadorExcluir As Button
    Friend WithEvents ButtonOperadorAdicionar As Button
    Friend WithEvents ComboBoxPorta As ComboBox

    Private Sub Configuracoes_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ConfigurationData = New ConfigurationData()
        LoadDataToWindow()
    End Sub

    Private Sub ButtonSalvar_Click(sender As Object, e As EventArgs) Handles ButtonSalvar.Click
        SendDataToConfigurations()
        ConfigurationData.SaveConfigurations()
    End Sub

    Private Sub ButtonConfiguracoes_Click(sender As Object, e As EventArgs) Handles ButtonConfiguracoesDeFabrica.Click
        ConfigurationData.DefaultFactorConfiguration()
        LoadDataToWindow()
    End Sub

    Private Sub LoadDataToWindow()
        getDefinedUser()
        getPorta()
        getColeta()
        getSolenoide()
        getNoRead()
    End Sub


    Dim ConfigurationData As ConfigurationData
    Dim SerialController As SerialController
    Private Sub getDefinedUser()
        Dim i As Integer
        ComboBoxOperador.Items.Clear()
        For i = 0 To ConfigurationData.fileData.configuration.users.Length - 1
            ComboBoxOperador.Items.Insert(i, ConfigurationData.fileData.configuration.users(i).code + " - " + ConfigurationData.fileData.configuration.users(i).name)
            If ConfigurationData.fileData.configuration.users(i).code = ConfigurationData.fileData.configuration.definedUser.code Then
                ComboBoxOperador.SelectedIndex = i
            End If
        Next
        If ComboBoxOperador.Text = "" Then
            ComboBoxOperador.Text = "Selecione o Operador"
        End If
    End Sub

    Private Sub getColeta()
        TextBoxColetaPath.Text = ConfigurationData.fileData.configuration.coleta.path
        CheckBoxColetaQuebraDeLinha.Checked = ConfigurationData.fileData.configuration.coleta.useLF
        CheckBoxColetaRecuoDeLinha.Checked = ConfigurationData.fileData.configuration.coleta.useCF
    End Sub

    Private Sub getSolenoide()
        TextBoxSolenoideCode.Text = ConfigurationData.fileData.configuration.solenoide.code
        CheckBoxSolenoideQuebraDeLinha.Checked = ConfigurationData.fileData.configuration.solenoide.useLF
        CheckBoxSolenoideRecuoDeLinha.Checked = ConfigurationData.fileData.configuration.solenoide.useCF
    End Sub

    Private Sub getNoRead()
        TextBoxNoReadCode.Text = ConfigurationData.fileData.configuration.noread.code
        CheckBoxNoReadQuebraDeLinha.Checked = ConfigurationData.fileData.configuration.noread.useLF
        CheckBoxNoReadRecuoDeLinha.Checked = ConfigurationData.fileData.configuration.noread.useCF
    End Sub

    Private Sub SendDataToConfigurations()
        setColeta()
        setSolenoide()
        setNoRead()
    End Sub

    Private Sub setColeta()
        ConfigurationData.SetColeta(TextBoxColetaPath.Text, CheckBoxColetaQuebraDeLinha.Checked, CheckBoxColetaRecuoDeLinha.Checked)
    End Sub

    Private Sub setSolenoide()
        ConfigurationData.SetSolenoide(TextBoxSolenoideCode.Text, CheckBoxSolenoideQuebraDeLinha.Checked, CheckBoxSolenoideRecuoDeLinha.Checked)
    End Sub

    Private Sub setNoRead()
        ConfigurationData.SetNoRead(TextBoxNoReadCode.Text, CheckBoxNoReadQuebraDeLinha.Checked, CheckBoxNoReadRecuoDeLinha.Checked)
    End Sub

    Private Sub ButtonOperadorAdicionar_Click(sender As Object, e As EventArgs) Handles ButtonOperadorAdicionar.Click
        Dim userName As String
        Dim userCode As String

        userName = InputBox("Qual o nome do NOVO Operdaor?", "Adicionar", "")
        If userName = "" Then
            MsgBox("Operação Abortada!", 0, "Aviso")
            Exit Sub
        End If

        userCode = InputBox("Qual o código do NOVO Operdaor?", "Adicionar", "")
        If userCode = "" Then
            MsgBox("Operação Abortada!", 0, "Aviso")
            Exit Sub
        End If

        If ConfigurationData.AddUser(userCode, userName) = -1 Then
            MsgBox("Usuario Adicionado!!", 0, "Sucesso")
            getDefinedUser()
        End If

    End Sub

    Private Sub ButtonOperadorExcluir_Click(sender As Object, e As EventArgs) Handles ButtonOperadorExcluir.Click
        Dim userName As String
        Dim userCode As String
        Dim palavras() As String

        palavras = ComboBoxOperador.Text.Split(" - ")
        userName = palavras(1)
        userCode = palavras(0)

        If ConfigurationData.DelUser(userCode) = -1 Then
            MsgBox("Usuario Inexistente!!", 0, "Erro")
        Else
            MsgBox("Usuario Excluido!!", 0, "Sucesso")
            getDefinedUser()
        End If
    End Sub

    Private Sub ComboBoxOperador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOperador.SelectedIndexChanged
        setDefinedUser()
    End Sub

    Private Sub setDefinedUser()
        Dim userName As String
        Dim userCode As String
        Dim palavras() As String

        palavras = ComboBoxOperador.Text.Split(" - ")
        If (palavras.Length > 1) Then
            userName = palavras(1)
            userCode = palavras(0)

            ConfigurationData.SetDefinedUser(userCode, userName)
        End If
    End Sub

    Private Sub ButtonInicio_Click(sender As Object, e As EventArgs) Handles ButtonInicio.Click
        Me.Close()
    End Sub

    Private Sub Configuracoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialController = New SerialController()
        Dim lista() As String
        lista = SerialController.ListSerialPorts()
        Dim Port As String

        For Each Port In lista
            ComboBoxPorta.Items.Add(Port)
        Next Port
    End Sub

    Private Sub getPorta()
        ComboBoxPorta.Text = ConfigurationData.fileData.configuration.porta
    End Sub

    Private Sub ComboBoxPorta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPorta.SelectedIndexChanged
        ConfigurationData.SetPorta(ComboBoxPorta.Text)
    End Sub
End Class
