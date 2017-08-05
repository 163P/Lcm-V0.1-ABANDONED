Module Module1
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32
    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As String
        Dim Str As String
        Str = ""
        Str = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), FileName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function
    Public Function WriteINI(ByVal 框里的 As String, ByVal 等号前 As String, ByVal 等号后 As String, ByVal FileName As String) As Long
        WriteINI = WritePrivateProfileString(框里的, 等号前, 等号后, FileName)
    End Function
    Sub Main()
        'utau oto转LCM OTO
        Dim utau As New IO.StreamReader("E:\OTO.INI")
        '这里定义变量
        Dim file As String
        Dim files() As String
        Dim lyric() As String
        '       Dim start As String
        '     Dim consonant As String
        '   Dim overlap As String
        ' Dim lend As String
        '这里开始循环
        ' Kill("f:\k.ini")
        Do Until utau.EndOfStream = True
            '将参数和wav文件名分开
            file = utau.ReadLine
            files = Split(file, "=")
            '分割
            lyric = Split(files(1), ",")

            '写发音和wav（发音是[]里的）
            If lyric(0) = "" Then


                lyric(0) = Replace(files(0), ".wav", "") '如果没有发音，那么就直接将WAV名称写入
            End If
            WriteINI(lyric(0), "wav", files(0), "f:\k.ini")
            '写开始
            WriteINI(lyric(0), "start", lyric(1), "f:\k.ini")
            '写辅音
            WriteINI(lyric(0), "consonant", lyric(2), "f:\k.ini")
            '写重叠
            WriteINI(lyric(0), "overlap", lyric(5), "f:\k.ini")
            '写结束(这里去掉了-，因为勇气CVVC OTO中的end是从前面开始数的有负号，但是utau是从后面数的)
            WriteINI(lyric(0), "end", lyric(3), "f:\k.ini")
        Loop
    End Sub

End Module
