<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListStyle
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
        cbCAP = New CheckBox()
        lblPSIGN = New Label()
        tbPSIGN = New TextBox()
        rbNUMB = New RadioButton()
        rbLETT = New RadioButton()
        rbROM = New RadioButton()
        cbZERO = New CheckBox()
        btnSAVE = New Button()
        cb10 = New CheckBox()
        cb100 = New CheckBox()
        lblINFO1 = New Label()
        lblINFO2 = New Label()
        SuspendLayout()
        ' 
        ' cbCAP
        ' 
        cbCAP.AutoSize = True
        cbCAP.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cbCAP.ForeColor = SystemColors.ControlDarkDark
        cbCAP.Location = New Point(135, 47)
        cbCAP.Name = "cbCAP"
        cbCAP.Size = New Size(69, 21)
        cbCAP.TabIndex = 58
        cbCAP.Text = "Capitals"
        cbCAP.UseVisualStyleBackColor = True
        ' 
        ' lblPSIGN
        ' 
        lblPSIGN.AutoSize = True
        lblPSIGN.BackColor = Color.Transparent
        lblPSIGN.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblPSIGN.ForeColor = Color.Navy
        lblPSIGN.Location = New Point(197, 80)
        lblPSIGN.Name = "lblPSIGN"
        lblPSIGN.Size = New Size(71, 17)
        lblPSIGN.TabIndex = 59
        lblPSIGN.Text = "Period sign:"
        ' 
        ' tbPSIGN
        ' 
        tbPSIGN.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        tbPSIGN.Location = New Point(272, 78)
        tbPSIGN.MaxLength = 1
        tbPSIGN.Name = "tbPSIGN"
        tbPSIGN.Size = New Size(30, 23)
        tbPSIGN.TabIndex = 60
        ' 
        ' rbNUMB
        ' 
        rbNUMB.AutoSize = True
        rbNUMB.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        rbNUMB.ForeColor = Color.Peru
        rbNUMB.Location = New Point(18, 19)
        rbNUMB.Name = "rbNUMB"
        rbNUMB.Size = New Size(74, 21)
        rbNUMB.TabIndex = 61
        rbNUMB.TabStop = True
        rbNUMB.Text = "Numbers"
        rbNUMB.UseVisualStyleBackColor = True
        ' 
        ' rbLETT
        ' 
        rbLETT.AutoSize = True
        rbLETT.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        rbLETT.ForeColor = SystemColors.ControlDarkDark
        rbLETT.Location = New Point(18, 47)
        rbLETT.Name = "rbLETT"
        rbLETT.Size = New Size(65, 21)
        rbLETT.TabIndex = 62
        rbLETT.TabStop = True
        rbLETT.Text = "Letters"
        rbLETT.UseVisualStyleBackColor = True
        ' 
        ' rbROM
        ' 
        rbROM.AutoSize = True
        rbROM.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        rbROM.ForeColor = SystemColors.ControlDarkDark
        rbROM.Location = New Point(18, 75)
        rbROM.Name = "rbROM"
        rbROM.Size = New Size(103, 21)
        rbROM.TabIndex = 63
        rbROM.TabStop = True
        rbROM.Text = "Roman letters"
        rbROM.UseVisualStyleBackColor = True
        ' 
        ' cbZERO
        ' 
        cbZERO.AutoSize = True
        cbZERO.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cbZERO.ForeColor = Color.Peru
        cbZERO.Location = New Point(248, 47)
        cbZERO.Name = "cbZERO"
        cbZERO.Size = New Size(95, 21)
        cbZERO.TabIndex = 64
        cbZERO.Text = "Start at zero"
        cbZERO.UseVisualStyleBackColor = True
        ' 
        ' btnSAVE
        ' 
        btnSAVE.BackColor = Color.White
        btnSAVE.Cursor = Cursors.Hand
        btnSAVE.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSAVE.ForeColor = Color.Navy
        btnSAVE.Location = New Point(312, 80)
        btnSAVE.Margin = New Padding(3, 0, 3, 3)
        btnSAVE.Name = "btnSAVE"
        btnSAVE.Size = New Size(48, 20)
        btnSAVE.TabIndex = 65
        btnSAVE.Text = "SAVE"
        btnSAVE.TextAlign = ContentAlignment.TopCenter
        btnSAVE.UseVisualStyleBackColor = False
        ' 
        ' cb10
        ' 
        cb10.AutoSize = True
        cb10.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cb10.ForeColor = Color.Peru
        cb10.Location = New Point(135, 19)
        cb10.Name = "cb10"
        cb10.Size = New Size(92, 21)
        cb10.TabIndex = 68
        cb10.Text = "Fill under 10"
        cb10.UseVisualStyleBackColor = True
        ' 
        ' cb100
        ' 
        cb100.AutoSize = True
        cb100.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cb100.ForeColor = Color.Peru
        cb100.Location = New Point(248, 19)
        cb100.Name = "cb100"
        cb100.Size = New Size(101, 21)
        cb100.TabIndex = 69
        cb100.Text = "Fill under 100"
        cb100.UseVisualStyleBackColor = True
        ' 
        ' lblINFO1
        ' 
        lblINFO1.AutoSize = True
        lblINFO1.BackColor = Color.Transparent
        lblINFO1.Font = New Font("SF Electrotome", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        lblINFO1.ForeColor = SystemColors.InfoText
        lblINFO1.Location = New Point(12, 111)
        lblINFO1.Name = "lblINFO1"
        lblINFO1.Size = New Size(352, 17)
        lblINFO1.TabIndex = 70
        lblINFO1.Text = "Sometimes you have to restyle the list yourself if the formatting"
        ' 
        ' lblINFO2
        ' 
        lblINFO2.AutoSize = True
        lblINFO2.BackColor = Color.Transparent
        lblINFO2.Font = New Font("SF Electrotome", 11.25F, FontStyle.Italic, GraphicsUnit.Point)
        lblINFO2.ForeColor = SystemColors.InfoText
        lblINFO2.Location = New Point(12, 128)
        lblINFO2.Name = "lblINFO2"
        lblINFO2.Size = New Size(114, 17)
        lblINFO2.TabIndex = 71
        lblINFO2.Text = "of your variant fails"
        ' 
        ' FrmListStyle
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(369, 151)
        Controls.Add(lblINFO2)
        Controls.Add(lblINFO1)
        Controls.Add(cb100)
        Controls.Add(cb10)
        Controls.Add(btnSAVE)
        Controls.Add(cbZERO)
        Controls.Add(rbROM)
        Controls.Add(rbLETT)
        Controls.Add(rbNUMB)
        Controls.Add(tbPSIGN)
        Controls.Add(lblPSIGN)
        Controls.Add(cbCAP)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmListStyle"
        Text = "Set list style"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbCAP As CheckBox
    Friend WithEvents lblPSIGN As Label
    Friend WithEvents tbPSIGN As TextBox
    Friend WithEvents rbNUMB As RadioButton
    Friend WithEvents rbLETT As RadioButton
    Friend WithEvents rbROM As RadioButton
    Friend WithEvents cbZERO As CheckBox
    Friend WithEvents btnSAVE As Button
    Friend WithEvents cb10 As CheckBox
    Friend WithEvents cb100 As CheckBox
    Friend WithEvents lblINFO1 As Label
    Friend WithEvents lblINFO2 As Label
End Class
