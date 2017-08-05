Public Class Main

    Dim i As Integer


   
    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      
    End Sub

    Private Sub Button1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button1.Paint
       
    End Sub

    Private Sub Main_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim graph As Graphics = Me.CreateGraphics
        Dim pen2 As Pen = New Pen(Color.Green, 3)
        Do Until i = 24



            graph.DrawLine(pen2, 1, 18 * i, 9000, 18 * i)
            i = i + 1
        Loop
    End Sub
End Class
