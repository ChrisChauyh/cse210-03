using System;
using System.Collections.Generic;

namespace cse210_03
{
    public class Draw
    //this is the parachute man 
    {

        
   private static string GallowView(int livesLeft)
        {
            //simple function to print out the hangman
            string drawHangman = "";

            if (livesLeft < 5)
            {
                drawHangman += "--------\n";
            }

            if (livesLeft < 4)
            {
                drawHangman += "       |\n";
            }

            if (livesLeft < 3)
            {
                drawHangman += "       O\n";
            }

            if (livesLeft < 2)
            {
                drawHangman += "      /|\\ \n";
            }

            if (livesLeft == 0)
            {
                drawHangman += "      / \\ \n";
            }

            return drawHangman;



    }        

    }
}
