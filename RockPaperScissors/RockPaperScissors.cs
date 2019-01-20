using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            string[] answers = new string[] { "rock", "paper", "scissors" };
            int index = 0;
            Random r = new Random();
            string computerPlayer = "";

            do
            {
                Console.WriteLine("Enter hand 1:");
                string hand1 = Console.ReadLine().ToLower();

                index = r.Next(0, 3);
                computerPlayer = answers[index];

                string hand2 = computerPlayer;
                Console.WriteLine($"Computer Plays: {computerPlayer}");
                Console.WriteLine(CompareHands(hand1, hand2));
                Console.WriteLine("Do you want to play again?");
            } while (Console.ReadLine() == "yes");

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static string CompareHands(string hand1, string hand2)
        {
            if (hand1 == hand2)
            {
                return "It's a tie!";
            }
            if (hand1 == "rock")
            {
                if (hand2 == "scissors")
                {
                    return "Hand One Wins!";
                }
                return "Hand Two Wins!";
            }

            if (hand1 == "paper")
            {
                if (hand2 == "rock")
                {
                    return "Hand One Wins!";
                }
                return "Hand Two Wins!";
            }

            if (hand1 == "scissors")
            {
                if (hand2 == "paper")
                {
                    return "Hand One Wins!";
                }
                return "Hand Two Wins!";
            }
            return hand1 + ' ' + hand2;

        }
    }
}
