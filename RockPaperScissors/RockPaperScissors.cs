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
            int playerScore = 0;
            int computerScore = 0;

            do
            {
                Console.WriteLine("Enter choice Player:");
                string hand1 = Console.ReadLine().ToLower();

                index = r.Next(0, 3);
                computerPlayer = answers[index];

                string hand2 = computerPlayer;
                Console.WriteLine($"Computer Plays: {computerPlayer}");
                Console.WriteLine(CompareHands(hand1, hand2));
                if (CompareHands(hand1, hand2) == "Player Wins!")
                {
                    playerScore++;
                    Console.WriteLine($"Score: Player - {playerScore} | Score: Computer - {computerScore}");
                }
                else if (CompareHands(hand1, hand2) == "Computer Wins!")
                {
                    computerScore++;
                    Console.WriteLine($"Score: Player - {playerScore} | Score: Computer - {computerScore}");
                }
                else
                {
                    Console.WriteLine($"Score: Player - {playerScore} | Score: Computer - {computerScore}");
                }
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
                    return "Player Wins!";
                }
                return "Computer Wins!";
            }

            if (hand1 == "paper")
            {
                if (hand2 == "rock")
                {
                    return "Player Wins!";
                }
                return "Computer Wins!";
            }

            if (hand1 == "scissors")
            {
                if (hand2 == "paper")
                {

                    return "Player Wins!";
                }
                return "Computer Wins!";
            }
            return hand1 + ' ' + hand2;
        }
    }
}
