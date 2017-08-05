Imports System.Web.Security
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Module Module1
    Public Function md5(ByVal a As String) As String
        Dim tempmd5 As System.Security.Cryptography.MD5 = New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytResult() As Byte = tempmd5.ComputeHash(System.Text.Encoding.Default.GetBytes(a))
        Dim strResult As String = BitConverter.ToString(bytResult)
        strResult = strResult.Replace("-", "")
        Return strResult
    End Function
    Public Function Encrypt(ByVal pToEncrypt As String, ByVal sKey As String) As String
        Dim des As New DESCryptoServiceProvider()
        Dim inputByteArray() As Byte
        inputByteArray = Encoding.Default.GetBytes(pToEncrypt)
        '建立加密对象的密钥和偏移量
        '原文使用ASCIIEncoding.ASCII方法的GetBytes方法
        '使得输入密码必须输入英文文本
        des.Key = ASCIIEncoding.ASCII.GetBytes(sKey)
        des.IV = ASCIIEncoding.ASCII.GetBytes(sKey)
        '写二进制数组到加密流
        '(把内存流中的内容全部写入)
        Dim ms As New System.IO.MemoryStream()
        Dim cs As New CryptoStream(ms, des.CreateEncryptor, CryptoStreamMode.Write)
        '写二进制数组到加密流
        '(把内存流中的内容全部写入)
        cs.Write(inputByteArray, 0, inputByteArray.Length)
        cs.FlushFinalBlock()

        '建立输出字符串     
        Dim ret As New StringBuilder()
        Dim b As Byte
        For Each b In ms.ToArray()
            ret.AppendFormat("{0:X2}", b)
        Next

        Return ret.ToString()
    End Function

    '解密方法
    Public Function Decrypt(ByVal pToDecrypt As String, ByVal sKey As String) As String
        Dim des As New DESCryptoServiceProvider()
        '把字符串放入byte数组
        Dim len As Integer
        len = pToDecrypt.Length / 2 - 1
        Dim inputByteArray(len) As Byte
        Dim x, i As Integer
        For x = 0 To len
            i = Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16)
            inputByteArray(x) = CType(i, Byte)
        Next
        '建立加密对象的密钥和偏移量，此值重要，不能修改
        des.Key = ASCIIEncoding.ASCII.GetBytes(sKey)
        des.IV = ASCIIEncoding.ASCII.GetBytes(sKey)
        Dim ms As New System.IO.MemoryStream()
        Dim cs As New CryptoStream(ms, des.CreateDecryptor, CryptoStreamMode.Write)
        cs.Write(inputByteArray, 0, inputByteArray.Length)
        cs.FlushFinalBlock()
        Return Encoding.Default.GetString(ms.ToArray)

    End Function
    Sub Main()
        Dim n
        n = 0
        Dim fil As New System.IO.StreamWriter("d:\1.txt")
        Dim Files() As String = System.IO.Directory.GetFiles("F:\DF\SoundSource\")
        Do Until Files.Length = n
            fil.WriteLine(Replace(Files(n), "F:\DF\SoundSource\", "") & "=" & md5(Files(n)))
            n = n + 1

        Loop
        fil.Close()
        Console.Read()
    End Sub

End Module
