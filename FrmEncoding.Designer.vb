<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEncoding
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
        rbECAUTO = New RadioButton()
        rbECANSI = New RadioButton()
        rbECASCII = New RadioButton()
        rbECUTF7 = New RadioButton()
        rbECUTF8 = New RadioButton()
        rbECUTF16 = New RadioButton()
        rbECUTF32 = New RadioButton()
        rbECUNICODE = New RadioButton()
        rbECLATIN = New RadioButton()
        cbENCODESAVE = New CheckBox()
        SuspendLayout()
        ' 
        ' rbECAUTO
        ' 
        rbECAUTO.AutoSize = True
        rbECAUTO.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        rbECAUTO.ForeColor = Color.Navy
        rbECAUTO.Location = New Point(12, 12)
        rbECAUTO.Name = "rbECAUTO"
        rbECAUTO.Size = New Size(106, 21)
        rbECAUTO.TabIndex = 63
        rbECAUTO.TabStop = True
        rbECAUTO.Text = "Auto (default)"
        rbECAUTO.UseVisualStyleBackColor = True
        ' 
        ' rbECANSI
        ' 
        rbECANSI.AutoSize = True
        rbECANSI.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        rbECANSI.ForeColor = Color.Navy
        rbECANSI.Location = New Point(12, 39)
        rbECANSI.Name = "rbECANSI"
        rbECANSI.Size = New Size(51, 21)
        rbECANSI.TabIndex = 64
        rbECANSI.TabStop = True
        rbECANSI.Text = "ANSI"
        rbECANSI.UseVisualStyleBackColor = True
        ' 
        ' rbECASCII
        ' 
        rbECASCII.AutoSize = True
        rbECASCII.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        rbECASCII.ForeColor = Color.Navy
        rbECASCII.Location = New Point(12, 66)
        rbECASCII.Name = "rbECASCII"
        rbECASCII.Size = New Size(53, 21)
        rbECASCII.TabIndex = 65
        rbECASCII.TabStop = True
        rbECASCII.Text = "ASCII"
        rbECASCII.UseVisualStyleBackColor = True
        ' 
        ' rbECUTF7
        ' 
        rbECUTF7.AutoSize = True
        rbECUTF7.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        rbECUTF7.ForeColor = Color.Navy
        rbECUTF7.Location = New Point(12, 93)
        rbECUTF7.Name = "rbECUTF7"
        rbECUTF7.Size = New Size(61, 21)
        rbECUTF7.TabIndex = 66
        rbECUTF7.TabStop = True
        rbECUTF7.Text = "UTF-7"
        rbECUTF7.UseVisualStyleBackColor = True
        ' 
        ' rbECUTF8
        ' 
        rbECUTF8.AutoSize = True
        rbECUTF8.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        rbECUTF8.ForeColor = Color.Navy
        rbECUTF8.Location = New Point(12, 120)
        rbECUTF8.Name = "rbECUTF8"
        rbECUTF8.Size = New Size(63, 21)
        rbECUTF8.TabIndex = 67
        rbECUTF8.TabStop = True
        rbECUTF8.Text = "UTF-8"
        rbECUTF8.UseVisualStyleBackColor = True
        ' 
        ' rbECUTF16
        ' 
        rbECUTF16.AutoSize = True
        rbECUTF16.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        rbECUTF16.ForeColor = Color.Navy
        rbECUTF16.Location = New Point(12, 147)
        rbECUTF16.Name = "rbECUTF16"
        rbECUTF16.Size = New Size(137, 21)
        rbECUTF16.TabIndex = 68
        rbECUTF16.TabStop = True
        rbECUTF16.Text = "UTF-16 (Big Endian)"
        rbECUTF16.UseVisualStyleBackColor = True
        ' 
        ' rbECUTF32
        ' 
        rbECUTF32.AutoSize = True
        rbECUTF32.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        rbECUTF32.ForeColor = Color.Navy
        rbECUTF32.Location = New Point(12, 174)
        rbECUTF32.Name = "rbECUTF32"
        rbECUTF32.Size = New Size(71, 21)
        rbECUTF32.TabIndex = 69
        rbECUTF32.TabStop = True
        rbECUTF32.Text = "UTF-32"
        rbECUTF32.UseVisualStyleBackColor = True
        ' 
        ' rbECUNICODE
        ' 
        rbECUNICODE.AutoSize = True
        rbECUNICODE.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        rbECUNICODE.ForeColor = Color.Navy
        rbECUNICODE.Location = New Point(12, 201)
        rbECUNICODE.Name = "rbECUNICODE"
        rbECUNICODE.Size = New Size(68, 21)
        rbECUNICODE.TabIndex = 70
        rbECUNICODE.TabStop = True
        rbECUNICODE.Text = "Unicode"
        rbECUNICODE.UseVisualStyleBackColor = True
        ' 
        ' rbECLATIN
        ' 
        rbECLATIN.AutoSize = True
        rbECLATIN.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        rbECLATIN.ForeColor = Color.Navy
        rbECLATIN.Location = New Point(12, 228)
        rbECLATIN.Name = "rbECLATIN"
        rbECLATIN.Size = New Size(53, 21)
        rbECLATIN.TabIndex = 71
        rbECLATIN.TabStop = True
        rbECLATIN.Text = "Latin"
        rbECLATIN.UseVisualStyleBackColor = True
        ' 
        ' cbENCODESAVE
        ' 
        cbENCODESAVE.AutoSize = True
        cbENCODESAVE.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cbENCODESAVE.ForeColor = Color.Navy
        cbENCODESAVE.Location = New Point(12, 267)
        cbENCODESAVE.Name = "cbENCODESAVE"
        cbENCODESAVE.Size = New Size(163, 21)
        cbENCODESAVE.TabIndex = 72
        cbENCODESAVE.Text = "Save file as selected type"
        cbENCODESAVE.UseVisualStyleBackColor = True
        ' 
        ' FrmEncoding
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(209, 296)
        Controls.Add(cbENCODESAVE)
        Controls.Add(rbECLATIN)
        Controls.Add(rbECUNICODE)
        Controls.Add(rbECUTF32)
        Controls.Add(rbECUTF16)
        Controls.Add(rbECUTF8)
        Controls.Add(rbECUTF7)
        Controls.Add(rbECASCII)
        Controls.Add(rbECANSI)
        Controls.Add(rbECAUTO)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmEncoding"
        Text = "Select text file encoding type"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rbECAUTO As RadioButton
    Friend WithEvents rbECANSI As RadioButton
    Friend WithEvents rbECASCII As RadioButton
    Friend WithEvents rbECUTF7 As RadioButton
    Friend WithEvents rbECUTF8 As RadioButton
    Friend WithEvents rbECUTF16 As RadioButton
    Friend WithEvents rbECUTF32 As RadioButton
    Friend WithEvents rbECUNICODE As RadioButton
    Friend WithEvents rbECLATIN As RadioButton
    Friend WithEvents cbENCODESAVE As CheckBox
End Class
