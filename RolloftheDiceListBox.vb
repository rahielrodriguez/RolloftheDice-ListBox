Option Strict On
Option Explicit On

Public Class RolloftheDice

    Sub RollingDice()
        Console.WriteLine("Roll of the Dice")
        Console.WriteLine()
        Randomize()
        Dim firstRollValue As Integer
        Dim secondRollValue As Integer
        Dim rollingResult As Integer
        Dim resultsTable(1, 10) As Integer
        Dim temp As String

        For i = 0 To 10
            resultsTable(0, i) = i + 2
        Next

        For i = 1 To 1000
            firstRollValue = CInt((Int(Rnd() * 6)) + 1)
            secondRollValue = CInt((Int(Rnd() * 6)) + 1)
            rollingResult = firstRollValue + secondRollValue

            Select Case rollingResult
                Case Is = 2
                    resultsTable(1, 0) += 1
                Case Is = 3
                    resultsTable(1, 1) += 1
                Case Is = 4
                    resultsTable(1, 2) += 1
                Case Is = 5
                    resultsTable(1, 3) += 1
                Case Is = 6
                    resultsTable(1, 4) += 1
                Case Is = 7
                    resultsTable(1, 5) += 1
                Case Is = 8
                    resultsTable(1, 6) += 1
                Case Is = 9
                    resultsTable(1, 7) += 1
                Case Is = 10
                    resultsTable(1, 8) += 1
                Case Is = 11
                    resultsTable(1, 9) += 1
                Case Is = 12
                    resultsTable(1, 10) += 1
            End Select
        Next

        For row = 0 To 1
            For column = 0 To 10
                temp = CStr(resultsTable(row, column)) & " |"
                Console.Write(temp.PadLeft(6))

            Next
            Console.WriteLine()
            Console.WriteLine("------------------------------------------------------------------")
            Console.WriteLine(StrDup(66, " "))
        Next

        Console.Read()
    End Sub
End Class
