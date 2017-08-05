<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开项目文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存项目文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.另存为项目文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.旧项目文件迁移ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.导出干声音频ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑器设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.项目设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.虚拟歌手ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.虚拟歌手列表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.无ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.虚拟歌手设置ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.虚拟歌手信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.官方网站ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.给我们报告BUGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.教程ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.工具ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.批量导入歌词ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ShartTSB = New System.Windows.Forms.ToolStripButton()
        Me.StopTSB = New System.Windows.Forms.ToolStripButton()
        Me.授权信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.制作团队ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新建项目文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件ToolStripMenuItem, Me.工具ToolStripMenuItem, Me.编辑ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(815, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '文件ToolStripMenuItem
        '
        Me.文件ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新建项目文件ToolStripMenuItem, Me.打开项目文件ToolStripMenuItem, Me.保存项目文件ToolStripMenuItem, Me.另存为项目文件ToolStripMenuItem, Me.旧项目文件迁移ToolStripMenuItem, Me.导出干声音频ToolStripMenuItem})
        Me.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem"
        Me.文件ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.文件ToolStripMenuItem.Text = "文件"
        '
        '打开项目文件ToolStripMenuItem
        '
        Me.打开项目文件ToolStripMenuItem.Name = "打开项目文件ToolStripMenuItem"
        Me.打开项目文件ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.打开项目文件ToolStripMenuItem.Text = "打开项目文件"
        '
        '保存项目文件ToolStripMenuItem
        '
        Me.保存项目文件ToolStripMenuItem.Name = "保存项目文件ToolStripMenuItem"
        Me.保存项目文件ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.保存项目文件ToolStripMenuItem.Text = "保存项目文件"
        '
        '另存为项目文件ToolStripMenuItem
        '
        Me.另存为项目文件ToolStripMenuItem.Name = "另存为项目文件ToolStripMenuItem"
        Me.另存为项目文件ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.另存为项目文件ToolStripMenuItem.Text = "另存为项目文件"
        '
        '旧项目文件迁移ToolStripMenuItem
        '
        Me.旧项目文件迁移ToolStripMenuItem.Name = "旧项目文件迁移ToolStripMenuItem"
        Me.旧项目文件迁移ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.旧项目文件迁移ToolStripMenuItem.Text = "旧项目文件迁移"
        '
        '导出干声音频ToolStripMenuItem
        '
        Me.导出干声音频ToolStripMenuItem.Name = "导出干声音频ToolStripMenuItem"
        Me.导出干声音频ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.导出干声音频ToolStripMenuItem.Text = "导出干声音频"
        '
        '编辑ToolStripMenuItem
        '
        Me.编辑ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.编辑器设置ToolStripMenuItem, Me.项目设置ToolStripMenuItem, Me.虚拟歌手ToolStripMenuItem})
        Me.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem"
        Me.编辑ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.编辑ToolStripMenuItem.Text = "设置"
        '
        '编辑器设置ToolStripMenuItem
        '
        Me.编辑器设置ToolStripMenuItem.Name = "编辑器设置ToolStripMenuItem"
        Me.编辑器设置ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.编辑器设置ToolStripMenuItem.Text = "编辑器设置"
        '
        '项目设置ToolStripMenuItem
        '
        Me.项目设置ToolStripMenuItem.Name = "项目设置ToolStripMenuItem"
        Me.项目设置ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.项目设置ToolStripMenuItem.Text = "项目设置"
        '
        '虚拟歌手ToolStripMenuItem
        '
        Me.虚拟歌手ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.虚拟歌手列表ToolStripMenuItem, Me.虚拟歌手设置ToolStripMenuItem1, Me.虚拟歌手信息ToolStripMenuItem})
        Me.虚拟歌手ToolStripMenuItem.Name = "虚拟歌手ToolStripMenuItem"
        Me.虚拟歌手ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.虚拟歌手ToolStripMenuItem.Text = "虚拟歌手"
        '
        '虚拟歌手列表ToolStripMenuItem
        '
        Me.虚拟歌手列表ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.无ToolStripMenuItem})
        Me.虚拟歌手列表ToolStripMenuItem.Name = "虚拟歌手列表ToolStripMenuItem"
        Me.虚拟歌手列表ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.虚拟歌手列表ToolStripMenuItem.Text = "虚拟歌手列表"
        '
        '无ToolStripMenuItem
        '
        Me.无ToolStripMenuItem.Checked = True
        Me.无ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.无ToolStripMenuItem.Name = "无ToolStripMenuItem"
        Me.无ToolStripMenuItem.Size = New System.Drawing.Size(88, 22)
        Me.无ToolStripMenuItem.Text = "无"
        '
        '虚拟歌手设置ToolStripMenuItem1
        '
        Me.虚拟歌手设置ToolStripMenuItem1.Name = "虚拟歌手设置ToolStripMenuItem1"
        Me.虚拟歌手设置ToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.虚拟歌手设置ToolStripMenuItem1.Text = "虚拟歌手设置"
        '
        '虚拟歌手信息ToolStripMenuItem
        '
        Me.虚拟歌手信息ToolStripMenuItem.Name = "虚拟歌手信息ToolStripMenuItem"
        Me.虚拟歌手信息ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.虚拟歌手信息ToolStripMenuItem.Text = "虚拟歌手信息"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.官方网站ToolStripMenuItem, Me.给我们报告BUGToolStripMenuItem, Me.教程ToolStripMenuItem, Me.制作团队ToolStripMenuItem, Me.授权信息ToolStripMenuItem})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '官方网站ToolStripMenuItem
        '
        Me.官方网站ToolStripMenuItem.Name = "官方网站ToolStripMenuItem"
        Me.官方网站ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.官方网站ToolStripMenuItem.Text = "官方网站"
        '
        '给我们报告BUGToolStripMenuItem
        '
        Me.给我们报告BUGToolStripMenuItem.Name = "给我们报告BUGToolStripMenuItem"
        Me.给我们报告BUGToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.给我们报告BUGToolStripMenuItem.Text = "给我们报告BUG"
        '
        '教程ToolStripMenuItem
        '
        Me.教程ToolStripMenuItem.Name = "教程ToolStripMenuItem"
        Me.教程ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.教程ToolStripMenuItem.Text = "教程"
        '
        '工具ToolStripMenuItem
        '
        Me.工具ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.批量导入歌词ToolStripMenuItem})
        Me.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem"
        Me.工具ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.工具ToolStripMenuItem.Text = "工具"
        '
        '批量导入歌词ToolStripMenuItem
        '
        Me.批量导入歌词ToolStripMenuItem.Name = "批量导入歌词ToolStripMenuItem"
        Me.批量导入歌词ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.批量导入歌词ToolStripMenuItem.Text = "批量导入歌词"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShartTSB, Me.StopTSB})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(815, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ShartTSB
        '
        Me.ShartTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShartTSB.Image = CType(resources.GetObject("ShartTSB.Image"), System.Drawing.Image)
        Me.ShartTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShartTSB.Name = "ShartTSB"
        Me.ShartTSB.Size = New System.Drawing.Size(23, 22)
        Me.ShartTSB.Text = "ToolStripButton1"
        '
        'StopTSB
        '
        Me.StopTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StopTSB.Image = CType(resources.GetObject("StopTSB.Image"), System.Drawing.Image)
        Me.StopTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StopTSB.Name = "StopTSB"
        Me.StopTSB.Size = New System.Drawing.Size(23, 22)
        Me.StopTSB.Text = "ToolStripButton1"
        '
        '授权信息ToolStripMenuItem
        '
        Me.授权信息ToolStripMenuItem.Name = "授权信息ToolStripMenuItem"
        Me.授权信息ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.授权信息ToolStripMenuItem.Text = "授权信息"
        '
        '制作团队ToolStripMenuItem
        '
        Me.制作团队ToolStripMenuItem.Name = "制作团队ToolStripMenuItem"
        Me.制作团队ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.制作团队ToolStripMenuItem.Text = "制作团队"
        '
        '新建项目文件ToolStripMenuItem
        '
        Me.新建项目文件ToolStripMenuItem.Name = "新建项目文件ToolStripMenuItem"
        Me.新建项目文件ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.新建项目文件ToolStripMenuItem.Text = "新建项目文件"
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 554)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainFrm"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 文件ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 打开项目文件ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 保存项目文件ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 另存为项目文件ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 旧项目文件迁移ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 导出干声音频ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 编辑ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 编辑器设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 项目设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 虚拟歌手ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 虚拟歌手列表ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 无ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 虚拟歌手设置ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 虚拟歌手信息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 官方网站ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 给我们报告BUGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 教程ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 工具ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 批量导入歌词ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ShartTSB As System.Windows.Forms.ToolStripButton
    Friend WithEvents StopTSB As System.Windows.Forms.ToolStripButton
    Friend WithEvents 新建项目文件ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 制作团队ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 授权信息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
