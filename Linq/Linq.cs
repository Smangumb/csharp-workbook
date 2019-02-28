using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            var source = new int[] { 1, 2 };
            var results =
            from i in source
            select i;

            int total = source.Where(x => true).Select(Square).Sum();
            Console.WriteLine(total);

        }
        public static int Square(int value)
        {
            return value * value;
        }
    }
}
