using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Controller
    {
        View view;
        Model model;
        public Controller(View _view, Model _model)
        {
            view = _view;
            model = _model;
        }
        
        

        int GenerateNumber()
        {
            // Generate a random number
            Random random = new Random();

            // Generate a number between 1 and 100
            return random.Next(1, 101);
        }

        public void GameLoop()
        {

            model.targetNumber = GenerateNumber();

            view.BeginGame();

            // Game loop
            while (!model.guessedCorrectly)
            {
                view.Print("Take a guess: ");
                model.guess = Convert.ToInt32(Console.ReadLine());
                model.attempts++;

                if (model.guess == model.targetNumber)
                {
                    view.Print(
                        "Congratulations! You guessed the number correctly!");
                    view.Print("Number of attempts: " + model.attempts);
                    model.guessedCorrectly = true;
                }
                else if (model.guess < model.targetNumber)
                {
                    view.Print("Too low! Try again.");
                }
                else
                {
                    view.Print("Too high! Try again.");
                }
            }
            view.EndGame();
        }

        
    }
}