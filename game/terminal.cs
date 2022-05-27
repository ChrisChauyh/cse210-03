using System;

namespace cse210_03
{
    class Run_Terminal
    {
        //just a welcome greetings.
        void welcomewords()
        {
            Console.WriteLine("Welcome to Parachute game.");
            Console.WriteLine("In this game ");
        
        }
        void askforsymbols()
        {
            Console.Write("What do you want?");
            var prompt = Console.ReadLine();
        }

        public void start_terminal()
        {
            welcomewords();
            askforsymbols();
            Guessinggame guessingGame = new Guessinggame();
            guessingGame.Startgame();


        }
    }
}
