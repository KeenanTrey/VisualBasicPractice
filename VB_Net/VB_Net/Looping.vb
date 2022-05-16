
Public Class Loops
    Sub Looping()
        Dim count = 2
        Dim output
        Dim current = "-"c

        Do
            count = count + 1
            If (count > 30) Then
                current = Console.ReadKey.KeyChar
            End If
            output = New String(current, count)
            Console.WriteLine(output)

        Loop While current <> " "c

    End Sub
End Class

