Public Class Form1

    Private Sub btnPlayGolf_Click(sender As Object, e As EventArgs) Handles btnPlayGolf.Click
        Dim GolfScoreCard(3, 8) As Integer

        For row As Integer = 0 To GolfScoreCard.GetLength(0) - 1
            For col As Integer = 0 To GolfScoreCard.GetLength(1) - 1
                GolfScoreCard(row, col) = RndInt(1, 9)
                Me.lstScores.Items.Item(row) = vbTab & GolfScoreCard(row, col)
            Next col
        Next row

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
