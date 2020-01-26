Public Class FrmNQueen
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        N = Convert.ToInt16(CbNN.Text)
        TbResult.ResetText()
        CheckSolution()
        'SolveNQ()
    End Sub

    Public N As Integer = 8
    Public Sub PrintBoard(board(,) As Integer)

        Dim i As Integer        '--Colume
        Dim j As Integer        '--Row

        For i = 0 To N - 1
            For j = 0 To N - 1
                Console.Write("{0} ", board(i, j))
                TbResult.Text = TbResult.Text & board(i, j) & " "
            Next
            Console.WriteLine()
            TbResult.Text = TbResult.Text & vbCrLf
        Next
    End Sub

    Public Function IsValid(board(,) As Integer, row As Integer, col As Integer) As Boolean

        Dim i As Integer            '--Colume
        Dim j As Integer            '--Row

        'Console.WriteLine("Step 0 Col={0} Row={1}", col, row)

        For i = 0 To col - 1        '--Check left board(colume,row)
            'Console.WriteLine("Step Check Left i={0} row={1}", i, row)
            If board(i, row) Then
                Return False
            End If
        Next

        j = col
        For i = row To 0 Step -1        '--Left upper diagonal ทะแหยงมุมไล่ซ้ายขึ้นบน
            If (j >= 0 And i < N) Then
                ' Console.WriteLine("Step Check Upper Diagonal Row(i)={0} Col(j)={1}", i, j)
                If board(j, i) Then
                    Return False
                End If
                j -= 1
            End If
        Next
        ' Console.WriteLine("Step Upper Diagonal(End Loop) Row(i)={0} Col(j)={1}", i, j)

        j = col
        For i = row To N - 1                        '--Left lower diagonal
            If (j >= 0 And i < N) Then
                'Console.WriteLine("Step Check Lower Diagonal Row(i)={0} Col(j)={1}", i, j)
                If board(j, i) Then
                    Return False
                End If
                j -= 1
            End If
        Next

        Return True
    End Function

    Public Function SolveNQueen(board(,) As Integer, col As Integer) As Boolean

        If col >= N Then
            Return True                 '--when N queens are placed successfully
        End If

        'Console.WriteLine("Current Col : {0}", col)

        For i = 0 To N - 1
            'Console.WriteLine("Inloop Current Col : {0} row(i) : {1}", col, i)
            If IsValid(board, i, col) Then
                board(col, i) = 1           '--if validate, place the queen at place (i, col)
                'Console.WriteLine("Col{0}   row : {1}  data : {2}", col, i, board(col, i))
                If SolveNQueen(board, col + 1) Then
                    Return True
                End If
                board(col, i) = 0       '--When no place is vacant remove that queen
            End If
        Next

        Return False        '--when no possible order is found
    End Function

    Public Function CheckSolution() As Boolean

        Dim board(N, N) As Integer

        For i = 0 To N - 1
            For j = 0 To N - 1
                board(i, j) = 0        '--Set All Element to 0
            Next
        Next

        'board = {{0, 0, 0, 0, 0, 0, 0, 0},
        '    {0, 0, 0, 0, 0, 0, 0, 0},
        '    {0, 0, 0, 0, 0, 0, 0, 0},
        '    {0, 0, 0, 0, 0, 0, 0, 0},
        '    {0, 0, 0, 0, 0, 0, 0, 0},
        '    {0, 0, 0, 0, 0, 0, 0, 0},
        '    {0, 0, 0, 0, 0, 0, 0, 0},
        '    {0, 0, 0, 0, 0, 0, 0, 0},
        '    {0, 0, 0, 0, 0, 0, 0, 0}}

        If SolveNQueen(board, 0) = False Then                     '--starting from 0th column
            Console.WriteLine("Solution does not exist")
            Return False
        End If

        PrintBoard(board)
        Return True

    End Function

End Class