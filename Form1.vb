Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Text
Imports System.Drawing.Text

Public Class Form1

    Const X_skarm As Integer = 836
    Dim Y_skarm As Integer
    Const x_panel As Integer = 750
    Const y_panel As Integer = 1180
    Dim arkX_A4 As Integer
    Dim arkY_A4 As Integer
    Dim arkY_A4S As Integer 'För att A4-arket ska få plats på skärmen.
    Dim arkX_pos As Integer
    Dim arkY_pos As Integer
    Dim Y_hojden As Integer 'Pollar hela tiden av höjden av innehållet.
    Dim total_pages, goto_page As Integer 'Sidhantering.
    Dim selstart, sellength, startsample As Integer 'Används för att återställa textmarkeringen och för IsSuper.
    Dim CONTROLSTR, jobs(10) As String 'Kollar om man exempelvis försöker avsluta utan att man först sparat jobbet och senaste jobbfiler.
    Public browserfile As String 'Den fil som används för hyperlänkar i texten.
    ReadOnly filindata As Byte() 'Filens innehåll.
    Dim IsChanged As Boolean 'Blir sann om innehållet i rtbARK har modifieras på något vis.
    Dim inopendialog As Boolean 'Sant om OpenFileDialog och falsk om SaveFileDialog. 
    Dim ejoppnat As Boolean = True 'Har man tidigare öppnat en fil?
    Dim ejsparat As Boolean = True 'Har man tidigare sparat en fil?
    Dim ejbild As Boolean = True 'Har man tidigare öppnat en fil?
    Dim IsEE As Boolean = True 'Växlar visning av ABOUT.
    Public Rtf_ON As Boolean = True 'Är det en RTF-fil eller en ASCII-fil?
    Public CODENAME As String = "" 'Typ av filkodning gällande textfiler.
    Public IsEncode As Boolean = False 'När användaren valt en egen kodning.
    Public IsEncodesave As Boolean = False 'Om använaren vill att vald kodning också ska sparas.
    Public codetype As Encoding 'Typ av kodning som användaren valt.
    Public staycoded As Byte = 0 'Sparar inställning gällande vilken radioknapp som är vald.
    Public IsBackColor As Boolean 'Val av text eller textbakgrundsfärg.
    Public IsA4Color As Boolean 'Om bakgrundsfärg på arket.
    Dim format_F As Font 'Format för vald font.
    Dim format_C, format_BC As Color 'Format för vald text- och bakgrundsfärg.
    Dim format_ON As Boolean = False 'Har "Format"-knappen tryckts ned?
    Public indent_V, bull_LI, bull_BI, bull_RI As Integer 'Ifall man ändrar värdet för indrag och i punktlistor.
    Public IsNumber, IsCapital, IsAlpha, IsZero, IsSave As Boolean 'Är det nummer/bokstäver? Är det versaler/gemener? Är det arabiska/romerska? Är från noll? Är sparad?
    Public Psign As Char 'Tecknet efter siffran eller bokstaven.
    Public F10 As String 'Fyller med nollor för tal mindre än 10.
    Public F100 As String 'Fyller med nollor för tal mindre än 100.
    Public IsASCII As Boolean = True 'Fungerar utökning av ASCII-koder?
    Dim LastCharPrinted As Integer 'För utskrift i RTB-formatet.
    Dim job As Byte 'Antalet jobbfiler.
    Dim IsSuper As Boolean 'Skiftar mellan exponent och index.
    Dim supersize As Byte = 10 'Fontstorlek.
    Public tabint As Integer 'Sparar tabulatorinställningen.
    Private special1, special2, special3 As New PrivateFontCollection() 'Global lagring av PFC-instanserna så att inte Garbage Collectorn kan ta bort dem.
    Dim sfe14 As Font
    Dim sfe20B As Font
    Dim ef22 As Font
    'Threading.Thread.Sleep(1000) Är användbart då man vill ha en tidsfördröjning (1 sekund).
    'Task.WaitAll() Är användbar då man vill att alla operationer först ska genomfördas, innan...

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Anropas direkt vid start.
        SpecialFonts()

        Try
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance) 'Utökning av ascii-koder.
            'Dim enc1252 = Encoding.GetEncoding(1252)
        Catch
            IsASCII = False 'Systemet tillåter inte utökade ascii-koder.
        End Try
        Me.Width = X_skarm
        Y_skarm = My.Computer.Screen.WorkingArea.Height - 5
        Me.Height = Y_skarm
        pARK.Width = x_panel
        pARK.Height = Y_skarm - 150
        arkY_A4 = 1060 'Lämplig höjd för ett A4. OBS två ställen (1060)!
        arkY_A4S = pARK.Height - y_panel + arkY_A4

        arkX_A4 = 625 'Lämplig bredd för ett A4.
        rtbARK.Size = New Size(arkX_A4, arkY_A4S)
        arkX_pos = 90 'Lämpligt horisontellt indrag för ett A4.
        arkY_pos = 60 'Lämpligt vertikalt indrag för ett A4.
        rtbARK.Location = New Point(arkX_pos, arkY_pos)
        rtbARK.Font = New Font("Times New Roman", 12)
        IsSuper = True
        startsample = 0
        tabint = 48 '48 pixlar är uppmätt standardtabbstorlek.
        tbSNITT.Font = New Font("Times New Roman", 10)
        tbSNITT.Text = "Times New Roman"
        nudSL.Font = New Font("Times New Roman", 10)
        nudSL.Text = "12"
        btnSAVE.ForeColor = Color.Navy

        nudLEFT.Text = arkX_pos
        nudRIGHT.Text = x_panel - arkX_A4 - arkX_pos
        nudTOP.Text = arkY_pos
        arkY_A4 = 1060 'Lämplig höjd för ett A4. OBS två ställen (1060)!
        nudBOTTOM.Text = y_panel - arkY_A4 - arkY_pos

        CType(tsmSTART.DropDown, ToolStripDropDownMenu).ShowImageMargin = False
        CType(tsmEDIT.DropDown, ToolStripDropDownMenu).ShowImageMargin = False
        CType(tsmFORMAT.DropDown, ToolStripDropDownMenu).ShowImageMargin = False
        CType(tsmOBJECT.DropDown, ToolStripDropDownMenu).ShowImageMargin = False

        indent_V = 10
        bull_LI = 10
        bull_BI = 20
        bull_RI = 40
        IsNumber = True
        IsCapital = True
        IsAlpha = True
        IsZero = False
        IsSave = False
        Psign = "."
        F10 = " "
        F100 = " "

        job = 0
        SampleAndReset(True)
        IfFilesExist()
        SetCustomA4L()

        FrmEncoding.rbECAUTO.Checked = True 'Auto är standardinställningen för kodningstypen.
        rtbARK.AcceptsTab = True
        MyBase.AutoScroll = True
    End Sub

    Private Declare Function ShowScrollBar Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal wBar As Integer, ByVal bShow As Boolean) As Boolean
    Protected Overrides Sub WndProc(ByRef m As Message) 'Av user2480047. Gör så att inte den vertikala scrollisten dyker upp.
        Try
            ShowScrollBar(MyBase.Handle, 1, False)
        Catch
            'Ingen åtgärd
        End Try
        MyBase.WndProc(m)
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged 'Om programfönstrets storlek (höjd) ändras.
        pARK.Height = Me.Height - 150
        arkY_pos = nudTOP.Text
        arkY_A4 = y_panel - arkY_pos - nudBOTTOM.Text

        arkY_A4S = pARK.Height - y_panel + arkY_A4
        rtbARK.Size = New Size(arkX_A4, arkY_A4S)
        rtbARK.Location = New Point(arkX_pos, arkY_pos)
    End Sub

    Private Sub RtbARK_KeyDown(sender As Object, e As KeyEventArgs) Handles rtbARK.KeyDown 'Copilots förslag: När man kopierar från en extern källa.
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.V Then
            ' Stop the default paste action
            e.Handled = True

            Try
                ' Check if the clipboard contains rich text format (RTF) data
                If Clipboard.ContainsText(TextDataFormat.Rtf) Then
                    ' Insert RTF data into the rich text box
                    Dim rtfText As String = Clipboard.GetText(TextDataFormat.Rtf)
                    rtbARK.SelectedRtf = rtfText
                Else
                    ' Insert plain text data into the rich text box
                    Dim plainText As String = Clipboard.GetText(TextDataFormat.Text)
                    Dim selectionStart As Integer = rtbARK.SelectionStart
                    rtbARK.Text = rtbARK.Text.Insert(selectionStart, plainText)
                    rtbARK.SelectionStart = selectionStart + plainText.Length
                End If
            Catch ex As Exception
                MessageBox.Show("Cannot insert object" & vbCrLf & ex.Message, "Object insert error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
            End Try
        End If
    End Sub

    Private Sub IfFilesExist() 'Laddar jobb och skapar nya filer om någon saknas.
        Dim fileReader As StreamReader

        If My.Computer.FileSystem.FileExists("LatestJob.var") Then
            fileReader = My.Computer.FileSystem.OpenTextFileReader("LatestJob.var")

            Do While fileReader.Peek() <> -1 'Läser rad för rad och lägger sökvägarna i en array.
                jobs(job) = fileReader.ReadLine()
                Dim newMenu As New ToolStripMenuItem() With {.Text = jobs(job), .Name = "mnuItem" & job}
                tsmiLatest.DropDownItems.Add(newMenu) 'Här sker själva tilldelningen av en ny submeny.
                AddHandler newMenu.Click, AddressOf MenuItems_Clicked 'Här kopplas submenyn till en subrutin.
                job += 1
            Loop

            fileReader.Close()
        End If

        If My.Computer.FileSystem.FileExists("Browser.var") Then
            browserfile = My.Computer.FileSystem.ReadAllText("Browser.var")
        Else
            My.Computer.FileSystem.WriteAllText("Browser.var", "explorer.exe", False)
            MessageBox.Show("Cannot find browser file", "File recreated", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End If

        If Not My.Computer.FileSystem.FileExists("Custom.var") Then
            My.Computer.FileSystem.WriteAllText("Custom.var", "05|#|05|#|05|#|05|#|False|@|Consolas|#|11|#|05|#|05|#|05|#|05|#|X|#|Y|#|H", False)
            MessageBox.Show("Cannot find custom file", "File recreated", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End If

        If Not My.Computer.FileSystem.FileExists("Wordlang.var") Then
            My.Computer.FileSystem.WriteAllText("Wordlang.var", "1033=English - United States", False)
            MessageBox.Show("Cannot find word-language file", "File recreated", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End If
    End Sub

    Private Sub SetCustomA4L() 'Applicerar egen A4-storlek om Custom.var är sant och placerar programfönstret om <> XY.
        Dim str_custom As String
        Dim array_C As Array 'Custom.
        Dim array_P1, array_P2 As Array 'Part 1 & 2 of custom.

        Try
            str_custom = My.Computer.FileSystem.ReadAllText("Custom.var")
            array_C = str_custom.Split("|@|")
            array_P1 = array_C(0).ToString().Split("|#|")
            array_P2 = array_C(1).ToString().Split("|#|")

            If array_P1(4).ToString() = "True" Then

                nudLEFT.Text = array_P1(0)
                nudRIGHT.Text = array_P1(1)
                nudTOP.Text = array_P1(2)
                nudBOTTOM.Text = array_P1(3)

                arkX_pos = nudLEFT.Text
                arkX_A4 = x_panel - arkX_pos - nudRIGHT.Text
                arkY_pos = nudTOP.Text
                arkY_A4 = y_panel - arkY_pos - nudBOTTOM.Text

                arkY_A4S = pARK.Height - y_panel + arkY_A4
                rtbARK.Size = New Size(arkX_A4, arkY_A4S)
                rtbARK.Location = New Point(arkX_pos, arkY_pos)
            End If

            If array_P2(6).ToString() <> "X" And array_P2(7).ToString() <> "Y" Then 'Programfönstrets position och höjd.
                Me.Location = New Point(array_P2(6), array_P2(7))
                Me.Height = array_P2(8)
                pARK.Height = array_P2(8) - 150
                arkY_pos = nudTOP.Text
                arkY_A4 = y_panel - arkY_pos - nudBOTTOM.Text

                arkY_A4S = pARK.Height - y_panel + arkY_A4
                rtbARK.Size = New Size(arkX_A4, arkY_A4S)
                rtbARK.Location = New Point(arkX_pos, arkY_pos)
            End If
        Catch
            str_custom = "05|#|05|#|05|#|05|#|False|@|Consolas|#|11|#|05|#|05|#|05|#|05|#|X|#|Y|#|H"
            My.Computer.FileSystem.WriteAllText("Custom.var", str_custom, False)
        End Try
    End Sub

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing 'När man stänger med krysset.
        If IsChanged Then
            Dim resultat As DialogResult = MessageBox.Show("Cancel without saving", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)

            Select Case resultat
                Case DialogResult.Yes
                    End
                Case DialogResult.No
                    e.Cancel = True
                    Exit Sub
                Case Else
                    e.Cancel = True
                    Exit Sub
            End Select
        Else
            End
        End If
    End Sub

    Private Sub RtbARK_TextChanged(sender As Object, e As EventArgs) Handles rtbARK.TextChanged 'Övervakar om innehållet förändras.
        btnSAVE.Text = "S a v e"

        If CONTROLSTR <> rtbARK.Text Then
            IsChanged = True
            btnSAVE.ForeColor = Color.Red
        Else
            IsChanged = False
            btnSAVE.ForeColor = Color.Navy
        End If
    End Sub

    Private Sub BtnSNITT_Click(sender As Object, e As EventArgs) Handles btnSNITT.Click 'Fixar nytt teckensnitt etcetera när man klickar "OK".
        a4wFontDialog.Font = rtbARK.SelectionFont
        If a4wFontDialog.ShowDialog <> DialogResult.Cancel Then
            rtbARK.SelectionFont = a4wFontDialog.Font
            rtbARK.SelectionColor = a4wFontDialog.Color
            tbSNITT.Font = New Font(a4wFontDialog.Font.Name, 10)
            tbSNITT.Text = a4wFontDialog.Font.Name
            nudSL.Font = New Font(a4wFontDialog.Font.Name, 10)
            nudSL.Text = CInt(a4wFontDialog.Font.Size)
        End If
    End Sub

    Private Sub FdA4W_Apply(sender As Object, e As EventArgs) Handles a4wFontDialog.Apply 'Fixar nytt teckensnitt etcetera när man klickar "Verkställ".
        rtbARK.SelectionFont = a4wFontDialog.Font
        rtbARK.SelectionColor = a4wFontDialog.Color
        tbSNITT.Font = New Font(a4wFontDialog.Font.Name, 10)
        tbSNITT.Text = a4wFontDialog.Font.Name
        nudSL.Font = New Font(a4wFontDialog.Font.Name, 10)
        nudSL.Text = CInt(a4wFontDialog.Font.Size)
    End Sub

    Private Sub RtbARK_MouseDown(sender As Object, e As MouseEventArgs) Handles rtbARK.MouseDown 'Visar textens teckensnitt och storlek där man klickar.
        Try
            tbSNITT.Font = New Font(rtbARK.SelectionFont.Name, 10)
            nudSL.Font = New Font(rtbARK.SelectionFont.Name, 10)
            tbSNITT.Text = rtbARK.SelectionFont.Name
            nudSL.Text = CInt(rtbARK.SelectionFont.Size)
        Catch
            'Markerar man olika typsnitt och klickar i markeringen så kommer man hit.
        End Try
    End Sub

    Private Sub RtbARK_MouseUp(sender As Object, e As MouseEventArgs) Handles rtbARK.MouseUp 'Lämnar hämtat format till den text som markerats.
        If format_ON Then
            Try
                rtbARK.SelectionFont = format_F
                rtbARK.SelectionColor = format_C
                rtbARK.SelectionBackColor = format_BC
                format_ON = False
            Catch
                MessageBox.Show("Cannot read font", "Multiple fonts", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
                format_ON = False
            End Try
        End If
    End Sub

    Private Sub NudSL_ValueChanged(sender As Object, e As EventArgs) Handles nudSL.ValueChanged 'Ökar eller minskar storleken på aktuellt teckensnitt.
        Dim sel_s As Integer = rtbARK.SelectionStart
        Dim sel_l As Integer = rtbARK.SelectedText.Length

        Try
            For index = sel_s To sel_l + sel_s - 1
                rtbARK.Select(index, 1)
                rtbARK.SelectionFont = New Font(rtbARK.SelectionFont.Name, nudSL.Value, rtbARK.SelectionFont.Style)
            Next
        Catch ex As Exception
            MessageBox.Show("Cannot read font" & vbCrLf & ex.Message, "Font size error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
        rtbARK.Select(sel_s, sel_l)
    End Sub

    Private Sub RtbARK_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles rtbARK.LinkClicked 'Om man har klickat på en hyperlänk.
        Try
            Process.Start(browserfile, e.LinkText)
        Catch ex As Exception
            MessageBox.Show("Cannot find browser or address" & vbCrLf & ex.Message, "Hyperlink error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Function DetectFileEncoding(filePath As String) As Encoding 'Copilots förslag.
        Dim bomBytes As Byte() = New Byte(4) {}
        Using fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
            fs.Read(bomBytes, 0, 4)
        End Using
        If bomBytes(0) = &HFF AndAlso bomBytes(1) = &HFE Then
            ' UTF-16 (Little-Endian)
            CODENAME = "UTF16 LE"
            Return Encoding.Unicode
        ElseIf bomBytes(0) = &HFE AndAlso bomBytes(1) = &HFF Then
            ' UTF-16 (Big-Endian)
            CODENAME = "UTF16 BE"
            Return Encoding.BigEndianUnicode
        ElseIf bomBytes(0) = 0 AndAlso bomBytes(1) = 0 AndAlso bomBytes(2) = &HFE AndAlso bomBytes(3) = &HFF Then
            ' UTF-32 (Big-Endian)
            CODENAME = "UTF32 BE"
            Return Encoding.UTF32
        ElseIf bomBytes(0) = &H2B AndAlso bomBytes(1) = &H2F AndAlso bomBytes(2) = &H76 Then
            ' UTF-7
            CODENAME = "UTF7"
            Return Encoding.UTF7
        Else
            ' Fallback till UTF-8 (utan BOM). Även ANSI- och Latin1-kodade filer hamnar här.
            CODENAME = "UTF8"
            Return Encoding.UTF8
        End If
    End Function

    Private Sub BtnOPEN_Click(sender As Object, e As EventArgs) Handles btnOPEN.Click 'Öppnar filer.
        Dim filtyp, filnamn As String
        Dim f_langd As Byte

        If btnSAVE.Text = "Press!" Then
            btnSAVE.Text = "Save"
            btnSAVE.ForeColor = Color.Navy
        End If

        If ejoppnat Then 'Gör en förladdning så att dessa parametrar kan aktiveras vid det första klicket.
            a4wOpenFileDialog.Title = "Open File"
            a4wOpenFileDialog.FileName = ""
            ejoppnat = False
        End If

        If a4wOpenFileDialog.ShowDialog = DialogResult.OK Then
            a4wOpenFileDialog.Title = "Open File"
            filtyp = a4wOpenFileDialog.FileName
            filnamn = filtyp
            f_langd = filnamn.Length

            If IsChanged Then 'Larmar om man försöker öppna en ny fil utan att först sparat det man håller på med.
                Dim resultat As DialogResult = MessageBox.Show("Continue to finish work before opening file", "Open file", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                If resultat = DialogResult.Yes Then Exit Sub
            End If

            If f_langd > 3 Then filtyp = filtyp.Substring(f_langd - 4, 4) 'Hämtar fyra tecken av filtyp .rtf

            If filtyp = ".rtf" Or filtyp = ".Rtf" Or filtyp = ".rTf" Or filtyp = ".rtF" Or filtyp = ".RTf" Or
            filtyp = ".rTF" Or filtyp = ".RtF" Or filtyp = ".RTF" Then 'Kollar om filtypen är av Rich text-formatet.
                rtbARK.LoadFile(a4wOpenFileDialog.FileName, RichTextBoxStreamType.RichText) 'Laddar upp i Rich text-formatet.
                Me.Text = "EE A4W Portrait [RTF] - " & a4wOpenFileDialog.SafeFileName
                Rtf_ON = True
                btnSAVE.Text = "Save"
                btnSAVE.ForeColor = Color.Navy
                SampleAndReset(True)
            Else
                OpenTXTFile(filnamn) 'Laddar upp i textformatet.
                Rtf_ON = False
                btnSAVE.Text = "Save"
                btnSAVE.ForeColor = Color.Navy
                SampleAndReset(True)
            End If

            Write_Jobs(a4wOpenFileDialog.FileName)
            inopendialog = True
        End If
    End Sub

    Private Sub OpenTXTFile(path As String) 'Laddar upp i det enkla textformatet men försöker först utröna hur den är kodad.
        Dim str_custom As String
        Dim array_C As Array 'Custom.
        Dim array_P2 As Array 'Part 2 of custom.

        Try
            If IsEncode Then
                'Använarens kodval.
                rtbARK.Text = My.Computer.FileSystem.ReadAllText(path, codetype)
            Else
                'Automatiskt kodval.
                Dim detected As Encoding = DetectFileEncoding(path)
                Select Case CODENAME
                    Case "UTF7"
                        rtbARK.Text = My.Computer.FileSystem.ReadAllText(path, detected)
                    Case "UTF8"
                        rtbARK.Text = My.Computer.FileSystem.ReadAllText(path, detected)
                    Case "UTF16 LE"
                        rtbARK.Text = My.Computer.FileSystem.ReadAllText(path, detected)
                    Case "UTF16 BE"
                        rtbARK.Text = My.Computer.FileSystem.ReadAllText(path, detected)
                    Case "UTF32 BE"
                        rtbARK.Text = My.Computer.FileSystem.ReadAllText(path, detected)
                End Select
            End If

        Catch ex As Exception
            CODENAME = "UNKNOWN"
            rtbARK.LoadFile(a4wOpenFileDialog.FileName, RichTextBoxStreamType.PlainText)
            MessageBox.Show("Could not find correct encoding" & vbCrLf & ex.Message, "Default encoding", MessageBoxButtons.OK, MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try

        Try
            str_custom = My.Computer.FileSystem.ReadAllText("Custom.var")
            array_C = str_custom.Split("|@|")
            array_P2 = array_C(1).ToString().Split("|#|")

            Me.Text = "EE A4W Portrait [" & CODENAME & "] - " & a4wOpenFileDialog.SafeFileName
            rtbARK.Font = New Font(array_P2(0).ToString(), CInt(array_P2(1)))
            tbSNITT.Font = New Font(array_P2(0).ToString(), 10)
            tbSNITT.Text = array_P2(0).ToString()
            nudSL.Font = New Font(array_P2(0).ToString(), 10)
            nudSL.Text = array_P2(1).ToString()

            nudLEFT.Text = array_P2(2)
            nudRIGHT.Text = array_P2(3)
            nudTOP.Text = array_P2(4)
            nudBOTTOM.Text = array_P2(5)

            arkX_pos = nudLEFT.Text
            arkX_A4 = x_panel - arkX_pos - nudRIGHT.Text
            arkY_pos = nudTOP.Text
            arkY_A4 = y_panel - arkY_pos - nudBOTTOM.Text

            arkY_A4S = pARK.Height - y_panel + arkY_A4
            rtbARK.Size = New Size(arkX_A4, arkY_A4S)
            rtbARK.Location = New Point(arkX_pos, arkY_pos)
        Catch
            rtbARK.Font = New Font("Consolas", 11)
            tbSNITT.Font = New Font("Consolas", 10)
            tbSNITT.Text = "Consolas"
            nudSL.Font = New Font("Consolas", 10)
            nudSL.Text = "11"
            MessageBox.Show("Cannot read custom file", "Corrupt file", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
        rtbARK.ScrollBars = ScrollBars.None
        rtbARK.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub BtnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click 'Sparar filer.
        Dim filtyp, filnamn As String
        Dim f_langd As Byte

        If btnSAVE.Text = "Press!" Or btnSAVE.Text = "S a v e" Then
            btnSAVE.Text = "Save"
            btnSAVE.ForeColor = Color.Navy
        End If

        If ejsparat Then 'Gör en förladdning så att dessa parametrar kan aktiveras vid det första klicket.
            a4wSaveFileDialog.Title = "Save File"
            a4wSaveFileDialog.FileName = ""
            ejsparat = False
        End If

        If Not ejoppnat Then
            If inopendialog Then 'Sparar i ett svep utan att någon dialogruta öppnas först.
                filtyp = a4wOpenFileDialog.FileName
                filnamn = filtyp
                f_langd = filnamn.Length

                If filnamn = Nothing Then
                    btnSAVE.Text = "Press!"
                    btnSAVE.ForeColor = Color.Navy
                    ejoppnat = True
                    Exit Sub
                End If

                If f_langd > 3 Then filtyp = filtyp.Substring(f_langd - 4, 4) 'Hämtar fyra tecken av filtyp .rtf

                If filtyp = ".rtf" Or filtyp = ".Rtf" Or filtyp = ".rTf" Or filtyp = ".rtF" Or filtyp = ".RTf" Or
                filtyp = ".rTF" Or filtyp = ".RtF" Or filtyp = ".RTF" Then 'Kollar om filtypen är av Rich text-formatet.
                    SaveRtfFile(filnamn, False)
                Else
                    SaveTXTFile(filnamn, False)
                End If

            Else
                filtyp = a4wSaveFileDialog.FileName
                filnamn = filtyp
                f_langd = filnamn.Length

                If filnamn = Nothing Then
                    btnSAVE.Text = "Press!"
                    btnSAVE.ForeColor = Color.Navy
                    ejoppnat = True
                    Exit Sub
                End If

                If f_langd > 3 Then filtyp = filtyp.Substring(f_langd - 4, 4) 'Hämtar fyra tecken av filtyp .rtf

                If filtyp = ".rtf" Or filtyp = ".Rtf" Or filtyp = ".rTf" Or filtyp = ".rtF" Or filtyp = ".RTf" Or
                filtyp = ".rTF" Or filtyp = ".RtF" Or filtyp = ".RTF" Then 'Kollar om filtypen är av Rich text-formatet.
                    SaveRtfFile(filnamn, False)
                Else
                    SaveTXTFile(filnamn, False)
                End If
            End If
        Else
            If a4wSaveFileDialog.ShowDialog = DialogResult.OK Then
                a4wSaveFileDialog.Title = "Save File"
                filtyp = a4wSaveFileDialog.FileName
                filnamn = filtyp
                f_langd = filnamn.Length

                If f_langd > 3 Then filtyp = filtyp.Substring(f_langd - 4, 4) 'Hämtar fyra tecken av filtyp .rtf

                If filtyp = ".rtf" Or filtyp = ".Rtf" Or filtyp = ".rTf" Or filtyp = ".rtF" Or filtyp = ".RTf" Or
                filtyp = ".rTF" Or filtyp = ".RtF" Or filtyp = ".RTF" Then 'Kollar om filtypen är av Rich text-formatet.
                    SaveRtfFile(filnamn, True)
                Else
                    SaveTXTFile(filnamn, True)
                End If

                Write_Jobs(a4wSaveFileDialog.FileName)
                inopendialog = False
                ejoppnat = False
            End If
        End If
    End Sub

    Private Sub BtnSAVEAS_Click(sender As Object, e As EventArgs) Handles btnSAVEAS.Click 'Sparar filer som?
        Dim filtyp, filnamn As String
        Dim f_langd As Byte

        If btnSAVE.Text = "Press!" Or btnSAVE.Text = "S a v e" Then
            btnSAVE.Text = "Save"
            btnSAVE.ForeColor = Color.Navy
        End If

        If ejsparat Then 'Gör en förladdning så att dessa parametrar kan aktiveras vid det första klicket.
            a4wSaveFileDialog.Title = "Save File As..."
            a4wSaveFileDialog.FileName = ""
            ejsparat = False
        End If

        If a4wSaveFileDialog.ShowDialog = DialogResult.OK Then
            a4wSaveFileDialog.Title = "Save File As..."
            filtyp = a4wSaveFileDialog.FileName
            filnamn = filtyp
            f_langd = filnamn.Length

            If f_langd > 3 Then filtyp = filtyp.Substring(f_langd - 4, 4) 'Hämtar fyra tecken av filtyp .rtf

            If filtyp = ".rtf" Or filtyp = ".Rtf" Or filtyp = ".rTf" Or filtyp = ".rtF" Or filtyp = ".RTf" Or
            filtyp = ".rTF" Or filtyp = ".RtF" Or filtyp = ".RTF" Then 'Kollar om filtypen är av Rich text-formatet.
                SaveRtfFile(filnamn, True)
            Else
                SaveTXTFile(filnamn, True)
            End If

            Write_Jobs(a4wSaveFileDialog.FileName)
            inopendialog = False
            ejoppnat = False
        End If
    End Sub

    Private Sub SaveRtfFile(filepath As String, headertext As Boolean) 'Sparar endast i Rich text-formatet.
        Try
            rtbARK.SaveFile(filepath, RichTextBoxStreamType.RichText)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Save file error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
        If headertext Then Me.Text = "EE A4W Portrait [RTF] - " & Path.GetFileName(a4wSaveFileDialog.FileName)
        SampleAndReset(False)
    End Sub

    Private Sub SaveTXTFile(filepath As String, headertext As Boolean) 'Sparar endast textfiler beroende på kodningen.
        If IsEncodesave Then
            Try
                rtbARK.SaveFile(filepath, RichTextBoxStreamType.PlainText) 'Sparar med samma format som textfilen är kodad med.
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Save file error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
            End Try
            If headertext Then Me.Text = "EE A4W Portrait [" & CODENAME & "] - " & Path.GetFileName(a4wSaveFileDialog.FileName)
        Else
            Try
                My.Computer.FileSystem.WriteAllText(filepath, rtbARK.Text, False) 'Sparar textfilen som en UTF-8.
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Save file error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
            End Try
            If headertext Then Me.Text = "EE A4W Portrait [UTF8] - " & Path.GetFileName(a4wSaveFileDialog.FileName)
        End If
        SampleAndReset(False)
    End Sub

    Private Sub Write_Jobs(path As String) 'Laddar upp nya jobb i jobb-filen plus en massa annat.
        Dim fileReader As StreamReader
        Dim tal As Byte = job
        Dim new_path As Boolean = True
        Dim position As Byte

        For index = 0 To job - 1 'Kollar om den nya sökvägen och filen redan finns.
            If jobs(index) = path Then
                new_path = False
                position = index
            End If
        Next

        If Not new_path And position = 0 Then Exit Sub

        If new_path Then 'Görs om det är en helt ny sökväg och fil.
            If job > 9 Then jobs(9) = "" 'Om det finns fler än nio jobb så tas den tionde bort.

            For index = job To 1 Step -1 'Alla jobb flyttas upp ett steg.
                jobs(index) = jobs(index - 1)
            Next

            jobs(0) = path 'Nykomlingen.
        Else
            For index = position To 1 Step -1 'Alla jobb under position flyttas upp ett steg.
                jobs(index) = jobs(index - 1)
            Next

            jobs(0) = path 'Aktuell läggs först.
        End If

        While job > 0
            tsmiLatest.DropDownItems.RemoveAt(job - 1) 'Borttagning av alla submenyer.
            job -= 1
        End While

        File.WriteAllText("LatestJob.var", "") 'Skapar filen och laddar den med inget.

        For index = 0 To tal
            If index <> tal Then
                My.Computer.FileSystem.WriteAllText("LatestJob.var", jobs(index) & vbLf, True) 'Laddar filen med en ny och resten gamla jobb.
            Else
                My.Computer.FileSystem.WriteAllText("LatestJob.var", jobs(tal), True) 'Den sista skippar ny rad.
            End If
        Next

        fileReader = My.Computer.FileSystem.OpenTextFileReader("LatestJob.var")

        Do While fileReader.Peek() <> -1 'Läser rad för rad och lägger sökvägarna i en array.
            jobs(job) = fileReader.ReadLine()
            Dim newMenu As New ToolStripMenuItem() With {.Text = jobs(job), .Name = "mnuItem" & job}
            tsmiLatest.DropDownItems.Add(newMenu) 'Här sker själva tilldelningen av en ny submeny.
            AddHandler newMenu.Click, AddressOf MenuItems_Clicked 'Här kopplas submenyn till en subrutin.
            job += 1
        Loop

        fileReader.Close()
    End Sub

    Private Sub NudLEFT_ValueChanged(sender As Object, e As EventArgs) Handles nudLEFT.ValueChanged 'Inställning av arkets bredd - vänster.
        arkX_A4 = x_panel - nudLEFT.Value - nudRIGHT.Text
        arkX_pos = nudLEFT.Value
        rtbARK.Size = New Size(arkX_A4, arkY_A4S)
        rtbARK.Location = New Point(arkX_pos, arkY_pos)
    End Sub

    Private Sub NudRIGHT_ValueChanged(sender As Object, e As EventArgs) Handles nudRIGHT.ValueChanged 'Inställning av arkets bredd - höger.
        arkX_A4 = x_panel - nudLEFT.Text - nudRIGHT.Value
        rtbARK.Size = New Size(arkX_A4, arkY_A4S)
        rtbARK.Location = New Point(arkX_pos, arkY_pos)
    End Sub

    Private Sub NudTOP_ValueChanged(sender As Object, e As EventArgs) Handles nudTOP.ValueChanged 'Inställning av arkets höjd - topp.
        arkY_A4 = y_panel - nudTOP.Value - nudBOTTOM.Text
        arkY_pos = nudTOP.Value
        arkY_A4S = pARK.Height - y_panel + arkY_A4
        rtbARK.Size = New Size(arkX_A4, arkY_A4S)
        rtbARK.Location = New Point(arkX_pos, arkY_pos)
    End Sub

    Private Sub NudBOTTOM_ValueChanged(sender As Object, e As EventArgs) Handles nudBOTTOM.ValueChanged 'Inställning av arkets höjd - botten.
        arkY_A4 = y_panel - nudTOP.Text - nudBOTTOM.Value
        arkY_A4S = pARK.Height - y_panel + arkY_A4
        rtbARK.Size = New Size(arkX_A4, arkY_A4S)
        rtbARK.Location = New Point(arkX_pos, arkY_pos)
    End Sub

    Private Sub BtnLEFT_Click(sender As Object, e As EventArgs) Handles btnLEFT.Click 'Justering av text.
        rtbARK.SelectionAlignment = HorizontalAlignment.Left
        rtbARK.SelectionIndent = 0
        rtbARK.SelectionRightIndent = 0
        rtbARK.SelectionHangingIndent = 0
    End Sub

    Private Sub BtnCENTER_Click(sender As Object, e As EventArgs) Handles btnCENTER.Click 'Justering av text.
        rtbARK.SelectionAlignment = HorizontalAlignment.Center
        rtbARK.SelectionIndent = 0
        rtbARK.SelectionRightIndent = 0
        rtbARK.SelectionHangingIndent = 0
    End Sub

    Private Sub BtnRIGHT_Click(sender As Object, e As EventArgs) Handles btnRIGHT.Click 'Justering av text.
        rtbARK.SelectionAlignment = HorizontalAlignment.Right
        rtbARK.SelectionIndent = 0
        rtbARK.SelectionRightIndent = 2
        rtbARK.SelectionHangingIndent = 0
    End Sub

    Private Sub BtnJUST_Click(sender As Object, e As EventArgs) Handles btnJUST.Click 'Justering av text.
        Dim pf2 As PARAFORMAT2

        pf2.cbSize = CBSIZE
        pf2.dwMask = pf2.dwMask Or PFM_ALIGNMENT
        pf2.wAlignment = PFA_JUSTIFY

        'Allocate memory for the PARAFORMAT2 struct and
        'copy the contents of the struct to this memory
        Dim lParam As IntPtr
        lParam = Marshal.AllocCoTaskMem(Marshal.SizeOf(pf2))
        Marshal.StructureToPtr(pf2, lParam, False)

        Dim iRet As Integer
        iRet = SendMessage(rtbARK.Handle(), EM_SETPARAFORMAT, 0, lParam)

        'Free allocated memory
        Marshal.FreeCoTaskMem(lParam)
        rtbARK.SelectionIndent = 0
        rtbARK.SelectionRightIndent = 2
        rtbARK.SelectionHangingIndent = 0
    End Sub

    Private Sub BtnB_Click(sender As Object, e As EventArgs) Handles btnB.Click 'Fet text.
        selstart = rtbARK.SelectionStart 'Sparar markeringens startposition.
        sellength = rtbARK.SelectionLength 'Sparar markeringens längd.
        Try
            If rtbARK.SelectionFont Is Nothing Then 'Om det finns flera olika fonter.
                For index = 0 To sellength - 1
                    rtbARK.Select(selstart + index, 1)
                    SetStyle_B(rtbARK.SelectionFont)
                Next
            Else
                SetStyle_B(rtbARK.SelectionFont) 'Finns bara en font så blir det enklare.
            End If
            rtbARK.Select(selstart, sellength) 'Markerar det specifika textområdet igen.
        Catch ex As Exception
            MessageBox.Show("Cannot read font" & vbCrLf & ex.Message, "Font error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Sub SetStyle_B(RTB_in As Font)
        If RTB_in.Style = 1 Then 'B
            Fstyle(0) 'R
        ElseIf RTB_in.Style = 3 Then 'B+I
            Fstyle(2) 'I
        ElseIf RTB_in.Style = 5 Then 'B+U
            Fstyle(4) 'U
        ElseIf RTB_in.Style = 7 Then 'B+I+U
            Fstyle(6) 'I+U
        ElseIf RTB_in.Style = 9 Then 'B+S
            Fstyle(8) 'S
        ElseIf RTB_in.Style = 11 Then 'B+I+S
            Fstyle(10) 'I+S
        ElseIf RTB_in.Style = 13 Then 'B+U+S
            Fstyle(12) 'U+S
        ElseIf RTB_in.Style = 15 Then 'B+I+U+S
            Fstyle(14) 'I+U+S
        ElseIf RTB_in.Style = 0 Then 'R
            Fstyle(1) 'B
        ElseIf RTB_in.Style = 2 Then 'I
            Fstyle(3) 'B+I
        ElseIf RTB_in.Style = 4 Then 'U
            Fstyle(5) 'B+U
        ElseIf RTB_in.Style = 6 Then 'I+U
            Fstyle(7) 'B+I+U
        ElseIf RTB_in.Style = 8 Then 'S
            Fstyle(9) 'B+S
        ElseIf RTB_in.Style = 10 Then 'I+S
            Fstyle(11) 'B+I+S
        ElseIf RTB_in.Style = 12 Then 'U+S
            Fstyle(13) 'B+U+S
        ElseIf RTB_in.Style = 14 Then 'I+U+S
            Fstyle(15) 'B+I+U+S
        End If
    End Sub

    Private Sub BtnI_Click(sender As Object, e As EventArgs) Handles btnI.Click 'Kursiv text.
        selstart = rtbARK.SelectionStart 'Sparar markeringens startposition.
        sellength = rtbARK.SelectionLength 'Sparar markeringens längd.
        Try
            If rtbARK.SelectionFont Is Nothing Then 'Om det finns flera olika fonter.
                For index = 0 To sellength - 1
                    rtbARK.Select(selstart + index, 1)
                    SetStyle_I(rtbARK.SelectionFont)
                Next
            Else
                SetStyle_I(rtbARK.SelectionFont) 'Finns bara en font så blir det enklare.
            End If
            rtbARK.Select(selstart, sellength) 'Markerar det specifika textområdet igen.
        Catch ex As Exception
            MessageBox.Show("Cannot read font" & vbCrLf & ex.Message, "Font error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Sub SetStyle_I(RTB_in As Font)
        If RTB_in.Style = 2 Then 'I
            Fstyle(0) 'R
        ElseIf RTB_in.Style = 3 Then 'B+I
            Fstyle(1) 'B
        ElseIf RTB_in.Style = 6 Then 'I+U
            Fstyle(4) 'U
        ElseIf RTB_in.Style = 7 Then 'B+I+U
            Fstyle(5) 'B+U
        ElseIf RTB_in.Style = 10 Then 'I+S
            Fstyle(8) 'S
        ElseIf RTB_in.Style = 11 Then 'B+I+S
            Fstyle(9) 'B+S
        ElseIf RTB_in.Style = 14 Then 'I+U+S
            Fstyle(12) 'U+S
        ElseIf RTB_in.Style = 15 Then 'B+I+U+S
            Fstyle(13) 'B+U+S
        ElseIf RTB_in.Style = 0 Then 'R
            Fstyle(2) 'I
        ElseIf RTB_in.Style = 1 Then 'B
            Fstyle(3) 'B+I
        ElseIf RTB_in.Style = 4 Then 'U
            Fstyle(6) 'I+U
        ElseIf RTB_in.Style = 5 Then 'B+U
            Fstyle(7) 'B+I+U
        ElseIf RTB_in.Style = 8 Then 'S
            Fstyle(10) 'I+S
        ElseIf RTB_in.Style = 9 Then 'B+S
            Fstyle(11) 'B+I+S
        ElseIf RTB_in.Style = 12 Then 'U+S
            Fstyle(14) 'I+U+S
        ElseIf RTB_in.Style = 13 Then 'B+U+S
            Fstyle(15) 'B+I+U+S
        End If
    End Sub

    Private Sub BtnU_Click(sender As Object, e As EventArgs) Handles btnU.Click 'Understruken text.
        selstart = rtbARK.SelectionStart 'Sparar markeringens startposition.
        sellength = rtbARK.SelectionLength 'Sparar markeringens längd.
        Try
            If rtbARK.SelectionFont Is Nothing Then 'Om det finns flera olika fonter.
                For index = 0 To sellength - 1
                    rtbARK.Select(selstart + index, 1)
                    SetStyle_U(rtbARK.SelectionFont)
                Next
            Else
                SetStyle_U(rtbARK.SelectionFont) 'Finns bara en font så blir det enklare.
            End If
            rtbARK.Select(selstart, sellength) 'Markerar det specifika textområdet igen.
        Catch ex As Exception
            MessageBox.Show("Cannot read font" & vbCrLf & ex.Message, "Font error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Sub SetStyle_U(RTB_in As Font)
        If RTB_in.Style = 4 Then 'U
            Fstyle(0) 'R
        ElseIf RTB_in.Style = 5 Then 'B+U
            Fstyle(1) 'B
        ElseIf RTB_in.Style = 6 Then 'I+U
            Fstyle(2) 'I
        ElseIf RTB_in.Style = 7 Then 'B+I+U
            Fstyle(3) 'B+I
        ElseIf RTB_in.Style = 12 Then 'U+S
            Fstyle(8) 'S
        ElseIf RTB_in.Style = 13 Then 'B+U+S
            Fstyle(9) 'B+S
        ElseIf RTB_in.Style = 14 Then 'I+U+S
            Fstyle(10) 'I+S
        ElseIf RTB_in.Style = 15 Then 'B+I+U+S
            Fstyle(11) 'B+I+S
        ElseIf RTB_in.Style = 0 Then 'R
            Fstyle(4) 'U
        ElseIf RTB_in.Style = 1 Then 'B
            Fstyle(5) 'B+U
        ElseIf RTB_in.Style = 2 Then 'I
            Fstyle(6) 'I+U
        ElseIf RTB_in.Style = 3 Then 'B+I
            Fstyle(7) 'B+I+U
        ElseIf RTB_in.Style = 8 Then 'S
            Fstyle(12) 'U+S
        ElseIf RTB_in.Style = 9 Then 'B+S
            Fstyle(13) 'B+U+S
        ElseIf RTB_in.Style = 10 Then 'I+S
            Fstyle(14) 'I+U+S
        ElseIf RTB_in.Style = 11 Then 'B+I+S
            Fstyle(15) 'B+I+U+S
        End If
    End Sub

    Private Sub BtnS_Click(sender As Object, e As EventArgs) Handles btnS.Click 'Överstruken text.
        selstart = rtbARK.SelectionStart 'Sparar markeringens startposition.
        sellength = rtbARK.SelectionLength 'Sparar markeringens längd.
        Try
            If rtbARK.SelectionFont Is Nothing Then 'Om det finns flera olika fonter.
                For index = 0 To sellength - 1
                    rtbARK.Select(selstart + index, 1)
                    SetStyle_S(rtbARK.SelectionFont)
                Next
            Else
                SetStyle_S(rtbARK.SelectionFont) 'Finns bara en font så blir det enklare.
            End If
            rtbARK.Select(selstart, sellength) 'Markerar det specifika textområdet igen.
        Catch ex As Exception
            MessageBox.Show("Cannot read font" & vbCrLf & ex.Message, "Font error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Sub SetStyle_S(RTB_in As Font)
        If RTB_in.Style = 8 Then 'S
            Fstyle(0) 'R
        ElseIf RTB_in.Style = 9 Then 'B+S
            Fstyle(1) 'B
        ElseIf RTB_in.Style = 10 Then 'I+S
            Fstyle(2) 'I
        ElseIf RTB_in.Style = 11 Then 'B+I+S
            Fstyle(3) 'B+I
        ElseIf RTB_in.Style = 12 Then 'U+S
            Fstyle(4) 'U
        ElseIf RTB_in.Style = 13 Then 'B+U+S
            Fstyle(5) 'B+U
        ElseIf RTB_in.Style = 14 Then 'I+U+S
            Fstyle(6) 'I+U
        ElseIf RTB_in.Style = 15 Then 'B+I+U+S
            Fstyle(7) 'B+I+U
        ElseIf RTB_in.Style = 0 Then 'R
            Fstyle(8) 'S
        ElseIf RTB_in.Style = 1 Then 'B
            Fstyle(9) 'B+S
        ElseIf RTB_in.Style = 2 Then 'I
            Fstyle(10) 'I+S
        ElseIf RTB_in.Style = 3 Then 'B+I
            Fstyle(11) 'B+I+S
        ElseIf RTB_in.Style = 4 Then 'U
            Fstyle(12) 'U+S
        ElseIf RTB_in.Style = 5 Then 'B+U
            Fstyle(13) 'B+U+S
        ElseIf RTB_in.Style = 6 Then 'I+U
            Fstyle(14) 'I+U+S
        ElseIf RTB_in.Style = 7 Then 'B+I+U
            Fstyle(15) 'B+I+U+S
        End If
    End Sub

    Private Sub Fstyle(s As Byte) 'Tilldelar vald FontStyle till markerad text
        'FontStyle: 0 = Regular, 1 (-15) = Bold, 2 (-14) = Italic, 3 (-13) = Bold+Italic, 4 (-12) = Underline, 5 (-11) = Bold+Underline, 6 (-10) = Italic+Underline
        '           7 (-9) = Bold+Italic+Underline, 8 (-8) = Strikeout, 9 (-7) = Bold+Strikeout, 10 (-6) = Italic+Strikeout, 11 (-5) = Bold+Italic+Strikeout
        '           12 (-4) = Underline+Strikeout, 13 (-3) = Bold+Underline+Strikeout, 14 (-2) = Italic+Underline+Strikeout, 15 (-1) = Bold+Italic+Underline+Strikout
        rtbARK.SelectionFont = New Font(rtbARK.SelectionFont, s)
    End Sub

    Private Sub BtnSUP_Click(sender As Object, e As EventArgs) Handles btnSUP.Click 'Exponent- och indextext.
        Dim lfont As Font

        selstart = rtbARK.SelectionStart 'Sparar markeringens startposition.
        sellength = rtbARK.SelectionLength 'Sparar markeringens längd.
        Try
            For index = 0 To sellength - 1
                rtbARK.Select(selstart + index, 1)
                If IsSuper Then lfont = New Font(rtbARK.SelectionFont, rtbARK.SelectionFont.Style)

                If selstart <> startsample Then IsSuper = True 'Så att inte en annan plats i texten börjar med IsSuper = false.

                If IsSuper Then
                    lfont = New Font(rtbARK.SelectionFont, rtbARK.SelectionFont.Style)
                    rtbARK.SelectionFont = New Font(lfont.FontFamily, CInt(lfont.Size - lfont.Size * 0.2), lfont.Style)
                    rtbARK.SelectionCharOffset = CInt(lfont.Size * 0.8)
                    supersize = lfont.Size
                Else
                    rtbARK.SelectionCharOffset = CInt(0 - supersize * 0.4)
                End If
            Next

            If IsSuper Then
                IsSuper = False
            Else
                IsSuper = True
            End If
            rtbARK.Select(selstart, sellength) 'Markerar det specifika textområdet igen.
            startsample = selstart
        Catch ex As Exception
            MessageBox.Show("Cannot read font" & vbCrLf & ex.Message, "Font error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Sub BtnOFFSET_Click(sender As Object, e As EventArgs) Handles btnOFFSET.Click 'Avståndet mellan raderna.
        FrmCharOffset.Show()
        IsSuper = True 'Återställer om man vill börja om från början.
    End Sub

    Private Sub BtnCOLOR_Click(sender As Object, e As EventArgs) Handles btnCOLOR.Click 'Väljer textfärg.
        IsBackColor = False
        IsA4Color = False
        FrmBackColor.Show()
    End Sub

    Private Sub BtnBCOLOR_Click(sender As Object, e As EventArgs) Handles btnBCOLOR.Click 'Väljer textbakgrundsfärg.
        IsBackColor = True
        IsA4Color = False
        FrmBackColor.Show()
    End Sub

    Private Sub BtnSELECTALL_Click(sender As Object, e As EventArgs) Handles btnSELECTALL.Click 'Markera allt (miniknapp).
        rtbARK.SelectAll()
    End Sub

    Private Sub BtnDESELECTALL_Click(sender As Object, e As EventArgs) Handles btnDESELECTALL.Click 'Avmarkera allt (miniknapp).
        rtbARK.DeselectAll()
    End Sub

    Private Sub BtnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click 'Sök.
        FrmSearch.Show() 'Med Show() kan man komma åt båda formulären, med ShowDialog() kan man bara komma åt det formulär som öppnas. 
    End Sub

    Private Sub BtnREPLACE_Click(sender As Object, e As EventArgs) Handles btnREPLACE.Click 'Ersätt.
        FrmReplace.Show() 'Med Show() kan man komma åt båda formulären, med ShowDialog() kan man bara komma åt det formulär som öppnas.
    End Sub

    Private Sub BtnCY_Click(sender As Object, e As EventArgs) Handles btnCY.Click 'Kopierar markerad text.
        rtbARK.Copy()
    End Sub

    Private Sub BtnCT_Click(sender As Object, e As EventArgs) Handles btnCT.Click 'Klipper ut markerad text.
        rtbARK.Cut()
    End Sub

    Private Sub BtnPE_Click(sender As Object, e As EventArgs) Handles btnPT.Click 'Klistrar in markerad text.
        rtbARK.Paste()
    End Sub

    Private Sub BtnUO_Click(sender As Object, e As EventArgs) Handles btnUO.Click 'Undo.
        rtbARK.Undo()
    End Sub

    Private Sub BtnRO_Click(sender As Object, e As EventArgs) Handles btnRO.Click 'Redo.
        rtbARK.Redo()
    End Sub

    Private Sub BtnFORMAT_Click(sender As Object, e As EventArgs) Handles btnFORMAT.Click 'Hämtar format.
        format_F = rtbARK.SelectionFont
        format_C = rtbARK.SelectionColor
        format_BC = rtbARK.SelectionBackColor
        format_ON = True
    End Sub

    Private Sub BtnBL_Click(sender As Object, e As EventArgs) Handles btnBL.Click 'Punktlista.
        rtbARK.SelectionBullet = True
        rtbARK.SelectionIndent = bull_LI
        rtbARK.BulletIndent = bull_BI
        rtbARK.SelectionRightIndent = bull_RI
    End Sub

    Private Sub BtnNL_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNL.Click 'Numrerad eller andra typer av listor.
        Dim arrCalpha() As Char = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"} '26
        Dim arrLalpha() As Char = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"} '26
        Dim arrCroman() As String = {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII", "XIII", "XIV", "XV", "XVI", "XVII", "XVIII", "XIX", "XX" _
        , "XXI", "XXII", "XXIII", "XXIV", "XXV", "XXVI", "XXVII", "XXVIII", "XXIX", "XXX", "XXXI", "XXXII", "XXXIII", "XXXIVX", "XXXV", "XXXVI", "XXXVII", "XXXVIII" _
        , "XXXIX", "XXXX", "XXXXI", "XXXXII", "XXXXIII", "XXXXIVX", "XXXXVX", "XXXXVI", "XXXXVII", "XXXXVIII", "XXXXIX", "L", "LI", "LII", "LIII", "LIV", "LV", "LVI"} '56
        Dim arrLroman() As String = {"i", "ii", "iii", "iv", "v", "vi", "vii", "viii", "ix", "x", "xi", "xii", "xiii", "xiv", "xv", "xvi", "xvii", "xviii", "xix", "xx" _
        , "xxi", "xxii", "xxiii", "xxiv", "xxv", "xxvi", "xxvii", "xxviii", "xxix", "xxx", "xxxi", "xxxii", "xxxiii", "xxxivx", "xxxv", "xxxvi", "xxxvii", "xxxviii" _
        , "xxxix", "xxxx", "xxxxi", "xxxxii", "xxxxiii", "xxxxivx", "xxxxvx", "xxxxvi", "xxxxvii", "xxxxviii", "xxxxix", "l", "li", "lii", "liii", "liv", "lv", "lvi"} '56
        Dim seltext As String = rtbARK.SelectedRtf.ToString()
        Dim bullint As Integer = 0
        Dim cone As Byte = 1
        Dim listfont As Font

        Try
            listfont = New Font(rtbARK.SelectionFont.Name, rtbARK.SelectionFont.Size)
        Catch
            listfont = nudSL.Font 'Tilldelar textboxen samma typsnitt som för arket.
        End Try

        If seltext.IndexOf("\'B7") > -1 And seltext.IndexOf("pnlvlblt") > -1 And seltext.IndexOf("{\pntxtb\'B7}") > -1 Then 'Identifiering.
            If IsNumber Then
                If IsZero Then cone = 0
                seltext = Replace(seltext, "{\pntxtb\'B7}", "\pnstart1\pndec{\pntxta.}") 'Kod för numrerad lista.
                Do 'Byter ut punkter med nummer + periodtecken.
                    If bullint < (10 - cone) Then
                        seltext = Replace(seltext, "\'B7", F10 & (bullint + cone).ToString() & Psign,, 1)
                    ElseIf bullint < (100 - cone) Then
                        seltext = Replace(seltext, "\'B7", F100 & (bullint + cone).ToString() & Psign,, 1)
                    End If
                    bullint += 1
                Loop While seltext.IndexOf("\'B7") > -1
            Else
                If IsCapital Then
                    If IsAlpha Then
                        seltext = Replace(seltext, "{\pntxtb\'B7}", "\pnstart1\pnucltr{\pntxta.}") 'Kod för alfanumerisk lista.
                        Do 'Byter ut punkter med stora bokstäver + periodtecken.
                            seltext = Replace(seltext, "\'B7", " " & arrCalpha(bullint) & Psign,, 1) 'Fyller automagiskt med dubbletter!
                            bullint += 1
                            If bullint > 25 Then bullint = 0
                        Loop While seltext.IndexOf("\'B7") > -1
                    Else
                        seltext = Replace(seltext, "{\pntxtb\'B7}", "\pnstart1\pnucrm{\pntxta.}") 'Kod för romerska siffror.
                        Do 'Byter ut punkter med stora romerska siffror + periodtecken.
                            seltext = Replace(seltext, "\'B7", " " & arrCroman(bullint) & Psign,, 1)
                            bullint += 1
                            If bullint > 56 Then bullint = 0
                        Loop While seltext.IndexOf("\'B7") > -1
                    End If
                Else
                    If IsAlpha Then
                        seltext = Replace(seltext, "{\pntxtb\'B7}", "\pnstart1\pnucltr{\pntxta.}") 'Kod för alfanumerisk lista.
                        Do 'Byter ut punkter med små bokstäver + periodtecken.
                            seltext = Replace(seltext, "\'B7", " " & arrLalpha(bullint) & Psign,, 1)
                            bullint += 1
                            If bullint > 25 Then bullint = 0
                        Loop While seltext.IndexOf("\'B7") > -1
                    Else
                        seltext = Replace(seltext, "{\pntxtb\'B7}", "\pnstart1\pnucrm{\pntxta.}") 'Kod för romerska siffror.
                        Do 'Byter ut punkter med små romerska siffror + periodtecken.
                            seltext = Replace(seltext, "\'B7", " " & arrLroman(bullint) & Psign,, 1)
                            bullint += 1
                            If bullint > 56 Then bullint = 0
                        Loop While seltext.IndexOf("\'B7") > -1
                    End If
                End If
            End If
            seltext = Replace(seltext, "pnlvlblt", "pnlvlbody") 'Omkodning.
            seltext = Replace(seltext, "Symbol;", listfont.Name & ";",, 1) 'Fontbyte.
            rtbARK.SelectedRtf = seltext
        Else
            MessageBox.Show("You must select (marking) a bullet list", "Identify bullet list", MessageBoxButtons.OK, MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End If
    End Sub

    Private Sub BtnLOUT_Click(sender As Object, e As EventArgs) Handles btnLOUT.Click 'Öka indrag vänster.
        rtbARK.SelectionIndent += indent_V
    End Sub

    Private Sub BtnLIN_Click(sender As Object, e As EventArgs) Handles btnLIN.Click 'Minska indrag vänster.
        If rtbARK.SelectionIndent >= indent_V Then rtbARK.SelectionIndent -= indent_V
    End Sub

    Private Sub BtnROUT_Click(sender As Object, e As EventArgs) Handles btnROUT.Click 'Ökan indrag höger.
        rtbARK.SelectionRightIndent += indent_V
    End Sub

    Private Sub BtnRIN_Click(sender As Object, e As EventArgs) Handles btnRIN.Click 'Minska indrag höger
        If rtbARK.SelectionRightIndent >= indent_V Then rtbARK.SelectionRightIndent -= indent_V
    End Sub

    Private Sub BtnRESETINDENT_Click(sender As Object, e As EventArgs) Handles btnRESETINDENT.Click 'Nollställer alla indrag.
        rtbARK.SelectionIndent = 0
        rtbARK.SelectionRightIndent = 0
        rtbARK.BulletIndent = 0
        rtbARK.SelectionHangingIndent = 0
    End Sub

    Private Sub BtnINDENTBL_Click(sender As Object, e As EventArgs) Handles btnINDENTBL.Click 'Ändra indrag för punktlistor (miniknapp).
        Dim seltext As String = rtbARK.SelectedRtf.ToString
        If seltext.IndexOf("\'B7") > -1 Or rtbARK.SelectedText.Length = 0 Then
            FrmBullet.Show()
        Else
            FrmBullet.Show()
            MessageBox.Show("This works best for a marked bullet lists", "Type of list", MessageBoxButtons.OK, MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End If
    End Sub

    Private Sub BtnSTYLENL_Click(sender As Object, e As EventArgs) Handles btnSTYLENL.Click 'Stilar för nummerlistor (miniknapp).
        FrmListStyle.Show()
    End Sub

    Private Sub BtnINDENT_Click(sender As Object, e As EventArgs) Handles btnINDENT.Click 'Ändra Indrag (miniknapp).
        FrmIndent.Show()
    End Sub

    Private Sub BtnTAB_Click(sender As Object, e As EventArgs) Handles btnTAB.Click 'Ändra tab-instansen (miniknapp).
        FrmTab.Show()
    End Sub

    Private Sub BtnIMAGE_Click(sender As Object, e As EventArgs) Handles btnIMAGE.Click 'Ladda ner en bild.
        Dim loadimg As Image
        Dim isloaded As Boolean = False

        If ejbild Then 'Gör en förladdning så att dessa parametrar kan aktiveras vid det första klicket.
            imgOpenFileDialog.Title = "Download Image"
            imgOpenFileDialog.FileName = ""
            ejbild = False
        End If

        If imgOpenFileDialog.ShowDialog = DialogResult.OK Then
            imgOpenFileDialog.Title = "Download Image"
            Try
                loadimg = Image.FromFile(imgOpenFileDialog.FileName)
            Catch ex As Exception
                MessageBox.Show("Not a valid image" & vbCrLf & ex.Message, "Image check", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
                loadimg = Nothing
            End Try

            If loadimg IsNot Nothing Then isloaded = True

            If rbL.Checked And isloaded Then
                Clipboard.SetImage(loadimg)
                rtbARK.Paste()
                rtbARK.SelectionAlignment = HorizontalAlignment.Left
            End If

            If rbC.Checked And isloaded Then
                Clipboard.SetImage(loadimg)
                rtbARK.Paste()
                rtbARK.SelectionAlignment = HorizontalAlignment.Center
            End If

            If rbR.Checked And isloaded Then
                Clipboard.SetImage(loadimg)
                rtbARK.Paste()
                rtbARK.SelectionAlignment = HorizontalAlignment.Right
            End If
        End If
    End Sub

    Private Sub BtnOHM_Click(sender As Object, e As EventArgs) Handles btnOHM.Click 'Hämtar en symbol.
        FrmSymbol.Show()
    End Sub

    Private Sub BtnRA4_Click(sender As Object, e As EventArgs) Handles btnRA4.Click 'Applicerar ett normalt A4.
        Dim str_custom As String

        arkX_pos = 90
        nudLEFT.Text = arkX_pos
        arkX_A4 = 625
        nudRIGHT.Text = x_panel - arkX_A4 - arkX_pos
        arkY_pos = 60
        nudTOP.Text = arkY_pos
        arkY_A4 = 1060
        nudBOTTOM.Text = y_panel - arkY_A4 - arkY_pos

        arkY_A4S = pARK.Height - y_panel + arkY_A4
        rtbARK.Size = New Size(arkX_A4, arkY_A4S)
        rtbARK.Location = New Point(arkX_pos, arkY_pos)

        Try
            str_custom = My.Computer.FileSystem.ReadAllText("Custom.var")
            str_custom = str_custom.Replace("True", "False")
            My.Computer.FileSystem.WriteAllText("Custom.var", str_custom, False)
        Catch
            str_custom = "05|#|05|#|05|#|05|#|False|@|Consolas|#|11|#|05|#|05|#|05|#|05|#|X|#|Y|#|H"
            My.Computer.FileSystem.WriteAllText("Custom.var", str_custom, False)
        End Try
        rtbARK.ScrollBars = ScrollBars.None
        rtbARK.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub BtnOWN_Click(sender As Object, e As EventArgs) Handles btnOWN.Click 'Applicerar egen A4-storlek.
        Dim str_custom As String
        Dim array_C As Array 'Custom.
        Dim array_P1 As Array 'Part 1 of custom.

        Try
            str_custom = My.Computer.FileSystem.ReadAllText("Custom.var")
            array_C = str_custom.Split("|@|")
            array_P1 = array_C(0).ToString().Split("|#|")

            nudLEFT.Text = array_P1(0)
            nudRIGHT.Text = array_P1(1)
            nudTOP.Text = array_P1(2)
            nudBOTTOM.Text = array_P1(3)

            arkX_pos = nudLEFT.Text
            arkX_A4 = x_panel - arkX_pos - nudRIGHT.Text
            arkY_pos = nudTOP.Text
            arkY_A4 = y_panel - arkY_pos - nudBOTTOM.Text

            arkY_A4S = pARK.Height - y_panel + arkY_A4
            rtbARK.Size = New Size(arkX_A4, arkY_A4S)
            rtbARK.Location = New Point(arkX_pos, arkY_pos)

            str_custom = str_custom.Replace("False", "True")
            My.Computer.FileSystem.WriteAllText("Custom.var", str_custom, False)
        Catch
            str_custom = "05|#|05|#|05|#|05|#|False|@|Consolas|#|11|#|05|#|05|#|05|#|05|#|X|#|Y|#|H"
            My.Computer.FileSystem.WriteAllText("Custom.var", str_custom, False)
            MessageBox.Show("Custom file is reset - try again", "Corrupt file", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
        rtbARK.ScrollBars = ScrollBars.None
        rtbARK.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub PbEE_Click(sender As Object, e As EventArgs) Handles pbEE.Click 'Visar ABOUT.
        Dim ecolor As Color = Color.Gray

        Dim pan As New Panel With {
            .Name = "e_pEE",
            .Size = New Size(200, 127),
            .BackColor = Color.FromArgb(168, 255, 255),
            .Location = New Point(CInt((rtbARK.Width - 200) / 2), 50)
        }
        Dim lbl1 As New Label With {
            .Name = "e_lblEE1",
            .Font = sfe20B,
            .Text = "A4 WORD",
            .ForeColor = ecolor,
            .TextAlign = 2,
            .Size = New Size(190, 30),
            .Location = New Point(5, 5),
            .Cursor = Cursors.Hand
        }
        Dim lbl2 As New Label With {
            .Name = "e_lblEE2",
            .Font = sfe14,
            .Text = "B.Lindqvist",
            .ForeColor = ecolor,
            .TextAlign = 2,
            .Size = New Size(190, 28),
            .Location = New Point(5, 40)
        }
        Dim lbl3 As New Label With {
            .Name = "e_lblEE3",
            .Font = ef22,
            .Text = "EE",
            .ForeColor = ecolor,
            .TextAlign = 2,
            .Size = New Size(190, 30),
            .Location = New Point(5, 65)
        }
        Dim lbl4 As New Label With {
            .Name = "e_lblEE4",
            .Font = sfe14,
            .Text = "Ver 1.2",
            .ForeColor = ecolor,
            .TextAlign = 2,
            .Size = New Size(190, 28),
            .Location = New Point(5, 95)
        }

        If IsEE Then
            pan.Controls.Add(lbl1)
            pan.Controls.Add(lbl2)
            pan.Controls.Add(lbl3)
            pan.Controls.Add(lbl4)
            rtbARK.Controls.Add(pan)
            AddHandler pan.Paint, AddressOf Pan_Paint
            AddHandler lbl1.Click, AddressOf EEInfo
            IsEE = False
        Else
            For i = rtbARK.Controls.Count - 1 To 0 Step -1
                If rtbARK.Controls(i).Name.Contains("pEE") Then
                    rtbARK.Controls(i).Dispose()
                End If
            Next
            IsEE = True
        End If
    End Sub

    Private Sub Pan_Paint(sender As Object, e As PaintEventArgs) 'Två linjer.
        Dim aPen = New Pen(Color.Black) With {
            .Width = 3.0F
        }
        e.Graphics.DrawLine(aPen, 0, 1, 200, 1)
        e.Graphics.DrawLine(aPen, 0, 125, 200, 125)
    End Sub

    Private Sub EEInfo()
        FrmInfo.Show()
    End Sub

    Private Sub TbBROWS_TextChanged(sender As Object, e As EventArgs) Handles tbBROWS.TextChanged 'Inmatning av en specifik sida.

        If tbBROWS.Text <> "" And tbBROWS.Text <> " " And total_pages > 0 Then
            tbBROWS.Text = tbBROWS.Text.Trim

            Try
                If tbBROWS.Text = 0 Then tbBROWS.Text = 1

                If tbBROWS.Text > total_pages Then
                    goto_page = total_pages
                    tbBROWS.Text = goto_page
                    rtbARK.SelectionStart = rtbARK.TextLength
                    rtbARK.Focus()
                Else
                    goto_page = tbBROWS.Text
                    If goto_page = 1 Then
                        rtbARK.SelectionStart = 0
                        rtbARK.Focus()
                    ElseIf goto_page = total_pages Then
                        rtbARK.SelectionStart = rtbARK.TextLength
                        rtbARK.Focus()
                    Else
                        rtbARK.SelectionStart = CInt(rtbARK.TextLength / total_pages) * goto_page
                        rtbARK.Focus()
                    End If
                End If
            Catch
                MessageBox.Show("Only positive integer numbers are allowed", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
                tbBROWS.Text = 0
            End Try
        End If
    End Sub

    Private Sub PbAU_Click(sender As Object, e As EventArgs) Handles pbAU.Click 'Minska sida med ett med pil upp.
        If total_pages > 1 And goto_page > 1 Then
            goto_page -= 1
            tbBROWS.Text = goto_page
            If goto_page = 1 Then
                rtbARK.SelectionStart = 0
                rtbARK.Focus()
            Else
                rtbARK.SelectionStart = CInt(rtbARK.TextLength / total_pages) * goto_page 'Närmevärde.
                rtbARK.Focus()
            End If
        End If
    End Sub

    Private Sub PbAD_Click(sender As Object, e As EventArgs) Handles pbAD.Click 'Öka sida med ett med pil ned.
        If total_pages > 1 And goto_page < total_pages Then
            goto_page += 1
            tbBROWS.Text = goto_page
            If goto_page = total_pages Then
                rtbARK.SelectionStart = rtbARK.TextLength
                rtbARK.Focus()
            Else
                rtbARK.SelectionStart = CInt(rtbARK.TextLength / total_pages) * goto_page 'Närmevärde.
                rtbARK.Focus()
            End If
        End If
    End Sub

    Private Sub RtbARK_ContentsResized(sender As Object, e As ContentsResizedEventArgs) Handles rtbARK.ContentsResized 'Hämtar höjden för total text.
        'Om skrollisten blir synlig så blir panelen och arket bredare.
        Y_hojden = e.NewRectangle.Height
        If Y_hojden > arkY_A4S - 5 Then '16 = kompenserar skrollisten (tre ställen).
            pARK.Width = x_panel + 16
            rtbARK.Size = New Size(arkX_A4 + 16, arkY_A4S)
        Else
            rtbARK.Size = New Size(arkX_A4, arkY_A4S)
            pARK.Width = x_panel
        End If

        If rtbARK.TextLength < 1 Then
            total_pages = 0 'Ett tomt blad.
        Else
            total_pages = Math.Ceiling(Y_hojden / (arkY_A4 - 60)) 'Det totala antalet (approximativt).
        End If
        tbPAGES.Text = total_pages
    End Sub

    Private Sub SampleAndReset(page As Boolean)
        CONTROLSTR = rtbARK.Text
        IsChanged = False
        If page Then
            If rtbARK.TextLength < 1 Then
                total_pages = 0 'Ett tomt blad.
                tbPAGES.Text = ""
                goto_page = 0
                tbBROWS.Text = 0
            Else
                total_pages = Math.Ceiling(Y_hojden / (arkY_A4 - 60)) 'Det totala antalet (approximativt).
                tbPAGES.Text = total_pages
                goto_page = 1
                tbBROWS.Text = 1
            End If
        End If
    End Sub

    Private Sub BtnPREVIEW_Click(sender As Object, e As EventArgs) Handles btnPREVIEW.Click 'Förhandsgranskning.
        'Om skrollisten är synlig så är panelen och arket bredare än normalt.
        rtbARK.ScrollBars = ScrollBars.None
        rtbARK.Size = New Size(arkX_A4, arkY_A4S)
        pARK.Width = x_panel

        a4wPrintPreviewDialog.ShowDialog()

        'Återställer skrollisten till auto.
        rtbARK.ScrollBars = ScrollBars.Vertical
        rtbARK.SelectionStart = 0
        rtbARK.Focus()
    End Sub

    Private Sub BtnPRINT_Click(sender As Object, e As EventArgs) Handles btnPRINT.Click 'Standardinställningar för printer.
        'Om skrollisten är synlig så är panelen och arket bredare än normalt.
        rtbARK.ScrollBars = ScrollBars.None
        rtbARK.Size = New Size(arkX_A4, arkY_A4S)
        pARK.Width = x_panel

        Try
            If a4wPrintDialog.ShowDialog = DialogResult.OK Then 'Öppnar printdialogens fönster.  
                a4wPrintDocument.Print() 'Skriver ut bladen.
            End If
        Catch ex As Exception
            MessageBox.Show("Fail to print" & vbCrLf & ex.Message, "Printing error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try

        'Återställer skrollisten till auto.
        rtbARK.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub A4wPrintDocument_BeginPrint(sender As Object, e As PrintEventArgs) Handles a4wPrintDocument.BeginPrint 'PrintDocument 1 för RTB.
        LastCharPrinted = 0
    End Sub

    Private Sub A4wPrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles a4wPrintDocument.PrintPage 'PrintDocument 2 för RTB.
        LastCharPrinted = RichTextBoxPrintCtrl.Print(rtbARK, LastCharPrinted, rtbARK.TextLength,
        nudTOP.Value, nudBOTTOM.Value, nudLEFT.Value, nudRIGHT.Value + 40, e) 'Anropar klassen längst ned (40 = okänd justering).
        If LastCharPrinted < rtbARK.TextLength Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

    Private Sub TsmiNew_Click(sender As Object, e As EventArgs) Handles tsmiNew.Click 'Skapar ett nytt blad och med ett normalt A4.
        If IsChanged Then
            Dim resultat As DialogResult = MessageBox.Show("Continue without saving", "New work sheet", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)

            If resultat = DialogResult.No Then Exit Sub
        End If

        rtbARK.Text = ""
        SampleAndReset(True)
        Me.Text = "EE A4W Portrait [RTF]"
        a4wOpenFileDialog.FileName = ""
        a4wSaveFileDialog.FileName = ""
        btnSAVE.Text = "Save"
        btnSAVE.ForeColor = Color.Navy
        ejoppnat = True
        ejsparat = True
    End Sub

    Private Sub TsmiOpen_Click(sender As Object, e As EventArgs) Handles tsmiOpen.Click 'Öppnar filer.
        BtnOPEN_Click(sender, e)
    End Sub

    Private Sub TsmiSave_Click(sender As Object, e As EventArgs) Handles tsmiSave.Click 'Sparar filer.
        BtnSAVE_Click(sender, e)
    End Sub

    Private Sub TsmiSA_Click(sender As Object, e As EventArgs) Handles tsmiSA.Click 'Sparar filer som?
        BtnSAVEAS_Click(sender, e)
    End Sub

    Private Sub TsmiCLatest_Click(sender As Object, e As EventArgs) Handles tsmiCLatest.Click 'Raderar alla jobb.
        Dim result As DialogResult = MessageBox.Show("Do you really want to clear the job list", "Remove and reset", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

        If result = DialogResult.Yes Then
            While job > 0
                tsmiLatest.DropDownItems.RemoveAt(job - 1) 'Borttagning av alla submenyer.
                jobs(job - 1) = ""
                job -= 1
            End While

            If My.Computer.FileSystem.FileExists("LatestJob.var") Then File.WriteAllText("LatestJob.var", "") 'Laddar filen med inget.
        End If
    End Sub

    Private Sub TsmiPP_Click(sender As Object, e As EventArgs) Handles tsmiPP.Click 'Förhandsgranskning.
        BtnPREVIEW_Click(sender, e)
    End Sub

    Private Sub TsmiPrint_Click(sender As Object, e As EventArgs) Handles tsmiPrint.Click 'Skriver till skrivare.
        BtnPRINT_Click(sender, e)
    End Sub

    Private Sub TsmiINITpos_Click(sender As Object, e As EventArgs) Handles tsmiINITpos.Click 'Sparar programfönstrets position vid start.
        Dim str_custom As String
        Dim array_C As Array 'Custom.
        Dim array_P1, array_P2 As Array 'Part 1 & 2 of custom.

        Try
            str_custom = My.Computer.FileSystem.ReadAllText("Custom.var")
            array_C = str_custom.Split("|@|")
            array_P1 = array_C(0).ToString.Split("|#|")
            array_P2 = array_C(1).ToString.Split("|#|")

            str_custom = array_P1(0) & "|#|" & array_P1(1) & "|#|" & array_P1(2) & "|#|" & array_P1(3) & "|#|" & array_P1(4) & "|@|" _
            & array_P2(0) & "|#|" & array_P2(1) & "|#|" & array_P2(2) & "|#|" & array_P2(3) & "|#|" & array_P2(4) & "|#|" & array_P2(5) _
            & "|#|" & Me.Location.X & "|#|" & Me.Location.Y & "|#|" & Me.Height
            My.Computer.FileSystem.WriteAllText("Custom.var", str_custom, False)
        Catch
            MessageBox.Show("Cannot handle custom file", "Corrupt file", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Sub TsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click 'Avsluta programmet.
        If IsChanged Then
            Dim resultat As DialogResult = MessageBox.Show("Cancel without saving", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)

            Select Case resultat
                Case DialogResult.Yes
                    End
                Case DialogResult.No
                    Exit Sub
                Case Else
                    Exit Sub
            End Select
        Else
            End
        End If
    End Sub

    Private Sub TsmiUndo_Click(sender As Object, e As EventArgs) Handles tsmiUndo.Click 'Ångra.
        BtnUO_Click(sender, e)
    End Sub

    Private Sub TsmiRedo_Click(sender As Object, e As EventArgs) Handles tsmiRedo.Click 'Redo.
        BtnRO_Click(sender, e)
    End Sub

    Private Sub TsmiCopy_Click(sender As Object, e As EventArgs) Handles tsmiCopy.Click 'Kopierar markerad text.
        BtnCY_Click(sender, e)
    End Sub

    Private Sub TsmiCut_Click(sender As Object, e As EventArgs) Handles tsmiCut.Click 'Klipper ut markerad text.
        BtnCT_Click(sender, e)
    End Sub

    Private Sub TsmiPaste_Click(sender As Object, e As EventArgs) Handles tsmiPaste.Click 'Klistrar in markerad text.
        BtnPE_Click(sender, e)
    End Sub

    Private Sub TsmiSelectall_Click(sender As Object, e As EventArgs) Handles tsmiSelectall.Click 'Markera allt.
        BtnSELECTALL_Click(sender, e)
    End Sub

    Private Sub TsmiDeselectall_Click(sender As Object, e As EventArgs) Handles tsmiDeselectall.Click 'Avmarkera allt.
        BtnDESELECTALL_Click(sender, e)
    End Sub

    Private Sub TsmiClearall_Click(sender As Object, e As EventArgs) Handles tsmiClearall.Click 'Ta bort allt.
        Dim resultat As DialogResult = MessageBox.Show("Are you really sure", "Deleting all text", MessageBoxButtons.YesNo,
        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        If resultat = DialogResult.Yes Then
            rtbARK.Clear()
        End If
    End Sub

    Private Sub TsmiSearch_Click(sender As Object, e As EventArgs) Handles tsmiSearch.Click 'Sök.
        BtnSEARCH_Click(sender, e)
    End Sub

    Private Sub TsmiReplace_Click(sender As Object, e As EventArgs) Handles tsmiReplace.Click 'Ersätt.
        BtnREPLACE_Click(sender, e)
    End Sub

    Private Sub TsmiFont_Click(sender As Object, e As EventArgs) Handles tsmiFont.Click 'Fixar nytt teckensnitt etcetera när man klickar "OK".
        BtnSNITT_Click(sender, e)
    End Sub

    Private Sub TsmiFColor_Click(sender As Object, e As EventArgs) Handles tsmiFColor.Click 'Väljer textfärg.
        IsBackColor = False
        IsA4Color = False
        FrmBackColor.Show()
    End Sub

    Private Sub TsmiBColor_Click(sender As Object, e As EventArgs) Handles tsmiBColor.Click 'Väljer textbakgrundsfärg.
        IsBackColor = True
        IsA4Color = False
        FrmBackColor.Show()
    End Sub

    Private Sub TsmiA4BColor_Click(sender As Object, e As EventArgs) Handles tsmiA4BColor.Click 'Väljer bakgrundsfärg på arket.
        IsA4Color = True
        IsBackColor = False
        FrmBackColor.Show()
    End Sub

    Private Sub TsmiCap_Click(sender As Object, e As EventArgs) Handles tsmiCap.Click 'Text till versaler.
        selstart = rtbARK.SelectionStart 'Sparar markeringens startposition.
        sellength = rtbARK.SelectionLength 'Sparar markeringens längd.
        Try
            If rtbARK.SelectionFont Is Nothing Then 'Om det finns flera olika fonter.
                For index = 0 To sellength - 1
                    rtbARK.Select(selstart + index, 1)
                    rtbARK.SelectedText = rtbARK.SelectedText.ToUpper
                Next
            Else
                rtbARK.SelectedText = rtbARK.SelectedText.ToUpper 'Finns bara en font så blir det enklare.
            End If
            rtbARK.Select(selstart, sellength) 'Markerar det specifika textområdet igen.
        Catch ex As Exception
            MessageBox.Show("Cannot read font" & vbCrLf & ex.Message, "Font error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Sub TsmiLow_Click(sender As Object, e As EventArgs) Handles tsmiLow.Click 'Text till gemener.
        selstart = rtbARK.SelectionStart 'Sparar markeringens startposition.
        sellength = rtbARK.SelectionLength 'Sparar markeringens längd.
        Try
            If rtbARK.SelectionFont Is Nothing Then 'Om det finns flera olika fonter.
                For index = 0 To sellength - 1
                    rtbARK.Select(selstart + index, 1)
                    rtbARK.SelectedText = rtbARK.SelectedText.ToLower
                Next
            Else
                rtbARK.SelectedText = rtbARK.SelectedText.ToLower 'Finns bara en font så blir det enklare.
            End If
            rtbARK.Select(selstart, sellength) 'Markerar det specifika textområdet igen.
        Catch ex As Exception
            MessageBox.Show("Cannot read font" & vbCrLf & ex.Message, "Font error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Sub TsmiAlignL_Click(sender As Object, e As EventArgs) Handles tsmiAlignL.Click 'Justerar text.
        BtnLEFT_Click(sender, e)
    End Sub

    Private Sub TsmiAlignC_Click(sender As Object, e As EventArgs) Handles tsmiAlignC.Click 'Justerar text.
        BtnCENTER_Click(sender, e)
    End Sub

    Private Sub TsmiAlignR_Click(sender As Object, e As EventArgs) Handles tsmiAlignR.Click 'Justerar text.
        BtnRIGHT_Click(sender, e)
    End Sub

    Private Sub TsmiAlignJ_Click(sender As Object, e As EventArgs) Handles tsmiAlignJ.Click 'Justerar text.
        BtnJUST_Click(sender, e)
    End Sub

    Private Sub TsmiSpaceBetween_Click(sender As Object, e As EventArgs) Handles tsmiSpaceBetween.Click 'Olika avstånd.
        FrmSpaceBetween.Show()
    End Sub

    Private Sub TsmiOffset_Click(sender As Object, e As EventArgs) Handles tsmiOffset.Click 'Teckenoffset.
        FrmCharOffset.Show()
    End Sub

    Private Sub TsmiSpecial_Click(sender As Object, e As EventArgs) Handles tsmiSpecial.Click 'Specialformat.
        FrmSpecialFormat.Show()
    End Sub

    Private Sub TsmiImageL_Click(sender As Object, e As EventArgs) Handles tsmiImageL.Click 'Ladda ner en bild.
        BtnIMAGE_Click(sender, e)
    End Sub

    Private Sub TsmiBrowser_Click(sender As Object, e As EventArgs) Handles tsmiBrowser.Click 'Ändra browster för hyperlänkar i texten.
        FrmBrowser.Show()
    End Sub

    Private Sub TsmiBulletI_Click(sender As Object, e As EventArgs) Handles tsmiBulletl.Click 'Ändra indrag för punktlistor.
        BtnINDENTBL_Click(sender, e)
    End Sub

    Private Sub TsmiNumberl_Click(sender As Object, e As EventArgs) Handles tsmiNumberl.Click 'Stilar för nummerlistor.
        BtnSTYLENL_Click(sender, e)
    End Sub

    Private Sub TsmiIndent_Click(sender As Object, e As EventArgs) Handles tsmiIndent.Click 'Ändra indrag.
        BtnINDENT_Click(sender, e)
    End Sub

    Private Sub TsmiTab_Click(sender As Object, e As EventArgs) Handles tsmiTab.Click 'Ändra tab-distansen.
        BtnTAB_Click(sender, e)
    End Sub

    Private Sub TsmiSymbol_Click(sender As Object, e As EventArgs) Handles tsmiSymbol.Click 'Hämtar en symbol.
        BtnOHM_Click(sender, e)
    End Sub

    Private Sub TsmiSpellCheck_Click(sender As Object, e As EventArgs) Handles tsmiSpellcheck.Click 'Stavningskontroll med MS Word.
        FrmWordLang.Show()
    End Sub

    Private Sub TsmiEncoding_Click(sender As Object, e As EventArgs) Handles tsmiEncoding.Click 'Välj kodningstyp manuellt.
        FrmEncoding.Show()
    End Sub

    Private Sub TsmiTXTsizefont_Click(sender As Object, e As EventArgs) Handles tsmiTXTsizefont.Click 'Sparar egen storlek och typsnitt för textfiler.
        Dim str_custom As String
        Dim array_C As Array 'Custom.
        Dim array_P1, array_P2 As Array 'Part 1 & 2 of custom.

        Try
            str_custom = My.Computer.FileSystem.ReadAllText("Custom.var")
            array_C = str_custom.Split("|@|")
            array_P1 = array_C(0).ToString.Split("|#|")
            array_P2 = array_C(1).ToString().Split("|#|")

            str_custom = array_P1(0) & "|#|" & array_P1(1) & "|#|" & array_P1(2) & "|#|" & array_P1(3) & "|#|" & array_P1(4) & "|@|" _
            & tbSNITT.Text & "|#|" & nudSL.Text & "|#|" & nudLEFT.Text & "|#|" & nudRIGHT.Text & "|#|" & nudTOP.Text & "|#|" & nudBOTTOM.Text _
            & "|#|" & array_P2(6) & "|#|" & array_P2(7) & "|#|" & array_P2(8)
            My.Computer.FileSystem.WriteAllText("Custom.var", str_custom, False)
        Catch
            MessageBox.Show("Cannot handle custom file", "Corrupt file", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Sub TsmiA4S_Click(sender As Object, e As EventArgs) Handles tsmiA4S.Click 'Sparar egen inställning för A4.
        Dim str_custom As String
        Dim array_C As Array 'Custom.
        Dim array_P2 As Array 'Part 2 of custom.

        Try
            str_custom = My.Computer.FileSystem.ReadAllText("Custom.var")
            array_C = str_custom.Split("|@|")
            array_P2 = array_C(1).ToString().Split("|#|")

            str_custom = nudLEFT.Text & "|#|" & nudRIGHT.Text & "|#|" & nudTOP.Text & "|#|" & nudBOTTOM.Text & "|#|" & "True" & "|@|" _
            & array_P2(0) & "|#|" & array_P2(1) & "|#|" & array_P2(2) & "|#|" & array_P2(3) & "|#|" & array_P2(4) & "|#|" & array_P2(5) _
            & "|#|" & array_P2(6) & "|#|" & array_P2(7) & "|#|" & array_P2(8)
            My.Computer.FileSystem.WriteAllText("Custom.var", str_custom, False)
        Catch
            MessageBox.Show("Cannot handle custom file", "Corrupt file", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Sub TsmiRecreate_Click(sender As Object, e As EventArgs) Handles tsmiRecreate.Click 'Återskapar Custom.var med standardinställningar.
        My.Computer.FileSystem.WriteAllText("Custom.var", "05|#|05|#|05|#|05|#|False|@|Consolas|#|11|#|05|#|05|#|05|#|05|#|X|#|Y|#|H", False)
    End Sub

    Private Sub MenuItems_Clicked(sender As Object, e As EventArgs) 'Identifierar alla nya submenyer i jobb-menyn.
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        Dim filtyp, path_file As String
        Dim f_langd As Byte

        If item IsNot Nothing Then
            filtyp = ""
            path_file = item.Text
            f_langd = path_file.Length

            If IsChanged Then 'Larmar om man försöker öppna en ny fil utan att först sparat det man håller på med.
                Dim resultat As DialogResult = MessageBox.Show("Continue to finish work before opening file", "Open file", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                If resultat = DialogResult.Yes Then Exit Sub
            End If

            If f_langd > 3 Then filtyp = path_file.Substring(f_langd - 4, 4) 'Hämtar fyra tecken av filtyp .rtf

            If My.Computer.FileSystem.FileExists(path_file) Then 'Om filen har flyttats eller tagits bort så finns den inte.
                ejoppnat = False
                inopendialog = True
                a4wOpenFileDialog.FileName = path_file

                If filtyp = ".rtf" Or filtyp = ".Rtf" Or filtyp = ".rTf" Or filtyp = ".rtF" Or filtyp = ".RTf" Or
                filtyp = ".rTF" Or filtyp = ".RtF" Or filtyp = ".RTF" Then 'Kollar om filtypen är av Rich text-formatet.
                    rtbARK.LoadFile(path_file, RichTextBoxStreamType.RichText) 'Laddar upp i Rich text-formatet.
                    Me.Text = "EE A4W Portrait [RTF] - " & a4wOpenFileDialog.SafeFileName
                    Rtf_ON = True
                    btnSAVE.Text = "Save"
                    btnSAVE.ForeColor = Color.Navy
                    SampleAndReset(True)
                Else
                    OpenTXTFile(path_file) 'Laddar upp i textformatet.
                    Rtf_ON = False
                    btnSAVE.Text = "Save"
                    btnSAVE.ForeColor = Color.Navy
                    SampleAndReset(True)
                End If

            Else
                MessageBox.Show("Cannot find this file", "File not exist", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
                Fix_Jobs(path_file)
            End If
        End If
    End Sub

    Private Sub Fix_Jobs(path As String) 'Raderar den icke existerande filen i jobb-filen etcetera.
        Dim fileReader As StreamReader
        Dim tal As Byte = job
        Dim position As Byte

        For index = 0 To job - 1 'Fastställer positionen.
            If jobs(index) = path Then
                position = index
            End If
        Next

        For index = position To job - 1 'Alla jobb över position flyttas ned ett steg.
            jobs(index) = jobs(index + 1)
        Next

        jobs(job - 1) = "" 'Den sista raden raderas.

        While job > 0
            tsmiLatest.DropDownItems.RemoveAt(job - 1) 'Borttagning av alla submenyer.
            job -= 1
        End While

        File.WriteAllText("LatestJob.var", "") 'Skapar filen och laddar den med inget.

        For index = 0 To tal - 1
            If index <> tal - 1 Then
                My.Computer.FileSystem.WriteAllText("LatestJob.var", jobs(index) & vbLf, True) 'Laddar filen med en ny och resten gamla jobb.
            Else
                My.Computer.FileSystem.WriteAllText("LatestJob.var", jobs(tal - 1), True) 'Den sista skippar ny rad.
            End If
        Next

        fileReader = My.Computer.FileSystem.OpenTextFileReader("LatestJob.var")

        Do While fileReader.Peek() <> -1 'Läser rad för rad och lägger sökvägarna i en array.
            jobs(job) = fileReader.ReadLine()
            Dim newMenu As New ToolStripMenuItem() With {.Text = jobs(job), .Name = "mnuItem" & job}
            tsmiLatest.DropDownItems.Add(newMenu) 'Här sker själva tilldelningen av en ny submeny.
            AddHandler newMenu.Click, AddressOf MenuItems_Clicked 'Här kopplas submenyn till en subrutin.
            job += 1
        Loop

        fileReader.Close()
    End Sub

    Private Sub SpecialFonts() 'Hämtning och implementation av specialtypsnitt.
        Try
            special1.AddFontFile("Fonts\ElectrotomeR.ttf")
            special2.AddFontFile("Fonts\ElectrotomeC.ttf")
            special3.AddFontFile("Fonts\ElectrofiedR.ttf")
            Dim font1 As FontFamily = special1.Families(0)
            Dim font2 As FontFamily = special2.Families(0)
            Dim font3 As FontFamily = special3.Families(0)
            Dim sfe8 As New Font(font1, 8)
            Dim sfe8B As New Font(font1, 8, FontStyle.Bold)
            Dim sfe8I As New Font(font1, 8, FontStyle.Italic)
            Dim sfe8U As New Font(font1, 8, FontStyle.Underline)
            Dim sfe9B As New Font(font1, 9, FontStyle.Bold)
            Dim sfe10 As New Font(font1, 10)
            Dim sfe11 As New Font(font1, 11)
            Dim sfe11C As New Font(font2, 11)
            Dim sfe11I As New Font(font1, 11, FontStyle.Italic)
            Dim sfe12 As New Font(font1, 12)
            'FrmBackColor:
            FrmBackColor.lblRED.Font = sfe11
            FrmBackColor.lblGREEN.Font = sfe11
            FrmBackColor.lblBLUE.Font = sfe11
            FrmBackColor.lbl255.Font = sfe11
            FrmBackColor.nudRED.Font = sfe11C
            FrmBackColor.nudGREEN.Font = sfe11C
            FrmBackColor.nudBLUE.Font = sfe11C
            FrmBackColor.btnBACKCOLOR.Font = sfe8
            'FrmBrowser:
            FrmBrowser.lblBROWSER.Font = sfe11
            FrmBrowser.btnBROWSER.Font = sfe8
            'FrmBullet:
            FrmBullet.nudLI.Font = sfe11C
            FrmBullet.nudBI.Font = sfe11C
            FrmBullet.nudRI.Font = sfe11C
            FrmBullet.lblBULLET.Font = sfe11
            FrmBullet.lblTEXT.Font = sfe11
            'FrmCharOffset:
            FrmCharOffset.lblOFFSET.Font = sfe11
            FrmCharOffset.nudOFFSET.Font = sfe11C
            FrmCharOffset.btnRESET.Font = sfe8
            'FrmEncoding:
            FrmEncoding.rbECAUTO.Font = sfe11
            FrmEncoding.rbECANSI.Font = sfe11
            FrmEncoding.rbECASCII.Font = sfe11
            FrmEncoding.rbECUTF7.Font = sfe11
            FrmEncoding.rbECUTF8.Font = sfe11
            FrmEncoding.rbECUTF16.Font = sfe11
            FrmEncoding.rbECUTF32.Font = sfe11
            FrmEncoding.rbECUNICODE.Font = sfe11
            FrmEncoding.rbECLATIN.Font = sfe11
            FrmEncoding.cbENCODESAVE.Font = sfe11
            'FrmIndent:
            FrmIndent.lblINDENT.Font = sfe11
            FrmIndent.nudINDENT.Font = sfe11C
            FrmIndent.lblHANGING.Font = sfe11
            FrmIndent.nudHANGING.Font = sfe11C
            'FrmListStyle:
            FrmListStyle.rbNUMB.Font = sfe11
            FrmListStyle.rbLETT.Font = sfe11
            FrmListStyle.rbROM.Font = sfe11
            FrmListStyle.cb10.Font = sfe11
            FrmListStyle.cb100.Font = sfe11
            FrmListStyle.cbCAP.Font = sfe11
            FrmListStyle.cbZERO.Font = sfe11
            FrmListStyle.lblPSIGN.Font = sfe11
            FrmListStyle.btnSAVE.Font = sfe8
            FrmListStyle.lblINFO1.Font = sfe11I
            FrmListStyle.lblINFO2.Font = sfe11I
            'FrmReplace:
            FrmReplace.lblSEARCH.Font = sfe11
            FrmReplace.btnSEARCH.Font = sfe8
            FrmReplace.btnCLEAR.Font = sfe8
            FrmReplace.lblREPLACE.Font = sfe11
            FrmReplace.btnREPLACE.Font = sfe8
            FrmReplace.cbCASE.Font = sfe10
            FrmReplace.cbWHOLE.Font = sfe10
            FrmReplace.lblFINDS.Font = sfe11
            FrmReplace.btnREPLACEALL.Font = sfe8
            'FrmSearch:
            FrmSearch.lblSEARCH.Font = sfe11
            FrmSearch.btnSEARCH.Font = sfe8
            FrmSearch.cbCASE.Font = sfe10
            FrmSearch.cbWHOLE.Font = sfe10
            FrmSearch.lblFINDS.Font = sfe11
            FrmSearch.btnCLEAR.Font = sfe8
            'FrmSpaceBetween:
            FrmSpaceBetween.lblSPACEB1.Font = sfe11
            FrmSpaceBetween.lblSPACEB2.Font = sfe11
            FrmSpaceBetween.lblSPACEB3.Font = sfe11
            FrmSpaceBetween.lblSPACEB4.Font = sfe11
            FrmSpaceBetween.tbSPACEB1.Font = sfe11C
            FrmSpaceBetween.nudSPACEB2.Font = sfe11C
            FrmSpaceBetween.nudSPACEB3.Font = sfe11C
            FrmSpaceBetween.nudSPACEB4.Font = sfe11C
            FrmSpaceBetween.btnAPPLY1.Font = sfe8
            FrmSpaceBetween.btnAPPLY2.Font = sfe8
            FrmSpaceBetween.btnAPPLY3.Font = sfe8
            FrmSpaceBetween.btnR1.Font = sfe8
            FrmSpaceBetween.btnR2.Font = sfe8
            FrmSpaceBetween.btnR3.Font = sfe8
            'FrmSpecialFormat:
            FrmSpecialFormat.rbULD.Font = sfe11
            FrmSpecialFormat.rbULDASH.Font = sfe11
            FrmSpecialFormat.rbULDASHD.Font = sfe11
            FrmSpecialFormat.rbULDASHDD.Font = sfe11
            FrmSpecialFormat.rbULDB.Font = sfe11
            FrmSpecialFormat.rbULHWAVE.Font = sfe11
            FrmSpecialFormat.rbULLDASH.Font = sfe11
            FrmSpecialFormat.rbULTH.Font = sfe11
            FrmSpecialFormat.rbULTHD.Font = sfe11
            FrmSpecialFormat.rbULTHDASH.Font = sfe11
            FrmSpecialFormat.rbULTHDASHD.Font = sfe11
            FrmSpecialFormat.rbULTHDASHDD.Font = sfe11
            FrmSpecialFormat.rbULTHLDASH.Font = sfe11
            FrmSpecialFormat.rbULULDBWAVE.Font = sfe11
            FrmSpecialFormat.rbULW.Font = sfe11
            FrmSpecialFormat.rbULWAVE.Font = sfe11
            FrmSpecialFormat.rbEMBO.Font = sfe11
            FrmSpecialFormat.rbIMPR.Font = sfe11
            FrmSpecialFormat.rbSCAPS.Font = sfe11
            FrmSpecialFormat.rbSUB.Font = sfe11
            FrmSpecialFormat.rbSUPER.Font = sfe11
            FrmSpecialFormat.rbSHAD.Font = sfe11
            FrmSpecialFormat.btnAPPLY.Font = sfe8
            FrmSpecialFormat.btnCLEAR.Font = sfe8
            'FrmTab:
            FrmTab.lblTAB.Font = sfe11
            FrmTab.nudTAB.Font = sfe11C
            FrmTab.btnAPPLY1.Font = sfe8
            FrmTab.btnAPPLY10.Font = sfe8
            FrmTab.btnUNDO.Font = sfe8
            FrmTab.btnDEFAULT.Font = sfe8
            FrmTab.lblNUMBER.Font = sfe11
            'FrmWordLang:
            FrmWordLang.lblSELLANG.Font = sfe11
            FrmWordLang.btnAPPLY.Font = sfe8
            'Form1:
            btnSNITT.Font = sfe12
            lblLeft.Font = sfe11C
            lblRight.Font = sfe11C
            lblTop.Font = sfe11C
            lblBottom.Font = sfe11C
            nudLEFT.Font = sfe11C
            nudRIGHT.Font = sfe11C
            nudTOP.Font = sfe11C
            nudBOTTOM.Font = sfe11C
            btnB.Font = sfe8B
            btnI.Font = sfe8I
            btnU.Font = sfe8U
            btnS.Font = sfe8
            btnSUP.Font = sfe8
            btnOFFSET.Font = sfe8
            btnSEARCH.Font = sfe8
            btnREPLACE.Font = sfe8
            btnPREVIEW.Font = sfe8
            btnPRINT.Font = sfe8
            btnCY.Font = sfe8
            btnCT.Font = sfe8
            btnPT.Font = sfe8
            btnUO.Font = sfe8
            btnRO.Font = sfe8
            btnFORMAT.Font = sfe8
            btnOPEN.Font = sfe8
            btnSAVE.Font = sfe8
            btnSAVEAS.Font = sfe8
            btnRA4.Font = sfe8
            btnOWN.Font = sfe8
            tbBROWS.Font = sfe9B
            tbPAGES.Font = sfe9B
            'About EE:
            sfe14 = New Font(font1, 14)
            sfe20B = New Font(font1, 20, FontStyle.Bold)
            ef22 = New Font(font3, 22)
        Catch
            MessageBox.Show("Cannot find system fonts in Fonts", "Missing fonts", MessageBoxButtons.OK, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    'För justering av text.
    'Constants and structures from richedit.h
    Const MAX_TAB_STOPS = 32 ' expanded individually
    Const PFA_JUSTIFY = 4 ' Left = 1, Center = 2, Right = 3
    Const CBSIZE = 188 ' Size of PARAFORMAT2 structure
    Const PFM_ALIGNMENT = &H8

    Const WM_USER = &H400
    Const EM_DISPLAYBAND = WM_USER + 51

    Const EM_FORMATRANGE = WM_USER + 57
    Const EM_SETPARAFORMAT = WM_USER + 71
    Const EM_SETTARGETDEVICE = WM_USER + 72

    <StructLayout(LayoutKind.Sequential)>
    Private Structure PARAFORMAT2
        Public cbSize As Int16 'UINT cbSize
        Public dwMask As Int32 'DWORD dwMask
        Public wNumbering As Int16 'WORD  wNumbering
        Public wEffects As Int16  'WORD  wEffects
        Public dxStartIndent As Int32  'LONG  dxStartIndent
        Public dxRightIndent As Int32  'LONG  dxRightIndent
        Public dxOffset As Int32  'LONG  dxOffset
        Public wAlignment As Int16  'WORD  wAlignment
        Public cTabCount As Int16  'SHORT cTabCount
        Public rgxTabs1 As Int32   'LONG  rgxTabs[MAX_TAB_STOPS]
        Public rgxTabs2 As Int32
        Public rgxTabs3 As Int32
        Public rgxTabs4 As Int32
        Public rgxTabs5 As Int32
        Public rgxTabs6 As Int32
        Public rgxTabs7 As Int32
        Public rgxTabs8 As Int32
        Public rgxTabs9 As Int32
        Public rgxTabs10 As Int32
        Public rgxTabs11 As Int32
        Public rgxTabs12 As Int32
        Public rgxTabs13 As Int32
        Public rgxTabs14 As Int32
        Public rgxTabs15 As Int32
        Public rgxTabs16 As Int32
        Public rgxTabs17 As Int32
        Public rgxTabs18 As Int32
        Public rgxTabs19 As Int32
        Public rgxTabs20 As Int32
        Public rgxTabs21 As Int32
        Public rgxTabs22 As Int32
        Public rgxTabs23 As Int32
        Public rgxTabs24 As Int32
        Public rgxTabs25 As Int32
        Public rgxTabs26 As Int32
        Public rgxTabs27 As Int32
        Public rgxTabs28 As Int32
        Public rgxTabs29 As Int32
        Public rgxTabs30 As Int32
        Public rgxTabs31 As Int32
        Public rgxTabs32 As Int32
        Public dySpaceBefore As Int32 'LONG  dySpaceBefore
        Public dySpaceAfter As Int32 'LONG  dySpaceAfter
        Public dyLineSpacing As Int32 'LONG  dyLineSpacing
        Public sStyle As Int16 'SHORT sStyle;
        Public bLineSpacingRule As Byte 'BYTE  bLineSpacingRule
        Public bOutlineLevel As Byte 'BYTE  bOutlineLevel
        Public wShadingWeight As Int16 'WORD  wShadingWeight
        Public wShadingStyle As Int16 'WORD  wShadingStyle
        Public wNumberingStart As Int16 'WORD  wNumberingStart
        Public wNumberingStyle As Int16 'WORD  wNumberingStyle
        Public wNumberingTab As Int16 'WORD  wNumberingTab
        Public wBorderSpace As Int16 'WORD  wBorderSpace
        Public wBorderwidth As Int16 'WORD  wBorderWidth
        Public wBorders As Int16 'WORD  wBorders
    End Structure

    <DllImport("user32.dll")> 'För justering av text.
    Private Shared Function SendMessage(ByVal hWnd As IntPtr,
                                    ByVal msg As Int32,
                                    ByVal wParam As Int32,
                                    ByVal lParam As IntPtr) As Int32
    End Function

End Class

Public Class RichTextBoxPrintCtrl 'För utskrift av RTB.

    Private Const anInch As Double = 14.4
    Private Const EM_FORMATRANGE As Integer = 1081

    <DllImport("USER32.dll")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wp As IntPtr, ByRef lp As FORMATRANGE) As Integer
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure RECT
        Public Left, Top, Right, Bottom As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Private Structure CHARRANGE
        Public cpMin As Integer
        Public cpMax As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Private Structure FORMATRANGE
        Public hdc As IntPtr
        Public hdcTarget As IntPtr
        Public rc As RECT
        Public rcPage As RECT
        Public chrg As CHARRANGE
    End Structure

    Public Shared Function Print(Rtb As Control, ByVal charFrom As Integer, ByVal charTo As Integer,
    v_top As Integer, v_bot As Integer, v_lef As Integer, v_rig As Integer, e As PrintPageEventArgs) As Integer

        Dim rectToPrint As RECT
        rectToPrint.Top = CInt(e.MarginBounds.Top * anInch - 100 * anInch + v_top * anInch)
        rectToPrint.Bottom = CInt(e.MarginBounds.Bottom * anInch + 100 * anInch - v_bot * anInch)
        rectToPrint.Left = CInt(e.MarginBounds.Left * anInch - 100 * anInch + v_lef * anInch)
        rectToPrint.Right = CInt(e.MarginBounds.Right * anInch + 100 * anInch - v_rig * anInch)

        Dim rectPage As RECT
        rectPage.Top = CInt(e.PageBounds.Top * anInch)
        rectPage.Bottom = CInt(e.PageBounds.Bottom * anInch)
        rectPage.Left = CInt(e.PageBounds.Left * anInch)
        rectPage.Right = CInt(e.PageBounds.Right * anInch)

        Dim hdc As IntPtr = e.Graphics.GetHdc

        Dim fmtRange As FORMATRANGE
        fmtRange.chrg.cpMax = charTo
        fmtRange.chrg.cpMin = charFrom
        fmtRange.hdc = hdc
        fmtRange.hdcTarget = hdc
        fmtRange.rc = rectToPrint
        fmtRange.rcPage = rectPage

        Dim res As Integer = SendMessage(Rtb.Handle, EM_FORMATRANGE, New IntPtr(1), fmtRange)
        e.Graphics.ReleaseHdc(hdc)
        Return res
    End Function

End Class