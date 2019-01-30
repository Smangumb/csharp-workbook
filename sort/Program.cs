using System;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] a = new int[30];
            Console.Write("Enter the Number of values to be Sort : ");
            // read the string value and convert it in to integer  
            int n = Convert.ToInt16(Console.ReadLine());
            //Reading the values one by one  
            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter the No " + i + ":");
                // read the string value and convert it in to integer  
                a[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.Write("Ascending Sort : ");
            for (i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
            }
            //Sort Lowest to Highest
        }
    }
}
