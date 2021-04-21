<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ColetaManual
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
        Me.ButtonColetar = New System.Windows.Forms.Button()
        Me.ButtonInicio = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelColetaInfo = New System.Windows.Forms.Label()
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox()
        Me.LabelCodigoRef = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonColetar
        '
        Me.ButtonColetar.BackColor = System.Drawing.Color.PaleGreen
        Me.ButtonColetar.FlatAppearance.BorderSize = 0
        Me.ButtonColetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonColetar.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonColetar.Location = New System.Drawing.Point(12, 12)
        Me.ButtonColetar.Name = "ButtonColetar"
        Me.ButtonColetar.Size = New System.Drawing.Size(350, 120)
        Me.ButtonColetar.TabIndex = 5
        Me.ButtonColetar.Text = "Coletar"
        Me.ButtonColetar.UseVisualStyleBackColor = False
        '
        'ButtonInicio
        '
        Me.ButtonInicio.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ButtonInicio.FlatAppearance.BorderSize = 0
        Me.ButtonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInicio.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonInicio.Location = New System.Drawing.Point(12, 138)
        Me.ButtonInicio.Name = "ButtonInicio"
        Me.ButtonInicio.Size = New System.Drawing.Size(350, 120)
        Me.ButtonInicio.TabIndex = 6
        Me.ButtonInicio.Text = "Inicio"
        Me.ButtonInicio.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(449, 436)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.LabelColetaInfo)
        Me.GroupBox1.Controls.Add(Me.TextBoxCodigo)
        Me.GroupBox1.Controls.Add(Me.LabelCodigoRef)
        Me.GroupBox1.Location = New System.Drawing.Point(368, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 247)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'LabelColetaInfo
        '
        Me.LabelColetaInfo.BackColor = System.Drawing.Color.Gainsboro
        Me.LabelColetaInfo.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelColetaInfo.Location = New System.Drawing.Point(17, 102)
        Me.LabelColetaInfo.Name = "LabelColetaInfo"
        Me.LabelColetaInfo.Size = New System.Drawing.Size(430, 125)
        Me.LabelColetaInfo.TabIndex = 9
        Me.LabelColetaInfo.Text = "...Aguardando..."
        Me.LabelColetaInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxCodigo.Location = New System.Drawing.Point(17, 53)
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.Size = New System.Drawing.Size(430, 38)
        Me.TextBoxCodigo.TabIndex = 8
        Me.TextBoxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelCodigoRef
        '
        Me.LabelCodigoRef.AutoSize = True
        Me.LabelCodigoRef.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelCodigoRef.Location = New System.Drawing.Point(186, 19)
        Me.LabelCodigoRef.Name = "LabelCodigoRef"
        Me.LabelCodigoRef.Size = New System.Drawing.Size(91, 31)
        Me.LabelCodigoRef.TabIndex = 7
        Me.LabelCodigoRef.Text = "Código"
        '
        'ColetaManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 271)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtonInicio)
        Me.Controls.Add(Me.ButtonColetar)
        Me.Name = "ColetaManual"
        Me.Text = "Coleta Manual"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonColetar As Button
    Friend WithEvents ButtonInicio As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxCodigo As TextBox
    Friend WithEvents LabelCodigoRef As Label
    Friend WithEvents LabelColetaInfo As Label
End Class
