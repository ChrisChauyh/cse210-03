using System;
using System.Collections.Generic;


namespace cse210_03
//this is a terminal which will print words
{
    public class Run_Terminal
    {
        //just some welcome greetings.
        public void welcomewords()
        {
            Console.WriteLine("Welcome to Parachute game.");
            Console.WriteLine("In this game, put in letters, make sure the parachute man don't die \n The puzzle is a secret word randomly chosen from a list. \nThe player guesses a letter in the puzzle. \nIf the guess is correct, the letter is revealed. \nIf the guess is incorrect, a line is cut on the player's parachute.\nIf the puzzle is solved the game is over.\nIf the player has no more parachute the game is over.");
            Console.WriteLine("Let's play!");
        }
     
    }
}
