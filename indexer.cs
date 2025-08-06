using System;
using System.Collections.Generic;

public class Team
{
    private Dictionary<int, string> players = new Dictionary<int, string>();

    // The indexer
    public string this[int playerNumber]
    {
        get
        {
            if (players.ContainsKey(playerNumber))
            {
                return players[playerNumber];
            }
            return "Player not found.";
        }
        set
        {
            players[playerNumber] = value;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Team myTeam = new Team();

        // Using the indexer to add players
        myTeam[10] = "Player One";
        myTeam[7] = "Player Two";

        // Using the indexer to retrieve player names
        Console.WriteLine("Player #10 is: " + myTeam[10]);
        Console.WriteLine("Player #7 is: " + myTeam[7]);
        Console.WriteLine("Player #5 is: " + myTeam[5]);
    }
}
