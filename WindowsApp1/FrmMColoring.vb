Public Class FrmMColoring

    Public Const VNode = 7
    Public Result(VNode) As String

    Public Function IsSafe(v As Integer, graph(,) As Boolean, color() As Integer, c As Integer) As Boolean

        For i = 0 To VNode - 1
            If graph(v, i) And c = color(i) Then
                Return False
            End If
        Next
        Return True

    End Function

    Public Function GraphColoringUtil(graph(,) As Boolean, m As Integer, color() As Integer, v As Integer) As Boolean

        If v = VNode Then
            Return True
        End If

        For c = 1 To m
            If IsSafe(v, graph, color, c) Then
                color(v) = c
                If GraphColoringUtil(graph, m, color, v + 1) = True Then
                    Return True
                End If
                color(v) = 0
            End If
        Next
        Return False

    End Function

    Public Function GraphColoring(graph(,) As Boolean, m As Integer) As Boolean

        Dim color(VNode) As Integer

        For i = 0 To VNode - 1
            color(i) = 0
        Next
        If GraphColoringUtil(graph, m, color, 0) = False Then
            Console.WriteLine("Solution does not exist")
            Return False
        End If

        PrintSolution(color)
        Return True

    End Function
    Public Sub PrintSolution(Colors() As Integer)
        Dim ColorName As String
        Dim i As Integer

        Console.WriteLine("Solution Exists :")

        For i = 0 To VNode - 1
            If Colors(i) = 1 Then
                ColorName = "Red"
                'Result(i) = "Red"
            ElseIf Colors(i) = 2 Then
                ColorName = "Green"
                'Result(i) = "Green"
            Else
                ColorName = "Blue"
                'Result(i) = "Blue"
            End If
            Console.Write(" {0} ", ColorName)
            Console.WriteLine(" ")
        Next

        If Colors(0) = 1 Then
            BtnQ.BackColor = Color.Red
        ElseIf Colors(0) = 2 Then
            BtnQ.BackColor = Color.Green
        Else
            BtnQ.BackColor = Color.Blue
        End If

        If Colors(1) = 1 Then
            BtnNT.BackColor = Color.Red
        ElseIf Colors(1) = 2 Then
            BtnNT.BackColor = Color.Green
        Else
            BtnNT.BackColor = Color.Blue
        End If

        If Colors(2) = 1 Then
            Btnwa.BackColor = Color.Red
        ElseIf Colors(2) = 2 Then
            Btnwa.BackColor = Color.Green
        Else
            Btnwa.BackColor = Color.Blue
        End If

        If Colors(3) = 1 Then
            BtnNSW.BackColor = Color.Red
        ElseIf Colors(3) = 2 Then
            BtnNSW.BackColor = Color.Green
        Else
            BtnNSW.BackColor = Color.Blue
        End If

        If Colors(4) = 1 Then
            BtnSA.BackColor = Color.Red
        ElseIf Colors(4) = 2 Then
            BtnSA.BackColor = Color.Green
        Else
            BtnSA.BackColor = Color.Blue
        End If

        If Colors(5) = 1 Then
            BtnV.BackColor = Color.Red
        ElseIf Colors(5) = 2 Then
            BtnV.BackColor = Color.Green
        Else
            BtnV.BackColor = Color.Blue
        End If

        If Colors(6) = 1 Then
            BtnT.BackColor = Color.Red
        ElseIf Colors(6) = 2 Then
            BtnT.BackColor = Color.Green
        Else
            BtnT.BackColor = Color.Blue
        End If

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        Dim Graph(VNode, VNode) As Boolean
        Dim m As Integer = 3

        'Graph = {{0, 1, 1, 1},
        '            {1, 0, 1, 0},
        '            {1, 1, 0, 1},
        '            {1, 0, 1, 0}
        '         }
        Graph = {
                    {0, 1, 1, 1, 1, 0, 0},
                    {1, 0, 1, 0, 1, 0, 0},
                    {0, 1, 0, 0, 1, 0, 0},
                    {1, 0, 0, 0, 1, 1, 0},
                    {1, 1, 1, 1, 0, 0, 0},
                    {0, 0, 0, 1, 0, 0, 1},
                    {0, 0, 0, 0, 0, 1, 0}
                }

        GraphColoring(Graph, m)


    End Sub
End Class