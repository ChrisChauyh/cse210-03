using System;
using System.Collections.Generic;

namespace cse210_03
{
    public class Draw
    //this is the parachute man 
    {
        private Generate_list generate_words = new Generate_list();
        public char[] ArrBoard =
        {
            '/', '_', '\\','\\', '_','/','0'
        }; 


        public void Board()
        {   
            for (int i = 0; i < generate_words.misterywords.Length; i++)
            {Console.Write("{0}",generate_words.misterywords[i]);}
Console.WriteLine();
            Console.WriteLine(" {0}",ArrBoard[1]);
            Console.WriteLine("{0} {1}", ArrBoard[0], ArrBoard[2]);
            Console.WriteLine("{0}{1}{2}", ArrBoard[3], ArrBoard[4], ArrBoard[5]);
            Console.WriteLine(" | ");
            Console.WriteLine(" 0 ", ArrBoard[6]);
            Console.WriteLine("/|\\");
            Console.WriteLine(" | ");
            Console.WriteLine("/ \\");

        } 
    }
}
