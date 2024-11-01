<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSpaceBetween
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
        lblSPACEB2 = New Label()
        nudSPACEB2 = New NumericUpDown()
        btnAPPLY2 = New Button()
        btnAPPLY1 = New Button()
        lblSPACEB3 = New Label()
        nudSPACEB3 = New NumericUpDown()
        btnAPPLY3 = New Button()
        lblSPACEB4 = New Label()
        nudSPACEB4 = New NumericUpDown()
        lblSPACEB1 = New Label()
        tbSPACEB1 = New TextBox()
        btnR1 = New Button()
        btnR2 = New Button()
        btnR3 = New Button()
        CType(nudSPACEB2, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudSPACEB3, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudSPACEB4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblSPACEB2
        ' 
        lblSPACEB2.AutoSize = True
        lblSPACEB2.BackColor = Color.Transparent
        lblSPACEB2.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblSPACEB2.ForeColor = Color.Navy
        lblSPACEB2.Location = New Point(12, 60)
        lblSPACEB2.Name = "lblSPACEB2"
        lblSPACEB2.Size = New Size(148, 17)
        lblSPACEB2.TabIndex = 46
        lblSPACEB2.Text = "Space between characters"
        ' 
        ' nudSPACEB2
        ' 
        nudSPACEB2.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudSPACEB2.Location = New Point(170, 58)
        nudSPACEB2.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        nudSPACEB2.Minimum = New Decimal(New Integer() {100000, 0, 0, Integer.MinValue})
        nudSPACEB2.Name = "nudSPACEB2"
        nudSPACEB2.Size = New Size(56, 24)
        nudSPACEB2.TabIndex = 45
        nudSPACEB2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' btnAPPLY2
        ' 
        btnAPPLY2.BackColor = Color.White
        btnAPPLY2.Cursor = Cursors.Hand
        btnAPPLY2.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAPPLY2.ForeColor = Color.Navy
        btnAPPLY2.Location = New Point(240, 60)
        btnAPPLY2.Margin = New Padding(3, 0, 3, 3)
        btnAPPLY2.Name = "btnAPPLY2"
        btnAPPLY2.Size = New Size(50, 20)
        btnAPPLY2.TabIndex = 73
        btnAPPLY2.Text = "APPLY"
        btnAPPLY2.TextAlign = ContentAlignment.TopCenter
        btnAPPLY2.UseVisualStyleBackColor = False
        ' 
        ' btnAPPLY1
        ' 
        btnAPPLY1.BackColor = Color.White
        btnAPPLY1.Cursor = Cursors.Hand
        btnAPPLY1.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAPPLY1.ForeColor = Color.Navy
        btnAPPLY1.Location = New Point(240, 13)
        btnAPPLY1.Margin = New Padding(3, 0, 3, 3)
        btnAPPLY1.Name = "btnAPPLY1"
        btnAPPLY1.Size = New Size(50, 20)
        btnAPPLY1.TabIndex = 76
        btnAPPLY1.Text = "APPLY"
        btnAPPLY1.TextAlign = ContentAlignment.TopCenter
        btnAPPLY1.UseVisualStyleBackColor = False
        ' 
        ' lblSPACEB3
        ' 
        lblSPACEB3.AutoSize = True
        lblSPACEB3.BackColor = Color.Transparent
        lblSPACEB3.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblSPACEB3.ForeColor = Color.Navy
        lblSPACEB3.Location = New Point(12, 107)
        lblSPACEB3.Name = "lblSPACEB3"
        lblSPACEB3.Size = New Size(129, 17)
        lblSPACEB3.TabIndex = 75
        lblSPACEB3.Text = "Space before paragraph"
        ' 
        ' nudSPACEB3
        ' 
        nudSPACEB3.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudSPACEB3.Location = New Point(170, 105)
        nudSPACEB3.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        nudSPACEB3.Name = "nudSPACEB3"
        nudSPACEB3.Size = New Size(56, 24)
        nudSPACEB3.TabIndex = 74
        nudSPACEB3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' btnAPPLY3
        ' 
        btnAPPLY3.BackColor = Color.White
        btnAPPLY3.Cursor = Cursors.Hand
        btnAPPLY3.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnAPPLY3.ForeColor = Color.Navy
        btnAPPLY3.Location = New Point(240, 137)
        btnAPPLY3.Margin = New Padding(3, 0, 3, 3)
        btnAPPLY3.Name = "btnAPPLY3"
        btnAPPLY3.Size = New Size(50, 20)
        btnAPPLY3.TabIndex = 79
        btnAPPLY3.Text = "APPLY"
        btnAPPLY3.TextAlign = ContentAlignment.TopCenter
        btnAPPLY3.UseVisualStyleBackColor = False
        ' 
        ' lblSPACEB4
        ' 
        lblSPACEB4.AutoSize = True
        lblSPACEB4.BackColor = Color.Transparent
        lblSPACEB4.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblSPACEB4.ForeColor = Color.Navy
        lblSPACEB4.Location = New Point(12, 137)
        lblSPACEB4.Name = "lblSPACEB4"
        lblSPACEB4.Size = New Size(121, 17)
        lblSPACEB4.TabIndex = 78
        lblSPACEB4.Text = "Space after paragraph"
        ' 
        ' nudSPACEB4
        ' 
        nudSPACEB4.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudSPACEB4.Location = New Point(170, 135)
        nudSPACEB4.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        nudSPACEB4.Name = "nudSPACEB4"
        nudSPACEB4.Size = New Size(56, 24)
        nudSPACEB4.TabIndex = 77
        nudSPACEB4.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblSPACEB1
        ' 
        lblSPACEB1.AutoSize = True
        lblSPACEB1.BackColor = Color.Transparent
        lblSPACEB1.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblSPACEB1.ForeColor = Color.Navy
        lblSPACEB1.Location = New Point(12, 13)
        lblSPACEB1.Name = "lblSPACEB1"
        lblSPACEB1.Size = New Size(144, 17)
        lblSPACEB1.TabIndex = 81
        lblSPACEB1.Text = "New line space (decimal)"
        ' 
        ' tbSPACEB1
        ' 
        tbSPACEB1.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        tbSPACEB1.Location = New Point(167, 11)
        tbSPACEB1.Name = "tbSPACEB1"
        tbSPACEB1.Size = New Size(60, 24)
        tbSPACEB1.TabIndex = 82
        tbSPACEB1.Text = "12"
        ' 
        ' btnR1
        ' 
        btnR1.BackColor = Color.White
        btnR1.Cursor = Cursors.Hand
        btnR1.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnR1.ForeColor = Color.Navy
        btnR1.Location = New Point(300, 13)
        btnR1.Margin = New Padding(3, 0, 3, 3)
        btnR1.Name = "btnR1"
        btnR1.Size = New Size(25, 20)
        btnR1.TabIndex = 86
        btnR1.Text = "R"
        btnR1.TextAlign = ContentAlignment.TopCenter
        btnR1.UseVisualStyleBackColor = False
        ' 
        ' btnR2
        ' 
        btnR2.BackColor = Color.White
        btnR2.Cursor = Cursors.Hand
        btnR2.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnR2.ForeColor = Color.Navy
        btnR2.Location = New Point(300, 60)
        btnR2.Margin = New Padding(3, 0, 3, 3)
        btnR2.Name = "btnR2"
        btnR2.Size = New Size(25, 20)
        btnR2.TabIndex = 87
        btnR2.Text = "R"
        btnR2.TextAlign = ContentAlignment.TopCenter
        btnR2.UseVisualStyleBackColor = False
        ' 
        ' btnR3
        ' 
        btnR3.BackColor = Color.White
        btnR3.Cursor = Cursors.Hand
        btnR3.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnR3.ForeColor = Color.Navy
        btnR3.Location = New Point(300, 137)
        btnR3.Margin = New Padding(3, 0, 3, 3)
        btnR3.Name = "btnR3"
        btnR3.Size = New Size(25, 20)
        btnR3.TabIndex = 89
        btnR3.Text = "R"
        btnR3.TextAlign = ContentAlignment.TopCenter
        btnR3.UseVisualStyleBackColor = False
        ' 
        ' FrmSpaceBetween
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(334, 166)
        Controls.Add(btnR3)
        Controls.Add(btnR2)
        Controls.Add(btnR1)
        Controls.Add(tbSPACEB1)
        Controls.Add(lblSPACEB1)
        Controls.Add(btnAPPLY3)
        Controls.Add(lblSPACEB4)
        Controls.Add(nudSPACEB4)
        Controls.Add(btnAPPLY1)
        Controls.Add(lblSPACEB3)
        Controls.Add(nudSPACEB3)
        Controls.Add(btnAPPLY2)
        Controls.Add(lblSPACEB2)
        Controls.Add(nudSPACEB2)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmSpaceBetween"
        Text = "Space Between"
        TopMost = True
        CType(nudSPACEB2, ComponentModel.ISupportInitialize).EndInit()
        CType(nudSPACEB3, ComponentModel.ISupportInitialize).EndInit()
        CType(nudSPACEB4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSPACEB2 As Label
    Friend WithEvents nudSPACEB2 As NumericUpDown
    Friend WithEvents btnAPPLY2 As Button
    Friend WithEvents btnAPPLY1 As Button
    Friend WithEvents nudSPACEB3 As NumericUpDown
    Friend WithEvents btnAPPLY3 As Button
    Friend WithEvents lblSPACEB4 As Label
    Friend WithEvents nudSPACEB4 As NumericUpDown
    Friend WithEvents lblSPACEB1 As Label
    Friend WithEvents tbSPACEB1 As TextBox
    Friend WithEvents lblSPACEB3 As Label
    Friend WithEvents btnR1 As Button
    Friend WithEvents btnR2 As Button
    Friend WithEvents btnR3 As Button
End Class
