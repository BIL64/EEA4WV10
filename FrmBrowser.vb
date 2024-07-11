Public Class FrmBrowser

    Private Sub FrmBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbBROWSER.Font = Form1.nudSL.Font 'Tilldelar textboxen samma typsnitt som den på Form1.
        tbBROWSER.Text = My.Computer.FileSystem.ReadAllText("Browser.var")
    End Sub

    Private Sub BtnBROWSER_Click(sender As Object, e As EventArgs) Handles btnBROWSER.Click
        Const controlcharacters = "“”"",;'*¨^|§½!@#£¤$%&=+?`´<>(){}[]"
        Dim approved As Boolean = True
        Dim newbrowser As String

        newbrowser = tbBROWSER.Text
        newbrowser = Trim(newbrowser)

        newbrowser = Replace(newbrowser, " is saved.", "")

        If newbrowser = "" Then
            MessageBox.Show("Input emty", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
            approved = False

        ElseIf newbrowser.IndexOfAny(controlcharacters.ToArray) > -1 Then
            MessageBox.Show("Only characters used in a file names is allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
            approved = False
        End If

        If approved Then
            Try
                Process.Start(newbrowser)
                My.Computer.FileSystem.WriteAllText("Browser.var", newbrowser, False)
                Form1.browserfile = newbrowser
                tbBROWSER.Text = newbrowser & " is saved."
            Catch ex As Exception
                MessageBox.Show("Cannot load Web page" & vbCrLf & ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
            End Try
        End If
    End Sub

End Class