Imports System.IO
Public Class Frm_Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Pbx_Image.Image.Dispose()
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try

        Try
            Dim i As ImageBase64 = New ImageBase64 With {
                .Base64String = RichTextBox1.Text
                }
            i.StartAsync()

            Button3.Enabled = True
        Catch ex As Exception
            Debug.Print(ex.Message)
            Button3.Enabled = False
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = Ofd_LoadImage.ShowDialog()
        Dim acc As Image = Nothing

        If result = DialogResult.OK Then
            Try
                'Start Clear
                If Not Pbx_Image.Image Is Nothing Then
                    Pbx_Image.Image.Dispose()
                End If
                RichTextBox1.Clear()
                '# ###

                acc = Image.FromFile(Ofd_LoadImage.FileName)
                Pbx_Image.Image = acc.Clone()

                Dim i As Base64Image = New Base64Image With {
                    .Image = acc
                    }
                i.StartAsync()

                Button3.Enabled = True
            Catch ex As Exception
                Debug.Print(ex.Message)
            Finally
                acc.Dispose()
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = SFD_Image.ShowDialog()
        If result = DialogResult.OK Then
            Try
                Pbx_Image.Image.Save(SFD_Image.FileName, Imaging.ImageFormat.Png)
                Dim p As Process = New Process With {
                    .StartInfo = New ProcessStartInfo(Path.GetDirectoryName(SFD_Image.FileName))
                }
                p.Start()
                Debug.Print(Path.GetDirectoryName(SFD_Image.FileName))
            Catch ex As Exception
                Debug.Print(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mod_AppProperties.SetSettings(Me)
        StatLabel.Text = "Ready"
    End Sub
End Class
