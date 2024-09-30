<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWordLang
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
        lblSELLANG = New Label()
        combLANGUAGE = New ComboBox()
        btnAPPLY = New Button()
        SuspendLayout()
        ' 
        ' lblSELLANG
        ' 
        lblSELLANG.AutoSize = True
        lblSELLANG.BackColor = Color.Transparent
        lblSELLANG.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblSELLANG.ForeColor = Color.Navy
        lblSELLANG.Location = New Point(12, 13)
        lblSELLANG.Name = "lblSELLANG"
        lblSELLANG.Size = New Size(95, 17)
        lblSELLANG.TabIndex = 67
        lblSELLANG.Text = "Select language:"
        ' 
        ' combLANGUAGE
        ' 
        combLANGUAGE.FormattingEnabled = True
        combLANGUAGE.Location = New Point(113, 11)
        combLANGUAGE.Name = "combLANGUAGE"
        combLANGUAGE.Size = New Size(250, 23)
        combLANGUAGE.TabIndex = 71
        ' 
        ' btnAPPLY
        ' 
        btnAPPLY.BackColor = Color.White
        btnAPPLY.Cursor = Cursors.Hand
        btnAPPLY.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAPPLY.ForeColor = Color.Navy
        btnAPPLY.Location = New Point(12, 35)
        btnAPPLY.Margin = New Padding(3, 0, 3, 3)
        btnAPPLY.Name = "btnAPPLY"
        btnAPPLY.Size = New Size(50, 20)
        btnAPPLY.TabIndex = 72
        btnAPPLY.Text = "APPLY"
        btnAPPLY.TextAlign = ContentAlignment.TopCenter
        btnAPPLY.UseVisualStyleBackColor = False
        ' 
        ' FrmWordLang
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 61)
        Controls.Add(btnAPPLY)
        Controls.Add(combLANGUAGE)
        Controls.Add(lblSELLANG)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmWordLang"
        Text = "Simple spell check through MS Word"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblSELLANG As Label
    Friend WithEvents combLANGUAGE As ComboBox
    Friend WithEvents btnAPPLY As Button
End Class
