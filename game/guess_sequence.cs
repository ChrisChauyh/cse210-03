using System;
using System.Collections.Generic;

namespace cse210_03
{
    public class Guessinggame
    {
        Draw drawing_the_man = new Draw();
        Run_Terminal terminallol = new Run_Terminal();
        Generate_list generate_words = new Generate_list();
        bool isWin = false;


        bool wordisCorrect = false;    

        public void Startgame()
        {
            while(isWin==false)
{            terminallol.welcomewords();
            generate_words.magic();
            drawing_the_man.Board();
            terminallol.check_status();
            terminallol.askforsymbols();
            checkcorrect();
            if(Array.IndexOf(generate_words.misterywords, "_") < -1)   
            {terminallol.win();
            isWin = true;}
            else if (terminallol.guesstimes>0)
            {terminallol.lost();}}

        }
    
   

        void checkcorrect()
        {
        
            for(int i = 0; i < generate_words.misterywords.Length; i++)
            {
                if (terminallol.alphabet.Equals(generate_words.letterList[i]))
                {
                    generate_words.misterywords[i] = terminallol.alphabet;
                    wordisCorrect = true;
                }

            }
        }
    }        
}
    