Public Class FrmMain
	Private Sub MainMenuDropDownClick(sender As Object, e As ToolStripItemClickedEventArgs) Handles FIleToolStripMenuItem.DropDownItemClicked

		Dim SelectMenu As String = e.ClickedItem.Text

		Select Case SelectMenu
			Case "Depth First Search"

				Dim FrmDFS = New FrmDFS()
				FrmDFS.MdiParent = Me
				FrmDFS.Show()
				Exit Select

			Case "Breadth First Search"
				Dim FrmBFS = New FrmBFS()
				FrmBFS.MdiParent = Me
				FrmBFS.Show()
				Exit Select

			Case "DijkStra Search"
				Dim FrmDijkstra = New FrmDijkstra()
				FrmDijkstra.MdiParent = Me
				FrmDijkstra.Show()
				Exit Select

			Case "Greedy Best First Search"
				Dim FrmGreedyBFS = New FrmGreedyBFS()
				FrmGreedyBFS.MdiParent = Me
				FrmGreedyBFS.Show()
				Exit Select

		End Select

	End Sub

	Private Sub BacktrackingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BacktrackingToolStripMenuItem.Click
		Dim FrmBT = New FrmBT()
		FrmBT.MdiParent = Me
		FrmBT.Show()
	End Sub

	Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub BacktrackingNQueenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BacktrackingNQueenToolStripMenuItem.Click
		Dim FrmNQueen = New FrmNQueen()
		FrmNQueen.MdiParent = Me
		FrmNQueen.Show()
	End Sub

	Private Sub BacktrackingMapColoringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BacktrackingMapColoringToolStripMenuItem.Click

		Dim FrmMapColoring = New FrmMColoring()
		FrmMColoring.MdiParent = Me
		FrmMColoring.Show()

	End Sub

	Private Sub ASearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASearchToolStripMenuItem.Click

		Dim FrmAstar = New FrmAStart()
		FrmAstar.MdiParent = Me
		FrmAstar.Show()

	End Sub

	Private Sub CryptarithmeticToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CryptarithmeticToolStripMenuItem.Click

		Dim FrmCrypta = New FrmCryptarithmetic
		FrmCrypta.MdiParent = Me
		FrmCrypta.Show()

	End Sub
End Class