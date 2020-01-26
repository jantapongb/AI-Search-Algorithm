<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBT
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TbResult = New System.Windows.Forms.TextBox()
        Me.TbQuestion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 616)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1197, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(996, 561)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(190, 46)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.Text = "Solve"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TbResult
        '
        Me.TbResult.Enabled = False
        Me.TbResult.Font = New System.Drawing.Font("Sukhumvit Set", 31.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbResult.Location = New System.Drawing.Point(21, 23)
        Me.TbResult.Multiline = True
        Me.TbResult.Name = "TbResult"
        Me.TbResult.Size = New System.Drawing.Size(567, 532)
        Me.TbResult.TabIndex = 2
        '
        'TbQuestion
        '
        Me.TbQuestion.Enabled = False
        Me.TbQuestion.Font = New System.Drawing.Font("Sukhumvit Set", 31.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbQuestion.Location = New System.Drawing.Point(619, 23)
        Me.TbQuestion.Multiline = True
        Me.TbQuestion.Name = "TbQuestion"
        Me.TbQuestion.Size = New System.Drawing.Size(567, 532)
        Me.TbQuestion.TabIndex = 3
        '
        'FrmBT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 638)
        Me.Controls.Add(Me.TbQuestion)
        Me.Controls.Add(Me.TbResult)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MaximizeBox = False
        Me.Name = "FrmBT"
        Me.Text = "Backtracking Algorithm | Sudoku"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TbResult As TextBox
    Friend WithEvents TbQuestion As TextBox
End Class
