Public Class FrmCharOffset

    Private Sub FrmLineSpace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudOFFSET.Value = Form1.rtbARK.SelectionCharOffset
    End Sub

    Private Sub NudSPACE_ValueChanged(sender As Object, e As EventArgs) Handles nudOFFSET.ValueChanged
        Form1.rtbARK.SelectionCharOffset = nudOFFSET.Value
    End Sub

    Private Sub BtnRESET_Click(sender As Object, e As EventArgs) Handles btnRESET.Click
        nudOFFSET.Value = 0
        Form1.rtbARK.SelectionCharOffset = 0
    End Sub

End Class