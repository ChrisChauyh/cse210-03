using System;
using System.Linq;

namespace cse210_03
{
    class Program
    {
        //start the game
        static void Main(string[] args)
        {
            Guessinggame guessingGame = new Guessinggame();
            Run_Terminal terminallol = new Run_Terminal();
            Draw drawing_the_man = new Draw();
            guessingGame.Startgame();

        }
    }
}
