Imports System.Text

Public Class FrmEncoding

    Private Sub FrmEncoding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Form1.staycoded
            Case 1
                rbECANSI.Checked = True
            Case 2
                rbECASCII.Checked = True
            Case 3
                rbECUTF7.Checked = True
            Case 4
                rbECUTF8.Checked = True
            Case 5
                rbECUTF16.Checked = True
            Case 6
                rbECUTF32.Checked = True
            Case 7
                rbECUNICODE.Checked = True
            Case 8
                rbECLATIN.Checked = True
            Case Else
                rbECAUTO.Checked = True
        End Select

        If Form1.IsEncodesave Then
            cbENCODESAVE.Checked = True
        Else
            cbENCODESAVE.Checked = False
        End If
    End Sub

    Private Sub RbECAUTO_CheckedChanged(sender As Object, e As EventArgs) Handles rbECAUTO.CheckedChanged
        Form1.codetype = Encoding.Default
        Form1.CODENAME = "AUTO"
        Form1.IsEncode = False
        Form1.staycoded = 0
    End Sub

    Private Sub RbECANSI_CheckedChanged(sender As Object, e As EventArgs) Handles rbECANSI.CheckedChanged
        Form1.codetype = Encoding.GetEncoding("iso-8859-1") 'ANSI-koden!
        Form1.CODENAME = "ANSI"
        Form1.IsEncode = True
        If rbECANSI.Checked And Not Form1.IsEncodesave And Form1.staycoded <> 1 Then SaveInfo()
        Form1.staycoded = 1
    End Sub

    Private Sub RbASCII_CheckedChanged(sender As Object, e As EventArgs) Handles rbECASCII.CheckedChanged
        Form1.codetype = Encoding.ASCII
        Form1.CODENAME = "ASCII"
        Form1.IsEncode = True
        If rbECASCII.Checked And Not Form1.IsEncodesave And Form1.staycoded <> 2 Then SaveInfo()
        Form1.staycoded = 2
    End Sub

    Private Sub RbECUTF7_CheckedChanged(sender As Object, e As EventArgs) Handles rbECUTF7.CheckedChanged
        Form1.codetype = Encoding.UTF7
        Form1.CODENAME = "UTF7"
        Form1.IsEncode = True
        If rbECUTF7.Checked And Not Form1.IsEncodesave And Form1.staycoded <> 3 Then SaveInfo()
        Form1.staycoded = 3
    End Sub

    Private Sub RbECUTF8_CheckedChanged(sender As Object, e As EventArgs) Handles rbECUTF8.CheckedChanged
        Form1.codetype = Encoding.UTF8
        Form1.CODENAME = "UTF8"
        Form1.IsEncode = True
        Form1.staycoded = 4
    End Sub

    Private Sub RbECUTF16_CheckedChanged(sender As Object, e As EventArgs) Handles rbECUTF16.CheckedChanged
        Form1.codetype = Encoding.BigEndianUnicode
        Form1.CODENAME = "UTF16 BE"
        Form1.IsEncode = True
        If rbECUTF16.Checked And Not Form1.IsEncodesave And Form1.staycoded <> 5 Then SaveInfo()
        Form1.staycoded = 5
    End Sub

    Private Sub RbECUTF32_CheckedChanged(sender As Object, e As EventArgs) Handles rbECUTF32.CheckedChanged
        Form1.codetype = Encoding.UTF32
        Form1.CODENAME = "UTF32"
        Form1.IsEncode = True
        If rbECUTF32.Checked And Not Form1.IsEncodesave And Form1.staycoded <> 6 Then SaveInfo()
        Form1.staycoded = 6
    End Sub

    Private Sub RbECUNICODE_CheckedChanged(sender As Object, e As EventArgs) Handles rbECUNICODE.CheckedChanged
        Form1.codetype = Encoding.Unicode
        Form1.CODENAME = "UNICODE"
        Form1.IsEncode = True
        If rbECUNICODE.Checked And Not Form1.IsEncodesave And Form1.staycoded <> 7 Then SaveInfo()
        Form1.staycoded = 7
    End Sub

    Private Sub RbECLATIN_CheckedChanged(sender As Object, e As EventArgs) Handles rbECLATIN.CheckedChanged
        Form1.codetype = Encoding.Latin1
        Form1.CODENAME = "LATIN"
        Form1.IsEncode = True
        If rbECLATIN.Checked And Not Form1.IsEncodesave And Form1.staycoded <> 8 Then SaveInfo()
        Form1.staycoded = 8
    End Sub

    Private Sub CbENCODESAVE_CheckedChanged(sender As Object, e As EventArgs) Handles cbENCODESAVE.CheckedChanged
        If cbENCODESAVE.Checked Then
            Form1.IsEncodesave = True
        Else
            Form1.IsEncodesave = False
        End If
    End Sub

    Private Sub SaveInfo()
        MessageBox.Show("Note! All text files are converted to UTF-8 if saved", "Unicode UTF-8", MessageBoxButtons.OK, MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
    End Sub

End Class