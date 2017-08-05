Public Class PianoNote
    Dim m As New moveobj(Me, Me)
    Public Property LYC As String
    Public Property PIT As Integer
    Public Property DYN As Integer
    Public Property VEL As Integer
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LbLYC.Click

    End Sub

    Private Sub 修改此音符的歌词ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 修改此音符的歌词ToolStripMenuItem.Click
        LYC = InputBox("请输入发音记号【示例：hao】", "输入发音记号", "a")
        LbLYC.Text = LYC
    End Sub

    Private Sub 音量大小VELToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 音量大小VELToolStripMenuItem.Click

    End Sub

    Private Sub 修改此音符的参数ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 修改此音符的参数ToolStripMenuItem.Click

    End Sub

    Private Sub PianoNote_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click

    End Sub

    Private Sub PianoNote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub PianoNote_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move

    End Sub
End Class
