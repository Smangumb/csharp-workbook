using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here
            System.Console.WriteLine("enter the phrase you want to translate:");
            string input = Console.ReadLine().ToLower();
            string output = "";
            char[] punctuation = new char[] { ',', '?', '"' };

            string[] words = input.Split(' ');
            foreach (var item in words)
            {
                output += TranslateWord(item) + " ";
            }
            Console.WriteLine(output);
        }


        public static string TranslateWord(string input)
        {
            // your code goes here
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int firstLetterIndex = input.IndexOfAny(vowels);
            string firstPart = input.Substring(0, firstLetterIndex);
            string restWord = input.Substring(firstLetterIndex);
            input = restWord + firstPart + "ay";

            if (firstLetterIndex == 0)
            {
                input = restWord + "yay";
            }
            return input;
        }
    }
}
