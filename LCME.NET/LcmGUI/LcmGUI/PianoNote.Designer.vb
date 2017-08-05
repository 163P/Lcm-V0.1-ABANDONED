<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PianoNote
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
        Me.components = New System.ComponentModel.Container()
        Me.LbLYC = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.修改此音符的歌词ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改此音符的参数ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.音量大小VELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.力度DYNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改此音符的高级属性ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.生成此音符的目前状态并播放 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbLYC
        '
        Me.LbLYC.AutoSize = True
        Me.LbLYC.Location = New System.Drawing.Point(2, 1)
        Me.LbLYC.Name = "LbLYC"
        Me.LbLYC.Size = New System.Drawing.Size(29, 12)
        Me.LbLYC.TabIndex = 0
        Me.LbLYC.Text = "歌词"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.修改此音符的歌词ToolStripMenuItem, Me.修改此音符的参数ToolStripMenuItem, Me.修改此音符的高级属性ToolStripMenuItem, Me.生成此音符的目前状态并播放})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(197, 92)
        '
        '修改此音符的歌词ToolStripMenuItem
        '
        Me.修改此音符的歌词ToolStripMenuItem.Name = "修改此音符的歌词ToolStripMenuItem"
        Me.修改此音符的歌词ToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.修改此音符的歌词ToolStripMenuItem.Text = "修改此音符的发音记号"
        '
        '修改此音符的参数ToolStripMenuItem
        '
        Me.修改此音符的参数ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.音量大小VELToolStripMenuItem, Me.力度DYNToolStripMenuItem})
        Me.修改此音符的参数ToolStripMenuItem.Name = "修改此音符的参数ToolStripMenuItem"
        Me.修改此音符的参数ToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.修改此音符的参数ToolStripMenuItem.Text = "修改此音符的普通参数"
        '
        '音量大小VELToolStripMenuItem
        '
        Me.音量大小VELToolStripMenuItem.Name = "音量大小VELToolStripMenuItem"
        Me.音量大小VELToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.音量大小VELToolStripMenuItem.Text = "音量（VEL）"
        '
        '力度DYNToolStripMenuItem
        '
        Me.力度DYNToolStripMenuItem.Name = "力度DYNToolStripMenuItem"
        Me.力度DYNToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.力度DYNToolStripMenuItem.Text = "力度（DYN）"
        '
        '修改此音符的高级属性ToolStripMenuItem
        '
        Me.修改此音符的高级属性ToolStripMenuItem.Name = "修改此音符的高级属性ToolStripMenuItem"
        Me.修改此音符的高级属性ToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.修改此音符的高级属性ToolStripMenuItem.Text = "修改此音符的高级属性"
        '
        '生成此音符的目前状态并播放
        '
        Me.生成此音符的目前状态并播放.Name = "生成此音符的目前状态并播放"
        Me.生成此音符的目前状态并播放.Size = New System.Drawing.Size(196, 22)
        Me.生成此音符的目前状态并播放.Text = "ToolStripMenuItem1"
        '
        'PianoNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.LbLYC)
        Me.Name = "PianoNote"
        Me.Size = New System.Drawing.Size(103, 14)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbLYC As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 修改此音符的歌词ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 修改此音符的参数ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 音量大小VELToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 力度DYNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 修改此音符的高级属性ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 生成此音符的目前状态并播放 As System.Windows.Forms.ToolStripMenuItem

End Class
