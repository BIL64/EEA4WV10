Public Class FrmTab

    Dim IsApply As Boolean

    Private Sub FrmTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudTAB.Value = Convert.ToDecimal(Form1.tabint) '48 pixlar är uppmätt standardtabbstorlek.
        IsApply = False
    End Sub

    Private Sub BtnAPPLY1_Click(sender As Object, e As EventArgs) Handles btnAPPLY1.Click 'Endast en stycken tabb.
        Dim lblint As Integer

        Form1.rtbARK.SelectionTabs = New Integer() {Int(nudTAB.Value)} 'Konverterar till array.
        Form1.tabint = nudTAB.Value
        Form1.rtbARK.SelectedText = vbTab
        IsApply = True
        lblint = Math.Floor((Form1.rtbARK.Width - Int(nudTAB.Value) - 8) / 48)

        If lblint < 1 Then
            lblNUMBER.Text = "Maximum number of tabs = " & Math.Floor((Form1.rtbARK.Width - 8) / 48)
            lblNUMBER.ForeColor = Color.Red
        Else
            lblNUMBER.Text = "Maximum number of tabs = " & lblint + 1
            lblNUMBER.ForeColor = Color.Purple
        End If
    End Sub

    Private Sub BtnAPPLY10_Click(sender As Object, e As EventArgs) Handles btnAPPLY10.Click '10 stycken tabbar.
        Dim tabarray(10) As Integer
        Dim tabwidth As Integer = Int(nudTAB.Value)
        Dim lblint As Integer

        For index = 0 To 9 'Laddar array.
            tabarray(index) = tabwidth + (index * tabwidth)
        Next
        Form1.rtbARK.SelectionTabs = {tabarray(0), tabarray(1), tabarray(2), tabarray(3), tabarray(4), tabarray(5), tabarray(6), tabarray(7), tabarray(8), tabarray(9)}
        Form1.tabint = tabwidth
        Form1.rtbARK.SelectedText = vbTab
        IsApply = True
        lblint = Math.Floor((Form1.rtbARK.Width - tabwidth * 10 - 8) / 48)

        If lblint < 1 Then
            Dim test As Integer
            Dim count As Byte = 1

            Do 'Testar först hur många av den valda tabbstorleken som får plats.
                test = Math.Floor(Form1.rtbARK.Width - tabwidth * count - 8)
                count += 1
            Loop While test > 0

            lblNUMBER.Text = "Maximum number of tabs = " & Math.Floor((Form1.rtbARK.Width - tabwidth * (count - 2) - 8) / 48) + count - 2
            lblNUMBER.ForeColor = Color.Red
        ElseIf tabwidth < 9 Then
            lblNUMBER.Text = "Number of tabs is unknown"
            lblNUMBER.ForeColor = Color.Purple
        ElseIf tabwidth >= 9 Then
            lblNUMBER.Text = "Maximum number of tabs = " & lblint + 10
            lblNUMBER.ForeColor = Color.Purple
        End If
    End Sub

    Private Sub BtnUNDO_Click(sender As Object, e As EventArgs) Handles btnUNDO.Click 'Ångrar ny tabulator.
        If IsApply Then
            Form1.rtbARK.Undo()
            Form1.rtbARK.Undo()
            IsApply = False
        End If
    End Sub

    Private Sub BtnDEFAULT_Click(sender As Object, e As EventArgs) Handles btnDEFAULT.Click
        nudTAB.Value = Convert.ToDecimal(48) '48 pixlar är uppmätt standardtabbstorlek.
        Form1.tabint = nudTAB.Value
    End Sub

End Class