using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class Player : IComparable<Player>
    {
        public string Name{ get; }
        public int Score{ get; set; }
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public int CompareTo(Player other)
        {
            if (other.Score > Score) return 1;
            else if(other.Score < Score) return -1;
            else return 0;
            

        }
             
    }
}