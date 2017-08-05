Imports Microsoft.Win32
Module Module2
    Dim filename As String
    Dim OFN As String
    Dim LENTH As Double
    Dim cmdstr As String
    Dim mFen As Single

    ' Dim LW As New LcmNetDllV1.Wave

    'Dim mSingerdir As String
    Dim mNotenum As Integer
    Dim mUstname As String

    'Dim mJichu As Short
    Dim mLong As Long
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32

    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As String
        Dim Str As String
        Str = ""
        Str = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), FileName)
        Return Microsoft.VisualBasic.Left(Str, InStr(Str, Chr(0)) - 1)

    End Function

    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, ByVal FileName As String) As Long
        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, FileName)
    End Function
    'Public Function StartFunction(mSingerdir As String) As Boolean

    'cmdstr = Command()

    'MsgBox(cmdstr)
    'Console.WriteLine("LcmEngine No.1 *This is the test program")
    'Console.WriteLine("Lcm声音合成引擎 第一部分 *这是测试程序")
    'Console.WriteLine()
    'Console.WriteLine("Length change *This is the test program")
    'Console.WriteLine("长度更改*这是测试程序")
    'Console.WriteLine("启动引擎...")



    'plcm:
    'Console.WriteLine("输入源文件完整路径（单声道)")
    'filename = "F:\..bianpl\" & Console.ReadLine
    'Console.WriteLine("输入目标文件完整路径")
    'OFN = Console.ReadLine
    'If OFN = "" Then
    ' OFN = filename & "_1.wav"
    ' End If
    ' Console.WriteLine("输入长度(建议不要太大，太大有可能失败，毕竟唱歌一个字不会连续唱1分钟)")
    ' LENTH = Console.ReadLine
    '
    '        A = LP.Pitch(1, "", filename, OFN, LENTH, 1)
    '
    '        GoTo plcm
    '
    '        Console.WriteLine("执行完成，回车键关闭程序")
    '        MsgBox(Console.Read())


    'yinyuanlujing:

    'mSingerdir = 
    'mSingerdir = "E:\HENGJING\"
    'Console.WriteLine("获取音源信息... *test 0.1")
    'If Dir(mSingerdir & "\se.txt") = "" Then '看看有没有设定文件

    'Console.WriteLine("找不到音源设定文件，有以下解决问题的方案您可以考虑")
    'Console.WriteLine("1.检查音源完整性")
    'Console.WriteLine("2.是否具有相应访问权限")
    'Console.WriteLine("3.目录应指定至音源根目录")
    'Console.WriteLine("请重新设置音源路径！")

    'MsgBox（“找不到音源设定文件！”）

    'Return False

    'Exit Function

    'GoTo yinyuanlujing
    'End If

    'Dim dbf As New System.IO.StreamReader(mSingerdir & "\se.txt", System.Text.Encoding.Default)

    'Console.WriteLine("歌手名称：" & dbf.ReadLine)

    'Console.WriteLine("性别：" & dbf.ReadLine)

    'Console.WriteLine("是否为移植音源：" & dbf.ReadLine)
    'mJichu = dbf.ReadLine

    'Console.WriteLine("基点：" & mJichu)
    'Console.WriteLine("需要手动输入FFV吗？")
    'If Console.ReadLine = 0 Then
    ' mFen()
    ' End If
    'mFen = dbf.ReadLine
    'Console.WriteLine("分数值:" & mFen)
    'Console.WriteLine("检查音源损坏情况...")
    'If My.Computer.FileSystem.DirectoryExists(mSingerdir & "\Cache\") And My.Computer.FileSystem.DirectoryExists(mSingerdir & "\Cache2\") And My.Computer.FileSystem.DirectoryExists(mSingerdir & "\Cache3\") = True Then
    'Console.WriteLine("缓存文件夹正常")
    'Else
    'Console.WriteLine("找不到缓存文件夹，尝试自动修复？（输入1自动修复 其余不修复）")
    'If Console.ReadLine = "1" Then
    ' My.Computer.FileSystem.CreateDirectory(mSingerdir & "\Cache\")
    ' My.Computer.FileSystem.CreateDirectory(mSingerdir & "\Cache2\")
    ' My.Computer.FileSystem.CreateDirectory(mSingerdir & "\Cache3\")
    'Console.WriteLine("修复完成，请重新指定音源目录！")
    'Else
    'Console.WriteLine("修复失败，请重新指定音源目录！")
    'End If

    'GoTo yinyuanlujing
    'End If
    'If My.Computer.FileSystem.DirectoryExists(mSingerdir & "\SoundSource\") = True And My.Computer.FileSystem.FileExists(mSingerdir & "\SoundSource\R.WAV") = True Then
    'Console.WriteLine("库文件夹正常")
    ' Else
    'Console.WriteLine("找不到库文件夹或库文件夹不完整！")
    'Console.WriteLine("可以考虑以下解决方案：")
    'Console.WriteLine("1.重新下载音源")
    'Console.WriteLine("请重新指定音源目录！")
    'GoTo yinyuanlujing
    'End If
    'If My.Computer.FileSystem.DirectoryExists(mSingerdir & "\WAV\") = True Then
    'Console.WriteLine("输出文件夹正常")
    'Else
    'Console.WriteLine("找不到输出文件夹，尝试自动修复？（输入1自动修复 其余不修复）")
    'If Console.ReadLine = "1" Then
    'My.Computer.FileSystem.CreateDirectory(mSingerdir & "\WAV\")
    'Console.WriteLine("修复完成，请重新指定音源目录！")
    'Else
    'Console.WriteLine("修复失败，请重新指定音源目录！")
    'End If
    'GoTo yinyuanlujing
    ' End If
    'Console.WriteLine("检查完毕，音源没有损坏！")
    'Console.WriteLine("需要删除缓存文件吗？(输入1跳过) *test 0.1")

    'If Console.ReadLine = "1" Then GoTo U
    'Console.WriteLine("清除缓存文件... *test 0.1")
    ' My.Computer.FileSystem.DeleteDirectory(mSingerdir & "\Cache\", FileIO.DeleteDirectoryOption.DeleteAllContents)
    'My.Computer.FileSystem.DeleteDirectory(mSingerdir & "\Cache2\", FileIO.DeleteDirectoryOption.DeleteAllContents)
    'My.Computer.FileSystem.DeleteDirectory(mSingerdir & "\Cache3\", FileIO.DeleteDirectoryOption.DeleteAllContents)
    'My.Computer.FileSystem.CreateDirectory(mSingerdir & "\Cache\")
    'My.Computer.FileSystem.CreateDirectory(mSingerdir & "\Cache2\")
    'My.Computer.FileSystem.CreateDirectory(mSingerdir & "\Cache3\")
    'U:


    'Console.WriteLine("输入UST完整路径 *test 0.1")
    'mUstname = Console.ReadLine
    'If Dir(mUstname) = "" Then
    'Console.WriteLine("文件不存在！请重新输入")
    'GoTo U
    'Else
    'If GetINI("#SETTING", "Tempo", "hhhhhhhhhhhhhhhhhhhhhhhhh", mUstname) = "hhhhhhhhhhhhhhhhhhhhhhhhh" Then
    'Console.WriteLine("文件损坏！")
    'GoTo U
    'End If
    'End If
    'Console.WriteLine("输入UST音符数量 *test 0.1")
    'mNotenum = Console.ReadLine
    'If GetINI("#" & mNotenum.ToString("0000"), "Length", "操操操操操操操操操操操操操操操操操操操操操操操操", mUstname) = "操操操操操操操操操操操操操操操操操操操操操操操操" Then
    'Console.WriteLine("输入数量大于文件内音符数量！")
    'GoTo U
    'End If
    'UST(mUstname, mSingerdir, mNotenum)
    'MADD(mFen)
    'Console.Read()
    'MADD(mFen)
    'Shell("explorer.exe " & mSingerdir & "\WAV\")
    'Console.WriteLine("执行完毕，保存在音源WAV目录下,输入1再次生成，其余则关闭")
    'If Console.ReadLine = "1" Then
    'GoTo U
    'End If

    'End Function
    Public Function UST(ByVal UstName As String, ByVal SingerDir As String, ByVal Notenums As Integer, Engine As String, Parameter As String, err_proo As String, err_pitt As String, mfen As Single) As Boolean
        'Try
        'UST 
        'UstName 文件路径
        'jishu 基点（源文件音高，UST里的表示方式）
        '
        mLong = 0
        'If SingerDir = "" Then
        'SingerDir = mSingerdir
        'End If
        'UstName = "F:\..整理出来的有用的好玩的东西\VSQ和VSQX和UST\VSQX转UST\yx.ust"
        'If Jichu = 0 Then

        'Jichu = 53
        ' End If
        'Dim UST As New System.IO.StreamReader(UstName)
        Dim bpm As Single 'bpm
        Dim Length As Integer 'UST里的长度
        Dim SLength As Single '秒数长度
        Dim Lyric As String '歌词
        Dim NoteNum As Short '高度
        'Dim Nothings As String '其余无效的东西
        Dim Tall As String '真 · 高度 后改为文本
        Dim No As Short ' 序号
        Dim start As Single
        Dim consonant As Single
        Dim Send As Single
        Dim wav As String

        bpm = GetINI("#SETTING", "Tempo", "", UstName) 'bpm

P:

        'Length = CInt(Replace(UST.ReadLine, "Length=", "")) 'length
        Length = GetINI("#" & No.ToString("0000"), "Length", "", UstName)

        SLength = (60 / bpm) * (Length / 480)
        ' If GetINI("#" & No + 1.ToString("0000"), "Lyric", "", UstName) <> "R " Then
        mLong = mLong + SLength

        SLength = SLength * (1 + 1 / mfen) '求秒数
        'End If
        Lyric = GetINI("#" & No.ToString("0000"), "Lyric", "", UstName) 'lyric

        start = GetINI(Lyric, "start", "0.01", SingerDir & "\k.ini")
        Send = GetINI(Lyric, "end", "0.1", SingerDir & "\k.ini")
        consonant = GetINI(Lyric, "consonant", "0.1", SingerDir & "\k.ini")
        wav = GetINI(Lyric, "wav", err_proo & ".WAV", SingerDir & "\k.ini")
        'If Lyric = "R" Then GoTo P
        NoteNum = GetINI("#" & No.ToString("0000"), "NoteNum", "", UstName) '高度
        No = No + 1

        '       If Jichu < NoteNum Then
        '
        '        Tall = NoteNum - Jichu
        '        Tall = Tall * 0.05
        '        Tall = 1 + Tall
        '      ElseIf Jichu > NoteNum Then
        '
        'Tall = Jichu - NoteNum
        '  Tall = Tall * 0.05
        '    Tall = 1 - Tall
        '  ElseIf Jichu = NoteNum Then
        '    Tall = 1
        '
        'End If
        Tall = GetINI("#List", NoteNum, err_pitt, SingerDir & "/pitch.ini")
        'If Lyric = "R" Then

        'System.IO.File.Copy(SingerDir & "\SoundSource\" & Lyric & ".wav", SingerDir & "\Cache\" & No & ".wav")
        'GoTo L
        'End 
        ' mFen = 10
        If Lyric <> "R" Then
            'Try

            Process.Start(Engine, "  """ & SingerDir & "\SoundSource\" & wav & """ """ & SingerDir & "\Cache2\" & No + 1 & ".wav"" " & Tall & " 100 ""/" & Parameter & """ " & start & " " & SLength * 1000.ToString & " " & Send.ToString & " " & consonant.ToString & " 100 0 !" & bpm)

            'A = LL.LengthChange(1, SingerDir & "\SoundSource\" & wav, SLength, SingerDir & "\Cache\" & No & ".wav", mFen * 3, start, Send, consonant, SingerDir & "\Cache\")
            Try


                '    A = LP.Pitch(1, SingerDir & "\Cache\", No & ".wav", SingerDir & "\Cache2\" & No + 1 & ".wav", Tall, 1) '0.7
            Catch ex As Exception
                FileCopy(SingerDir & "\Cache\" & No & ".wav", SingerDir & "\Cache2\" & No + 1 & ".wav")
            End Try
            ' Catch ex As Exception
            'Lyric = "a"
            'start = GetINI(Lyric, "start", "0.01", SingerDir & "\k.ini")
            '    Send = GetINI(Lyric, "end", "0.1", SingerDir & "\k.ini")
            'consonant = GetINI(Lyric, "consonant", "0.01", SingerDir & "\k.ini")
            'wav = GetINI(Lyric, "wav", "R.WAV", SingerDir & "\k.ini")
            'A = LL.LengthChange(1, SingerDir & "\SoundSource\" & wav, SLength, SingerDir & "\Cache\" & No & ".wav", mFen * 3, start, Send, consonant, SingerDir & "\Cache\")
            'A = LP.Pitch(1, SingerDir & "\Cache\", No & ".wav", SingerDir & "\Cache2\" & No + 1 & ".wav", Tall, 1) '0.7

            'End Try
        Else

            ' If Dir(SingerDir & "\Cache\" & No & ".wav") = "" Then
            '     System.IO.File.Copy(SingerDir & "\SoundSource\" & wav, SingerDir & "\Cache\" & No & ".wav", False)
            '    A = LL.LengthChange(1, SingerDir & "\Cache\" & No & ".wav", SLength, SingerDir & "\Cache2\" & No + 1 & ".wav", mFen * 3, start, Send, consonant, SingerDir & "\Cache\")
            ' Kill(SingerDir & "\Cache\" & No & ".wav")
            'If No = 3 Then
            'A = LA.Add(1, SingerDir & "\Cache2\" & No - 1 & ".wav", SingerDir & "\Cache2\" & No & ".wav", SingerDir & "\Cache3\a.wav")
            ' End If
            'End If
            ' A = LL.LengthChange(1, SingerDir & "\SoundSource\" & wav, SLength, SingerDir & "\Cache2\" & No + 1 & ".wav", mFen * 3, start, Send, consonant, SingerDir & "\Cache\")
            Process.Start(Engine, " """ & SingerDir & "\SoundSource\" & wav & """ """ & SingerDir & "\Cache2\" & No + 1 & ".wav"" " & Tall & " 100 ""/e"" " & start & " " & SLength * 1000.ToString & " " & consonant.ToString & " " & Send.ToString & " 100 0 !" & bpm)

        End If
        '  mFen = 3
        Console.WriteLine("输出 """ & Lyric & """ - 第" & No - 1 & "个音符")

        If No <> Notenums + 1 Then

            GoTo P
        Else
            'Dim Files() As String = System.IO.Directory.GetFiles(SingerDir & "\Cache2\")
            'Dim i As String = 0
            'Do Until i = Files.Count
            ' A = LL.VBOUT(1, Files(i), mFen, Files(i))
            ' i = i + 1

            '            Loop
            '''''MADD(mFen)
        End If
        Return True
        'Catch ex As Exception
        'Return False
        'MsgBox(ex.ToString)
        '    Exit Function
        'End Try
    End Function
    Public Function Madd(ByVal fen As Single, mSingerDir As String) As Boolean
        'Try
        Dim A As New Object
            MsgBox("")
            'Dim LP As New LcmNetDllV1.PitchClass
            Dim LA As New LcmNetDllV1.AddClass
            'Dim LL As New LcmNetDllV1.LengthOfSoundChangeClass
            'Console.WriteLine("合成第 1 个")
            Dim fenno As Long = fen
            MsgBox("")
            A = LA.Add2(1, mSingerDir & "\Cache2\2.wav", mSingerDir & "\Cache2\3.wav", mSingerDir & "\Cache3\1.wav", fenno) '3 4
            fenno = fenno + fen
            'Dim wfile() As MathWorks.MATLAB.NET.Arrays.MWNumericArray
            'Dim wfile1 As ArrayList
            Dim No2 As Short = 4 '5
            Dim No3 As Short = 1


            Do Until No2 = mNotenum + 1 '2
                'Console.WriteLine("合成第 " & No3 + 1 & " 次")

                'If No3 > 1 Then Kill(mSingerdir & "\Cache3\" & No3 & ".wav")
                A = LA.Add2(1, mSingerDir & "\Cache3\" & No3 & ".wav", mSingerDir & "\Cache2\" & No2 & ".wav", mSingerDir & "\Cache3\" & No3 + 1 & ".wav", fenno) '开启分数切割，不用准确值
                'wfile1.Add(wfile.ToArray())
                fenno = fenno + fen
                No2 = No2 + 1
                No3 = No3 + 1
            Loop


            'A = LL.LengthChange(1, mSingerdir & "\Cache3\" & No3 & ".wav", mLong, mSingerdir & "\WAV\TEST.wav", 100, 1, 7222, 2, mSingerdir & "\WAV\")
            FileCopy(mSingerDir & "\Cache3\" & No3 & ".wav", mSingerDir & "\WAV\TEST.wav")

        ' wfile = wfile1.ToArray
        ' Dim f As New System.IO.StreamWriter("F:\1.txt")
        ' f.WriteLine()
        'Catch ex As Exception

        '    MsgBox(ex.ToString)
        '   Return False

        'End Try

        Return True

    End Function
End Module
