Public Class FrmSpaceBetween

    Private Sub FrmSpaceBetween_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Kod delvis hämtad från Copilot.
        Dim rtf As String = Form1.rtbARK.Rtf

        'Läs radavstånd.
        Dim lineSpacingMatch As Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(rtf, "\\sl(\d+)")
        If lineSpacingMatch.Success Then
            Dim lineSpacing As Integer = Integer.Parse(lineSpacingMatch.Groups(1).Value) / 20
            tbSPACEB1.Text = lineSpacing.ToString()
        End If

        'Läs teckenavstånd.
        Dim charSpacingMatch As Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(rtf, "\\expnd(\d+)")
        If charSpacingMatch.Success Then
            nudSPACEB2.Value = Integer.Parse(charSpacingMatch.Groups(1).Value)
        End If

        'Läs ordavstånd.
        Dim wordSpacingMatch As Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(rtf, "\\scaps(\d+)")
        If wordSpacingMatch.Success Then
            nudSPACEB3.Value = Integer.Parse(wordSpacingMatch.Groups(1).Value)
        End If

        'Läs styckemellanrum.
        Dim paragraphSpacingBeforeMatch As Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(rtf, "\\sb(\d+)")
        Dim paragraphSpacingAfterMatch As Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(rtf, "\\sa(\d+)")
        If paragraphSpacingBeforeMatch.Success Then
            nudSPACEB3.Value = Integer.Parse(paragraphSpacingBeforeMatch.Groups(1).Value) / 20
        End If
        If paragraphSpacingAfterMatch.Success Then
            nudSPACEB4.Value = Integer.Parse(paragraphSpacingAfterMatch.Groups(1).Value) / 20
        End If
    End Sub

    Private Sub BtnAPPLY1_Click(sender As Object, e As EventArgs) Handles btnAPPLY1.Click 'Knapp - Justera radavstånd.
        Try
            ResetSpaceCode("\\sl-?\d+\\slmult[01]")
            ResetSpaceCode("\\sl-?\d+")
            ResetSpaceCode("\\sl")
            ReplaceOrAddLineSpacing(CSng(tbSPACEB1.Text))
        Catch ex As Exception
            MessageBox.Show("Cannot calculate value" & vbCrLf & ex.Message, "Calculation error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Sub BtnR1_Click(sender As Object, e As EventArgs) Handles btnR1.Click 'Knapp - Raderar kontrollord för radavstånd.
        ResetSpaceCode("\\sl-?\d+\\slmult[01]")
        ResetSpaceCode("\\sl-?\d+")
        ResetSpaceCode("\\sl")
    End Sub

    Private Sub BtnAPPLY2_Click(sender As Object, e As EventArgs) Handles btnAPPLY2.Click 'Knapp - Ändra avstånd mellan tecken.
        Try
            If nudSPACEB2.Value <> 0 Then
                ResetSpaceCode("\\expndtw-?\d+")
                ResetSpaceCode("\\expndtw")
                SetCharacterSpacing(nudSPACEB2.Value)
            Else
                ResetSpaceCode("\\expndtw-?\d+")
                ResetSpaceCode("\\expndtw")
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot calculate value" & vbCrLf & ex.Message, "Calculation error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Sub BtnR2_Click(sender As Object, e As EventArgs) Handles btnR2.Click 'Knapp - Raderar kontrollord för teckenavstånd.
        ResetSpaceCode("\\expndtw-?\d+")
        ResetSpaceCode("\\expndtw")
    End Sub

    Private Sub BtnAPPLY3_Click(sender As Object, e As EventArgs) Handles btnAPPLY3.Click 'Knapp - Justera avstånd före och efter stycken.
        Try
            ReplaceOrAddParagraphSpacing(nudSPACEB3.Value, nudSPACEB4.Value)

            If nudSPACEB3.Value = 0 Then
                ResetSpaceCode("\\sb\d+")
                ResetSpaceCode("\\sb")
            End If

            If nudSPACEB4.Value = 0 Then
                ResetSpaceCode("\\sa\d+")
                ResetSpaceCode("\\sa")
            End If
        Catch ex As Exception
            MessageBox.Show("Cannot calculate this values" & vbCrLf & ex.Message, "Calculation error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Sub BtnR3_Click(sender As Object, e As EventArgs) Handles btnR3.Click 'Knapp - Raderar kontrollord för styckeavstånd.
        ResetSpaceCode("\\sb\d+")
        ResetSpaceCode("\\sb")
        ResetSpaceCode("\\sa\d+")
        ResetSpaceCode("\\sa")
    End Sub

    'Copilot 1 Justera avståndet mellan textrader (radavstånd).
    Private Sub ReplaceOrAddLineSpacing(newLineSpacing As Single)
        Dim rtf As String = Form1.rtbARK.Rtf
        Dim newSpacingRtf As String = "\sl" & (newLineSpacing * 20).ToString()
        Dim pattern As String = "\\sl-?\d+"
        Dim regex As New Text.RegularExpressions.Regex(pattern)

        If Form1.rtbARK.SelectionLength > 0 Then
            Dim start As Integer = Form1.rtbARK.SelectionStart
            Dim length As Integer = Form1.rtbARK.SelectionLength
            Dim selectedRtf As String = Form1.rtbARK.SelectedRtf

            If regex.IsMatch(selectedRtf) Then
                selectedRtf = regex.Replace(selectedRtf, newSpacingRtf)
            Else
                selectedRtf = selectedRtf.Replace("\pard", "\pard " & newSpacingRtf)
            End If

            'Hantera liststycken.
            If selectedRtf.Contains("\pntext") Then
                Dim listPattern As String = "(\\pntext[^\\]*)\\sl-?\d*"
                Dim listRegex As New Text.RegularExpressions.Regex(listPattern)
                If listRegex.IsMatch(selectedRtf) Then
                    selectedRtf = listRegex.Replace(selectedRtf, "$1" & newSpacingRtf)
                Else
                    selectedRtf = selectedRtf.Replace("\pntext", "\pntext " & newSpacingRtf)
                End If
            End If

            Form1.rtbARK.SelectedRtf = selectedRtf
            Form1.rtbARK.Select(start, length)
        Else
            If regex.IsMatch(rtf) Then
                rtf = regex.Replace(rtf, newSpacingRtf)
            Else
                rtf = rtf.Replace("\pard", "\pard " & newSpacingRtf)
            End If

            Form1.rtbARK.Rtf = rtf
        End If
    End Sub

    'Copilot 2 Ändra avståndet mellan tecken.
    Private Sub SetCharacterSpacing(spacing As Integer)
        Dim rtf As String = Form1.rtbARK.Rtf
        Dim newSpacingRtf As String = "\expndtw" & (spacing * 20).ToString()
        Dim pattern As String = "\\expndtw-?\d+"
        Dim regex As New Text.RegularExpressions.Regex(pattern)

        If Form1.rtbARK.SelectionLength > 0 Then
            Dim start As Integer = Form1.rtbARK.SelectionStart
            Dim length As Integer = Form1.rtbARK.SelectionLength
            Dim selectedRtf As String = Form1.rtbARK.SelectedRtf

            If regex.IsMatch(selectedRtf) Then
                selectedRtf = regex.Replace(selectedRtf, newSpacingRtf)
            Else
                selectedRtf = selectedRtf.Replace("\pard", "\pard " & newSpacingRtf)
            End If

            'Hantera liststycken.
            If selectedRtf.Contains("\pntext") Then
                Dim listPattern As String = "(\\pntext[^\\]*)\\expndtw-?\d*"
                Dim listRegex As New Text.RegularExpressions.Regex(listPattern)
                If listRegex.IsMatch(selectedRtf) Then
                    selectedRtf = listRegex.Replace(selectedRtf, "$1" & newSpacingRtf)
                Else
                    selectedRtf = selectedRtf.Replace("\pntext", "\pntext " & newSpacingRtf)
                End If
            End If

            Form1.rtbARK.SelectedRtf = selectedRtf
            Form1.rtbARK.Select(start, length)
        Else
            If regex.IsMatch(rtf) Then
                rtf = regex.Replace(rtf, newSpacingRtf)
            Else
                rtf = rtf.Replace("\pard", "\pard " & newSpacingRtf)
            End If

            Form1.rtbARK.Rtf = rtf
        End If
    End Sub

    'Copilot 3 Justera avståndet före och efter ett stycke/stycken.
    Private Sub ReplaceOrAddParagraphSpacing(spaceBefore As Integer, spaceAfter As Integer)
        Dim rtf As String = Form1.rtbARK.Rtf
        Dim newBeforeRtf As String = "\sb" & (spaceBefore * 20).ToString()
        Dim newAfterRtf As String = "\sa" & (spaceAfter * 20).ToString()
        Dim beforePattern As String = "\\sb\d+"
        Dim afterPattern As String = "\\sa\d+"
        Dim beforeRegex As New Text.RegularExpressions.Regex(beforePattern)
        Dim afterRegex As New Text.RegularExpressions.Regex(afterPattern)

        If Form1.rtbARK.SelectionLength > 0 Then
            Dim start As Integer = Form1.rtbARK.SelectionStart
            Dim length As Integer = Form1.rtbARK.SelectionLength
            Dim selectedRtf As String = Form1.rtbARK.SelectedRtf

            If beforeRegex.IsMatch(selectedRtf) Then
                selectedRtf = beforeRegex.Replace(selectedRtf, newBeforeRtf)
            Else
                selectedRtf = selectedRtf.Replace("\pard", "\pard " & newBeforeRtf)
            End If

            If afterRegex.IsMatch(selectedRtf) Then
                selectedRtf = afterRegex.Replace(selectedRtf, newAfterRtf)
            Else
                selectedRtf = selectedRtf.Replace("\pard", "\pard " & newAfterRtf)
            End If

            Form1.rtbARK.SelectedRtf = selectedRtf
            Form1.rtbARK.Select(start, length)
        Else
            If beforeRegex.IsMatch(rtf) Then
                rtf = beforeRegex.Replace(rtf, newBeforeRtf)
            Else
                rtf = rtf.Replace("\pard", "\pard " & newBeforeRtf)
            End If

            If afterRegex.IsMatch(rtf) Then
                rtf = afterRegex.Replace(rtf, newAfterRtf)
            Else
                rtf = rtf.Replace("\pard", "\pard " & newAfterRtf)
            End If

            Form1.rtbARK.Rtf = rtf
        End If
    End Sub

    Private Sub ResetSpaceCode(pattern As String) 'Tar bort kontrollord för markerat område eller hela rasket.
        Dim rtf As String = Form1.rtbARK.Rtf
        Dim regex As New Text.RegularExpressions.Regex(pattern)

        If Form1.rtbARK.SelectionLength > 0 Then
            Dim start As Integer = Form1.rtbARK.SelectionStart
            Dim length As Integer = Form1.rtbARK.SelectionLength
            Dim selectedRtf As String = Form1.rtbARK.SelectedRtf
            selectedRtf = regex.Replace(selectedRtf, String.Empty)

            Form1.rtbARK.SelectedRtf = selectedRtf
            Form1.rtbARK.Select(start, length)
        Else
            rtf = regex.Replace(rtf, String.Empty)

            Form1.rtbARK.Rtf = rtf
        End If
    End Sub

End Class