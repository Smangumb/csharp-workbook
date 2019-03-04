using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysWithNumbers myBirthday = DaysWithNumbers.Friday;
            Console.WriteLine("Hello World!");
            // foreach (var item in Enum.GetValues(typeof(Days)))
            // {
            //     System.Console.WriteLine(item);
            // }
            foreach (var item in Enum.GetValues(typeof(DaysWithNumbers)))
            {
                System.Console.WriteLine(item);
            }
            if (myBirthday == DaysWithNumbers.Friday)
            {
                System.Console.WriteLine();
            }

        }
        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        enum DaysWithNumbers
        {
            Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7
        }
    }
}
