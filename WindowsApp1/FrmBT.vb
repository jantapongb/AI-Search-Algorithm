Public Class FrmBT

    Public Const N = 9
    Public Const UNASSIGNED = 0

    Public Function FindUnassignedLocation(ByVal Grid(,) As Integer, ByRef Row As Integer, ByRef Col As Integer) As Boolean

        For Row = 0 To N - 1
            For Col = 0 To N - 1
                If Grid(Row, Col) = UNASSIGNED Then
                    Return True
                End If
            Next
            Console.WriteLine("Value of Find Func Row : {0} Col : {1} ", Row, Col)
        Next
        Return False

    End Function

    Public Function UsedInRow(ByVal Grid(,) As Integer, Row As Integer, Num As Integer) As Boolean

        For Col = 0 To N - 1
            If Grid(Row, Col) = Num Then
                Return True
            End If
        Next
        Return False

    End Function

    Public Function UsedInCol(ByVal Grid(,) As Integer, Col As Integer, Num As Integer) As Boolean

        For Row = 0 To N - 1
            If Grid(Row, Col) = Num Then
                Return True
            End If
        Next
        Return False

    End Function

    Public Function UsedInBox(ByVal Grid(,) As Integer, BoxStartRow As Integer, BoxStartCol As Integer, Num As Integer) As Boolean

        For Row = 0 To 2
            For Col = 0 To 2
                If Grid(Row + BoxStartRow, Col + BoxStartCol) = Num Then
                    Return True
                End If
            Next
        Next
        Return False

    End Function

    Public Function IsSafe(ByVal Grid(,) As Integer, Row As Integer, Col As Integer, Num As Integer) As Boolean

        Dim ResultBoolean As Boolean
        ResultBoolean = Not UsedInRow(Grid, Row, Num) And
                        Not UsedInCol(Grid, Col, Num) And
                        Not UsedInBox(Grid, Row - (Row Mod 3), Col - (Col Mod 3), Num) And
                        Grid(Row, Col) = UNASSIGNED
        Return ResultBoolean

    End Function

    Public Sub PrintGrid(ByVal Grid(,) As Integer)

        For Row = 0 To N - 1
            For Col = 0 To N - 1
                Console.Write("{0} ", Grid(Row, Col))
                TbResult.Text = TbResult.Text & Grid(Row, Col) & "  "
            Next
            Console.WriteLine()
            TbResult.Text = TbResult.Text & vbCrLf
        Next

    End Sub

    Public Function SolveSudoku(ByVal Grid(,) As Integer) As Boolean

        Dim Row, Col As Integer
        If Not FindUnassignedLocation(Grid, Row, Col) Then
            Return True
        Else

            For Num = 1 To 9
                If IsSafe(Grid, Row, Col, Num) Then
                    Grid(Row, Col) = Num
                    If SolveSudoku(Grid) Then
                        Return True
                    Else
                        Grid(Row, Col) = UNASSIGNED
                    End If
                End If
            Next

        End If
        Return False

    End Function


    Public Grid(,) As Integer = {
                      {3, 0, 6, 5, 0, 8, 4, 0, 0},
                      {5, 2, 0, 0, 0, 0, 0, 0, 0},
                      {0, 8, 7, 0, 0, 0, 0, 3, 1},
                      {0, 0, 3, 0, 1, 0, 0, 8, 0},
                      {9, 0, 0, 8, 6, 3, 0, 0, 5},
                      {0, 5, 0, 0, 9, 0, 6, 0, 0},
                      {1, 3, 0, 0, 0, 0, 2, 5, 0},
                      {0, 0, 0, 0, 0, 0, 0, 7, 4},
                      {0, 0, 5, 2, 0, 6, 3, 0, 0}
        }

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        If SolveSudoku(Grid) = True Then
            PrintGrid(Grid)
        Else
            Console.Write("No Sulution Exits")
        End If

        'Dim AA As Integer = 10
        'Dim PP As IntPtr = AA

        'PP = 10
        'Console.WriteLine("Ptr : {0}", AddressOf AA)

    End Sub

    Private Sub FrmBT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Row = 0 To N - 1
            For Col = 0 To N - 1
                'Console.Write("{0} ", Grid(Row, Col))
                TbQuestion.Text = TbQuestion.Text & Grid(Row, Col) & "  "
            Next
            'Console.WriteLine()
            TbQuestion.Text = TbQuestion.Text & vbCrLf
        Next

    End Sub
End Class