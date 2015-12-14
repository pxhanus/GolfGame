'Patricia Hanus
'151214
'Golf Game
'_____________________________________________________________________________
Public Class Form1

    Private Sub btnPlayGolf_Click(sender As Object, e As EventArgs) Handles btnPlayGolf.Click
        Dim GolfScoreCard(3, 8) As Integer

        For row As Integer = 0 To GolfScoreCard.GetLength(0) - 1
            For col As Integer = 0 To GolfScoreCard.GetLength(1) - 1
                GolfScoreCard(row, col) = RndInt(1, 9)

            Next col
        Next row

        For row As Integer = 0 To 3
            Me.lstScores.Items.Add("Player " & row + 1 & vbTab & GolfScoreCard(row, 0) & vbTab & _
                                   GolfScoreCard(row, 1) & vbTab & GolfScoreCard(row, 2) & _
                                   vbTab & GolfScoreCard(row, 3) & vbTab & GolfScoreCard(row, 4) & _
                                   vbTab & GolfScoreCard(row, 5) & vbTab & GolfScoreCard(row, 6) & _
                                   vbTab & GolfScoreCard(row, 7) & vbTab & GolfScoreCard(row, 8))
        Next


        For row As Integer = 0 To GolfScoreCard.GetLength(1) - 1
            Static col = 0
            Dim max = 0
            Dim maxRow = 0
            If GolfScoreCard(row, col) > max Then
                max = GolfScoreCard(row, col)
                maxRow = row
                If maxRow = 0 Then

                End If
            End If
            col += 1
        Next row

        Me.lblWinners.Text = 


    End Sub
    '********************************************************************************************
    'RndInt
    'Returns a random integer between max and min
    '
    'post:  A number is returned
    '********************************************************************************************
    Function RndInt(ByVal min As Integer, ByVal max As Integer) As Integer
        Randomize()
        Return Int((max - min + 1) * Rnd() + min)
    End Function
End Class
