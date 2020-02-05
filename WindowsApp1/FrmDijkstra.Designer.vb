<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDijkstra
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LblStart = New System.Windows.Forms.Label()
        Me.TbResult = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CbSrc = New System.Windows.Forms.ComboBox()
        Me.Cbdest = New System.Windows.Forms.ComboBox()
        Me.LblDest = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(619, 409)
        Me.BtnStart.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(358, 45)
        Me.BtnStart.TabIndex = 0
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 468)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(993, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LblStart
        '
        Me.LblStart.AutoSize = True
        Me.LblStart.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStart.Location = New System.Drawing.Point(12, 414)
        Me.LblStart.Name = "LblStart"
        Me.LblStart.Size = New System.Drawing.Size(52, 22)
        Me.LblStart.TabIndex = 4
        Me.LblStart.Text = "Start"
        '
        'TbResult
        '
        Me.TbResult.Font = New System.Drawing.Font("Sukhumvit Set", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbResult.Location = New System.Drawing.Point(358, 409)
        Me.TbResult.Multiline = True
        Me.TbResult.Name = "TbResult"
        Me.TbResult.Size = New System.Drawing.Size(239, 30)
        Me.TbResult.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.MatrixDijkStraGraph
        Me.PictureBox2.Location = New System.Drawing.Point(608, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(369, 373)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.DijkStraGraph
        Me.PictureBox1.Location = New System.Drawing.Point(16, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(570, 374)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'CbSrc
        '
        Me.CbSrc.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbSrc.FormattingEnabled = True
        Me.CbSrc.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.CbSrc.Location = New System.Drawing.Point(69, 409)
        Me.CbSrc.Name = "CbSrc"
        Me.CbSrc.Size = New System.Drawing.Size(53, 30)
        Me.CbSrc.TabIndex = 7
        Me.CbSrc.Text = "A"
        '
        'Cbdest
        '
        Me.Cbdest.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbdest.FormattingEnabled = True
        Me.Cbdest.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.Cbdest.Location = New System.Drawing.Point(274, 409)
        Me.Cbdest.Name = "Cbdest"
        Me.Cbdest.Size = New System.Drawing.Size(53, 30)
        Me.Cbdest.TabIndex = 8
        Me.Cbdest.Text = "D"
        '
        'LblDest
        '
        Me.LblDest.AutoSize = True
        Me.LblDest.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDest.Location = New System.Drawing.Point(144, 414)
        Me.LblDest.Name = "LblDest"
        Me.LblDest.Size = New System.Drawing.Size(121, 22)
        Me.LblDest.TabIndex = 9
        Me.LblDest.Text = "Destination :"
        '
        'FrmDijkstra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 490)
        Me.Controls.Add(Me.Cbdest)
        Me.Controls.Add(Me.CbSrc)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TbResult)
        Me.Controls.Add(Me.LblStart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.LblDest)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmDijkstra"
        Me.Text = "Dijkstra Algorithm"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnStart As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblStart As Label
    Friend WithEvents TbResult As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CbSrc As ComboBox
    Friend WithEvents Cbdest As ComboBox
    Friend WithEvents LblDest As Label
End Class
