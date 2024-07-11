<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBullet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblBULLET = New Label()
        nudLI = New NumericUpDown()
        nudBI = New NumericUpDown()
        nudRI = New NumericUpDown()
        lblTEXT = New Label()
        CType(nudLI, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudBI, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudRI, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblBULLET
        ' 
        lblBULLET.AutoSize = True
        lblBULLET.BackColor = Color.Transparent
        lblBULLET.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblBULLET.ForeColor = Color.Navy
        lblBULLET.Location = New Point(80, 16)
        lblBULLET.Name = "lblBULLET"
        lblBULLET.Size = New Size(20, 17)
        lblBULLET.TabIndex = 46
        lblBULLET.Text = "☻"
        ' 
        ' nudLI
        ' 
        nudLI.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudLI.Location = New Point(8, 14)
        nudLI.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        nudLI.Name = "nudLI"
        nudLI.Size = New Size(56, 24)
        nudLI.TabIndex = 45
        ' 
        ' nudBI
        ' 
        nudBI.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudBI.Location = New Point(112, 14)
        nudBI.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        nudBI.Name = "nudBI"
        nudBI.Size = New Size(56, 24)
        nudBI.TabIndex = 47
        ' 
        ' nudRI
        ' 
        nudRI.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudRI.Location = New Point(240, 14)
        nudRI.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        nudRI.Name = "nudRI"
        nudRI.Size = New Size(56, 24)
        nudRI.TabIndex = 48
        ' 
        ' lblTEXT
        ' 
        lblTEXT.AutoSize = True
        lblTEXT.BackColor = Color.Transparent
        lblTEXT.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTEXT.ForeColor = Color.Navy
        lblTEXT.Location = New Point(184, 16)
        lblTEXT.Name = "lblTEXT"
        lblTEXT.Size = New Size(46, 17)
        lblTEXT.TabIndex = 49
        lblTEXT.Text = "text..."
        ' 
        ' FrmBullet
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(314, 51)
        Controls.Add(lblTEXT)
        Controls.Add(nudRI)
        Controls.Add(nudBI)
        Controls.Add(lblBULLET)
        Controls.Add(nudLI)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmBullet"
        Text = "Change indents for bullet list"
        TopMost = True
        CType(nudLI, ComponentModel.ISupportInitialize).EndInit()
        CType(nudBI, ComponentModel.ISupportInitialize).EndInit()
        CType(nudRI, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblBULLET As Label
    Friend WithEvents nudLI As NumericUpDown
    Friend WithEvents nudBI As NumericUpDown
    Friend WithEvents nudRI As NumericUpDown
    Friend WithEvents lblTEXT As Label
End Class
