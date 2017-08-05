Public Class Form1
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32
    Dim UstName As String
    Dim filename As String
    Dim Notenums As Long
    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As String
        Dim Str As String
        Str = ""
        Str = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), FileName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)
    End Function
    Public Function WriteINI(ByVal 方括号里的 As String, ByVal 等号前 As String, ByVal 等号后 As String, ByVal FileName As String) As Long
        WriteINI = WritePrivateProfileString(方括号里的, 等号前, 等号后, FileName)
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        OpenFileDialog1.ShowDialog()

        UstName = OpenFileDialog1.FileName

        Notenums = InputBox("需要转换的音符数量（请输入数字）")

        SaveFileDialog1.ShowDialog()

        filename = SaveFileDialog1.FileName

        WriteINI("Info", "Trainer", "LCM", filename)
        Dim bpm As Single 'bpm
        Dim Length As Integer 'UST里的长度
        Dim SLength As Single '秒数长度
        Dim Lyric As String '歌词
        Dim NoteNum As Short '高度
        'Dim Nothings As String '其余无效的东西
        'Dim Tall As Single '真 · 高度
        Dim No As Short ' 序号


        bpm = GetINI("#SETTING", "Tempo", "", UstName) 'bpm
        WriteINI("Info", "BPM", bpm, filename)

P:

        'Length = CInt(Replace(UST.ReadLine, "Length=", "")) 'length
        Length = GetINI("#" & No.ToString("0000"), "Length", "", UstName)

        SLength = Length / 8 / bpm '求正常秒数
        ' If GetINI("#" & No + 1.ToString("0000"), "Lyric", "", UstName) <> "R " Then


        'SLength = SLength * (1 + 1 / mFen) '求混音秒数，这里不做延长，混音秒数视歌手而定
        'End If
        Lyric = GetINI("#" & No.ToString("0000"), "Lyric", "", UstName) 'lyric


        'If Lyric = "R" Then GoTo P
        NoteNum = GetINI("#" & No.ToString("0000"), "NoteNum", "", UstName) '高度
        No = No + 1

        '写
        WriteINI(No, "Length", SLength, filename)
        WriteINI(No, "Lyric", Lyric, filename)
        WriteINI(No, "NoteNum", NoteNum, filename)
        WriteINI(No, "Strength", "0", filename)


        If No <> Notenums + 1 Then

            GoTo P
        Else

        End If
    End Sub
End Class
