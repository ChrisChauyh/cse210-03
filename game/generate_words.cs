using System;
using System.Collections.Generic;

namespace cse210_03
{
    class Generate_list
    {
        //
        //return a random word from the wordlist
        public string secretWord = null;
        private List<string> wordlist = new List<string>()
                    {
                        "organization",
                        "iphone",
                        "Mumbai",
                        "London"
                    };
        //get the random word
        public string magic()
        {
            Random randm = new Random();
            int num = randm.Next(0, wordlist.Count - 1);
            secretWord = wordlist[num];
            return secretWord;
        }

    }
}