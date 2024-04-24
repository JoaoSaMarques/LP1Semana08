using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace PlayerManager1
{
    public class Player
    {
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        readonly string Name { get; }
        public int Score { get; set; }
    }
    

}
