Imports System.Security.Cryptography
Public Class encryptClass
    Private hash As String
    Public Property hashProp() As String
        Get
            Dim sha = New System.Security.Cryptography.SHA256Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(hash))

            Return Convert.ToBase64String(sha).ToString
        End Get
        Set(ByVal value As String)
            hash = value
        End Set
    End Property
End Class
