// Game Function
using System;

namespace TextBasedGame
{
    class Program
    {
    public static void Main() 
    {
        Console.WriteLine("Welcome to the cavern of secrets!");
        
        Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
        
        // Choice 1
        Console.WriteLine("Do you take it? [y/n]: ");
        while (true)
        {
            ConsoleKeyInfo result = Console.ReadKey();
            if ((result.KeyChar == 'Y') || (result.KeyChar =='Y'))
            {
                Console.WriteLine("You have taken the stick!");
                break;
            }
            else if ((result.KeyChar == 'N') || (result.KeyChar == 'N'))
            {
                Console.WriteLine("You did not take the stick");
                break;
            }
        }

        Console.WriteLine("As you proceed further into the cave, you see a small glowing object");

    }

    }
}