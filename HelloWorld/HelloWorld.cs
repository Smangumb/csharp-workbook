using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string job = "";
            string school = "";

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your desired occupation: ");
            job = (Console.ReadLine());
            Console.WriteLine("Please enter where you to go school : ");
            school = (Console.ReadLine());

            Console.WriteLine("Hello! My name is {0} and I am interested in becoming a {1}. I am attending {2} to pursue my career.", name, job, school);
        }
    }
}
