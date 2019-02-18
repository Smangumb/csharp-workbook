using System;
using System.Collections.Generic;

namespace Mastermind
{

    class Program
    {
        // possible letters in code
        public static char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

        // size of code
        public static int codeSize = 4;

        // number of allowed attempts to crack the code
        public static int allowedAttempts = 10;

        // number of tried guesses
        public static int numTry = 0;

        // test solution
        public static char[] solution = GenerateRandomCode();

        // game board
        public static string[][] board = new string[allowedAttempts][];


        public static void Main()
        {
            char[] guess = new char[4];
            CreateBoard();
            DrawBoard();

            do
            {
                Console.WriteLine("Enter Guess:");
                string input = Console.ReadLine();
                guess = input.ToCharArray();
                PlaceMark(guess);
                DrawBoard();
                numTry++;
            } while (!CheckSolution(guess) && (numTry < allowedAttempts));
            if (CheckSolution(guess))
            {
                System.Console.WriteLine("You win!");
            }
            else
            {
                System.Console.WriteLine("You lost!");
            }

        }

        public static bool CheckSolution(char[] guess)
        {
            // Your code here
            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == solution[i])
                {
                    if (i == guess.Length - 1)
                    {
                        return true;
                    }
                    continue;

                }
                else
                {
                    break;
                }
            }


            return false;
        }

        public static string GenerateHint(char[] guess)
        {
            // Your code here
            return " ";
        }

        public static void CreateBoard()
        {
            for (var i = 0; i < allowedAttempts; i++)
            {
                board[i] = new string[codeSize + 1];
                for (var j = 0; j < codeSize + 1; j++)
                {
                    board[i][j] = " ";
                }
            }
        }
        public static void DrawBoard()
        {
            for (var i = 0; i < board.Length; i++)
            {
                Console.WriteLine("|" + String.Join("|", board[i]));
            }

        }

        public static void PlaceMark(char[] guess)
        {
            // your code goes here
            for (int i = 0; i < guess.Length; i++)
            {
                board[numTry][i] = guess[i].ToString();
            }

        }

        public static char[] GenerateRandomCode()
        {
            char[] solution = new char[codeSize];
            Random rnd = new Random();
            for (var i = 0; i < codeSize; i++)
            {
                solution[i] = letters[rnd.Next(0, letters.Length)];
            }
            return solution;
        }
    }
}
