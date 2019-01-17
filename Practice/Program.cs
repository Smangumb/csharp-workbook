using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "simple ";
            string secondWord = "word";

            string firstLetter = firstWord.Substring(0,1);
            string restWord = firstWord.Substring(1,5);

            string secondFirstLetter = secondWord.Substring(0,1);
            string secondRestWord = secondWord.Substring(1,3);

            Console.WriteLine(restWord + firstLetter + "ay");
            Console.WriteLine(secondRestWord + secondFirstLetter + "ay");

        }
    }
}
