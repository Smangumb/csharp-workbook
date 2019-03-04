using System;

namespace EnumsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            foreach (var item in Enum.GetValues(typeof(Months)))
            {
                System.Console.WriteLine(item);
            }
        }
        enum Months
        {
            January, February, March, April, May, June, July, August, September, October, November, December
        }
        Point point1 = new Point(0, 1);
        Point point2 = new Point(2, 2);
        public struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }
    }
}
