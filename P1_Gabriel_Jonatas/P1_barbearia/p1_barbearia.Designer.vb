﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barbearia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Barbearia))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AGENDAMENTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMINISTRADORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLIENTEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CLIENTEToolStripMenuItem
        '
        Me.CLIENTEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AGENDAMENTOToolStripMenuItem, Me.ADMINISTRADORToolStripMenuItem})
        Me.CLIENTEToolStripMenuItem.Image = CType(resources.GetObject("CLIENTEToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CLIENTEToolStripMenuItem.Name = "CLIENTEToolStripMenuItem"
        Me.CLIENTEToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.CLIENTEToolStripMenuItem.Text = "DIRON CORT'S"
        '
        'AGENDAMENTOToolStripMenuItem
        '
        Me.AGENDAMENTOToolStripMenuItem.Image = CType(resources.GetObject("AGENDAMENTOToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AGENDAMENTOToolStripMenuItem.Name = "AGENDAMENTOToolStripMenuItem"
        Me.AGENDAMENTOToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AGENDAMENTOToolStripMenuItem.Text = "AGENDAMENTO"
        '
        'ADMINISTRADORToolStripMenuItem
        '
        Me.ADMINISTRADORToolStripMenuItem.Image = CType(resources.GetObject("ADMINISTRADORToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ADMINISTRADORToolStripMenuItem.Name = "ADMINISTRADORToolStripMenuItem"
        Me.ADMINISTRADORToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ADMINISTRADORToolStripMenuItem.Text = "ADMINISTRADOR"
        '
        'Barbearia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Barbearia"
        Me.Text = "BARBEARIA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CLIENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AGENDAMENTOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADMINISTRADORToolStripMenuItem As ToolStripMenuItem
End Class
