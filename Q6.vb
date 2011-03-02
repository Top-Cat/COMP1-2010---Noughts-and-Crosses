Module Module1

    Sub Main()
        Dim PlayerOneScore, PlayerTwoScore, NoOfGamesInMatch As Byte
        Dim PlayerOneWinsGame As String
        PlayerOneScore = 0
        PlayerTwoScore = 0
        Console.WriteLine("How many games?")
        NoOfGamesInMatch = Console.ReadLine()
        For NoOfGamesPlayed = 1 To NoOfGamesInMatch
            Console.WriteLine("Did Player One win the game (enter Y or N)?")
            PlayerOneWinsGame = Console.ReadLine()
            If PlayerOneWinsGame = "Y" Then
                PlayerOneScore += 1
            Else
                PlayerTwoScore += 1
            End If
        Next
        Console.WriteLine(PlayerOneScore)
        Console.WriteLine(PlayerTwoScore)
    End Sub

End Module