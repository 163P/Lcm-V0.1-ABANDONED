
Friend Class moveobj
    Dim frm As Object
    Dim onDrag As Boolean
    Dim offset As Point

    Sub New(ByVal mouseobj As Object, ByVal frm As Object)
        Me.frm = frm
        If TypeOf mouseobj Is Control Then
            Dim obj = CType(mouseobj, Control)
            AddHandler obj.MouseDown, AddressOf obj_MouseDown
            AddHandler obj.MouseMove, AddressOf obj_MouseMove
            AddHandler obj.MouseUp, AddressOf obj_MouseUp
        ElseIf TypeOf mouseobj Is Form Then
            Dim obj = CType(mouseobj, Form)
            AddHandler obj.MouseDown, AddressOf obj_MouseDown
            AddHandler obj.MouseMove, AddressOf obj_MouseMove
            AddHandler obj.MouseUp, AddressOf obj_MouseUp

        End If

    End Sub

    Private Sub obj_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        onDrag = True
        Dim p As Point = Cursor.Position
        offset.X = frm.Location.X - p.X
        offset.Y = frm.Location.Y - p.Y

    End Sub

    Private Sub obj_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If onDrag Then
            Dim p As Point = Cursor.Position
            p.Offset(offset)
            frm.Location = p

        End If

    End Sub

    Private Sub obj_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        onDrag = False
    End Sub
End Class

