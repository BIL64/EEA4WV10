Public Class FrmLineSpace

    Private Sub FrmLineSpace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudSPACE.Value = Form1.rtbARK.SelectionCharOffset
    End Sub

    Private Sub NudSPACE_ValueChanged(sender As Object, e As EventArgs) Handles nudSPACE.ValueChanged
        Form1.rtbARK.SelectionCharOffset = nudSPACE.Value
    End Sub

    Private Sub BtnRESET_Click(sender As Object, e As EventArgs) Handles btnRESET.Click
        nudSPACE.Value = 0
        Form1.rtbARK.SelectionCharOffset = 0
    End Sub

End Class