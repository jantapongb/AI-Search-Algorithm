<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDFS
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
        Me.TbResult = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LblStart = New System.Windows.Forms.Label()
        Me.CbStart = New System.Windows.Forms.ComboBox()
        Me.Cbdest = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(915, 599)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(121, 41)
        Me.BtnSearch.TabIndex = 0
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TbResult
        '
        Me.TbResult.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbResult.Location = New System.Drawing.Point(352, 599)
        Me.TbResult.Name = "TbResult"
        Me.TbResult.Size = New System.Drawing.Size(557, 39)
        Me.TbResult.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 658)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1055, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LblStart
        '
        Me.LblStart.AutoSize = True
        Me.LblStart.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStart.Location = New System.Drawing.Point(12, 601)
        Me.LblStart.Name = "LblStart"
        Me.LblStart.Size = New System.Drawing.Size(71, 22)
        Me.LblStart.TabIndex = 6
        Me.LblStart.Text = "Source"
        '
        'CbStart
        '
        Me.CbStart.Font = New System.Drawing.Font("Sukhumvit Set", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbStart.FormattingEnabled = True
        Me.CbStart.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O"})
        Me.CbStart.Location = New System.Drawing.Point(89, 597)
        Me.CbStart.Name = "CbStart"
        Me.CbStart.Size = New System.Drawing.Size(53, 33)
        Me.CbStart.TabIndex = 7
        Me.CbStart.Text = "A"
        '
        'Cbdest
        '
        Me.Cbdest.Font = New System.Drawing.Font("Sukhumvit Set", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbdest.FormattingEnabled = True
        Me.Cbdest.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O"})
        Me.Cbdest.Location = New System.Drawing.Point(277, 598)
        Me.Cbdest.Name = "Cbdest"
        Me.Cbdest.Size = New System.Drawing.Size(50, 33)
        Me.Cbdest.TabIndex = 8
        Me.Cbdest.Text = "O"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 603)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Destination"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.DFS_Learnning
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1024, 560)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'FrmDFS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 680)
        Me.Controls.Add(Me.Cbdest)
        Me.Controls.Add(Me.CbStart)
        Me.Controls.Add(Me.LblStart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TbResult)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FrmDFS"
        Me.Text = "Depth First Search"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSearch As Button
    Friend WithEvents TbResult As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblStart As Label
    Friend WithEvents CbStart As ComboBox
    Friend WithEvents Cbdest As ComboBox
    Friend WithEvents Label1 As Label
End Class
