Imports System.CodeDom.Compiler

Public Class Codedom

    Public Shared Sub Compiler(ByVal Path As String, ByVal Code As String, ByVal Res As String, ByVal DLL As String, Optional ICOPath As String = "")

        Dim providerOptions = New Collections.Generic.Dictionary(Of String, String)
        providerOptions.Add("CompilerVersion", "v4.0")
        Dim CodeProvider As New Microsoft.VisualBasic.VBCodeProvider(providerOptions)
        Dim Parameters As New CompilerParameters
        Dim OP As String = " /target:winexe /platform:x86 /optimize+ /nowarn"

        If ICOPath IsNot Nothing Then
            IO.File.Copy(ICOPath, Environment.GetFolderPath(35) + "\icon.ico", True) 'codedom cant read spaces
            OP += " /win32icon:" + Environment.GetFolderPath(35) + "\icon.ico"
        End If

        With Parameters
            .GenerateExecutable = True
            .OutputAssembly = Path
            .CompilerOptions = OP
            .IncludeDebugInformation = False
            .ReferencedAssemblies.Add("System.Windows.Forms.dll")
            .ReferencedAssemblies.Add("system.dll")
            .ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")


            Using R As New Resources.ResourceWriter(IO.Path.GetTempPath & "\" + Res + ".Resources")
                R.AddResource(DLL, GZip(My.Resources.PE))
                R.Generate()
            End Using
            .EmbeddedResources.Add(IO.Path.GetTempPath & "\" + Res + ".Resources")

            'Check for errors
            Dim Results = CodeProvider.CompileAssemblyFromSource(Parameters, Code)
            If Results.Errors.Count > 0 Then
                For Each E In Results.Errors
                    MsgBox(E.ErrorText, MsgBoxStyle.Critical)

                Next
            End If
        End With

    End Sub

    Public Shared Function GZip(ByVal B As Byte()) As Byte()
        Dim MS As New IO.MemoryStream
        Dim Ziped As New IO.Compression.GZipStream(MS, IO.Compression.CompressionMode.Compress, True)
        Ziped.Write(B, 0, B.Length)
        Ziped.Dispose()
        MS.Position = 0
        Dim buffer As Byte() = New Byte((CInt(MS.Length) + 1) - 1) {}
        MS.Read(buffer, 0, buffer.Length)
        MS.Dispose()
        Return buffer
    End Function

End Class
