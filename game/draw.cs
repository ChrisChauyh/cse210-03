using System;
using System.Collections.Generic;

namespace cse210_03
{
    public class Draw
    //this is the parachute man drawings
    {
        //defaultman
        public string defaultman { get; set; } = "    _   \n" + "   / \\  \n" +
        "   \\ /  \n" +
        "    V    \n" +
        "    !   \n" +
        "    O\n" +
        "   /|\\ \n" +
        "   / \\ \n";
        //four left
        public string four { get; set; } = "        \n" + "   / \\  \n" +
            "   \\ /  \n" +
            "    V    \n" +
            "    !   \n" +
            "    O\n" +
            "   /|\\ \n" +
            "   / \\ \n";
        //threeleft
        public string three { get; set; } = "        \n\n" +
                    "   \\ /  \n" +
                    "    V    \n" +
                    "    !   \n" +
                    "    O\n" +
                    "   /|\\ \n" +
                    "   / \\ \n";
        //two left
        public string two { get; set; } = "        \n\n \n" +
                    "    V    \n" +
                    "    !   \n" +
                    "    O\n" +
                    "   /|\\ \n" +
                    "   / \\ \n";

        //oneleft
        public string one { get; set; } = "        \n\n \n\n" +
                    "    !   \n" +
                    "    O\n" +
                    "   /|\\ \n" +
                    "   / \\ \n";

        //lost
        public string lost { get; set; } = "        \n\n \n\n\n" +
                    "    X\n" +
                    "   /|\\ \n" +
                    "   / \\ \n";


    }
}
