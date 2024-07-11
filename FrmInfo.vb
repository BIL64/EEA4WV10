Public Class FrmInfo

    Dim Y_height As Integer

    Private Sub FrmINFO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            rtbINFO.LoadFile("readme.rtf", RichTextBoxStreamType.RichText) 'Laddar upp i Rich text-formatet.
        Catch
            Try
                rtbINFO.LoadFile("readme.txt", RichTextBoxStreamType.PlainText) 'Laddar upp i TXT-formatet.
            Catch
                'Ingen information krävs.
            End Try
        End Try

        rtbINFO.Height = Y_height + 10
        pINFO.Height = rtbINFO.Height + 20
        Me.Height = pINFO.Height + 63
    End Sub

    Private Sub RtbINFO_ContentsResized(sender As Object, e As ContentsResizedEventArgs) Handles rtbINFO.ContentsResized 'Hämtar höjden för total text.
        Y_height = e.NewRectangle.Height
    End Sub

End Class