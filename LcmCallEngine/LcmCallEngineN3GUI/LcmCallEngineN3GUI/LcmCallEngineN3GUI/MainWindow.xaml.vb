Imports Microsoft.Win32
Public Class MainWindow
    Dim mSingerDir As String = "e:\0001"
    Private Sub Compose_Click(sender As Object, e As RoutedEventArgs) Handles Compose.Click

        'UST(UstPath.Text, mSingerDir, Time.Text, R_Path.Text, Par.Text, Err_Pro.Text, Err_Pit.Text, CInt(Fra.Text))
        Madd(Fra.Text, mSingerDir)
        'If UST(UstPath.Text, mSingerDir, Time.Text, R_Path.Text, Par.Text, Err_Pro.Text, Err_Pit.Text, CInt(Fra.Text)) = True And Madd(CInt(Fra.Text), mSingerDir) = True Then
        '     MsgBox("OK")

        ' Else
        'MsgBox("no")
        'End If

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim dialog = New OpenFileDialog
        dialog.ShowDialog()


        UstPath.Text = dialog.FileName

    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim dialog = New OpenFileDialog
        dialog.ShowDialog()

        R_Path.Text = dialog.FileName

    End Sub
End Class
