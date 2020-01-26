<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBFS
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.LblSrc = New System.Windows.Forms.Label()
        Me.LblDest = New System.Windows.Forms.Label()
        Me.CbSrc = New System.Windows.Forms.ComboBox()
        Me.CbDest = New System.Windows.Forms.ComboBox()
        Me.TbResult = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 640)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1094, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.DFS_Learnning
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1067, 557)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(930, 580)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(149, 40)
        Me.BtnStart.TabIndex = 2
        Me.BtnStart.Text = "Search"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'LblSrc
        '
        Me.LblSrc.AutoSize = True
        Me.LblSrc.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSrc.Location = New System.Drawing.Point(12, 583)
        Me.LblSrc.Name = "LblSrc"
        Me.LblSrc.Size = New System.Drawing.Size(62, 22)
        Me.LblSrc.TabIndex = 3
        Me.LblSrc.Text = "Start :"
        '
        'LblDest
        '
        Me.LblDest.AutoSize = True
        Me.LblDest.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDest.Location = New System.Drawing.Point(139, 583)
        Me.LblDest.Name = "LblDest"
        Me.LblDest.Size = New System.Drawing.Size(121, 22)
        Me.LblDest.TabIndex = 4
        Me.LblDest.Text = "Destination :"
        '
        'CbSrc
        '
        Me.CbSrc.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbSrc.FormattingEnabled = True
        Me.CbSrc.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O"})
        Me.CbSrc.Location = New System.Drawing.Point(79, 580)
        Me.CbSrc.Name = "CbSrc"
        Me.CbSrc.Size = New System.Drawing.Size(41, 30)
        Me.CbSrc.TabIndex = 5
        Me.CbSrc.Text = "A"
        '
        'CbDest
        '
        Me.CbDest.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbDest.FormattingEnabled = True
        Me.CbDest.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O"})
        Me.CbDest.Location = New System.Drawing.Point(266, 580)
        Me.CbDest.Name = "CbDest"
        Me.CbDest.Size = New System.Drawing.Size(52, 30)
        Me.CbDest.TabIndex = 6
        Me.CbDest.Text = "O"
        '
        'TbResult
        '
        Me.TbResult.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbResult.Location = New System.Drawing.Point(335, 580)
        Me.TbResult.Name = "TbResult"
        Me.TbResult.Size = New System.Drawing.Size(572, 39)
        Me.TbResult.TabIndex = 7
        '
        'FrmBFS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 662)
        Me.Controls.Add(Me.TbResult)
        Me.Controls.Add(Me.CbDest)
        Me.Controls.Add(Me.CbSrc)
        Me.Controls.Add(Me.LblDest)
        Me.Controls.Add(Me.LblSrc)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MaximizeBox = False
        Me.Name = "FrmBFS"
        Me.Text = "Breadth First Search"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnStart As Button
    Friend WithEvents LblSrc As Label
    Friend WithEvents LblDest As Label
    Friend WithEvents CbSrc As ComboBox
    Friend WithEvents CbDest As ComboBox
    Friend WithEvents TbResult As TextBox
End Class
