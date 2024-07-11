<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInfo
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
        rtbINFO = New RichTextBox()
        pINFO = New Panel()
        SuspendLayout()
        ' 
        ' rtbINFO
        ' 
        rtbINFO.BackColor = Color.Cyan
        rtbINFO.BorderStyle = BorderStyle.None
        rtbINFO.Location = New Point(22, 22)
        rtbINFO.Name = "rtbINFO"
        rtbINFO.ReadOnly = True
        rtbINFO.ScrollBars = RichTextBoxScrollBars.None
        rtbINFO.Size = New Size(570, 372)
        rtbINFO.TabIndex = 0
        rtbINFO.TabStop = False
        rtbINFO.Text = "There should be a file (readme.rtf or readme.txt) in the program folder. Now it's gone!"
        ' 
        ' pINFO
        ' 
        pINFO.BackColor = Color.Cyan
        pINFO.Location = New Point(12, 12)
        pINFO.Name = "pINFO"
        pINFO.Size = New Size(590, 392)
        pINFO.TabIndex = 1
        ' 
        ' FrmInfo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(614, 416)
        Controls.Add(rtbINFO)
        Controls.Add(pINFO)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "FrmInfo"
        Text = "Info"
        TopMost = True
        ResumeLayout(False)
    End Sub

    Friend WithEvents rtbINFO As RichTextBox
    Friend WithEvents pINFO As Panel
End Class
