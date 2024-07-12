<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearch
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
        components = New ComponentModel.Container()
        btnSEARCH = New Button()
        btnCLEAR = New Button()
        lblFINDS = New Label()
        lblSEARCH = New Label()
        tbSEARCH = New TextBox()
        cbCASE = New CheckBox()
        cbWHOLE = New CheckBox()
        btnSEARCHALL = New Button()
        ttSEARCH = New ToolTip(components)
        SuspendLayout()
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
        btnSEARCH.TabIndex = 39
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
        btnCLEAR.Location = New Point(328, 46)
        btnCLEAR.Margin = New Padding(3, 0, 3, 3)
        btnCLEAR.Name = "btnCLEAR"
        btnCLEAR.Size = New Size(48, 20)
        btnCLEAR.TabIndex = 40
        btnCLEAR.Text = "CLEAR"
        btnCLEAR.TextAlign = ContentAlignment.TopCenter
        btnCLEAR.UseVisualStyleBackColor = False
        ' 
        ' lblFINDS
        ' 
        lblFINDS.AutoSize = True
        lblFINDS.BackColor = Color.Transparent
        lblFINDS.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblFINDS.ForeColor = Color.Purple
        lblFINDS.Location = New Point(208, 48)
        lblFINDS.Name = "lblFINDS"
        lblFINDS.Size = New Size(58, 17)
        lblFINDS.TabIndex = 41
        lblFINDS.Text = "Finds = ?"
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
        lblSEARCH.TabIndex = 42
        lblSEARCH.Text = "Fields for search:"
        ' 
        ' tbSEARCH
        ' 
        tbSEARCH.Location = New Point(112, 14)
        tbSEARCH.Name = "tbSEARCH"
        tbSEARCH.Size = New Size(208, 23)
        tbSEARCH.TabIndex = 43
        ' 
        ' cbCASE
        ' 
        cbCASE.AutoSize = True
        cbCASE.Font = New Font("SF Electrotome", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbCASE.ForeColor = SystemColors.ControlDarkDark
        cbCASE.Location = New Point(16, 48)
        cbCASE.Name = "cbCASE"
        cbCASE.Size = New Size(98, 19)
        cbCASE.TabIndex = 44
        cbCASE.Text = "Case Sensitive"
        cbCASE.UseVisualStyleBackColor = True
        ' 
        ' cbWHOLE
        ' 
        cbWHOLE.AutoSize = True
        cbWHOLE.Font = New Font("SF Electrotome", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbWHOLE.ForeColor = SystemColors.ControlDarkDark
        cbWHOLE.Location = New Point(120, 48)
        cbWHOLE.Name = "cbWHOLE"
        cbWHOLE.Size = New Size(83, 19)
        cbWHOLE.TabIndex = 45
        cbWHOLE.Text = "Whole Word"
        cbWHOLE.UseVisualStyleBackColor = True
        ' 
        ' btnSEARCHALL
        ' 
        btnSEARCHALL.BackColor = Color.White
        btnSEARCHALL.Cursor = Cursors.Hand
        btnSEARCHALL.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSEARCHALL.ForeColor = Color.Navy
        btnSEARCHALL.Location = New Point(366, 16)
        btnSEARCHALL.Margin = New Padding(3, 0, 3, 3)
        btnSEARCHALL.Name = "btnSEARCHALL"
        btnSEARCHALL.Size = New Size(32, 20)
        btnSEARCHALL.TabIndex = 48
        btnSEARCHALL.Text = "ALL"
        btnSEARCHALL.TextAlign = ContentAlignment.TopCenter
        btnSEARCHALL.UseVisualStyleBackColor = False
        ' 
        ' FrmSearch
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(404, 76)
        Controls.Add(btnSEARCHALL)
        Controls.Add(cbWHOLE)
        Controls.Add(cbCASE)
        Controls.Add(tbSEARCH)
        Controls.Add(lblSEARCH)
        Controls.Add(lblFINDS)
        Controls.Add(btnCLEAR)
        Controls.Add(btnSEARCH)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmSearch"
        Text = "Search for character or word/words"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnSEARCH As Button
    Friend WithEvents btnCLEAR As Button
    Friend WithEvents lblFINDS As Label
    Friend WithEvents lblSEARCH As Label
    Friend WithEvents tbSEARCH As TextBox
    Friend WithEvents cbCASE As CheckBox
    Friend WithEvents cbWHOLE As CheckBox
    Friend WithEvents btnSEARCHALL As Button
    Friend WithEvents ttSEARCH As ToolTip
End Class
