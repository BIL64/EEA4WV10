<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLineSpace
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
        nudSPACE = New NumericUpDown()
        lblSPACE = New Label()
        btnRESET = New Button()
        CType(nudSPACE, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' nudSPACE
        ' 
        nudSPACE.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudSPACE.Location = New Point(16, 32)
        nudSPACE.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        nudSPACE.Minimum = New Decimal(New Integer() {100000, 0, 0, Integer.MinValue})
        nudSPACE.Name = "nudSPACE"
        nudSPACE.Size = New Size(56, 24)
        nudSPACE.TabIndex = 0
        ' 
        ' lblSPACE
        ' 
        lblSPACE.AutoSize = True
        lblSPACE.BackColor = Color.Transparent
        lblSPACE.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblSPACE.ForeColor = Color.Navy
        lblSPACE.Location = New Point(16, 8)
        lblSPACE.Name = "lblSPACE"
        lblSPACE.Size = New Size(64, 17)
        lblSPACE.TabIndex = 44
        lblSPACE.Text = "New value"
        ' 
        ' btnRESET
        ' 
        btnRESET.BackColor = Color.White
        btnRESET.Cursor = Cursors.Hand
        btnRESET.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnRESET.ForeColor = Color.Navy
        btnRESET.Location = New Point(104, 32)
        btnRESET.Margin = New Padding(3, 0, 3, 3)
        btnRESET.Name = "btnRESET"
        btnRESET.Size = New Size(48, 20)
        btnRESET.TabIndex = 48
        btnRESET.Text = "RESET"
        btnRESET.TextAlign = ContentAlignment.TopCenter
        btnRESET.UseVisualStyleBackColor = False
        ' 
        ' FrmLineSpace
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(164, 71)
        Controls.Add(btnRESET)
        Controls.Add(lblSPACE)
        Controls.Add(nudSPACE)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmLineSpace"
        Text = "Change V alignment"
        TopMost = True
        CType(nudSPACE, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents nudSPACE As NumericUpDown
    Friend WithEvents lblSPACE As Label
    Friend WithEvents btnRESET As Button
End Class
