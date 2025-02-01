using System;

class Player
{
     private string initials { get; set; }
     private int score { get; set; }

     public Player(string Initials, int Score)
     {
          initials = Initials;
          score = Score;
     }
     public void DiaplayPlayer(int programPlayers)
     {
          Console.WriteLine($"Player: {initials}, {score}");
     }
}