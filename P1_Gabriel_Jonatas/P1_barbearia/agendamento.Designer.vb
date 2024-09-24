<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agendamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agendamento))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_gravar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_valor = New System.Windows.Forms.ComboBox()
        Me.txt_idade = New System.Windows.Forms.TextBox()
        Me.cmb_corte = New System.Windows.Forms.ComboBox()
        Me.cmb_barbeiro = New System.Windows.Forms.ComboBox()
        Me.data_time_hora = New System.Windows.Forms.DateTimePicker()
        Me.cmb_data = New System.Windows.Forms.DateTimePicker()
        Me.txt_fone = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.img_cliente = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.img_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_gravar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_gravar
        '
        Me.btn_gravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_gravar.Image = CType(resources.GetObject("btn_gravar.Image"), System.Drawing.Image)
        Me.btn_gravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(23, 22)
        Me.btn_gravar.Text = "ToolStripButton1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_valor)
        Me.GroupBox1.Controls.Add(Me.txt_idade)
        Me.GroupBox1.Controls.Add(Me.cmb_corte)
        Me.GroupBox1.Controls.Add(Me.cmb_barbeiro)
        Me.GroupBox1.Controls.Add(Me.data_time_hora)
        Me.GroupBox1.Controls.Add(Me.cmb_data)
        Me.GroupBox1.Controls.Add(Me.txt_fone)
        Me.GroupBox1.Controls.Add(Me.txt_nome)
        Me.GroupBox1.Controls.Add(Me.img_cliente)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 409)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AGENDAMENTO"
        '
        'cmb_valor
        '
        Me.cmb_valor.FormattingEnabled = True
        Me.cmb_valor.Location = New System.Drawing.Point(278, 286)
        Me.cmb_valor.Name = "cmb_valor"
        Me.cmb_valor.Size = New System.Drawing.Size(121, 24)
        Me.cmb_valor.TabIndex = 16
        '
        'txt_idade
        '
        Me.txt_idade.Location = New System.Drawing.Point(9, 201)
        Me.txt_idade.Name = "txt_idade"
        Me.txt_idade.Size = New System.Drawing.Size(100, 22)
        Me.txt_idade.TabIndex = 15
        '
        'cmb_corte
        '
        Me.cmb_corte.FormattingEnabled = True
        Me.cmb_corte.Location = New System.Drawing.Point(9, 286)
        Me.cmb_corte.Name = "cmb_corte"
        Me.cmb_corte.Size = New System.Drawing.Size(121, 24)
        Me.cmb_corte.TabIndex = 14
        '
        'cmb_barbeiro
        '
        Me.cmb_barbeiro.FormattingEnabled = True
        Me.cmb_barbeiro.Location = New System.Drawing.Point(278, 201)
        Me.cmb_barbeiro.Name = "cmb_barbeiro"
        Me.cmb_barbeiro.Size = New System.Drawing.Size(121, 24)
        Me.cmb_barbeiro.TabIndex = 13
        '
        'data_time_hora
        '
        Me.data_time_hora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.data_time_hora.Location = New System.Drawing.Point(278, 119)
        Me.data_time_hora.Name = "data_time_hora"
        Me.data_time_hora.Size = New System.Drawing.Size(76, 22)
        Me.data_time_hora.TabIndex = 12
        '
        'cmb_data
        '
        Me.cmb_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data.Location = New System.Drawing.Point(9, 119)
        Me.cmb_data.Name = "cmb_data"
        Me.cmb_data.Size = New System.Drawing.Size(147, 22)
        Me.cmb_data.TabIndex = 11
        '
        'txt_fone
        '
        Me.txt_fone.Location = New System.Drawing.Point(471, 55)
        Me.txt_fone.Mask = "+55 (99) 99999-9999"
        Me.txt_fone.Name = "txt_fone"
        Me.txt_fone.Size = New System.Drawing.Size(142, 22)
        Me.txt_fone.TabIndex = 10
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(9, 55)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(435, 22)
        Me.txt_nome.TabIndex = 9
        '
        'img_cliente
        '
        Me.img_cliente.Image = CType(resources.GetObject("img_cliente.Image"), System.Drawing.Image)
        Me.img_cliente.Location = New System.Drawing.Point(619, 35)
        Me.img_cliente.Name = "img_cliente"
        Me.img_cliente.Size = New System.Drawing.Size(150, 180)
        Me.img_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_cliente.TabIndex = 8
        Me.img_cliente.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(275, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Preço"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tipo de atendimento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(275, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Barbeiro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Idade do cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(275, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Horário"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data de atendimento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(468, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contato"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'agendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "agendamento"
        Me.Text = "Agendamento"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.img_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_gravar As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents img_cliente As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents data_time_hora As DateTimePicker
    Friend WithEvents cmb_data As DateTimePicker
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_idade As TextBox
    Friend WithEvents cmb_corte As ComboBox
    Friend WithEvents cmb_barbeiro As ComboBox
    Friend WithEvents cmb_valor As ComboBox
End Class
