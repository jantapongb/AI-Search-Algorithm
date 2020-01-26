<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDepthFirstSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.TbResualt = New System.Windows.Forms.TextBox()
        Me.lblstart = New System.Windows.Forms.Label()
        Me.TbStart = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(476, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(256, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.MatrixDFS
        Me.PictureBox2.Location = New System.Drawing.Point(476, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(256, 292)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.GraphDFS1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(441, 292)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'StatusBar
        '
        Me.StatusBar.Location = New System.Drawing.Point(0, 428)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(745, 22)
        Me.StatusBar.TabIndex = 4
        Me.StatusBar.Text = "StatusStrip1"
        '
        'TbResualt
        '
        Me.TbResualt.Font = New System.Drawing.Font("Sukhumvit Set", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbResualt.Location = New System.Drawing.Point(156, 359)
        Me.TbResualt.Multiline = True
        Me.TbResualt.Name = "TbResualt"
        Me.TbResualt.Size = New System.Drawing.Size(297, 41)
        Me.TbResualt.TabIndex = 5
        Me.TbResualt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblstart
        '
        Me.lblstart.AutoSize = True
        Me.lblstart.Font = New System.Drawing.Font("Sukhumvit Set", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstart.Location = New System.Drawing.Point(12, 366)
        Me.lblstart.Name = "lblstart"
        Me.lblstart.Size = New System.Drawing.Size(66, 23)
        Me.lblstart.TabIndex = 6
        Me.lblstart.Text = "Start :"
        '
        'TbStart
        '
        Me.TbStart.Font = New System.Drawing.Font("Sukhumvit Set", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbStart.Location = New System.Drawing.Point(84, 359)
        Me.TbStart.Multiline = True
        Me.TbStart.Name = "TbStart"
        Me.TbStart.Size = New System.Drawing.Size(51, 41)
        Me.TbStart.TabIndex = 7
        Me.TbStart.Text = "C"
        Me.TbStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmDepthFirstSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 450)
        Me.Controls.Add(Me.TbStart)
        Me.Controls.Add(Me.lblstart)
        Me.Controls.Add(Me.TbResualt)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "FrmDepthFirstSearch"
        Me.Text = "Depth First Search"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents StatusBar As StatusStrip
    Friend WithEvents TbResualt As TextBox
    Friend WithEvents lblstart As Label
    Friend WithEvents TbStart As TextBox
End Class
