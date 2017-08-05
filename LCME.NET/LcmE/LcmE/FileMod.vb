Imports System.IO
Module FileMod

    '读取指定文本文件
    Public Function readtext(ByVal path As String)
        If path = "" Then
            readtext = "操作失败！"
            Exit Function
        End If
        Try
            If File.Exists(path) = True Then
                Dim fs As New FileStream(path, FileMode.Open)
                Dim sr As New StreamReader(fs)
                Dim str As String
                str = sr.ReadToEnd.ToString
                sr.Close()
                fs.Close()
                readtext = str
            Else
                readtext = "操作失败！"
            End If
        Catch ex As Exception
            readtext = "操作失败！"
        End Try
    End Function
    '向指定文件写入数据
    Public Function writetext(ByVal path As String, ByVal opi As Integer, ByVal msg As String)
        If path = "" Then
            writetext = "操作失败！"
            Exit Function
        End If
        Dim op As FileMode
        Select Case opi
            Case 1
                op = FileMode.Append
            Case 2
                op = FileMode.Create
            Case Else
                op = FileMode.Create
        End Select
        Try
            If File.Exists(path) = True Then
                Dim fs As New FileStream(path, op)
                Dim sr As New StreamWriter(fs)
                sr.WriteLine(msg)
                sr.Close()
                fs.Close()
                writetext = "操作完成！"
            Else
                writetext = "操作失败！"
            End If
        Catch ex As Exception
            writetext = "操作失败！"
        End Try
    End Function

End Module
