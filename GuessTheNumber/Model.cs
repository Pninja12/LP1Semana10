using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Model
    {
        public int guess;
        public int attempts = 0;
        public bool guessedCorrectly = false;
        public int targetNumber;
    }
}