<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRelatorio
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.ComboBoxOperador = New System.Windows.Forms.ComboBox()
        Me.LabelCode = New System.Windows.Forms.Label()
        Me.TextBoxCode = New System.Windows.Forms.TextBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.LabelOperador = New System.Windows.Forms.Label()
        Me.LabelCodigoRef = New System.Windows.Forms.Label()
        Me.ButtonInicio = New System.Windows.Forms.Button()
        Me.ButtonPesquisar = New System.Windows.Forms.Button()
        Me.DataGridViewRelatorio = New System.Windows.Forms.DataGridView()
        Me.SEQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPERADOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewRelatorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ComboBoxStatus)
        Me.GroupBox1.Controls.Add(Me.ComboBoxOperador)
        Me.GroupBox1.Controls.Add(Me.LabelCode)
        Me.GroupBox1.Controls.Add(Me.TextBoxCode)
        Me.GroupBox1.Controls.Add(Me.LabelStatus)
        Me.GroupBox1.Controls.Add(Me.LabelOperador)
        Me.GroupBox1.Controls.Add(Me.LabelCodigoRef)
        Me.GroupBox1.Location = New System.Drawing.Point(368, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(467, 246)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxStatus.FormattingEnabled = True
        Me.ComboBoxStatus.Items.AddRange(New Object() {"TODOS", "MANUAL", "AUTOMATICO", "PENDENTE"})
        Me.ComboBoxStatus.Location = New System.Drawing.Point(134, 128)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(325, 38)
        Me.ComboBoxStatus.TabIndex = 15
        Me.ComboBoxStatus.Text = "TODOS"
        '
        'ComboBoxOperador
        '
        Me.ComboBoxOperador.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBoxOperador.FormattingEnabled = True
        Me.ComboBoxOperador.Items.AddRange(New Object() {"TODOS"})
        Me.ComboBoxOperador.Location = New System.Drawing.Point(134, 84)
        Me.ComboBoxOperador.Name = "ComboBoxOperador"
        Me.ComboBoxOperador.Size = New System.Drawing.Size(325, 38)
        Me.ComboBoxOperador.TabIndex = 14
        Me.ComboBoxOperador.Text = "TODOS"
        '
        'LabelCode
        '
        Me.LabelCode.AutoSize = True
        Me.LabelCode.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelCode.Location = New System.Drawing.Point(6, 175)
        Me.LabelCode.Name = "LabelCode"
        Me.LabelCode.Size = New System.Drawing.Size(74, 31)
        Me.LabelCode.TabIndex = 13
        Me.LabelCode.Text = "Code:"
        '
        'TextBoxCode
        '
        Me.TextBoxCode.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxCode.Location = New System.Drawing.Point(134, 172)
        Me.TextBoxCode.Name = "TextBoxCode"
        Me.TextBoxCode.Size = New System.Drawing.Size(325, 38)
        Me.TextBoxCode.TabIndex = 12
        Me.TextBoxCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelStatus.Location = New System.Drawing.Point(6, 130)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(86, 31)
        Me.LabelStatus.TabIndex = 11
        Me.LabelStatus.Text = "Status:"
        '
        'LabelOperador
        '
        Me.LabelOperador.AutoSize = True
        Me.LabelOperador.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelOperador.Location = New System.Drawing.Point(6, 87)
        Me.LabelOperador.Name = "LabelOperador"
        Me.LabelOperador.Size = New System.Drawing.Size(122, 31)
        Me.LabelOperador.TabIndex = 9
        Me.LabelOperador.Text = "Operador:"
        '
        'LabelCodigoRef
        '
        Me.LabelCodigoRef.AutoSize = True
        Me.LabelCodigoRef.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelCodigoRef.Location = New System.Drawing.Point(186, 19)
        Me.LabelCodigoRef.Name = "LabelCodigoRef"
        Me.LabelCodigoRef.Size = New System.Drawing.Size(106, 31)
        Me.LabelCodigoRef.TabIndex = 7
        Me.LabelCodigoRef.Text = "Pesquisa"
        '
        'ButtonInicio
        '
        Me.ButtonInicio.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonInicio.FlatAppearance.BorderSize = 0
        Me.ButtonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInicio.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonInicio.Location = New System.Drawing.Point(12, 142)
        Me.ButtonInicio.Name = "ButtonInicio"
        Me.ButtonInicio.Size = New System.Drawing.Size(350, 116)
        Me.ButtonInicio.TabIndex = 10
        Me.ButtonInicio.Text = "Inicio"
        Me.ButtonInicio.UseVisualStyleBackColor = False
        '
        'ButtonPesquisar
        '
        Me.ButtonPesquisar.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonPesquisar.FlatAppearance.BorderSize = 0
        Me.ButtonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPesquisar.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonPesquisar.Location = New System.Drawing.Point(12, 12)
        Me.ButtonPesquisar.Name = "ButtonPesquisar"
        Me.ButtonPesquisar.Size = New System.Drawing.Size(350, 120)
        Me.ButtonPesquisar.TabIndex = 9
        Me.ButtonPesquisar.Text = "Pesquisar"
        Me.ButtonPesquisar.UseVisualStyleBackColor = False
        '
        'DataGridViewRelatorio
        '
        Me.DataGridViewRelatorio.AllowUserToOrderColumns = True
        Me.DataGridViewRelatorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRelatorio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SEQ, Me.CODE, Me.STATUS, Me.OPERADOR})
        Me.DataGridViewRelatorio.Location = New System.Drawing.Point(12, 264)
        Me.DataGridViewRelatorio.Name = "DataGridViewRelatorio"
        Me.DataGridViewRelatorio.ReadOnly = True
        Me.DataGridViewRelatorio.RowTemplate.Height = 25
        Me.DataGridViewRelatorio.Size = New System.Drawing.Size(823, 268)
        Me.DataGridViewRelatorio.TabIndex = 12
        '
        'SEQ
        '
        Me.SEQ.FillWeight = 60.9137!
        Me.SEQ.HeaderText = "SEQ"
        Me.SEQ.Name = "SEQ"
        Me.SEQ.ReadOnly = True
        '
        'CODE
        '
        Me.CODE.FillWeight = 113.0288!
        Me.CODE.HeaderText = "CODE"
        Me.CODE.Name = "CODE"
        Me.CODE.ReadOnly = True
        '
        'STATUS
        '
        Me.STATUS.FillWeight = 113.0288!
        Me.STATUS.HeaderText = "STATUS"
        Me.STATUS.Name = "STATUS"
        Me.STATUS.ReadOnly = True
        '
        'OPERADOR
        '
        Me.OPERADOR.FillWeight = 113.0288!
        Me.OPERADOR.HeaderText = "OPERADOR"
        Me.OPERADOR.Name = "OPERADOR"
        Me.OPERADOR.ReadOnly = True
        '
        'FormRelatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 537)
        Me.Controls.Add(Me.DataGridViewRelatorio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonInicio)
        Me.Controls.Add(Me.ButtonPesquisar)
        Me.Name = "FormRelatorio"
        Me.Text = "Relatório"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewRelatorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelCodigoRef As Label
    Friend WithEvents ButtonInicio As Button
    Friend WithEvents ButtonPesquisar As Button
    Friend WithEvents DataGridViewRelatorio As DataGridView
    Friend WithEvents LabelCode As Label
    Friend WithEvents TextBoxCode As TextBox
    Friend WithEvents LabelStatus As Label
    Friend WithEvents LabelOperador As Label
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents ComboBoxOperador As ComboBox
    Friend WithEvents SEQ As DataGridViewTextBoxColumn
    Friend WithEvents CODE As DataGridViewTextBoxColumn
    Friend WithEvents STATUS As DataGridViewTextBoxColumn
    Friend WithEvents OPERADOR As DataGridViewTextBoxColumn
End Class
