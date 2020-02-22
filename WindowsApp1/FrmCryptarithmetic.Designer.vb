<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCryptarithmetic
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
        Me.txtstr1 = New System.Windows.Forms.TextBox()
        Me.txtstr2 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtstr3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmdResolv = New System.Windows.Forms.Button()
        Me.TxtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 263)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(551, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtstr1
        '
        Me.txtstr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstr1.Location = New System.Drawing.Point(126, 25)
        Me.txtstr1.Name = "txtstr1"
        Me.txtstr1.Size = New System.Drawing.Size(171, 38)
        Me.txtstr1.TabIndex = 1
        Me.txtstr1.Text = "TWO"
        '
        'txtstr2
        '
        Me.txtstr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstr2.Location = New System.Drawing.Point(126, 79)
        Me.txtstr2.Name = "txtstr2"
        Me.txtstr2.Size = New System.Drawing.Size(171, 38)
        Me.txtstr2.TabIndex = 2
        Me.txtstr2.Text = "TWO"
        '
        'txt1
        '
        Me.txt1.AutoSize = True
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(30, 25)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(90, 25)
        Me.txt1.TabIndex = 3
        Me.txt1.Text = "String 1 :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "String 2 :"
        '
        'txtstr3
        '
        Me.txtstr3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstr3.Location = New System.Drawing.Point(126, 136)
        Me.txtstr3.Name = "txtstr3"
        Me.txtstr3.Size = New System.Drawing.Size(171, 38)
        Me.txtstr3.TabIndex = 5
        Me.txtstr3.Text = "FOUR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "String 3 :"
        '
        'CmdResolv
        '
        Me.CmdResolv.Location = New System.Drawing.Point(126, 191)
        Me.CmdResolv.Name = "CmdResolv"
        Me.CmdResolv.Size = New System.Drawing.Size(171, 45)
        Me.CmdResolv.TabIndex = 7
        Me.CmdResolv.Text = "Solv"
        Me.CmdResolv.UseVisualStyleBackColor = True
        '
        'TxtResult
        '
        Me.TxtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResult.Location = New System.Drawing.Point(314, 25)
        Me.TxtResult.Multiline = True
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.Size = New System.Drawing.Size(205, 211)
        Me.TxtResult.TabIndex = 8
        '
        'FrmCryptarithmetic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 285)
        Me.Controls.Add(Me.TxtResult)
        Me.Controls.Add(Me.CmdResolv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtstr3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.txtstr2)
        Me.Controls.Add(Me.txtstr1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MaximizeBox = False
        Me.Name = "FrmCryptarithmetic"
        Me.Text = "Cryptarithmetic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents txtstr1 As TextBox
    Friend WithEvents txtstr2 As TextBox
    Friend WithEvents txt1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtstr3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CmdResolv As Button
    Friend WithEvents TxtResult As TextBox
End Class
