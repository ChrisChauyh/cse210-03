using System;
using System.Collections.Generic;

namespace cse210_03
{
    class Generate_list
    {

        private string singleword;
        public char[] letterList;
        public char[] misterywords;
        private List<string> wordlist = new List<string>()
                    {
                        "NewYork",
                        "London",
                        "Mumbai",
                        "Chicago"                    
                    };
        public void magic()
        {
        Random randm = new Random();
        int num = randm.Next(0,wordlist.Count);
        singleword = wordlist[num];
        letterList = singleword.ToCharArray();
        misterywords = singleword.ToCharArray();
        for(int i = 0; i < misterywords.Length; i++){
            misterywords[i] = '_';
        }
        }
       
    }
}