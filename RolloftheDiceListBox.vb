'Rahiel Rodriguez
'RCET0265
'Spring 2024
'Roll of the Dice - List Box
'https://github.com/rahielrodriguez/RolloftheDice-ListBox.git

Option Strict On
Option Explicit On

Public Class RolloftheDice

    Sub RollingDice()
        SetDefaults()
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

        'Takes the header, converts it into an string and formats it.
        For Each letter In header
            headerRow += (CStr(letter) & "|").PadLeft(6)
        Next

        'Takes the resuls from the results table, converts them into a string and formats it
        For Each number In resultsTable
            dataRow += (CStr(number).PadLeft(4) & "|")
        Next

        'Sets format for the output and adds all the information to the listbox.
        DisplayListBox.Items.Add(StrDup(25, " ") & "Roll of The Dice")
        DisplayListBox.Items.Add(StrDup(80, "-"))
        DisplayListBox.Items.Add(headerRow)
        DisplayListBox.Items.Add(StrDup(80, "-"))
        DisplayListBox.Items.Add(dataRow)
        DisplayListBox.Items.Add(StrDup(80, "-"))

    End Sub
    Sub SetDefaults()

        'Sets a starting point for the program by setting the Display List Box to start empty and focus on the Roll Button
        DisplayListBox.SelectedIndex = -1

        RollButton.Focus()
    End Sub
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        RollingDice()

    End Sub
    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayListBox.Items.Clear()

    End Sub
    Private Sub RollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RollToolStripMenuItem.Click
        RollingDice()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        DisplayListBox.Items.Clear()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub
    Sub AboutMessage()
        'Sends out a message that provides information about the program and its functions.
        MsgBox("This form is used to simulate the rolling of two dices." & vbCrLf _
            & vbCrLf _
               & "After pressing the ""Roll"" button, the sum of two dice numbers rolled is recorded. This action is repeated 1000 times. Pressing the ""Clear"" button erases the display, while the ""Exit"" button closes the form.")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutMessage()

    End Sub
End Class
