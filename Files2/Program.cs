using System;
using System.IO;
using System.Collections.Generic;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randNum;
            List<string> text = new List<string>();
            foreach (string word in File.ReadLines(@"C:\Users\Sam Mangum-Bostick\Documents\c#\csharp-workbook\Files2\words.txt"))
            {
                text.Add(word);
            }
            randNum = rnd.Next(0, text.Count);

            string[] text2 = File.ReadAllLines(@"C:\Users\Sam Mangum-Bostick\Documents\c#\csharp-workbook\Files2\words.txt");
            System.Console.WriteLine("The random word is {0}", text2[randNum]);

            Console.WriteLine("Please enter a word to see if it comes before or after the random word");
            string userWord = Console.ReadLine();
            int wordPosition = text.FindIndex(w => userWord == w);
            if (wordPosition == -1)
            {
                Console.WriteLine("What you enter is not a word!");
            }
            else if (wordPosition < randNum && wordPosition > -1)
            {
                Console.WriteLine("The word you entered comes before {0}.", text[randNum]);
            }
            else if (wordPosition > randNum)
            {
                Console.WriteLine("The word you entered comes before {0}.", text[randNum]);
            }
            else if (wordPosition == randNum)
            {
                Console.WriteLine("The word you entered is the same as the random word");
            }
        }
    }
}