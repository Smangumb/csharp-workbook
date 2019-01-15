using System;

namespace Text_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int stick = 0;

            Console.WriteLine("Welcome to the cavern of secrets!");             
            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            
            // Choice 1
            Console.WriteLine("Do you take it? [y/n]: ");
            string result = Console.ReadLine();
            if ((result == "y") || (result =="Y"))
            {
                //Stick Taken
                Console.WriteLine("You have taken the stick!");
                stick = 1;
            }
            else if ((result == "n") || (result =="N"))
            {
                //Stick Not Taken
                Console.WriteLine("You did not take the stick");
                stick = 0;
            }


            Console.WriteLine("As you proceed further into the cave, you see a small glowing object");
            Console.WriteLine("Do you approach the object? [y/n]: ");
            result = Console.ReadLine();
            if ((result == "y") || (result =="Y"))
            {
                //Approach Spider
                Console.WriteLine("You approach the object...");
                Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                Console.WriteLine("The eye belongs to a giant spider!");
                Console.WriteLine("Do you try to fight it? [y/n]: ");

                result = Console.ReadLine();
                if ((result == "y") || (result =="Y"))
                {
                    //Fight Spider
                    if (stick == 1)
                    {
                        Console.WriteLine("You only have a stick to fight with!");
                        Console.WriteLine("You quickly jab the spider in it's eye and gain an advantage");
                        Console.WriteLine("     Fighting..      ");
                        Console.WriteLine(" [YOU MUST IT ABOVE A 5 TO KILL THE SPIDER]    ");
                        Console.WriteLine("[IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE]");
                        Random damage = new Random();
                        int playerDamage = damage.Next(3,10);
                        int spiderDamage = damage.Next(1,5);
                        Console.WriteLine($"you hit a: {playerDamage}");
                        Console.WriteLine($"the spider hits a: {spiderDamage}");

                        if(spiderDamage>playerDamage)
                        {
                            Console.WriteLine("The spider dealt more damage than you!");
                            Console.WriteLine("You Died!");
                        }
                        if(playerDamage<5)
                        {
                            Console.WriteLine("You didn't do enough damage to kill the spider, but you managed to escape");
                        }
                        else
                        {
                            Console.WriteLine("You Killed the Spider!");
                        }
                    }
                    else if (stick == 0)
                    {
                        Console.WriteLine("You don't have anything to fight with");
                        Console.WriteLine("     Fighting..      ");
                        Console.WriteLine(" [YOU MUST IT ABOVE A 5 TO KILL THE SPIDER]    ");
                        Console.WriteLine("[IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE]");
                        Random damage = new Random();
                        int playerDamage = damage.Next(1,8);
                        int spiderDamage = damage.Next(1,5);
                        Console.WriteLine($"you hit a: {playerDamage}");
                        Console.WriteLine($"the spider hits a: {spiderDamage}");
                        if(spiderDamage>playerDamage)
                        {
                            Console.WriteLine("The spider dealt more damage than you!");
                            Console.WriteLine("You Died!");
                        }
                        if(playerDamage<5)
                        {
                            Console.WriteLine("You didn't do enough damage to kill the spider, but you managed to escape");
                        }
                        else
                        {
                            Console.WriteLine("You Killed the Spider!");
                        }
                    }
                
                }


                else if ((result == "n") || (result == "N"))
                {
                    //Don't Fight Spider
                    Console.WriteLine("You choose not to fight the spider.");
                    Console.WriteLine("As you turn away, it ambushes you and impales you with it's fangs!!!");
                    Console.WriteLine("YOU DIED");
                }
            }

                
            else if ((result == "n") || (result == "N"))
            {
                //Don't Approach Spider
                Console.WriteLine("You turn away from the glowing object, and attempt to leave the cave..");
                Console.WriteLine("But something won't let you...");
                Console.WriteLine("You managed to escape the cavern alive!");
            }

        }
    }
}
