using System;
using System.Collections.Generic;

namespace cse210_03
{
    class Generate_list
    {

        private string singleword { get; set; }
        public char[] letterList { get; set; }

        public char[] misterywords { get; set; }  =    {
            '_', '_', '_', '_', '_','_', '_'
        }; 

        private List<string> wordlist = new List<string>()
                    {
                        "London",
                        "London",
                        "Mumbai",
                        "London"                    
                    };
        public void magic()
        {
        Random randm = new Random();
        int num = randm.Next(wordlist.Count);
        string singleword = wordlist[num];
        letterList = singleword.ToCharArray();
        misterywords = singleword.ToCharArray();
        for(int i = 0; i < misterywords.Length; i++){
            misterywords[i] = '_';
        }
        }
       
    }
}