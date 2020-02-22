Public Class FrmCryptarithmetic

    'Public s1 As Char() = New Char(9) {}
    'Public s2 As Char() = New Char(9) {}
    'Public s3 As Char() = New Char(9) {}
    Public s1 As Char()
    Public s2 As Char()
    Public s3 As Char()

    Public assinged As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Public c As Char() = New Char(10) {}
    Public val As Integer() = New Integer(10) {}
    Public topc As Integer = 0

    Private Sub FrmCryptarithmetic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Public Function solve(ByVal ind As Integer, ByVal temp1 As Integer()) As Integer
        Dim temp2 As Integer() = New Integer(9) {}
        Dim flag As Integer = 0

        For i As Integer = 0 To 10 - 1

            If temp1(i) = 0 Then

                For j As Integer = 0 To 10 - 1
                    temp2(j) = temp1(j)
                Next

                temp2(i) = 1
                Val(ind) = i

                If ind = topc - 1 Then

                    If verify() = 1 Then
                        flag = 1
                        GoTo [exit]
                    End If
                Else

                    If solve(ind + 1, temp2) = 1 Then
                        flag = 1
                        GoTo [exit]
                    End If
                End If
            End If
        Next

[exit]:

        If flag <> 0 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Function verify() As Integer
        Dim n1 As Long = 0, n2 As Long = 0, n3 As Long = 0
        Dim power As Long = 1
        Dim ch As Char
        Dim i As Integer = s1.Length - 1
        Dim in1 As Integer

        While i >= 0
            ch = s1(i)
            in1 = 0

            While in1 <> topc

                If c(in1) = ch Then
                    Exit While
                Else
                    in1 += 1
                End If
            End While

            n1 += power * Val(in1)
            power *= 10
            i -= 1
        End While

        power = 1
        i = s2.Length - 1

        While i >= 0
            ch = s2(i)
            in1 = 0

            While in1 <> topc

                If c(in1) = ch Then
                    Exit While
                Else
                    in1 += 1
                End If
            End While

            n2 += power * Val(in1)
            power *= 10
            i -= 1
        End While

        power = 1
        i = s3.Length - 1

        While i >= 0
            ch = s3(i)
            in1 = 0

            While in1 <> topc

                If c(in1) = ch Then
                    Exit While
                Else
                    in1 += 1
                End If
            End While

            n3 += power * Val(in1)
            power *= 10
            i -= 1
        End While

        If n1 + n2 = n3 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub CmdResolv_Click(sender As Object, e As EventArgs) Handles CmdResolv.Click

        TxtResult.Clear()
        s1 = txtstr1.Text.ToCharArray()
        s2 = txtstr2.Text.ToCharArray()
        s3 = txtstr3.Text.ToCharArray()
        Dim flag As Integer = 0

        For i As Integer = 0 To s1.Length - 1

            For j As Integer = 0 To topc

                If s1(i) <> c(j) Then
                    flag = 1
                Else
                    flag = 0
                    Exit For
                End If
            Next

            If flag = 1 Then c(Math.Min(Threading.Interlocked.Increment(topc), topc - 1)) = s1(i)
        Next

        For i As Integer = 0 To s2.Length - 1

            For j As Integer = 0 To topc

                If s2(i) <> c(j) Then
                    flag = 1
                Else
                    flag = 0
                    Exit For
                End If
            Next

            If flag = 1 Then c(Math.Min(Threading.Interlocked.Increment(topc), topc - 1)) = s2(i)
        Next

        For i As Integer = 0 To s3.Length - 1

            For j As Integer = 0 To topc

                If s3(i) <> c(j) Then
                    flag = 1
                Else
                    flag = 0
                    Exit For
                End If
            Next

            If flag = 1 Then c(Math.Min(Threading.Interlocked.Increment(topc), topc - 1)) = s3(i)
        Next

        If solve(0, assinged) = 1 Then

            For i As Integer = 0 To c.Length - 1
                TxtResult.Text += vbLf & c(i) & "---> " & val(i).ToString() & vbCrLf
            Next
        Else
            TxtResult.Text = "Sorry"
        End If


    End Sub
End Class