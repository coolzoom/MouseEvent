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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdClick = New System.Windows.Forms.Button()
        Me.picClicker = New System.Windows.Forms.PictureBox()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.LabelX = New System.Windows.Forms.Label()
        Me.LabelY = New System.Windows.Forms.Label()
        CType(Me.picClicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(184, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 22)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdClick
        '
        Me.cmdClick.Location = New System.Drawing.Point(282, 350)
        Me.cmdClick.Name = "cmdClick"
        Me.cmdClick.Size = New System.Drawing.Size(75, 22)
        Me.cmdClick.TabIndex = 1
        Me.cmdClick.Text = "Click"
        Me.cmdClick.UseVisualStyleBackColor = True
        '
        'picClicker
        '
        Me.picClicker.Location = New System.Drawing.Point(97, 26)
        Me.picClicker.Name = "picClicker"
        Me.picClicker.Size = New System.Drawing.Size(317, 172)
        Me.picClicker.TabIndex = 2
        Me.picClicker.TabStop = False
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(97, 255)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.Size = New System.Drawing.Size(376, 76)
        Me.txtResults.TabIndex = 3
        '
        'LabelX
        '
        Me.LabelX.AutoSize = True
        Me.LabelX.Location = New System.Drawing.Point(474, 85)
        Me.LabelX.Name = "LabelX"
        Me.LabelX.Size = New System.Drawing.Size(55, 15)
        Me.LabelX.TabIndex = 4
        Me.LabelX.Text = "Label1"
        '
        'LabelY
        '
        Me.LabelY.AutoSize = True
        Me.LabelY.Location = New System.Drawing.Point(474, 110)
        Me.LabelY.Name = "LabelY"
        Me.LabelY.Size = New System.Drawing.Size(55, 15)
        Me.LabelY.TabIndex = 5
        Me.LabelY.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 424)
        Me.Controls.Add(Me.LabelY)
        Me.Controls.Add(Me.LabelX)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.picClicker)
        Me.Controls.Add(Me.cmdClick)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Opacity = 0.8R
        Me.Text = "Form1"
        CType(Me.picClicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents cmdClick As Button
    Friend WithEvents picClicker As PictureBox
    Friend WithEvents txtResults As TextBox
    Friend WithEvents LabelX As Label
    Friend WithEvents LabelY As Label
End Class
