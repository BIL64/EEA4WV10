Public Class FrmBullet

    Private Sub FrmBullet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudLI.Text = Form1.bull_LI
        nudBI.Text = Form1.bull_BI
        nudRI.Text = Form1.bull_RI
    End Sub

    Private Sub NudLI_ValueChanged(sender As Object, e As EventArgs) Handles nudLI.ValueChanged
        Form1.rtbARK.SelectionIndent = nudLI.Value
        Form1.bull_LI = nudLI.Value
    End Sub

    Private Sub NudBI_ValueChanged(sender As Object, e As EventArgs) Handles nudBI.ValueChanged
        Form1.rtbARK.BulletIndent = nudBI.Value
        Form1.bull_BI = nudBI.Value
    End Sub

    Private Sub NudRI_ValueChanged(sender As Object, e As EventArgs) Handles nudRI.ValueChanged
        Form1.rtbARK.SelectionRightIndent = nudRI.Value
        Form1.bull_RI = nudRI.Value
    End Sub

End Class