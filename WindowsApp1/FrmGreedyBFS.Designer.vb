<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGreedyBFS
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
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblSource = New System.Windows.Forms.Label()
        Me.LblDestination = New System.Windows.Forms.Label()
        Me.cbdest = New System.Windows.Forms.ComboBox()
        Me.cbsrc = New System.Windows.Forms.ComboBox()
        Me.TbResult = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(631, 398)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(360, 39)
        Me.BtnSearch.TabIndex = 0
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 468)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(999, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.DijkStraGraph
        Me.PictureBox1.Location = New System.Drawing.Point(14, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(611, 376)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.MatrixDijkStraGraph
        Me.PictureBox2.Location = New System.Drawing.Point(631, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(360, 376)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'LblSource
        '
        Me.LblSource.AutoSize = True
        Me.LblSource.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSource.Location = New System.Drawing.Point(12, 401)
        Me.LblSource.Name = "LblSource"
        Me.LblSource.Size = New System.Drawing.Size(71, 22)
        Me.LblSource.TabIndex = 6
        Me.LblSource.Text = "Source"
        '
        'LblDestination
        '
        Me.LblDestination.AutoSize = True
        Me.LblDestination.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDestination.Location = New System.Drawing.Point(172, 404)
        Me.LblDestination.Name = "LblDestination"
        Me.LblDestination.Size = New System.Drawing.Size(111, 22)
        Me.LblDestination.TabIndex = 7
        Me.LblDestination.Text = "Destination"
        '
        'cbdest
        '
        Me.cbdest.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbdest.FormattingEnabled = True
        Me.cbdest.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.cbdest.Location = New System.Drawing.Point(289, 398)
        Me.cbdest.Name = "cbdest"
        Me.cbdest.Size = New System.Drawing.Size(49, 30)
        Me.cbdest.TabIndex = 8
        Me.cbdest.Text = "E"
        '
        'cbsrc
        '
        Me.cbsrc.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsrc.FormattingEnabled = True
        Me.cbsrc.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.cbsrc.Location = New System.Drawing.Point(89, 398)
        Me.cbsrc.Name = "cbsrc"
        Me.cbsrc.Size = New System.Drawing.Size(50, 30)
        Me.cbsrc.TabIndex = 9
        Me.cbsrc.Text = "A"
        '
        'TbResult
        '
        Me.TbResult.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbResult.Location = New System.Drawing.Point(356, 398)
        Me.TbResult.Name = "TbResult"
        Me.TbResult.Size = New System.Drawing.Size(269, 39)
        Me.TbResult.TabIndex = 10
        '
        'FrmGreedyBFS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 490)
        Me.Controls.Add(Me.TbResult)
        Me.Controls.Add(Me.cbsrc)
        Me.Controls.Add(Me.cbdest)
        Me.Controls.Add(Me.LblDestination)
        Me.Controls.Add(Me.LblSource)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BtnSearch)
        Me.MaximizeBox = False
        Me.Name = "FrmGreedyBFS"
        Me.Text = "FrmGreedyBFS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSearch As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblSource As Label
    Friend WithEvents LblDestination As Label
    Friend WithEvents cbdest As ComboBox
    Friend WithEvents cbsrc As ComboBox
    Friend WithEvents TbResult As TextBox
End Class
