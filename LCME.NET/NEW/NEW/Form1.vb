Public Class Form1
    Dim MovBoll As Boolean
    Dim CurrX As Integer
    Dim CurrY As Integer
    Dim MousX As Integer
    Dim MousY As Integer
    Public cname As String
    Dim namenum As Short

    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick

    End Sub



    Private Sub TextBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseDown
        cname = sender.name.ToString
        MousX = e.X
        MousY = e.Y
        MovBoll = True
    End Sub

    Private Sub TextBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseMove
        If MovBoll = True Then
            CurrX = sender.Left - MousX + e.X
            CurrY = sender.Top - MousY + e.Y
            sender.Location = New Point(CurrX, CurrY)

        End If

    End Sub

    Private Sub TextBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseUp


        MovBoll = False
    End Sub
    'Private Sub TextBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseDown
    '    TextBox1.DoDragDrop(TextBox1, DragDropEffects.Copy Or DragDropEffects.Move)

    'End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave

    End Sub

    Private Sub TextBox1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseWheel
        If e.Delta > 0 Then
            sender.Width += 10
        Else
            sender.Width -= 10
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddM()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim num As Short
        Dim f As New System.IO.StreamWriter("D:/A.TXT")
        f.WriteLine("!LcmMF 1.0")
        f.WriteLine("@StartLcmMF&")
        f.WriteLine("	Beat Per Minute:#BPM")
        f.WriteLine("		StartMusicalPart&")
        f.WriteLine("			#Number#" & namenum & "#Number#")
        num = namenum

        Dim nn As Short

        Do
            nn += 1
            f.WriteLine("			StartPart" & nn & "&")
            f.WriteLine("				#StartMusical#" & Me.Controls(nn.ToString).Location.X - 160 & "#StartMusical#")
            f.WriteLine("				#Lyric#" & Me.Controls(nn.ToString).Text & "#Lyric#")

            f.WriteLine("				#Pitch#C#3#Pitch#")
            f.WriteLine("				#Dyn#72#Dyn#")
            f.WriteLine("				#Gen#50#Gen#")
            f.WriteLine("				#EndMusical#" & Me.Controls(nn.ToString).Location.X - 160 + Me.Controls(nn.ToString).Width & "#EndMusical#")
            f.WriteLine("			&EndPart" & nn)

        Loop While nn <> namenum
        f.WriteLine("		&EndMusicalPart")
        f.WriteLine("@EndLcmMF&")
        f.Close()
        f.Dispose()
    End Sub

 

    Private Function a(ByVal p1 As Integer) As Object
        Throw New NotImplementedException
    End Function

    Private Sub Dyn力度ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dyn力度ToolStripMenuItem.Click

    End Sub

    Private Sub RectangleShape3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RectangleShape3.MouseUp

    End Sub
    Private Function AddM(Optional ByVal Xz As Short = 0, Optional ByVal Yz As Short = 0) As Boolean
        Dim a As New UserControl
        namenum += 1
        a.Name = namenum
        Dim exitLocation As New System.Drawing.Point(Xz, Yz)
        a.Location = exitLocation
        a.ContextMenuStrip = CMS1
        a.TextBox1.ContextMenuStrip = CMS1
        Me.Controls.Add(a)

        ' ReDim TextBoxName(TextBoxName.GetLength(0) + 1)

        AddHandler a.MouseDown, AddressOf UC_MouseDown
        'AddHandler a.MouseMove, AddressOf UC_MouseMove
        'AddHandler a.MouseUp, AddressOf UC_MouseUp
        'AddHandler a.MouseWheel, AddressOf UC_MouseWheel
        'AddHandler a.TextChanged, AddressOf TextBox1_TextChanged
        'a.ShortcutsEnabled = False
        Return True
    End Function


    Private Sub RectangleShape4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape4.Click

    End Sub

    Private Sub RectangleShape4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RectangleShape4.MouseUp
        AddM(e.X + 160, e.Y)
    End Sub




    Private Sub RectangleShape6_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RectangleShape6.MouseUp
        AddM(e.X + 160 + 160, e.Y)
    End Sub

    Private Sub RectangleShape5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape5.Click

    End Sub

    Private Sub RectangleShape5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RectangleShape5.MouseUp
        AddM(e.X + 160 + 160 + 160, e.Y)
    End Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape3.Click

    End Sub

    Private Sub 删除ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除ToolStripMenuItem.Click
        Me.Controls.Remove(Me.Controls(cname))
        namenum = namenum - 1
    End Sub

  

    Private Sub 打开参数ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 打开参数ToolStripMenuItem.Click
        'Me.Controls(UC.cname).UserControl_Parameters_Change()
    End Sub

 



    Private Sub UC_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        cname = sender.name.ToString

    End Sub
End Class
