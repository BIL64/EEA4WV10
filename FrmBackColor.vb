Public Class FrmBackColor

    Dim samplecolor As Color

    Private Sub FrmBackColor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.IsA4Color Then
            Me.Text = "Select background color"
            nudRED.Text = Form1.rtbARK.BackColor.R
            nudGREEN.Text = Form1.rtbARK.BackColor.G
            nudBLUE.Text = Form1.rtbARK.BackColor.B
            pRGB.BackColor = Form1.rtbARK.BackColor
            samplecolor = Form1.rtbARK.BackColor
        Else
            If Form1.IsBackColor Then
                Me.Text = "Select text back color"
                nudRED.Text = Form1.rtbARK.SelectionBackColor.R
                nudGREEN.Text = Form1.rtbARK.SelectionBackColor.G
                nudBLUE.Text = Form1.rtbARK.SelectionBackColor.B
                pRGB.BackColor = Form1.rtbARK.SelectionBackColor
            Else
                Me.Text = "Select text color"
                nudRED.Text = Form1.rtbARK.SelectionColor.R
                nudGREEN.Text = Form1.rtbARK.SelectionColor.G
                nudBLUE.Text = Form1.rtbARK.SelectionColor.B
                pRGB.BackColor = Form1.rtbARK.SelectionColor
            End If
        End If
    End Sub

    Private Sub BtnBACKCOLOR_Click(sender As Object, e As EventArgs) Handles btnBACKCOLOR.Click
        If Form1.IsA4Color Then
            Form1.rtbARK.BackColor = Color.FromArgb(nudRED.Text, nudGREEN.Text, nudBLUE.Text)
        Else
            If Form1.IsBackColor Then
                Form1.rtbARK.SelectionBackColor = Color.FromArgb(nudRED.Text, nudGREEN.Text, nudBLUE.Text)
            Else
                Form1.rtbARK.SelectionColor = Color.FromArgb(nudRED.Text, nudGREEN.Text, nudBLUE.Text)
            End If
        End If
    End Sub

    Private Sub NudRED_ValueChanged(sender As Object, e As EventArgs) Handles nudRED.ValueChanged
        pRGB.BackColor = Color.FromArgb(nudRED.Value, nudGREEN.Text, nudBLUE.Text)
    End Sub

    Private Sub NudGREEN_ValueChanged(sender As Object, e As EventArgs) Handles nudGREEN.ValueChanged
        pRGB.BackColor = Color.FromArgb(nudRED.Text, nudGREEN.Value, nudBLUE.Text)
    End Sub

    Private Sub NudBLUE_ValueChanged(sender As Object, e As EventArgs) Handles nudBLUE.ValueChanged
        pRGB.BackColor = Color.FromArgb(nudRED.Text, nudGREEN.Text, nudBLUE.Value)
    End Sub

    Private Sub Convert_Color(color_value As Color)
        If Form1.IsA4Color Then
            Form1.rtbARK.BackColor = color_value
        Else
            If Form1.IsBackColor Then
                Form1.rtbARK.SelectionBackColor = color_value
            Else
                Form1.rtbARK.SelectionColor = color_value
            End If
        End If

        nudRED.Text = color_value.R
        nudGREEN.Text = color_value.G
        nudBLUE.Text = color_value.B
    End Sub


    Private Sub PWhite_MouseClick(sender As Object, e As MouseEventArgs) Handles pWhite.MouseClick
        Convert_Color(Color.White)
    End Sub

    Private Sub P224_MouseClick(sender As Object, e As MouseEventArgs) Handles p224.MouseClick
        Convert_Color(Color.FromArgb(224, 224, 224))
    End Sub

    Private Sub PSilver_MouseClick(sender As Object, e As MouseEventArgs) Handles pSilver.MouseClick
        Convert_Color(Color.Silver)
    End Sub

    Private Sub PGray_MouseClick(sender As Object, e As MouseEventArgs) Handles pGray.MouseClick
        Convert_Color(Color.Gray)
    End Sub

    Private Sub P64_MouseClick(sender As Object, e As MouseEventArgs) Handles p64.MouseClick
        Convert_Color(Color.FromArgb(64, 64, 64))
    End Sub

    Private Sub PBlack_MouseClick(sender As Object, e As MouseEventArgs) Handles pBlack.MouseClick
        Convert_Color(Color.Black)
    End Sub


    Private Sub P255192_MouseClick(sender As Object, e As MouseEventArgs) Handles p255192.MouseClick
        Convert_Color(Color.FromArgb(225, 192, 192))
    End Sub

    Private Sub P255128_MouseClick(sender As Object, e As MouseEventArgs) Handles p255128.MouseClick
        Convert_Color(Color.FromArgb(255, 128, 128))
    End Sub

    Private Sub PRed_MouseClick(sender As Object, e As MouseEventArgs) Handles pRed.MouseClick
        Convert_Color(Color.Red)
    End Sub

    Private Sub P1920_MouseClick(sender As Object, e As MouseEventArgs) Handles p1920.MouseClick
        Convert_Color(Color.FromArgb(192, 0, 0))
    End Sub

    Private Sub PMaroon_MouseClick(sender As Object, e As MouseEventArgs) Handles pMaroon.MouseClick
        Convert_Color(Color.Maroon)
    End Sub

    Private Sub P640_MouseClick(sender As Object, e As MouseEventArgs) Handles p640.MouseClick
        Convert_Color(Color.FromArgb(64, 0, 0))
    End Sub


    Private Sub P255224192_MouseClick(sender As Object, e As MouseEventArgs) Handles p255224192.MouseClick
        Convert_Color(Color.FromArgb(255, 224, 192))
    End Sub

    Private Sub P255192128_MouseClick(sender As Object, e As MouseEventArgs) Handles p255192128.MouseClick
        Convert_Color(Color.FromArgb(255, 192, 128))
    End Sub

    Private Sub P2551280_MouseClick(sender As Object, e As MouseEventArgs) Handles p2551280.MouseClick
        Convert_Color(Color.FromArgb(255, 128, 0))
    End Sub

    Private Sub P1926400_MouseClick(sender As Object, e As MouseEventArgs) Handles p192640.MouseClick
        Convert_Color(Color.FromArgb(192, 64, 0))
    End Sub

    Private Sub P128640_MouseClick(sender As Object, e As MouseEventArgs) Handles p128640.MouseClick
        Convert_Color(Color.FromArgb(128, 64, 0))
    End Sub

    Private Sub P12864_MouseClick(sender As Object, e As MouseEventArgs) Handles p12864.MouseClick
        Convert_Color(Color.FromArgb(128, 64, 64))
    End Sub


    Private Sub P255255192_MouseClick(sender As Object, e As MouseEventArgs) Handles p255255192.MouseClick
        Convert_Color(Color.FromArgb(255, 255, 192))
    End Sub

    Private Sub P255255128_MouseClick(sender As Object, e As MouseEventArgs) Handles p255255128.MouseClick
        Convert_Color(Color.FromArgb(255, 255, 128))
    End Sub

    Private Sub PYellow_MouseClick(sender As Object, e As MouseEventArgs) Handles pYellow.MouseClick
        Convert_Color(Color.Yellow)
    End Sub

    Private Sub P1921920_MouseClick(sender As Object, e As MouseEventArgs) Handles p1921920.MouseClick
        Convert_Color(Color.FromArgb(192, 192, 0))
    End Sub

    Private Sub POlive_MouseClick(sender As Object, e As MouseEventArgs) Handles pOlive.MouseClick
        Convert_Color(Color.Olive)
    End Sub

    Private Sub P64640_MouseClick(sender As Object, e As MouseEventArgs) Handles p64640.MouseClick
        Convert_Color(Color.FromArgb(64, 64, 0))
    End Sub


    Private Sub P192255192_MouseClick(sender As Object, e As MouseEventArgs) Handles p192255192.MouseClick
        Convert_Color(Color.FromArgb(192, 255, 192))
    End Sub

    Private Sub P128255128_MouseClick(sender As Object, e As MouseEventArgs) Handles p128255128.MouseClick
        Convert_Color(Color.FromArgb(128, 255, 128))
    End Sub

    Private Sub PLime_MouseClick(sender As Object, e As MouseEventArgs) Handles pLime.MouseClick
        Convert_Color(Color.Lime)
    End Sub

    Private Sub P01920_MouseClick(sender As Object, e As MouseEventArgs) Handles p01920.MouseClick
        Convert_Color(Color.FromArgb(0, 192, 0))
    End Sub

    Private Sub PGreen_MouseClick(sender As Object, e As MouseEventArgs) Handles pGreen.MouseClick
        Convert_Color(Color.Green)
    End Sub

    Private Sub P4640_MouseClick(sender As Object, e As MouseEventArgs) Handles p64640.MouseClick
        Convert_Color(Color.FromArgb(64, 64, 0))
    End Sub


    Private Sub P192255255_MouseClick(sender As Object, e As MouseEventArgs) Handles p192255255.MouseClick
        Convert_Color(Color.FromArgb(192, 255, 255))
    End Sub

    Private Sub P128255255_MouseClick(sender As Object, e As MouseEventArgs) Handles p128255255.MouseClick
        Convert_Color(Color.FromArgb(128, 255, 255))
    End Sub

    Private Sub PCyan_MouseClick(sender As Object, e As MouseEventArgs) Handles pCyan.MouseClick
        Convert_Color(Color.Cyan)
    End Sub

    Private Sub P01921920_MouseClick(sender As Object, e As MouseEventArgs) Handles p0192192.MouseClick
        Convert_Color(Color.FromArgb(0, 192, 192))
    End Sub

    Private Sub PTeal_MouseClick(sender As Object, e As MouseEventArgs) Handles pTeal.MouseClick
        Convert_Color(Color.Teal)
    End Sub

    Private Sub P06464_MouseClick(sender As Object, e As MouseEventArgs) Handles p06464.MouseClick
        Convert_Color(Color.FromArgb(0, 64, 64))
    End Sub


    Private Sub P192192255_MouseClick(sender As Object, e As MouseEventArgs) Handles p192192255.MouseClick
        Convert_Color(Color.FromArgb(192, 192, 255))
    End Sub

    Private Sub P128128255_MouseClick(sender As Object, e As MouseEventArgs) Handles p128128255.MouseClick
        Convert_Color(Color.FromArgb(128, 128, 255))
    End Sub

    Private Sub PBlue_MouseClick(sender As Object, e As MouseEventArgs) Handles pBlue.MouseClick
        Convert_Color(Color.Blue)
    End Sub

    Private Sub P00192_MouseClick(sender As Object, e As MouseEventArgs) Handles p00192.MouseClick
        Convert_Color(Color.FromArgb(0, 0, 192))
    End Sub

    Private Sub PNavy_MouseClick(sender As Object, e As MouseEventArgs) Handles pNavy.MouseClick
        Convert_Color(Color.Navy)
    End Sub

    Private Sub P0064_MouseClick(sender As Object, e As MouseEventArgs) Handles p0064.MouseClick
        Convert_Color(Color.FromArgb(0, 0, 64))
    End Sub


    Private Sub P255192255_MouseClick(sender As Object, e As MouseEventArgs) Handles p255192255.MouseClick
        Convert_Color(Color.FromArgb(255, 192, 255))
    End Sub

    Private Sub P255128255_MouseClick(sender As Object, e As MouseEventArgs) Handles p255128255.MouseClick
        Convert_Color(Color.FromArgb(255, 128, 255))
    End Sub

    Private Sub PFuchsia_MouseClick(sender As Object, e As MouseEventArgs) Handles pFuchsia.MouseClick
        Convert_Color(Color.Fuchsia)
    End Sub

    Private Sub P1920192_MouseClick(sender As Object, e As MouseEventArgs) Handles p1920192.MouseClick
        Convert_Color(Color.FromArgb(192, 0, 192))
    End Sub

    Private Sub PPurple_MouseClick(sender As Object, e As MouseEventArgs) Handles pPurple.MouseClick
        Convert_Color(Color.Purple)
    End Sub

    Private Sub P64064_MouseClick(sender As Object, e As MouseEventArgs) Handles p64064.MouseClick
        Convert_Color(Color.FromArgb(64, 0, 64))
    End Sub

End Class