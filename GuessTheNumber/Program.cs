using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            View printer = new View();

            Model model= new Model();

            Controller controller = new Controller(printer, model);

            // Game loop
            controller.GameLoop();

        }
    }
}