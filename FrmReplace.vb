Imports System.Text.RegularExpressions

Public Class FrmReplace

    Dim MATCHES As MatchCollection 'Lagrar funna söktermer.
    Dim MatchList As New List(Of Object) 'Söktermerna i MATCHES men som kan nås direkt.
    Dim content As String 'Innehållet i rtbARK.
    Dim searchTerm As String = "" 'Sökterm.
    Dim IsSelected As Boolean = False 'Är texten markerad?
    Dim IsUsed As Boolean = False 'Pågår sökning?
    Dim IsCase As Boolean = False 'Är skriftlägeskänslig på?
    Dim IsWhole As Boolean = False 'Är skriftlägeskänslig på?
    Dim IsSame As Boolean = False 'Är sökordet och utbytesordet lika?
    Dim SC As String = "<-|*|->" 'Specialtecken om sökord och utbytesord är lika.
    Dim IsOnefont As Boolean = False 'Ska bara ett typsnitt och färger gälla?
    Dim finds As Integer = 0 'Räknare för antal sökta.
    Dim countr As Integer = 0 'Räknare för antal utbytta.
    Dim Isel, Lsel As Integer 'Index och Length för markerat innehåll.
    Dim mecolor, selectcolor, specialcolor As Color 'Färgen på windowsformen, markeringsfärg och vid specialtecken.

    Private Sub FrmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbSEARCH.Font = Form1.nudSL.Font 'Tilldelar textboxen samma typsnitt som den på Form1.
        lblFINDS.Text = "Finds = ?"
        btnOS.BackColor = Color.Silver
        mecolor = Me.BackColor
        selectcolor = Color.LightSteelBlue
        specialcolor = Color.Yellow
    End Sub

    Public Sub Search_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        ClearAll()
    End Sub

    Private Sub BtnOS_Click(sender As Object, e As EventArgs) Handles btnOS.Click
        If IsOnefont Then
            btnOS.BackColor = Color.Silver
            IsOnefont = False
        Else
            btnOS.BackColor = Color.Cyan
            IsOnefont = True
        End If
    End Sub

    Private Sub Prepare()

        If Not IsUsed Then 'Görs bara den första gången.
            searchTerm = tbSEARCH.Text

            If Form1.rtbARK.SelectionLength > 0 Then 'Är texten markerad?
                Isel = Form1.rtbARK.SelectionStart
                Lsel = Form1.rtbARK.SelectionLength
                IsSelected = True
            Else
                Isel = Form1.rtbARK.SelectionStart
                IsSelected = False
            End If

            If cbCASE.Checked Then 'Är skriftlägeskänslig på?
                IsCase = True
            Else
                IsCase = False
            End If

            If cbWHOLE.Checked Then 'Är sökning på ord på?
                IsWhole = True
            Else
                IsWhole = False
            End If
        End If

        If IsSelected Then
            Form1.rtbARK.Select(Isel, Lsel)
            content = Form1.rtbARK.SelectedText

            If IsSame Then
                Me.BackColor = specialcolor
            Else
                Me.BackColor = selectcolor
            End If
        Else
            content = Form1.rtbARK.Text.Substring(Isel, Form1.rtbARK.TextLength - Isel)

            If IsSame Then
                Me.BackColor = specialcolor
            Else
                Me.BackColor = mecolor
            End If
        End If

    End Sub

    Private Sub ListMatch() 'Regex gör jobbet!
        Try
            If IsCase Then
                If IsWhole Then
                    MATCHES = Regex.Matches(content, "\b" & searchTerm & "\b")
                Else
                    MATCHES = Regex.Matches(content, searchTerm)
                End If
            Else
                If IsWhole Then
                    MATCHES = Regex.Matches(content, "\b" & searchTerm & "\b", RegexOptions.IgnoreCase)
                Else
                    MATCHES = Regex.Matches(content, searchTerm, RegexOptions.IgnoreCase)
                End If
            End If

            MatchList.Clear()
            For Each match As Match In MATCHES 'Placerar matchningar i en lista så att man slipper iterera.
                MatchList.Add(match)
            Next
            MatchList = MatchList.Distinct.ToList 'Eliminerar dubbletter.
        Catch
            MessageBox.Show("Cannot handle this search term", "Invalid term", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Sub BtnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Prepare()
        If searchTerm <> "" And content <> "" Then

            ListMatch()
            If MatchList.Count > 0 And MatchList.Count > countr Then
                Form1.rtbARK.Select(MatchList(countr).Index + Isel, MatchList(countr).Length) 'Markerar den sökta strängen.
                finds += 1
                countr += 1
                IsUsed = True
            Else
                ShakeIt()
            End If
            lblFINDS.Text = "Finds = " & finds
            AfterCheck()
        End If
    End Sub

    Private Sub BtnREPLACE_Click(sender As Object, e As EventArgs) Handles btnREPLACE.Click
        If MatchList.Count > 0 And Form1.rtbARK.SelectionLength > 0 And tbSEARCH.Text <> "" Then

            If tbSEARCH.Text = rtbREPLACE.Text Then IsSame = True

            If IsOnefont Then
                If IsSame Then
                    Form1.rtbARK.SelectedText = SC
                Else
                    rtbREPLACE.Select(0, rtbREPLACE.Text.Length) 'Krävs för att alla variationer ska tas med.
                    rtbREPLACE.Copy()
                    Form1.rtbARK.Paste()
                End If
            Else
                If IsSame Then
                    Form1.rtbARK.SelectedText = SC
                Else
                    Form1.rtbARK.SelectedText = rtbREPLACE.Text
                End If
            End If

            Prepare()
            ListMatch()
            If MatchList.Count > 0 And MatchList.Count > countr - 1 And countr > 0 Then
                Form1.rtbARK.Select(MatchList(countr - 1).Index + Isel, MatchList(countr - 1).Length)
                finds += 1
                IsUsed = True
            Else
                If Not IsSelected Then Form1.rtbARK.Select(Form1.rtbARK.SelectionStart, 0)
            End If
            lblFINDS.Text = "Finds = " & finds
            AfterCheck()
        Else
            ShakeIt()
        End If
    End Sub

    Private Sub BtnREPLACEALL_Click(sender As Object, e As EventArgs) Handles btnREPLACEALL.Click
        Prepare()
        If content <> "" And searchTerm <> "" And tbSEARCH.Text <> "" Then
            ClearAll()
            ListMatch()

            If tbSEARCH.Text = rtbREPLACE.Text Then
                IsSame = True
                Me.BackColor = specialcolor
            End If

            If MatchList.Count > 0 Then
                For i As Integer = MatchList.Count - 1 To 0 Step -1
                    Form1.rtbARK.Select(MatchList(i).Index + Isel, MatchList(i).Length) 'Markerar den sökta strängen.

                    If IsOnefont Then
                        If IsSame Then
                            Form1.rtbARK.SelectedText = SC
                        Else
                            rtbREPLACE.Select(0, rtbREPLACE.Text.Length) 'Krävs för att alla variationer ska tas med.
                            rtbREPLACE.Copy()
                            Form1.rtbARK.Paste()
                        End If
                    Else
                        If IsSame Then
                            Form1.rtbARK.SelectedText = SC
                        Else
                            Form1.rtbARK.SelectedText = rtbREPLACE.Text
                        End If
                    End If
                    finds += 1
                Next i
            Else
                ShakeIt()
            End If
            IsUsed = True
            lblFINDS.Text = "Finds = " & finds
            AfterCheck()

            If IsSelected Then
                Form1.rtbARK.Select(Isel, Lsel)
                Me.BackColor = selectcolor
            End If
        End If
    End Sub

    Private Sub AfterCheck() 'Ändrar tillbaka checkboxarna igen, om de har ändrats?
        If IsCase Then
            cbCASE.Checked = True
        Else
            cbCASE.Checked = False
        End If
        If IsWhole Then
            cbWHOLE.Checked = True
        Else
            cbWHOLE.Checked = False
        End If
        tbSEARCH.Text = searchTerm
    End Sub

    Private Sub BtnCLEAR_Click(sender As Object, e As EventArgs) Handles btnCLEAR.Click
        If Not IsSelected Then
            Form1.rtbARK.Select(Form1.rtbARK.SelectionStart, Form1.rtbARK.TextLength)
            Threading.Thread.Sleep(100)
        End If
        ClearAll()
    End Sub

    Private Sub ClearAll()
        Form1.rtbARK.Select(Form1.rtbARK.SelectionStart, 0)
        Me.BackColor = mecolor

        If IsSame Then
            If IsOnefont Then
                While Form1.rtbARK.Text.Contains(SC) 'Sofistikerad replace-funktion.
                    rtbREPLACE.Select(0, rtbREPLACE.Text.Length)
                    rtbREPLACE.Copy()
                    Form1.rtbARK.Select(Form1.rtbARK.Text.IndexOf(SC), SC.Length)
                    Form1.rtbARK.Paste()
                End While
            Else
                Form1.rtbARK.Rtf = Form1.rtbARK.Rtf.Replace(SC, rtbREPLACE.Text)
            End If
        End If
        lblFINDS.Text = "Finds = ?"
        IsSelected = False
        cbCASE.Checked = False
        cbWHOLE.Checked = False
        IsUsed = False
        IsSame = False
        finds = 0
        countr = 0
    End Sub

    Private Sub ShakeIt()
        For i As Integer = 0 To 500
            Me.Left += 5
            Me.Left -= 5
        Next i
    End Sub

End Class