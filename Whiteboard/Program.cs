using System;
using System.Collections;
using System.Collections.Generic;


namespace Whiteboard
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Dog, Cat, Deer");
            // System.Console.WriteLine("One of these things is not like the others, one of these things just doesn't belong:");
            List<string> test = new List<string>();
            test.Add("dog");
            test.Add("cat");
            test.Add("deer");
            Filter(test).ForEach(Console.WriteLine);
        }

        public static IEnumerable<string> Filter(IEnumerable input)
        {
            List<string> ReturnMe = new List<string>();
            foreach (string item in input)
            {

                if (item.Length > 3)
                {
                    yield return item;
                    ReturnMe.Add(item);
                }
                // yield return ReturnMe;
            }
            // return ReturnMe;
        }
    }
}
