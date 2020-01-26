Public Class FrmAStart
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click





    End Sub

End Class

Public Class Edge

    Public cost As Double
    Public target As Node

    Public Function Edge(target As Node, cost As Double)
        Edge.cost = cost
        Edge.target = target
        Return True
    End Function

End Class
Public Class Node

    Public name As String
    Public g_cost As Double
    Public f_cost As Double
    Public h_cost As Double

    Public adjacency = New ArrayList()
    Public parent As Node

    Public Function Node(name As String, h_cost As Double)
        Node.name = name
        Node.h_cost = h_cost
        Return True
    End Function

    Public Function addNeighbour(neighbour As Node, cost As Integer)
        Dim Edge As Edge = New Edge()
        adjacency.add(Edge)
        Return True
    End Function


End Class

Public Class AStarSearch(Of source As Node, destination As Node)


End Class




