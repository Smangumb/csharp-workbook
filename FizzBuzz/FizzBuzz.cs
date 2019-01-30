using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                //Checks if divisible by 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                //Checks if divisible by 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                //Checks if divisible by 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                //If neither print number
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
