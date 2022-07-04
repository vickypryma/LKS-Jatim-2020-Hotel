Imports System.Text
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Module Module1
    Public employee As DbHotelDataSet.EmployeeRow

    Function PasswordHash(ByVal password As String) As String
        Dim myHash As New SHA256Managed
        Dim hashed = myHash.ComputeHash(Encoding.UTF8.GetBytes(password))
        Dim sb As New StringBuilder

        For i As Integer = 0 To hashed.Length - 1
            sb.Append(hashed(i).ToString("X2"))
        Next

        Return sb.ToString
    End Function

    Function IsEmail(ByVal email As String) As Boolean
        Return Regex.IsMatch(email, "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
    End Function

    Function BookingCode(length As Integer) As String
        Dim s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim sb As New StringBuilder
        Dim r As New Random

        For i = 1 To length
            Dim idx = r.Next(0, s.Length - 1)
            sb.Append(s.Substring(idx, 1))
        Next

        Return sb.ToString()
    End Function

End Module
