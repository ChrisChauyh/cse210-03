using System;

namespace cse210_03
{
    public class Draw
    {
        char[] ArrBoard =
        {
            '/', '_', '\\','\\', '_','/','0'
        }; 
        public void Board()
        {   
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