Imports System.Text.RegularExpressions

Public Class Validation
    Public Shared Sub txtName(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = " abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Public Shared Sub txtEmail(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "@._abcdefghijklmnopqrstuvwxyz0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Public Shared Sub txtNumbersOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Shared Function name(ByVal data As String) As Boolean
        Dim reg As Regex = New Regex("\b[a-zA-Z ]{3,}\s$")
        data = data & " "
        Dim m As Match = reg.Match(data)
        If m.Success Then
            Return True
        End If
        Return False
    End Function

    Public Shared Function email(ByVal data As String) As Boolean
        Dim reg As Regex = New Regex("\b[a-bA-Z._0-9]{5,}@[a-bA-Z_0-9]{2,}.[a-bA-Z_0-9]{2,}\s$")
        data = data & " "
        Dim m As Match = reg.Match(data)
        If m.Success Then
            Return True
        End If
        Return False
    End Function

    Public Shared Function aadhar(ByVal data As String) As Boolean
        Dim reg As Regex = New Regex("\b\d{12}\s$")
        data = data & " "
        Dim m As Match = reg.Match(data)
        If m.Success Then
            Return True
        End If

        Return False
    End Function

    Public Shared Function mobile(ByVal data As String) As Boolean
        Dim reg As Regex = New Regex("\b[6-9]\d{9}\s$")
        data = data & " "
        Dim m As Match = reg.Match(data)
        If m.Success Then
            Return True
        End If

        Return False
    End Function

    Public Shared Function joining(ByVal data As String) As Boolean
        If data > Date.Now.Date Then
            Return False
        End If
        Return True
    End Function
End Class
