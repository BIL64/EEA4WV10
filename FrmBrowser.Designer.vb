<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBrowser
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
        tbBROWSER = New TextBox()
        btnBROWSER = New Button()
        lblBROWSER = New Label()
        SuspendLayout()
        ' 
        ' tbBROWSER
        ' 
        tbBROWSER.Location = New Point(120, 14)
        tbBROWSER.Name = "tbBROWSER"
        tbBROWSER.Size = New Size(200, 23)
        tbBROWSER.TabIndex = 67
        ' 
        ' btnBROWSER
        ' 
        btnBROWSER.BackColor = Color.White
        btnBROWSER.Cursor = Cursors.Hand
        btnBROWSER.Font = New Font("SF Electrotome", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnBROWSER.ForeColor = Color.Navy
        btnBROWSER.Location = New Point(328, 16)
        btnBROWSER.Margin = New Padding(3, 0, 3, 3)
        btnBROWSER.Name = "btnBROWSER"
        btnBROWSER.Size = New Size(32, 20)
        btnBROWSER.TabIndex = 66
        btnBROWSER.Text = "GO"
        btnBROWSER.TextAlign = ContentAlignment.TopCenter
        btnBROWSER.UseVisualStyleBackColor = False
        ' 
        ' lblBROWSER
        ' 
        lblBROWSER.AutoSize = True
        lblBROWSER.BackColor = Color.Transparent
        lblBROWSER.Font = New Font("SF Electrotome", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblBROWSER.ForeColor = Color.Navy
        lblBROWSER.Location = New Point(8, 16)
        lblBROWSER.Name = "lblBROWSER"
        lblBROWSER.Size = New Size(104, 17)
        lblBROWSER.TabIndex = 65
        lblBROWSER.Text = "New browser file:"
        ' 
        ' FrmBrowser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(369, 46)
        Controls.Add(tbBROWSER)
        Controls.Add(btnBROWSER)
        Controls.Add(lblBROWSER)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmBrowser"
        Text = "Replace browser for hyperlinks"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents tbBROWSER As TextBox
    Friend WithEvents btnBROWSER As Button
    Friend WithEvents lblBROWSER As Label
End Class
