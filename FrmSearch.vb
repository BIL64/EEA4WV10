Imports System.Text.RegularExpressions

Public Class FrmSearch

    Dim MATCHES As MatchCollection 'Lagrar funna söktermer.
    Dim MatchList As New List(Of Object) 'Söktermerna i MATCHES men som kan nås direkt.
    Dim SAI As New List(Of Integer) 'Lagring av index-lista.
    Dim SAL As New List(Of Integer) 'Lagring av length-lista.
    Dim SAF As New List(Of Font) 'Lagring av textsnitt-lista.
    Dim SAC As New List(Of Color) 'Lagring av förgrundsfärg-lista.
    Dim content As String 'Innehållet i rtbARK.
    Dim searchTerm As String = "" 'Sökterm.
    Dim IsSelected As Boolean = False 'Är texten markerad?
    Dim IsUsed As Boolean = False 'Pågår sökning?
    Dim IsClear As Boolean = True 'Är listorna rensade?
    Dim IsCase As Boolean = False 'Är skriftlägeskänslig på?
    Dim IsWhole As Boolean = False 'Är skriftlägeskänslig på?
    Dim IsAll As Boolean = False 'Om sökning på allt.
    Dim finds As Integer = 0 'Räknare för antal sökta.
    Dim Isel, Lsel As Integer 'Index och Length för markerat innehåll.
    Dim mecolor, selectcolor As Color 'Färgen på windowsformen och markeringsfärg.

    Private Sub FrmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbSEARCH.Font = Form1.nudSL.Font 'Tilldelar textboxen samma typsnitt som den på Form1.
        lblFINDS.Text = "Finds = ?"
        mecolor = Me.BackColor
        selectcolor = Color.LightSteelBlue
        ttSEARCH.OwnerDraw = True
        ttSEARCH.SetToolTip(btnSEARCHALL, "The font style changes if the keyword         " _
        & vbCrLf & "has multiple colors or sizes!")
        AddHandler ttSEARCH.Draw, AddressOf ToolTip_Draw
    End Sub

    Private Sub ToolTip_Draw(sender As Object, e As DrawToolTipEventArgs)
        Dim f As New Font("Arial", 10.0F)
        ttSEARCH.BackColor = Color.FromArgb(255, 235, 235)
        e.DrawBackground()
        e.DrawBorder()
        e.Graphics.DrawString(e.ToolTipText, f, Brushes.Black, New PointF(2, 2))
    End Sub

    Public Sub Search_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        ClearAll()
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
            Me.BackColor = selectcolor
        Else
            If IsAll Then
                Isel = 0
                content = Form1.rtbARK.Text
            Else
                content = Form1.rtbARK.Text.Substring(Isel, Form1.rtbARK.TextLength - Isel)
            End If
            Me.BackColor = mecolor
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
        If IsClear And searchTerm <> "" And content <> "" Then

            ListMatch()
            If MatchList.Count > 0 And MatchList.Count > finds Then
                Form1.rtbARK.Select(MatchList(finds).Index + Isel, MatchList(finds).Length) 'Markerar den sökta strängen.
                finds += 1
                IsUsed = True
            Else
                If Not IsSelected Then Form1.rtbARK.Select(Form1.rtbARK.SelectionStart, 0)
                ShakeIt()
            End If
            lblFINDS.Text = "Finds = " & finds
            AfterCheck()
        Else
            ShakeIt()
        End If
    End Sub

    Private Sub BtnSEARCHALL_Click(sender As Object, e As EventArgs) Handles btnSEARCHALL.Click
        IsAll = True
        Prepare()
        If searchTerm <> "" And content <> "" Then
            ListMatch()
            ClearAll()
            IsAll = True

            If MATCHES IsNot Nothing Then
                For Each match As Match In MATCHES
                    Form1.rtbARK.Select(match.Index + Isel, match.Length) 'Markerar den sökta strängen.
                    SAI.Add(match.Index + Isel) 'Sparar undan position av markering.
                    SAL.Add(match.Length) 'Sparar undan längd av markering.

                    If Form1.rtbARK.SelectionFont IsNot Nothing And Form1.rtbARK.SelectionColor <> Nothing Then 'Font [Empty] & Color [Empty]
                        SAF.Add(Form1.rtbARK.SelectionFont) 'Sparar undan textsnitt för markering.
                        Form1.rtbARK.SelectionFont = New Font(Form1.rtbARK.SelectionFont.Name,
                        Form1.rtbARK.SelectionFont.Size, FontStyle.Bold Or FontStyle.Underline) 'Fet och understruket!
                        SAC.Add(Form1.rtbARK.SelectionColor) 'Sparar undan förgrundsfärg av markering.
                        Form1.rtbARK.SelectionColor = MarkerColor(Form1.rtbARK.SelectionColor)
                    Else
                        If Form1.rtbARK.SelectionFont Is Nothing Then
                            SAF.Add(Nothing) 'Om sökordets text har flera textsnitt.
                        Else
                            SAF.Add(Form1.rtbARK.SelectionFont) 'Sparar undan textsnitt för markering.
                            Form1.rtbARK.SelectionFont = New Font(Form1.rtbARK.SelectionFont.Name,
                            Form1.rtbARK.SelectionFont.Size, FontStyle.Bold Or FontStyle.Underline) 'Fet och understruket!
                        End If

                        If Form1.rtbARK.SelectionColor <> Nothing Then
                            SAC.Add(Form1.rtbARK.SelectionColor) 'Sparar undan förgrundsfärg av markering.
                            Form1.rtbARK.SelectionColor = MarkerColor(Form1.rtbARK.SelectionColor)
                        Else
                            SAC.Add(Color.Black) 'Om sökordets text har flera färger?
                            Form1.rtbARK.SelectionColor = Color.FromArgb(200, 0, 200) 'Dark magenta
                        End If
                    End If
                        finds += 1
                Next
            Else
                ShakeIt()
            End If
            IsUsed = True
            IsClear = False
            lblFINDS.Text = "Finds = " & finds

            If MATCHES IsNot Nothing Then If MATCHES.Count = 0 Then ShakeIt()
            Form1.rtbARK.ReadOnly = True 'Förhindrar att man kan ändra i innehållet.
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

    Private Function MarkerColor(textcolorin As Color) As Color 'Returnerar avvägd markeringsfärg.
        'Markörens färg bestäms av textens färg.
        If textcolorin.R > 100 And textcolorin.B < 200 Then
            Return Color.Blue
        Else Return Color.FromArgb(200, 0, 200) 'Dark magenta
        End If
    End Function

    Private Sub BtnCLEAR_Click(sender As Object, e As EventArgs) Handles btnCLEAR.Click
        If Not IsAll Then
            Form1.rtbARK.Select(Form1.rtbARK.SelectionStart, Form1.rtbARK.TextLength)
            Threading.Thread.Sleep(100)
        End If
        ClearAll()
    End Sub

    Private Sub ClearAll()
        For i As Integer = 0 To SAI.Count - 1
            Form1.rtbARK.Select(SAI(i), SAL(i))
            If SAF(i) IsNot Nothing Then Form1.rtbARK.SelectionFont = SAF(i)
            Form1.rtbARK.SelectionColor = SAC(i)
        Next i

        Form1.rtbARK.Select(Form1.rtbARK.SelectionStart, 0)
        Me.BackColor = mecolor
        SAI.Clear()
        SAL.Clear()
        SAF.Clear()
        SAC.Clear()
        Form1.rtbARK.ReadOnly = False
        lblFINDS.Text = "Finds = ?"
        cbCASE.Checked = False
        cbWHOLE.Checked = False
        IsUsed = False
        IsClear = True
        IsAll = False
        finds = 0
    End Sub

    Private Sub ShakeIt()
        For i As Integer = 0 To 500
            Me.Left += 5
            Me.Left -= 5
        Next i
    End Sub

End Class