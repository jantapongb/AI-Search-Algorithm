Public Class FrmDFS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        Dim vertices(NODEs) As VarNode
        Dim start As VarNode
        Dim S As Integer
        Dim iloopmain As Integer


        TbResult.ResetText()

        For iloopmain = 0 To (NODEs - 1)
            vertices(iloopmain).val = iloopmain
            'Console.Write("Clear :")
            'Console.WriteLine(vertices(iloopmain).val)
        Next

        S = Convert.ToInt32(Convert.ToChar(CbStart.Text))
        'Console.WriteLine("Start Point : {0}", CbStart.Text)
        'S = Convert.ToInt32(Convert.ToChar(TbStart.Text))

        start.val = S - 65

        Console.WriteLine("DFS Tracersal : ")
        Dfs(vertices, start)

    End Sub

    Public Const NODEs As Integer = 15

    Public Sub Dfs(vertex() As VarNode, start As VarNode)

        Dim graph(NODEs, NODEs) As Integer
        graph = {
                    {0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    {1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    {1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0},
                    {0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0},
                    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0},
                    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1},
                    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
                    {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0}
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
            Console.WriteLine("U Last State :{0} U Value Last :{1}", u.state, u.val)
            myStack.Pop()

            TbResult.Text = TbResult.Text + Convert.ToChar(u.val + 65) + " > "

            If u.state <> 1 Then
                u.state = 1
                vertex(u.val).state = 1                    '--Set to Visited

                For iloop = NODEs - 1 To 0 Step -1
                    If graph(iloop, u.val) = 1 Then
                        Console.WriteLine("Arrary Data ({0},{1}) = {2}", iloop, u.val, graph(iloop, u.val))
                        If vertex(iloop).state = 0 Then
                            myStack.Push(vertex(iloop))
                            vertex(iloop).state = 1
                        End If
                    End If
                Next

            End If
        Loop
        'Console.WriteLine(TbResult.Text.Substring(0, TbResult.Text.IndexOf(Cbdest.Text) + 1))
        TbResult.Text = TbResult.Text.Substring(0, TbResult.Text.IndexOf(Cbdest.Text) + 1)

    End Sub

    Public Structure VarNode

        Public val As Integer
        Public state As Integer

    End Structure

End Class