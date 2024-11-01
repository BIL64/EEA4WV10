Imports System.Text

Public Class FrmSpecialFormat

    Private Sub FrmSpecialFormat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ingen åtgärd.
    End Sub

    Private Sub BtnAPPLY_Click(sender As Object, e As EventArgs) Handles btnAPPLY.Click
        Select Case True
            Case rbULD.Checked
                ApplyControlWord("\uld")
            Case rbULDASH.Checked
                ApplyControlWord("\uldash")
            Case rbULDASHD.Checked
                ApplyControlWord("\uldashd")
            Case rbULDASHDD.Checked
                ApplyControlWord("\uldashdd")
            Case rbULDB.Checked
                ApplyControlWord("\uldb")
            Case rbULHWAVE.Checked
                ApplyControlWord("\ulhwave")
            Case rbULLDASH.Checked
                ApplyControlWord("\ulldash")
            Case rbULTH.Checked
                ApplyControlWord("\ulth")
            Case rbULTHD.Checked
                ApplyControlWord("\ulthd")
            Case rbULTHDASH.Checked
                ApplyControlWord("\ulthdash")
            Case rbULTHDASHD.Checked
                ApplyControlWord("\ulthdashd")
            Case rbULTHDASHDD.Checked
                ApplyControlWord("\ulthdashdd")
            Case rbULTHLDASH.Checked
                ApplyControlWord("\ulthldash")
            Case rbULULDBWAVE.Checked
                ApplyControlWord("\ululdbwave")
            Case rbULW.Checked
                ApplyControlWord("\ulw")
            Case rbULWAVE.Checked
                ApplyControlWord("\ulwave")
            Case rbEMBO.Checked
                ApplyControlWord("\embo")
            Case rbIMPR.Checked
                ApplyControlWord("\impr")
            Case rbSCAPS.Checked
                ApplyControlWord("\scaps")
            Case rbSUB.Checked
                ApplyControlWord("\sub")
            Case rbSUPER.Checked
                ApplyControlWord("\super")
            Case rbSHAD.Checked
                ApplyControlWord("\shad")
        End Select
    End Sub

    Private Sub BtnCLEAR_Click(sender As Object, e As EventArgs) Handles btnCLEAR.Click
        ApplyControlWord("")
    End Sub

    Private Sub ApplyControlWord(controlWord As String) 'Copilot: Formaterar med ett valfritt kontrollord i markerad text. Tom sträng nollställer.
        Dim start As Integer = Form1.rtbARK.SelectionStart
        Dim length As Integer = Form1.rtbARK.SelectionLength

        If length > 0 Then
            Dim selectedRtf As String = Form1.rtbARK.SelectedRtf

            'Regex-mönster för att hitta och ta bort specifikt kontrollord.
            Dim regexUnderline As New RegularExpressions.Regex("\\embo|\\impr|\\scaps|\\shad|\\sub|\\super|\\ul(thdashdd|thdashd|thldash|thdash|dashdd|dashd|ldash|dash|uldbwave|hwave|wave|thd|th|db|d|w)")

            If String.IsNullOrEmpty(controlWord) Then
                'Tar bort kontrollord.
                selectedRtf = regexUnderline.Replace(selectedRtf, String.Empty)
            Else
                'Lägg till specifikt kontrollord.
                If regexUnderline.IsMatch(selectedRtf) Then
                    selectedRtf = regexUnderline.Replace(selectedRtf, controlWord)
                Else
                    selectedRtf = selectedRtf.Replace("\pard", "\pard " & controlWord)
                End If
            End If

            If controlWord = "" Then 'Tar bort rester av oönskade taggar som kan dyka upp.
                Dim unwantedPatterns As String() = {"\\f\d+", "\\fs\d+", "\\li\d+", "\\fi-\d+"}
                For Each pattern As String In unwantedPatterns
                    Dim regex As New RegularExpressions.Regex(pattern)
                    selectedRtf = regex.Replace(selectedRtf, String.Empty)
                Next
            End If

            Form1.rtbARK.SelectedRtf = selectedRtf
            Form1.rtbARK.Select(start, length)
        Else
            MessageBox.Show("Unable to format unselected text", "Text selecting error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End If
    End Sub

End Class