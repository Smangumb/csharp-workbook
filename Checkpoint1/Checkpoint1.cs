using System;
using System.Linq;

namespace Checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program 1
            System.Console.WriteLine("Total amount of numbers between 1 and 100 that are divisible by 3 with no remainder:");
            Console.WriteLine(CountThrees());

            //Program 2
            string InputStr;
            int InputInt = 0, tempint = 0;
            do
            {
                System.Console.WriteLine("Enter a number or type ok to exit");
                InputStr = Console.ReadLine();
                bool success = int.TryParse(InputStr, out tempint);
                if (success == true)
                {
                    InputInt += tempint;
                }
                if (success == false)
                {
                    break;
                }
                Console.WriteLine($"Sum of the numbers is: {InputInt}");
            }
            while (InputStr != "ok");

            //Program 3
            int i, f = 1, num;
            Console.WriteLine("\n\n");
            Console.WriteLine("Input a number:");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                f = f * i;

            Console.WriteLine("{0}! = {1}", num, f);

            //Program 4
            System.Console.WriteLine("A random number is being picked between 1-10");
            System.Console.WriteLine("You have 4 tries to guess the number");
            int answer = 0;
            int guess = 0;
            Random number = new Random();
            answer = number.Next(1, 11);
            for (int numrandom = 0; numrandom <= 4; numrandom++)
            {
                if (numrandom == 4)
                {
                    System.Console.WriteLine("You lost");
                    break;
                }
                System.Console.WriteLine("Enter guess");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == answer)
                {
                    System.Console.WriteLine("You Won!");
                    break;
                }
            }

            //Program 5
            Console.WriteLine("Enter some numbers seperated by ", "");
            var numbers = Console.ReadLine();
            var splitNumber = numbers.Split(',');
            var maxNumber = splitNumber.Max();
            Console.WriteLine("Highest is: " + maxNumber);
        }

        static int CountThrees()
        {
            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }

            }
            return count;
        }
    }
}
