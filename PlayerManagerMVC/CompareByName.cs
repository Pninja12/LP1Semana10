using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class CompareByName : IComparer<Player>
    {
        private int side;

        public CompareByName(int side = 0)
        {
            this.side = side;
        }

        public int Compare(Player playerA, Player playerB)
        {
            switch (this.side)
            {
                case 0:
                    return playerA.CompareTo(playerB);
                case 1:
                    if (playerB.Name.Length > playerA.Name.Length) return 1;
                    else if(playerB.Name.Length <
                     playerA.Name.Length) return -1;
                    else return 0;
                case 2:
                    if (playerB.Name.Length > playerA.Name.Length) return -1;
                    else if(playerB.Name.Length <
                     playerA.Name.Length) return 1;
                    else return 0;
                default:
                    return 0;
            }
        }
    }
}