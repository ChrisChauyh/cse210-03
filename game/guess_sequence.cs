using System;
using System.Collections.Generic;
using System.Linq;

namespace cse210_03
{
    public class Guessinggame
    {
        Generate_list generate_List = new Generate_list();
        Run_Terminal run_Terminal = new Run_Terminal();
        //how many lives you have
        int lives = 5;
        int counter = -1;
        int numberStore = 0;
        public bool victory = false;
        
        public void Startgame()
        {   
            run_Terminal.welcomewords();
            //Get words from list
            string secretWord = generate_List.magic();
            //test to make sure only letters
            bool wordTest = secretWord.All(Char.IsLetter);
            //change to upper words
            secretWord = secretWord.ToUpper();
            //get the length
            int wordLength = secretWord.Length;
            //set the word into char Array
            char[] secretArray = secretWord.ToCharArray();
            char[] printArray = new char[wordLength];
            char[] guessedLetters = new char[26];

            //set the word into mistery
            foreach (char letter in printArray)
            {
                counter++;
                printArray[counter] = '_';
            }

            while (lives > 0)
            {
                counter = -1;
                string printProgress = String.Concat(printArray);
                bool letterFound = false;
                int multiples = 0;

                if (printProgress == secretWord)
                {
                    victory = true;
                    break;
                }

                if (lives > 1)
                {
                    Console.WriteLine("You have {0} more chances!", lives);
                }
                else
                {
                    Console.WriteLine("You only have {0} chances left!!", lives);
                }

                    Console.WriteLine(GallowView(lives));
                Console.WriteLine("current progress: " + printProgress);
                Console.Write("\n\n\n");
                Console.Write("Guess a letter: ");
                string playerGuess = Console.ReadLine();

                //test to make sure a single letter
                bool guessTest = playerGuess.All(Char.IsLetter);


                playerGuess = playerGuess.ToUpper();
                char playerChar = Convert.ToChar(playerGuess);

                if (guessedLetters.Contains(playerChar) == false)
                {

                    guessedLetters[numberStore] = playerChar;
                    numberStore++;

                    foreach (char letter in secretArray)
                    {
                        counter++;
                        if (letter == playerChar)
                        {
                            printArray[counter] = playerChar;
                            letterFound = true;
                            multiples++;
                        }

                    }

                    if (letterFound)
                    {
                        Console.WriteLine("Found {0} letter {1}!", multiples, playerChar);
                    }
                    else
                    {
                        Console.WriteLine("No letter {0}!", playerChar);
                        lives--;
                    }
                    Console.WriteLine(GallowView(lives));
                }
                else
                {
                    Console.WriteLine("You already guessed {0}!!", playerChar);
                }


            }




        }


        private static string GallowView(int livesLeft)
        {
            //simple function to print out the hangman
            string drawHangman = "    _   \n"+"   / \\  \n"+
            "   \\ /  \n"+
            "    V    \n"+
            "    !   \n"+
            "    O\n"+
            "   /|\\ \n"+
            "   / \\ \n";
            
            if (livesLeft < 5)
            {
                drawHangman = "        \n"+"   / \\  \n"+
            "   \\ /  \n"+
            "    V    \n"+
            "    !   \n"+
            "    O\n"+
            "   /|\\ \n"+
            "   / \\ \n";
            }

            if (livesLeft < 4)
            {
                drawHangman = "        \n\n"+
            "   \\ /  \n"+
            "    V    \n"+
            "    !   \n"+
            "    O\n"+
            "   /|\\ \n"+
            "   / \\ \n";
            }

            if (livesLeft < 3)
            {
              drawHangman =  "        \n\n \n"+
            "    V    \n"+
            "    !   \n"+
            "    O\n"+
            "   /|\\ \n"+
            "   / \\ \n";
            }

            if (livesLeft < 2)
            {
                drawHangman =  "        \n\n \n\n"+
            "    !   \n"+
            "    O\n"+
            "   /|\\ \n"+
            "   / \\ \n";
            }

            if (livesLeft == 0)
            {
                drawHangman =  "        \n\n \n\n\n"+
            "    X\n"+
            "   /|\\ \n"+
            "   / \\ \n";
            }
     return drawHangman;


    }        
}
}