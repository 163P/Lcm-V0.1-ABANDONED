<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CMS1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.更改参数ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Dyn力度ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gen浑厚ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开参数ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.UserControl1 = New WindowsApplication1.UserControl()
        Me.CMS1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-1, 307)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ShortcutsEnabled = False
        Me.TextBox1.Size = New System.Drawing.Size(160, 21)
        Me.TextBox1.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape6, Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape3, Me.LineShape1, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(848, 577)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape6
        '
        Me.RectangleShape6.Location = New System.Drawing.Point(320, -9)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(160, 461)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.Location = New System.Drawing.Point(480, -2)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(160, 456)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.Location = New System.Drawing.Point(160, -4)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(160, 456)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(160, 450)
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 1
        Me.LineShape1.X2 = 821
        Me.LineShape1.Y1 = 50
        Me.LineShape1.Y2 = 50
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(8, 251)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(150, 21)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(8, 228)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(63, 21)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "添加新音符"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(159, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 29)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "片段制作"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(260, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 28)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "变调处理"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(361, 7)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 28)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "片段合成"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "C#4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "C4"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(464, 7)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 27)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "保存"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CMS1
        '
        Me.CMS1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.更改参数ToolStripMenuItem, Me.删除ToolStripMenuItem})
        Me.CMS1.Name = "CMS1"
        Me.CMS1.Size = New System.Drawing.Size(125, 48)
        '
        '更改参数ToolStripMenuItem
        '
        Me.更改参数ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Dyn力度ToolStripMenuItem, Me.Gen浑厚ToolStripMenuItem, Me.打开参数ToolStripMenuItem})
        Me.更改参数ToolStripMenuItem.Name = "更改参数ToolStripMenuItem"
        Me.更改参数ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.更改参数ToolStripMenuItem.Text = "更改参数"
        '
        'Dyn力度ToolStripMenuItem
        '
        Me.Dyn力度ToolStripMenuItem.Name = "Dyn力度ToolStripMenuItem"
        Me.Dyn力度ToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.Dyn力度ToolStripMenuItem.Text = "Dyn[力度]"
        '
        'Gen浑厚ToolStripMenuItem
        '
        Me.Gen浑厚ToolStripMenuItem.Name = "Gen浑厚ToolStripMenuItem"
        Me.Gen浑厚ToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.Gen浑厚ToolStripMenuItem.Text = "Gen[浑厚]"
        '
        '打开参数ToolStripMenuItem
        '
        Me.打开参数ToolStripMenuItem.Name = "打开参数ToolStripMenuItem"
        Me.打开参数ToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.打开参数ToolStripMenuItem.Text = "打开参数"
        '
        '删除ToolStripMenuItem
        '
        Me.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem"
        Me.删除ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.删除ToolStripMenuItem.Text = "删除"
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.Lime
        Me.TrackBar1.Location = New System.Drawing.Point(6, 3)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 104)
        Me.TrackBar1.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TrackBar2)
        Me.Panel1.Controls.Add(Me.TrackBar1)
        Me.Panel1.Location = New System.Drawing.Point(3, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(95, 117)
        Me.Panel1.TabIndex = 11
        '
        'TrackBar2
        '
        Me.TrackBar2.BackColor = System.Drawing.Color.Cyan
        Me.TrackBar2.Location = New System.Drawing.Point(50, 3)
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar2.Size = New System.Drawing.Size(45, 104)
        Me.TrackBar2.TabIndex = 11
        '
        'UserControl1
        '
        Me.UserControl1.cname = ""
        Me.UserControl1.Dyn = CType(0, Short)
        Me.UserControl1.Gen = CType(0, Short)
        Me.UserControl1.Location = New System.Drawing.Point(240, 483)
        Me.UserControl1.Name = "UserControl1"
        Me.UserControl1.Parameters = False
        Me.UserControl1.Size = New System.Drawing.Size(275, 21)
        Me.UserControl1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 577)
        Me.Controls.Add(Me.UserControl1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.CMS1.ResumeLayout(False)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CMS1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 更改参数ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Dyn力度ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Gen浑厚ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents RectangleShape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents 删除ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 打开参数ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserControl1 As WindowsApplication1.UserControl

End Class
