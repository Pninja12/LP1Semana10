using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class View
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
        public void BeginGame()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        public void EndGame()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}