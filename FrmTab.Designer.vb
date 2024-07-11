<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTab
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
        btnDEFAULT = New Button()
        lblTAB = New Label()
        nudTAB = New NumericUpDown()
        lblNUMBER = New Label()
        btnAPPLY1 = New Button()
        btnAPPLY10 = New Button()
        btnUNDO = New Button()
        CType(nudTAB, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnDEFAULT
        ' 
        btnDEFAULT.BackColor = Color.White
        btnDEFAULT.Cursor = Cursors.Hand
        btnDEFAULT.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnDEFAULT.ForeColor = Color.Navy
        btnDEFAULT.Location = New Point(8, 54)
        btnDEFAULT.Margin = New Padding(3, 0, 3, 3)
        btnDEFAULT.Name = "btnDEFAULT"
        btnDEFAULT.Size = New Size(120, 20)
        btnDEFAULT.TabIndex = 54
        btnDEFAULT.Text = "GET DEFAULT DISTANCE"
        btnDEFAULT.TextAlign = ContentAlignment.TopCenter
        btnDEFAULT.UseVisualStyleBackColor = False
        ' 
        ' lblTAB
        ' 
        lblTAB.AutoSize = True
        lblTAB.BackColor = Color.Transparent
        lblTAB.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTAB.ForeColor = Color.Navy
        lblTAB.Location = New Point(8, 16)
        lblTAB.Name = "lblTAB"
        lblTAB.Size = New Size(82, 17)
        lblTAB.TabIndex = 56
        lblTAB.Text = "New tab size:"
        ' 
        ' nudTAB
        ' 
        nudTAB.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudTAB.Location = New Point(100, 14)
        nudTAB.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        nudTAB.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudTAB.Name = "nudTAB"
        nudTAB.Size = New Size(56, 24)
        nudTAB.TabIndex = 55
        nudTAB.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblNUMBER
        ' 
        lblNUMBER.AutoSize = True
        lblNUMBER.BackColor = Color.Transparent
        lblNUMBER.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblNUMBER.ForeColor = Color.Purple
        lblNUMBER.Location = New Point(150, 56)
        lblNUMBER.Name = "lblNUMBER"
        lblNUMBER.Size = New Size(173, 17)
        lblNUMBER.TabIndex = 57
        lblNUMBER.Text = "Maximum number of tabs = 0"
        ' 
        ' btnAPPLY1
        ' 
        btnAPPLY1.BackColor = Color.White
        btnAPPLY1.Cursor = Cursors.Hand
        btnAPPLY1.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAPPLY1.ForeColor = Color.Navy
        btnAPPLY1.Location = New Point(165, 16)
        btnAPPLY1.Margin = New Padding(3, 0, 3, 3)
        btnAPPLY1.Name = "btnAPPLY1"
        btnAPPLY1.Size = New Size(62, 20)
        btnAPPLY1.TabIndex = 58
        btnAPPLY1.Text = "APPLY 1"
        btnAPPLY1.TextAlign = ContentAlignment.TopCenter
        btnAPPLY1.UseVisualStyleBackColor = False
        ' 
        ' btnAPPLY10
        ' 
        btnAPPLY10.BackColor = Color.White
        btnAPPLY10.Cursor = Cursors.Hand
        btnAPPLY10.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAPPLY10.ForeColor = Color.Navy
        btnAPPLY10.Location = New Point(235, 16)
        btnAPPLY10.Margin = New Padding(3, 0, 3, 3)
        btnAPPLY10.Name = "btnAPPLY10"
        btnAPPLY10.Size = New Size(62, 20)
        btnAPPLY10.TabIndex = 59
        btnAPPLY10.Text = "APPLY 10"
        btnAPPLY10.TextAlign = ContentAlignment.TopCenter
        btnAPPLY10.UseVisualStyleBackColor = False
        ' 
        ' btnUNDO
        ' 
        btnUNDO.BackColor = Color.White
        btnUNDO.Cursor = Cursors.Hand
        btnUNDO.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnUNDO.ForeColor = Color.Navy
        btnUNDO.Location = New Point(313, 16)
        btnUNDO.Margin = New Padding(3, 0, 3, 3)
        btnUNDO.Name = "btnUNDO"
        btnUNDO.Size = New Size(32, 20)
        btnUNDO.TabIndex = 60
        btnUNDO.Text = "-U"
        btnUNDO.TextAlign = ContentAlignment.TopCenter
        btnUNDO.UseVisualStyleBackColor = False
        ' 
        ' FrmTab
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(354, 86)
        Controls.Add(btnUNDO)
        Controls.Add(btnAPPLY10)
        Controls.Add(btnAPPLY1)
        Controls.Add(lblNUMBER)
        Controls.Add(lblTAB)
        Controls.Add(nudTAB)
        Controls.Add(btnDEFAULT)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmTab"
        Text = "Change tab distance/size"
        TopMost = True
        CType(nudTAB, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnDEFAULT As Button
    Friend WithEvents lblTAB As Label
    Friend WithEvents nudTAB As NumericUpDown
    Friend WithEvents lblNUMBER As Label
    Friend WithEvents btnAPPLY1 As Button
    Friend WithEvents btnAPPLY10 As Button
    Friend WithEvents btnUNDO As Button
End Class
