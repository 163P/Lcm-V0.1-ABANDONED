Public Class UserControl

    Dim MovBoll As Boolean
    Dim CurrX As Integer
    Dim CurrY As Integer
    Dim MousX As Integer
    Dim MousY As Integer

    Public Property Gen As Short = 0
    Public Property Dyn As Short = 0
    Public Property cname As String = Me.Name.ToString
    Public Property Parameters As Boolean = False
    Public Event Parameters_Change()

    Public Sub UserControl_ChangeUICues(ByVal sender As Object, ByVal e As System.Windows.Forms.UICuesEventArgs) Handles Me.ChangeUICues

    End Sub


    Public Sub UserControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler Me.MouseDown, AddressOf TextBox1_MouseDown
        'AddHandler Me.MouseMove, AddressOf TextBox1_MouseMove
        'AddHandler Me.MouseUp, AddressOf TextBox1_MouseUp
        'AddHandler Me.MouseWheel, AddressOf TextBox1_MouseWheel
        If Parameters = True Then
            Me.Height = 135
        ElseIf Parameters = False Then
            Me.Height = TextBox1.Height
        End If
        'cname = sender.name.ToString
        'AddHandler Me.TextChanged, AddressOf TextBox1_TextChanged

    End Sub

    Public Sub TextBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseDown

        ' cname = Me.Name.ToString
        'RaiseEvent me.MouseDown()


    End Sub

    Public Sub TextBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseMove
        If MovBoll = True Then

            CurrX = Me.Left - MousX + e.X
            CurrY = Me.Top - MousY + e.Y
            Me.Location = New Point(CurrX, CurrY)
        End If

    End Sub

    Public Sub TextBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseUp


        MovBoll = False
    End Sub
    'Public Sub TextBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseDown
    '    TextBox1.DoDragDrop(TextBox1, DragDropEffects.Copy Or DragDropEffects.Move)

    'End Sub

    Public Sub TextBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.MouseLeave

    End Sub

    Public Sub TextBox1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseWheel
        If e.Delta > 0 Then
            'sender.Width += 10
            Me.Width += 10
        Else
            'sender.Width -= 10
            Me.Width -= 10
        End If
    End Sub
    Public Function sende(ByVal send As String) As String
        sende = send
    End Function
    Private Sub UserControl_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        MousX = e.X
        MousY = e.Y
        MovBoll = True
    End Sub

    Public Sub UserControl_PaddingChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PaddingChanged

    End Sub

    Public Sub UserControl_Parameters_Change() Handles Me.Parameters_Change
        If Parameters = False Then
            Me.Height = 135
        ElseIf Parameters = True Then
            Me.Height = TextBox1.Height
        End If
    End Sub

    Public Sub UserControl_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged

    End Sub

    Public Sub UserControl_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles Me.PreviewKeyDown

    End Sub

    Public Sub UserControl_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Parameters = True Then
            Me.Height = 135
        ElseIf Parameters = False Then
            Me.Height = TextBox1.Height
        End If
    End Sub



    Public Sub GenTB_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GenTB.SizeChanged
        Gen = GenTB.Value
    End Sub


    Public Sub DynTB_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DynTB.SizeChanged
        Dyn = DynTB.Value
    End Sub

    Private Sub UserControl_MouseDown()
        Throw New NotImplementedException
    End Sub

End Class
