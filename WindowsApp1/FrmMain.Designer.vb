<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepthFirstSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BreadthFirstSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DijkStraSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreedyBestFirstSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BacktrackingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BacktrackingNQueenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BacktrackingMapColoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FIleToolStripMenuItem
        '
        Me.FIleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepthFirstSearchToolStripMenuItem, Me.BreadthFirstSearchToolStripMenuItem, Me.DijkStraSearchToolStripMenuItem, Me.GreedyBestFirstSearchToolStripMenuItem, Me.ASearchToolStripMenuItem, Me.CSPToolStripMenuItem})
        Me.FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
        Me.FIleToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FIleToolStripMenuItem.Text = "File"
        '
        'DepthFirstSearchToolStripMenuItem
        '
        Me.DepthFirstSearchToolStripMenuItem.Name = "DepthFirstSearchToolStripMenuItem"
        Me.DepthFirstSearchToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.DepthFirstSearchToolStripMenuItem.Text = "Depth First Search"
        '
        'BreadthFirstSearchToolStripMenuItem
        '
        Me.BreadthFirstSearchToolStripMenuItem.Name = "BreadthFirstSearchToolStripMenuItem"
        Me.BreadthFirstSearchToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.BreadthFirstSearchToolStripMenuItem.Text = "Breadth First Search"
        '
        'DijkStraSearchToolStripMenuItem
        '
        Me.DijkStraSearchToolStripMenuItem.Name = "DijkStraSearchToolStripMenuItem"
        Me.DijkStraSearchToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.DijkStraSearchToolStripMenuItem.Text = "DijkStra Search"
        '
        'GreedyBestFirstSearchToolStripMenuItem
        '
        Me.GreedyBestFirstSearchToolStripMenuItem.Name = "GreedyBestFirstSearchToolStripMenuItem"
        Me.GreedyBestFirstSearchToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.GreedyBestFirstSearchToolStripMenuItem.Text = "Greedy Best First Search"
        '
        'ASearchToolStripMenuItem
        '
        Me.ASearchToolStripMenuItem.Name = "ASearchToolStripMenuItem"
        Me.ASearchToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.ASearchToolStripMenuItem.Text = "A* Search"
        '
        'CSPToolStripMenuItem
        '
        Me.CSPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BacktrackingToolStripMenuItem, Me.BacktrackingNQueenToolStripMenuItem, Me.BacktrackingMapColoringToolStripMenuItem})
        Me.CSPToolStripMenuItem.Name = "CSPToolStripMenuItem"
        Me.CSPToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.CSPToolStripMenuItem.Text = "CSP"
        '
        'BacktrackingToolStripMenuItem
        '
        Me.BacktrackingToolStripMenuItem.Name = "BacktrackingToolStripMenuItem"
        Me.BacktrackingToolStripMenuItem.Size = New System.Drawing.Size(279, 26)
        Me.BacktrackingToolStripMenuItem.Text = "Backtracking | Soduku"
        '
        'BacktrackingNQueenToolStripMenuItem
        '
        Me.BacktrackingNQueenToolStripMenuItem.Name = "BacktrackingNQueenToolStripMenuItem"
        Me.BacktrackingNQueenToolStripMenuItem.Size = New System.Drawing.Size(279, 26)
        Me.BacktrackingNQueenToolStripMenuItem.Text = "Backtracking | N Queen"
        '
        'BacktrackingMapColoringToolStripMenuItem
        '
        Me.BacktrackingMapColoringToolStripMenuItem.Name = "BacktrackingMapColoringToolStripMenuItem"
        Me.BacktrackingMapColoringToolStripMenuItem.Size = New System.Drawing.Size(279, 26)
        Me.BacktrackingMapColoringToolStripMenuItem.Text = "Backtracking | Map Coloring"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMain"
        Me.Text = "Search Algorithm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepthFirstSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BreadthFirstSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DijkStraSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreedyBestFirstSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CSPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BacktrackingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BacktrackingNQueenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BacktrackingMapColoringToolStripMenuItem As ToolStripMenuItem
End Class
