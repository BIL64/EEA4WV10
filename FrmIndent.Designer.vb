<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIndent
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
        lblINDENT = New Label()
        nudINDENT = New NumericUpDown()
        lblHANGING = New Label()
        nudHANGING = New NumericUpDown()
        CType(nudINDENT, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudHANGING, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblINDENT
        ' 
        lblINDENT.AutoSize = True
        lblINDENT.BackColor = Color.Transparent
        lblINDENT.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblINDENT.ForeColor = Color.Navy
        lblINDENT.Location = New Point(8, 16)
        lblINDENT.Name = "lblINDENT"
        lblINDENT.Size = New Size(73, 17)
        lblINDENT.TabIndex = 46
        lblINDENT.Text = "New indent:"
        ' 
        ' nudINDENT
        ' 
        nudINDENT.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudINDENT.Location = New Point(105, 14)
        nudINDENT.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        nudINDENT.Name = "nudINDENT"
        nudINDENT.Size = New Size(56, 24)
        nudINDENT.TabIndex = 45
        ' 
        ' lblHANGING
        ' 
        lblHANGING.AutoSize = True
        lblHANGING.BackColor = Color.Transparent
        lblHANGING.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblHANGING.ForeColor = Color.Navy
        lblHANGING.Location = New Point(8, 55)
        lblHANGING.Name = "lblHANGING"
        lblHANGING.Size = New Size(91, 17)
        lblHANGING.TabIndex = 48
        lblHANGING.Text = "Hanging indent:"
        ' 
        ' nudHANGING
        ' 
        nudHANGING.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudHANGING.Location = New Point(105, 53)
        nudHANGING.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        nudHANGING.Name = "nudHANGING"
        nudHANGING.Size = New Size(56, 24)
        nudHANGING.TabIndex = 47
        ' 
        ' FrmIndent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(174, 91)
        Controls.Add(lblHANGING)
        Controls.Add(nudHANGING)
        Controls.Add(lblINDENT)
        Controls.Add(nudINDENT)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmIndent"
        Text = "Change indent value"
        TopMost = True
        CType(nudINDENT, ComponentModel.ISupportInitialize).EndInit()
        CType(nudHANGING, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblINDENT As Label
    Friend WithEvents nudINDENT As NumericUpDown
    Friend WithEvents lblHANGING As Label
    Friend WithEvents nudHANGING As NumericUpDown
End Class
