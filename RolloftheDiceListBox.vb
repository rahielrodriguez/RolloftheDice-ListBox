Option Strict On
Option Explicit On

Public Class RolloftheDice

    Sub RollingDice()
        Randomize()
        Dim firstRollValue As Integer
        Dim secondRollValue As Integer
        Dim rollingResult As Integer
        Dim resultsTable(0, 10) As Integer
        'Creates an a header that will contain the static values of the possible results of the two dices after rolling them
        Dim header() = {"2", "3", "4", "05", "06", "07", "08", "09", "10", "11", "12"}
        Dim headerRow As String = ""
        Dim dataRow As String = ""

        'rolls each dice as a random number once and then adds them together.
        'The result would go into a select case that will add a 1 every time one of the possible results comes out.
        'Repeats this proces a 1000 times.
        For i = 1 To 1000
            firstRollValue = CInt((Int(Rnd() * 6)) + 1)
            secondRollValue = CInt((Int(Rnd() * 6)) + 1)
            rollingResult = firstRollValue + secondRollValue

            Select Case rollingResult
                Case Is = 2
                    resultsTable(0, 0) += 1
                Case Is = 3
                    resultsTable(0, 1) += 1
                Case Is = 4
                    resultsTable(0, 2) += 1
                Case Is = 5
                    resultsTable(0, 3) += 1
                Case Is = 6
                    resultsTable(0, 4) += 1
                Case Is = 7
                    resultsTable(0, 5) += 1
                Case Is = 8
                    resultsTable(0, 6) += 1
                Case Is = 9
                    resultsTable(0, 7) += 1
                Case Is = 10
                    resultsTable(0, 8) += 1
                Case Is = 11
                    resultsTable(0, 9) += 1
                Case Is = 12
                    resultsTable(0, 10) += 1
            End Select
        Next

    End Sub
End Class
