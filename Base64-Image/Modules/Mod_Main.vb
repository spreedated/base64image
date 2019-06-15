Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.ComponentModel

Module Mod_Main
    Class Base64Image
        Private _Image As Image
        Public Property Image As Image
            Set(value As Image)
                _Image = value
            End Set
            Get
                Return _Image
            End Get
        End Property

        Private Image_Base64_Result As String
        Public Sub StartAsync()
            If Not Image Is Nothing Then
                Frm_Main.StatLabel.Text = "Calculating..."
                BG_Worker = New BackgroundWorker
                With BG_Worker
                    .RunWorkerAsync()
                End With
            End If
        End Sub
        Private WithEvents BG_Worker As BackgroundWorker
        Private Sub BG_Worker_DoWork() Handles BG_Worker.DoWork
            Dim acc As String = Nothing
            Try
                Using ms As New MemoryStream()
                    Image.Save(ms, Imaging.ImageFormat.Png)
                    Dim obyte = ms.ToArray() 'We tranform it to byte array..

                    acc = Convert.ToBase64String(obyte) 'We then convert the byte array to base 64 string.

                    ms.Dispose()
                End Using
                Image_Base64_Result = acc
            Catch ex As Exception
                Debug.Print(ex.Message)
            End Try
        End Sub
        Private Sub BG_Worker_RunWorkerCompleted() Handles BG_Worker.RunWorkerCompleted
            Frm_Main.RichTextBox1.Text = Image_Base64_Result
            Frm_Main.StatLabel.Text = "Ready"
            Image.Dispose()
            BG_Worker.Dispose()
        End Sub

        Public Function Image_Base64(ByVal image As Image) As String
            Dim acc As String = Nothing
            Try
                Using ms As New MemoryStream()
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                    Dim obyte = ms.ToArray() 'We tranform it to byte array..

                    acc = Convert.ToBase64String(obyte) 'We then convert the byte array to base 64 string.

                    ms.Dispose()
                End Using
            Catch ex As Exception
                Debug.Print(ex.Message)
            End Try
            Return acc
        End Function
    End Class

    Class ImageBase64
        Private _Base64String As String
        Public Property Base64String As String
            Set(value As String)
                _Base64String = value
            End Set
            Get
                Return _Base64String
            End Get
        End Property

        Private Result As Image
        Public Sub StartAsync()
            If Not Base64String Is Nothing Then
                Frm_Main.StatLabel.Text = "Calculating..."
                BG_Worker = New BackgroundWorker
                With BG_Worker
                    .RunWorkerAsync()
                End With
            End If
        End Sub
        Private WithEvents BG_Worker As BackgroundWorker
        Private Sub BG_Worker_DoWork() Handles BG_Worker.DoWork
            Dim ms As MemoryStream = Nothing
            Try
                ms = New MemoryStream(Convert.FromBase64String(Base64String))
                Result = Image.FromStream(ms)
            Catch ex As Exception
                Debug.Print(ex.Message)
            Finally
                ms.Dispose()
            End Try
        End Sub
        Private Sub BG_Worker_RunWorkerCompleted() Handles BG_Worker.RunWorkerCompleted
            If Result Is Nothing Then
                Frm_Main.Pbx_Image.Image = Nothing
                Frm_Main.StatLabel.Text = "Not a valid Base64 String"
            Else
                Frm_Main.Pbx_Image.Image = Result.Clone
                Frm_Main.StatLabel.Text = "Ready"
                Result.Dispose()
            End If
            BG_Worker.Dispose()
        End Sub
    End Class
End Module
