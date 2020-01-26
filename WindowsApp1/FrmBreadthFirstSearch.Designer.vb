<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBreadthFirstSearch
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
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.TbResualt = New System.Windows.Forms.TextBox()
        Me.TbStart = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusBFS = New System.Windows.Forms.StatusStrip()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblstart = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnStart
        '
        Me.BtnStart.Font = New System.Drawing.Font("Sukhumvit Set", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.Location = New System.Drawing.Point(480, 316)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(249, 34)
        Me.BtnStart.TabIndex = 0
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'TbResualt
        '
        Me.TbResualt.Font = New System.Drawing.Font("Sukhumvit Set", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbResualt.Location = New System.Drawing.Point(153, 316)
        Me.TbResualt.Multiline = True
        Me.TbResualt.Name = "TbResualt"
        Me.TbResualt.Size = New System.Drawing.Size(302, 34)
        Me.TbResualt.TabIndex = 1
        '
        'TbStart
        '
        Me.TbStart.Font = New System.Drawing.Font("Sukhumvit Set", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbStart.Location = New System.Drawing.Point(72, 316)
        Me.TbStart.Multiline = True
        Me.TbStart.Name = "TbStart"
        Me.TbStart.Size = New System.Drawing.Size(64, 34)
        Me.TbStart.TabIndex = 2
        Me.TbStart.Text = "A"
        Me.TbStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.GraphDFS1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(443, 288)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'StatusBFS
        '
        Me.StatusBFS.Location = New System.Drawing.Point(0, 364)
        Me.StatusBFS.Name = "StatusBFS"
        Me.StatusBFS.Size = New System.Drawing.Size(733, 22)
        Me.StatusBFS.TabIndex = 4
        Me.StatusBFS.Text = "StatusStrip1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.MatrixDFS
        Me.PictureBox2.Location = New System.Drawing.Point(480, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(249, 288)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'lblstart
        '
        Me.lblstart.AutoSize = True
        Me.lblstart.Font = New System.Drawing.Font("Sukhumvit Set", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstart.Location = New System.Drawing.Point(12, 322)
        Me.lblstart.Name = "lblstart"
        Me.lblstart.Size = New System.Drawing.Size(52, 21)
        Me.lblstart.TabIndex = 6
        Me.lblstart.Text = "Start"
        '
        'FrmBreadthFirstSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 386)
        Me.Controls.Add(Me.lblstart)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.StatusBFS)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TbStart)
        Me.Controls.Add(Me.TbResualt)
        Me.Controls.Add(Me.BtnStart)
        Me.MaximizeBox = False
        Me.Name = "FrmBreadthFirstSearch"
        Me.Text = "Breadth First Search"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnStart As Button
    Friend WithEvents TbResualt As TextBox
    Friend WithEvents TbStart As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StatusBFS As StatusStrip
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblstart As Label
End Class
