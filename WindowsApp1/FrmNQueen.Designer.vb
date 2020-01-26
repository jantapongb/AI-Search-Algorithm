<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNQueen
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
        Me.CbNN = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 744)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(581, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(361, 677)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(205, 47)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.Text = "Start"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TbResult
        '
        Me.TbResult.Enabled = False
        Me.TbResult.Font = New System.Drawing.Font("Sukhumvit Set", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbResult.Location = New System.Drawing.Point(12, 12)
        Me.TbResult.Multiline = True
        Me.TbResult.Name = "TbResult"
        Me.TbResult.Size = New System.Drawing.Size(554, 646)
        Me.TbResult.TabIndex = 2
        '
        'CbNN
        '
        Me.CbNN.Font = New System.Drawing.Font("Sukhumvit Set", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbNN.FormattingEnabled = True
        Me.CbNN.Items.AddRange(New Object() {"4", "8", "16"})
        Me.CbNN.Location = New System.Drawing.Point(269, 683)
        Me.CbNN.Name = "CbNN"
        Me.CbNN.Size = New System.Drawing.Size(67, 33)
        Me.CbNN.TabIndex = 3
        Me.CbNN.Text = "8"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sukhumvit Set", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 686)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NxN"
        '
        'FrmNQueen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 766)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbNN)
        Me.Controls.Add(Me.TbResult)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MaximizeBox = False
        Me.Name = "FrmNQueen"
        Me.Text = "Backtracking Algorithm | N Queen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TbResult As TextBox
    Friend WithEvents CbNN As ComboBox
    Friend WithEvents Label1 As Label
End Class
