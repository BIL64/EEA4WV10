<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCharOffset
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
        nudOFFSET = New NumericUpDown()
        lblOFFSET = New Label()
        btnRESET = New Button()
        CType(nudOFFSET, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' nudOFFSET
        ' 
        nudOFFSET.Font = New Font("SF Electrotome Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudOFFSET.Location = New Point(16, 32)
        nudOFFSET.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        nudOFFSET.Minimum = New Decimal(New Integer() {100000, 0, 0, Integer.MinValue})
        nudOFFSET.Name = "nudOFFSET"
        nudOFFSET.Size = New Size(56, 24)
        nudOFFSET.TabIndex = 0
        ' 
        ' lblOFFSET
        ' 
        lblOFFSET.AutoSize = True
        lblOFFSET.BackColor = Color.Transparent
        lblOFFSET.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblOFFSET.ForeColor = Color.Navy
        lblOFFSET.Location = New Point(16, 8)
        lblOFFSET.Name = "lblOFFSET"
        lblOFFSET.Size = New Size(64, 17)
        lblOFFSET.TabIndex = 44
        lblOFFSET.Text = "New value"
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
        ' FrmCharOffset
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(164, 71)
        Controls.Add(btnRESET)
        Controls.Add(lblOFFSET)
        Controls.Add(nudOFFSET)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmCharOffset"
        Text = "Change Char Offset"
        TopMost = True
        CType(nudOFFSET, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents nudOFFSET As NumericUpDown
    Friend WithEvents lblOFFSET As Label
    Friend WithEvents btnRESET As Button
End Class
