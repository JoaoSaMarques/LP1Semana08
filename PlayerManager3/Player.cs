using System;
using System.Collections.Generic;

namespace PlayerManager3
{
    public class Player : IComparable<Player>
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public int CompareTo(Player other)
        {
            if (other == null)
            {
                return 1;
            }

            // Compare the scores of the two players
            return this.Score.CompareTo(other.Score);
        }
    }
}