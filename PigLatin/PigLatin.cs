﻿using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here
            string firstWord = "simple ";
            string secondWord = "word";

            string firstLetter = firstWord.Substring(0,1);
            string restWord = firstWord.Substring(1,5);

            string secondFirstLetter = secondWord.Substring(0,1);
            string secondRestWord = secondWord.Substring(1,3);

            Console.WriteLine(restWord + firstLetter + "ay");
            Console.WriteLine(secondRestWord + secondFirstLetter + "ay");
            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string TranslateWord(string word)
        {
            // your code goes here
            
            return word;
        }
    }
}
