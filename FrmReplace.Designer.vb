<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReplace
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblSEARCH = New Label()
        btnSEARCH = New Button()
        btnCLEAR = New Button()
        cbWHOLE = New CheckBox()
        lblFINDS = New Label()
        lblREPLACE = New Label()
        btnREPLACE = New Button()
        btnREPLACEALL = New Button()
        cbCASE = New CheckBox()
        tbSEARCH = New TextBox()
        rtbREPLACE = New RichTextBox()
        btnOS = New Button()
        ttREPLACE = New ToolTip(components)
        SuspendLayout()
        ' 
        ' lblSEARCH
        ' 
        lblSEARCH.AutoSize = True
        lblSEARCH.BackColor = Color.Transparent
        lblSEARCH.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblSEARCH.ForeColor = Color.Navy
        lblSEARCH.Location = New Point(8, 16)
        lblSEARCH.Name = "lblSEARCH"
        lblSEARCH.Size = New Size(100, 17)
        lblSEARCH.TabIndex = 43
        lblSEARCH.Text = "Fields for search:"
        ' 
        ' btnSEARCH
        ' 
        btnSEARCH.BackColor = Color.White
        btnSEARCH.Cursor = Cursors.Hand
        btnSEARCH.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSEARCH.ForeColor = Color.Navy
        btnSEARCH.Location = New Point(328, 16)
        btnSEARCH.Margin = New Padding(3, 0, 3, 3)
        btnSEARCH.Name = "btnSEARCH"
        btnSEARCH.Size = New Size(32, 20)
        btnSEARCH.TabIndex = 45
        btnSEARCH.Text = "GO>"
        btnSEARCH.TextAlign = ContentAlignment.TopCenter
        btnSEARCH.UseVisualStyleBackColor = False
        ' 
        ' btnCLEAR
        ' 
        btnCLEAR.BackColor = Color.White
        btnCLEAR.Cursor = Cursors.Hand
        btnCLEAR.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnCLEAR.ForeColor = Color.Navy
        btnCLEAR.Location = New Point(366, 16)
        btnCLEAR.Margin = New Padding(3, 0, 3, 3)
        btnCLEAR.Name = "btnCLEAR"
        btnCLEAR.Size = New Size(48, 20)
        btnCLEAR.TabIndex = 46
        btnCLEAR.Text = "CLEAR"
        btnCLEAR.TextAlign = ContentAlignment.TopCenter
        btnCLEAR.UseVisualStyleBackColor = False
        ' 
        ' cbWHOLE
        ' 
        cbWHOLE.AutoSize = True
        cbWHOLE.Font = New Font("SF Electrotome", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbWHOLE.ForeColor = SystemColors.ControlDarkDark
        cbWHOLE.Location = New Point(112, 80)
        cbWHOLE.Name = "cbWHOLE"
        cbWHOLE.Size = New Size(83, 19)
        cbWHOLE.TabIndex = 47
        cbWHOLE.Text = "Whole Word"
        cbWHOLE.UseVisualStyleBackColor = True
        ' 
        ' lblFINDS
        ' 
        lblFINDS.AutoSize = True
        lblFINDS.BackColor = Color.Transparent
        lblFINDS.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblFINDS.ForeColor = Color.Purple
        lblFINDS.Location = New Point(200, 80)
        lblFINDS.Name = "lblFINDS"
        lblFINDS.Size = New Size(60, 17)
        lblFINDS.TabIndex = 48
        lblFINDS.Text = "Finds = 0"
        ' 
        ' lblREPLACE
        ' 
        lblREPLACE.AutoSize = True
        lblREPLACE.BackColor = Color.Transparent
        lblREPLACE.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblREPLACE.ForeColor = Color.Navy
        lblREPLACE.Location = New Point(8, 48)
        lblREPLACE.Name = "lblREPLACE"
        lblREPLACE.Size = New Size(102, 17)
        lblREPLACE.TabIndex = 50
        lblREPLACE.Text = "Fields for replace:"
        ' 
        ' btnREPLACE
        ' 
        btnREPLACE.BackColor = Color.White
        btnREPLACE.Cursor = Cursors.Hand
        btnREPLACE.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnREPLACE.ForeColor = Color.Navy
        btnREPLACE.Location = New Point(358, 52)
        btnREPLACE.Margin = New Padding(3, 0, 3, 3)
        btnREPLACE.Name = "btnREPLACE"
        btnREPLACE.Size = New Size(56, 20)
        btnREPLACE.TabIndex = 52
        btnREPLACE.Text = "REPLACE"
        btnREPLACE.TextAlign = ContentAlignment.TopCenter
        btnREPLACE.UseVisualStyleBackColor = False
        ' 
        ' btnREPLACEALL
        ' 
        btnREPLACEALL.BackColor = Color.White
        btnREPLACEALL.Cursor = Cursors.Hand
        btnREPLACEALL.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnREPLACEALL.ForeColor = Color.Navy
        btnREPLACEALL.Location = New Point(339, 80)
        btnREPLACEALL.Margin = New Padding(3, 0, 3, 3)
        btnREPLACEALL.Name = "btnREPLACEALL"
        btnREPLACEALL.Size = New Size(75, 20)
        btnREPLACEALL.TabIndex = 53
        btnREPLACEALL.Text = "REPLACE ALL"
        btnREPLACEALL.TextAlign = ContentAlignment.TopCenter
        btnREPLACEALL.UseVisualStyleBackColor = False
        ' 
        ' cbCASE
        ' 
        cbCASE.AutoSize = True
        cbCASE.Font = New Font("SF Electrotome", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbCASE.ForeColor = SystemColors.ControlDarkDark
        cbCASE.Location = New Point(8, 80)
        cbCASE.Name = "cbCASE"
        cbCASE.Size = New Size(98, 19)
        cbCASE.TabIndex = 57
        cbCASE.Text = "Case Sensitive"
        cbCASE.UseVisualStyleBackColor = True
        ' 
        ' tbSEARCH
        ' 
        tbSEARCH.Location = New Point(112, 14)
        tbSEARCH.Name = "tbSEARCH"
        tbSEARCH.Size = New Size(208, 23)
        tbSEARCH.TabIndex = 58
        ' 
        ' rtbREPLACE
        ' 
        rtbREPLACE.BorderStyle = BorderStyle.None
        rtbREPLACE.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rtbREPLACE.Location = New Point(112, 48)
        rtbREPLACE.Name = "rtbREPLACE"
        rtbREPLACE.Size = New Size(208, 27)
        rtbREPLACE.TabIndex = 60
        rtbREPLACE.Text = ""
        ttREPLACE.SetToolTip(rtbREPLACE, "Here you can paste special fonts and colors")
        ' 
        ' btnOS
        ' 
        btnOS.BackColor = Color.White
        btnOS.Cursor = Cursors.Hand
        btnOS.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnOS.ForeColor = Color.Navy
        btnOS.Location = New Point(328, 52)
        btnOS.Margin = New Padding(3, 0, 3, 3)
        btnOS.Name = "btnOS"
        btnOS.Size = New Size(25, 20)
        btnOS.TabIndex = 61
        btnOS.Text = " OS"
        btnOS.TextAlign = ContentAlignment.TopCenter
        ttREPLACE.SetToolTip(btnOS, "Click for only one fontstyle")
        btnOS.UseVisualStyleBackColor = False
        ' 
        ' FrmReplace
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(419, 106)
        Controls.Add(btnOS)
        Controls.Add(rtbREPLACE)
        Controls.Add(tbSEARCH)
        Controls.Add(cbCASE)
        Controls.Add(btnREPLACEALL)
        Controls.Add(btnREPLACE)
        Controls.Add(lblREPLACE)
        Controls.Add(lblFINDS)
        Controls.Add(cbWHOLE)
        Controls.Add(btnCLEAR)
        Controls.Add(btnSEARCH)
        Controls.Add(lblSEARCH)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmReplace"
        Text = "Replace character or word/words"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblSEARCH As Label
    Friend WithEvents btnSEARCH As Button
    Friend WithEvents btnCLEAR As Button
    Friend WithEvents cbWHOLE As CheckBox
    Friend WithEvents lblFINDS As Label
    Friend WithEvents lblREPLACE As Label
    Friend WithEvents btnREPLACE As Button
    Friend WithEvents btnREPLACEALL As Button
    Friend WithEvents cbCASE As CheckBox
    Friend WithEvents tbSEARCH As TextBox
    Friend WithEvents rtbREPLACE As RichTextBox
    Friend WithEvents btnOS As Button
    Friend WithEvents ttREPLACE As ToolTip
End Class
