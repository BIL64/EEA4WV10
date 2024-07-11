Imports System.Drawing.Text

Public Class FrmSymbol

    Dim ASCII As Integer = 33 'Nummer för ascii-tecken.
    Dim MFONT As String = "Symbol"
    Dim startfont As Font = Form1.rtbARK.SelectionFont
    Dim selstart As Integer = Form1.rtbARK.SelectionStart

    Private Sub FrmSymbol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Form1.IsASCII Then Me.Text = "Get symbol (extended ASCII are refused)"
        Add_Labels(ASCII)
    End Sub

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing 'När man stänger med krysset.
        Form1.rtbARK.Select(selstart, 0)
        Form1.rtbARK.SelectionFont = startfont
        Form1.rtbARK.Focus()
    End Sub

    Private Sub Add_Buttons_Combobox()
        Dim btnd As New Button With { 'Minska-knapp.
            .Font = New Font("Verdana", 8),
            .Name = "s_btnD",
            .Text = "<<<",
            .Size = New Size(80, 22),
            .BackColor = Color.FromArgb(255, 255, 235),
            .Cursor = Cursors.Hand,
            .Location = New Point(41, 545)
        }
        AddHandler btnd.Click, AddressOf HandleDbuttonChanged
        Me.Controls.Add(btnd)

        Dim btni As New Button With { 'Öka-knapp.
            .Font = New Font("Verdana", 8),
            .Name = "s_btnI",
            .Text = ">>>",
            .Size = New Size(80, 22),
            .BackColor = Color.FromArgb(255, 255, 235),
            .Cursor = Cursors.Hand,
            .Location = New Point(141, 545)
        }
        AddHandler btni.Click, AddressOf HandleIbuttonChanged
        Me.Controls.Add(btni)

        Dim cb As New ComboBox With { 'Combobox.
            .Font = New Font("Verdana", 10),
            .Name = "s_cbFONT",
            .Size = New Size(252, 15),
            .BackColor = Color.White,
            .Location = New Point(5, 514)
        }
        AddHandler cb.SelectedIndexChanged, AddressOf HandleIndexChanged

        Dim fonts As New InstalledFontCollection()
        For index As Integer = 0 To fonts.Families.Length - 1
            cb.Items.Add(fonts.Families(index).Name)
        Next
        Me.Controls.Add(cb)
        cb.SelectedText = MFONT
    End Sub

    Private Sub HandleDbuttonChanged(sender As Object, e As EventArgs)
        Me.Controls.Clear()
        ASCII -= 80
        If ASCII < 1 Then ASCII = 1
        Add_Labels(ASCII)
    End Sub

    Private Sub HandleIbuttonChanged(sender As Object, e As EventArgs)
        Me.Controls.Clear()
        ASCII += 80
        Add_Labels(ASCII)
    End Sub

    Private Sub HandleIndexChanged(sender As Object, e As EventArgs)
        Me.Controls.Clear()
        MFONT = sender.SelectedItem.ToString()
        ASCII = 33
        Add_Labels(ASCII)
    End Sub

    Private Sub Add_Labels(asci As Integer)
        Add_Buttons_Combobox()
        Dim X As Byte = 0
        Dim Y As Integer = 2
        For i As Byte = 1 To 230 'Genererar en ny symbolkarta.
            Dim lbl As New Label With {
                .Font = New Font(MFONT, 12),
                .Name = "s_lblS" & i.ToString(),
                .Size = New Size(24, 20),
                .TextAlign = HorizontalAlignment.Center,
                .BackColor = Color.LightGray
            }
            Try 'Ascii-koder som inte finns orsakar programfel.
                lbl.Text = Chr(asci)
            Catch
                lbl.Text = ""
            End Try

            asci += 1
            If X > 9 Then 'Rad för rad...
                X = 0
                Y += 22
            End If
            lbl.Location = New Point(X * 26 + 2, Y) 'Positionsdata.
            X += 1
            AddHandler lbl.Click, AddressOf HandleCharChanged
            AddHandler lbl.MouseEnter, AddressOf HandleLightOn
            AddHandler lbl.MouseLeave, AddressOf HandleLightOff
            Me.Controls.Add(lbl)
        Next
    End Sub

    Private Sub HandleCharChanged(sender As Object, e As MouseEventArgs)
        Dim fsize As Integer = Form1.rtbARK.SelectionFont.Size
        Dim fstyle As FontStyle = Form1.rtbARK.SelectionFont.Style
        Form1.rtbARK.SelectionFont = sender.Font
        Form1.rtbARK.SelectionFont = New Font(Form1.rtbARK.SelectionFont.Name, fsize, fstyle)
        Form1.rtbARK.SelectedText += sender.Text
        selstart += 1
    End Sub

    Private Sub HandleLightOn(sender As Object, e As EventArgs)
        sender.BackColor = Color.LightCyan
    End Sub

    Private Sub HandleLightOff(sender As Object, e As EventArgs)
        sender.BackColor = Color.LightGray
    End Sub

End Class