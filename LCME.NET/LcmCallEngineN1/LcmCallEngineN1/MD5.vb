Module MD5
    Public Function md5(ByVal a As String) As String
        Dim tempmd5 As System.Security.Cryptography.MD5 = New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytResult() As Byte = tempmd5.ComputeHash(System.Text.Encoding.Default.GetBytes(a))
        Dim strResult As String = BitConverter.ToString(bytResult)
        strResult = strResult.Replace("-", "")
        Return strResult
    End Function
End Module
