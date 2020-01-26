Public Class FrmDepthFirstSearch
    Private Sub FrmDepthFirstSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim vertices(NODEs) As VarNode
        Dim start As VarNode
        Dim S As Integer
        Dim iloopmain As Integer

        TbResualt.ResetText()

        For iloopmain = 0 To (NODEs - 1)
            vertices(iloopmain).val = iloopmain
            Console.Write("Claear :")
            Console.WriteLine(vertices(iloopmain).val)
        Next

        'MsgBox(Convert.ToInt32(Convert.ToChar(TbStart.Text)))
        S = Convert.ToInt32(Convert.ToChar(TbStart.Text))

        ''S = 67
        start.val = S - 65

        Console.WriteLine("DFS Tracersal : ")
        Dfs(vertices, start)

    End Sub


    Public Const NODEs As Integer = 6

    Public Sub Dfs(vertex() As VarNode, start As VarNode)

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
        Dim myStack As New Stack()
        Dim iloop As Integer

        Dim indexloop As Integer

        For indexloop = 0 To (NODEs - 1)
            vertex(indexloop).state = 0
        Next

        myStack.Push(start)

        Do While myStack.Count <> 0

            u = myStack.Peek()
            myStack.Pop()
            'Console.WriteLine("{0} {1}", Convert.ToChar(u.val + 65), "->")
            TbResualt.Text = TbResualt.Text + Convert.ToChar(u.val + 65) + "->>"

            If u.state <> 1 Then
                u.state = 1
                vertex(u.val).state = 1
                For iloop = 0 To (NODEs - 1)
                    If graph(iloop, u.val) = 1 Then
                        If vertex(iloop).state = 0 Then
                            myStack.Push(vertex(iloop))
                            vertex(iloop).state = 1
                        End If
                    End If
                Next
            End If
        Loop

    End Sub

    Public Structure VarNode

        Public val As Integer
        Public state As Integer

    End Structure


End Class