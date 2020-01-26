Public Class FrmGreedyBFS

    Public len As Integer = 0
    Public Graph(Nodes, Nodes) As Integer
    Public Visited(25) As Integer
    Public Nodes As Integer = 5
    Public iLoopRow As Integer
    Public iLoopCol As Integer
    Public PathResult As String
    Dim Src As Integer
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        'Graph = {
        '    {0, 2, 0, 0, 5, 1},
        '    {1, 0, 3, 0, 0, 0},
        '    {0, 2, 0, 8, 0, 0},
        '    {0, 0, 3, 0, 5, 0},
        '    {1, 0, 0, 8, 0, 1},
        '    {1, 0, 0, 0, 5, 0}
        '    }
        Graph = {
            {0, 1, 0, 3, 10},
            {1, 0, 5, 0, 0},
            {0, 5, 0, 2, 1},
            {3, 0, 2, 0, 6},
            {10, 0, 1, 6, 0}
            }

        len = Graph.Length()
        ' Console.WriteLine("Len Array : {0}", len)

        For iLoopCol = 0 To len - 1
            Visited(iLoopCol) = 0
        Next

        Src = Convert.ToInt32(Convert.ToChar(cbsrc.Text)) - 65
        TbResult.ResetText()
        'PathResult = ""
        BestFirstSearch(Src)

        'Console.WriteLine(PathResult)

        TbResult.Text = PathResult
        PathResult = ""
        TbResult.Text = TbResult.Text.Substring(TbResult.Text.IndexOf(cbsrc.Text), TbResult.Text.IndexOf(cbdest.Text) + 1)

    End Sub

    Public Sub BestFirstSearch(Vertex As Integer)

        Dim GetArrayByRow(Nodes) As Integer
        Dim iLoop As Integer
        Dim Dict As New Dictionary(Of Integer, Integer)

        Visited(Vertex) = 1
        Console.WriteLine("Vertex :{0}", Vertex)
        PathResult = PathResult & Convert.ToChar(Vertex + 65) & ">"


        For iLoop = 0 To Nodes - 1
            GetArrayByRow(iLoop) = Graph(Vertex, iLoop)
            Dict.Add(iLoop, Graph(Vertex, iLoop))

            ' Console.WriteLine("Get Array Data : {0}", GetArrayByRow(iLoop))

        Next

        System.Array.Sort(GetArrayByRow)
        For Each Value In GetArrayByRow
            'Console.WriteLine("Sort Data : {0}", Value)

        Next

        Dim Sorted = From pair In Dict Order By pair.Value
        Dim SortedDict = Sorted.ToDictionary(Function(p) p.Key, Function(p) p.Value)

        For Each Value In SortedDict
            'Console.WriteLine("Dict Data : {0}", Value)
        Next

        'Console.WriteLine("Get key by value in Dict {0}", SortedDict.Keys(5))       '--Get Index by Value Dict(index,Value)

        For Each Value In SortedDict
            'Console.WriteLine(Value)
            'Console.WriteLine(Value.Key)
            'Console.WriteLine(Value.Value)
            If (Value.Value > 0 And Visited(Value.Key) <> 1) Then
                BestFirstSearch(Value.Key)
            End If
        Next

    End Sub

End Class