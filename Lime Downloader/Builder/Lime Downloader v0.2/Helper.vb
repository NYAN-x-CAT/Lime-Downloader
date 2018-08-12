Module Helper
    Public rand As New Random()
    Public Function Randomi(ByVal lenght As Integer) As String
        Dim Chr As String = "qwertyuiopasdfghjklzxcvbnm"
        Dim sb As New Text.StringBuilder()
        For i As Integer = 1 To lenght
            Dim idx As Integer = rand.Next(0, Chr.Length)
            sb.Append(Chr.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function
End Module
