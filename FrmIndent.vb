Public Class FrmIndent

    Private Sub FrmIndent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudINDENT.Text = Form1.indent_V
    End Sub

    Private Sub NudINDENT_ValueChanged(sender As Object, e As EventArgs) Handles nudINDENT.ValueChanged
        Form1.rtbARK.SelectionIndent = nudINDENT.Value
        Form1.indent_V = nudINDENT.Value
    End Sub

    Private Sub NudHANGING_ValueChanged(sender As Object, e As EventArgs) Handles nudHANGING.ValueChanged
        Form1.rtbARK.SelectionHangingIndent = nudHANGING.Value
    End Sub

End Class