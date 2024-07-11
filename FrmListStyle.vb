Public Class FrmListStyle

    Private Sub FrmListStyle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Form1.IsSave Then
            tbPSIGN.Font = Form1.nudSL.Font 'Tilldelar textboxen samma typsnitt som den på Form1.
            tbPSIGN.Text = "."
            rbNUMB.Checked = True
            cbZERO.Checked = False
            cbCAP.Checked = True
            cb10.Checked = False
            cb100.Checked = False
        Else
            rbNUMB.Checked = Form1.IsNumber
            rbLETT.Checked = Not Form1.IsNumber And Form1.IsAlpha
            rbROM.Checked = Not Form1.IsNumber And Not Form1.IsAlpha
            cbZERO.Checked = Form1.IsZero
            cbCAP.Checked = Form1.IsCapital
            tbPSIGN.Text = Form1.Psign

            If Form1.F10 = " " Then
                cb10.Checked = False
                cb100.Checked = False
            ElseIf Form1.F10 = " 0" Then
                cb10.Checked = True
                cb100.Checked = False
            ElseIf Form1.F10 = " 00" Then
                cb10.Checked = False
                cb100.Checked = True
            End If
        End If
    End Sub

    Private Sub RbNUMB_Click(sender As Object, e As EventArgs) Handles rbNUMB.Click
        rbNUMB.Checked = True
        Form1.IsNumber = True
        LoadPsign()
    End Sub

    Private Sub RbLETT_Click(sender As Object, e As EventArgs) Handles rbLETT.Click
        rbLETT.Checked = True
        Form1.IsNumber = False
        Form1.IsAlpha = True
        LoadPsign()
    End Sub

    Private Sub RbROM_Click(sender As Object, e As EventArgs) Handles rbROM.Click
        rbROM.Checked = True
        Form1.IsNumber = False
        Form1.IsAlpha = False
        LoadPsign()
    End Sub

    Private Sub Cb10_Click(sender As Object, e As EventArgs) Handles cb10.Click
        If cb10.Checked Then
            Form1.F10 = " 0"
            Form1.F100 = " "
            cb100.Checked = False
        Else
            Form1.F10 = " "
            Form1.F100 = " "
        End If
    End Sub

    Private Sub Cb100_Click(sender As Object, e As EventArgs) Handles cb100.Click
        If cb100.Checked Then
            Form1.F10 = " 00"
            Form1.F100 = " 0"
            cb10.Checked = False
        Else
            Form1.F10 = " "
            Form1.F100 = " "
        End If
    End Sub

    Private Sub CbZERO_Click(sender As Object, e As EventArgs) Handles cbZERO.Click
        If cbZERO.Checked Then
            Form1.IsZero = True
        Else
            Form1.IsZero = False
        End If
    End Sub

    Private Sub CbCAP_Click(sender As Object, e As EventArgs) Handles cbCAP.Click
        If cbCAP.Checked Then
            Form1.IsCapital = True
        Else
            Form1.IsCapital = False
        End If
    End Sub

    Private Sub BtnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        LoadPsign()
        Form1.IsSave = True
        Close()
    End Sub

    Private Sub LoadPsign()
        Form1.Psign = tbPSIGN.Text
        If tbPSIGN.Text = "" Then
            tbPSIGN.Text = " "
            Form1.Psign = " "
        End If
    End Sub

End Class