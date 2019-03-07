using System;
using System.Linq;
using System.Collections.Generic;

namespace week9whiteboard
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public static class SortExtensions
    {
        public static int[] Orderby(int[] values, Func<int, int> selector)
        {
            return values;
        }
        public static void Values(int[] values)
        {
            values = Orderby(values, selectMe);
            Orderby(values, selectMe);
        }
        public static int selectMe(int x)
        {
            return x;
        }
    }
}
