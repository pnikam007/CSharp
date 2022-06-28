﻿using System;
using System.Linq;

namespace AnagramString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "heater";
            string str2 = "reheat";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            string aa = String.Concat(str1.OrderBy(c => c));
            string bb = String.Concat(str2.OrderBy(c => c));

            if (aa == bb)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }
            Console.ReadKey();
        }
    }
}
