<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DynTB = New System.Windows.Forms.TrackBar()
        Me.GenTB = New System.Windows.Forms.TrackBar()
        CType(Me.DynTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenTB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ShortcutsEnabled = False
        Me.TextBox1.Size = New System.Drawing.Size(363, 21)
        Me.TextBox1.TabIndex = 0
        '
        'DynTB
        '
        Me.DynTB.Location = New System.Drawing.Point(0, 21)
        Me.DynTB.Name = "DynTB"
        Me.DynTB.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.DynTB.Size = New System.Drawing.Size(45, 132)
        Me.DynTB.TabIndex = 1
        '
        'GenTB
        '
        Me.GenTB.Location = New System.Drawing.Point(42, 21)
        Me.GenTB.Name = "GenTB"
        Me.GenTB.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.GenTB.Size = New System.Drawing.Size(45, 132)
        Me.GenTB.TabIndex = 2
        '
        'UserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GenTB)
        Me.Controls.Add(Me.DynTB)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "UserControl"
        Me.Size = New System.Drawing.Size(363, 153)
        CType(Me.DynTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenTB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DynTB As System.Windows.Forms.TrackBar
    Friend WithEvents GenTB As System.Windows.Forms.TrackBar

End Class
