Public Class FrmDijkstra

    Public Const INFINITY As Integer = 9999
    Public Const max As Integer = 5

    Public Sub Dijkstra(ByVal G(,) As Integer, n As Integer, StartNode As Integer)

        Dim Cost(max, max) As Integer
        Dim Distance(max) As Integer
        Dim Pred(max) As Integer
        Dim Count, MinDistance, NextNode, i, j As Integer
        Dim Visited(max) As Boolean

        Dim ResultDistance As String = ""

        For i = 0 To (n - 1)
            For j = 0 To (n - 1)
                If G(i, j) = 0 Then
                    Cost(i, j) = INFINITY
                Else
                    Cost(i, j) = G(i, j)
                End If
            Next
        Next

        For i = 0 To (n - 1)
            Distance(i) = Cost(StartNode, i)
            Pred(i) = StartNode
            Visited(i) = False
        Next

        Distance(StartNode) = 0
        Visited(StartNode) = True
        Count = Count + 1

        Do While Count < (n - 1)
            MinDistance = INFINITY
            For i = 0 To (n - 1)
                If (Distance(i) < MinDistance) And (Not Visited(i)) Then
                    MinDistance = Distance(i)
                    NextNode = i
                End If
            Next
            Visited(NextNode) = True
            For i = 0 To n - 1
                If Not Visited(i) Then
                    If (MinDistance + Cost(NextNode, i)) < Distance(i) Then
                        Distance(i) = MinDistance + Cost(NextNode, i)
                        Pred(i) = NextNode
                    End If
                End If
            Next
            Count = Count + 1
        Loop

        For i = 0 To (n - 1)
            If i <> StartNode Then

                ResultDistance = Distance(i) & Convert.ToChar(i + 65)
                Console.WriteLine("Source {0} to {1} Distance = {2}", StartNode, i, Distance(i))
                'Console.WriteLine("Distance of node {0} = {1}", i, Distance(i))

                j = i
                Console.Write(i)
                Do
                    j = Pred(j)
                    Console.Write(" <- {0}", j)
                    ResultDistance = ResultDistance & Convert.ToChar(j + 65)
                Loop While j <> StartNode
                Console.WriteLine("")
            End If
            Console.WriteLine(" Resutl : {0}", ResultDistance)
            If ResultDistance.Count <> 0 Then
                Console.WriteLine(" Cut : {0}", ResultDistance.Substring(1, ResultDistance.Length() - 1))
                'MsgBox(ResultDistance.Substring(1, 1))
                If ResultDistance.Substring(1, 1) = Cbdest.Text Then
                    'MsgBox(ResultDistance)
                    TbResult.Text = "Path : " & ResultDistance.Substring(1) & "  Cost : " & ResultDistance.Substring(0, 1)
                End If
            End If
            'TbResult.Text = TbResult.Text & ResultDistance & vbCrLf


        Next

    End Sub
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click

        Dim G(max, max) As Integer
        Dim n As Integer = 5
        Dim u As Integer = 0

        TbResult.ResetText()

        u = Convert.ToInt32(Convert.ToChar(CbSrc.Text)) - 65

        G = {{0, 1, 0, 3, 10},
                {1, 0, 5, 0, 0},
                {0, 5, 0, 2, 1},
                {3, 0, 2, 0, 6},
                {10, 0, 1, 6, 0}
               }
        Dijkstra(G, n, u)

    End Sub

End Class