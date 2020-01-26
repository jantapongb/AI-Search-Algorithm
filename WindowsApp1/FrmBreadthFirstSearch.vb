Public Class FrmBreadthFirstSearch
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click

        Dim vertices(Nodes) As VarNode
        Dim start As VarNode
        Dim S As Integer
        Dim iloopmain As Integer

        TbResualt.ResetText()

        For iloopmain = 0 To (Nodes - 1)
            vertices(iloopmain).val = iloopmain
            Console.Write("Claear :")
            Console.WriteLine(vertices(iloopmain).val)
        Next

        'MsgBox(Convert.ToInt32(Convert.ToChar(TbStart.Text)))
        S = Convert.ToInt32(Convert.ToChar(TbStart.Text))

        ''S = 67
        start.val = S - 65

        Console.WriteLine("BFS Tracersal : ")
        Bfs(vertices, start)


    End Sub

    Public Const NODEs As Integer = 6

    Public Sub Bfs(vertex() As VarNode, start As VarNode)

        Dim graph(NODEs, NODEs) As Integer
        graph = {
                   {0, 1, 1, 1, 0, 0},
                   {1, 0, 0, 1, 1, 0},
                   {1, 0, 0, 1, 0, 1},
                   {1, 1, 1, 0, 1, 1},
                   {0, 1, 0, 1, 0, 1},
                   {0, 0, 1, 1, 1, 0}
                }

        Dim u As VarNode
        'Dim myStack As New Stack()
        Dim myQueue As New Queue()
        Dim iloop As Integer
        Dim indexloop As Integer
        Dim iloopfor As Integer

        For indexloop = 0 To (NODEs - 1)
            vertex(indexloop).state = 0     '--Not Visited
        Next

        vertex(start.val).state = 1         '--Visited
        myQueue.Enqueue(start)              '--Insert staring node

        Do While myQueue.Count <> 0

            u = myQueue.Peek()             '--Delete form Queue and print

            myQueue.Dequeue()

            'Console.WriteLine("{0} {1}", Convert.ToChar(u.val + 65), "->")
            TbResualt.Text = TbResualt.Text + Convert.ToChar(u.val + 65) + "->>"

            For iloopfor = 0 To (NODEs - 1)
                If graph(iloopfor, u.val) = 1 Then      '--when the node is non-visited
                    If (vertex(iloopfor).state = 0) Then
                        vertex(iloopfor).state = 1
                        myQueue.Enqueue(vertex(iloopfor))
                    End If
                End If
            Next
            u.state = 2  '--Completed for node u
        Loop

    End Sub

    Public Structure VarNode

        Public val As Integer
        Public state As Integer

    End Structure

End Class