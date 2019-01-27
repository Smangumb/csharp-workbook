using System;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "O";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                playerTurn = (playerTurn == "X") ? "O" : "X"; ;
                DrawBoard();
                GetInput();

            } while (!CheckForWin() && !CheckForTie());
            DrawBoard();
            if (CheckForWin())
            {
                System.Console.WriteLine(playerTurn + " wins!");
            }
            else
            {
                System.Console.WriteLine("It's a tie!");
            }
            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
            PlaceMark(row, column);
        }

        public static void PlaceMark(int row, int column)
        {
            // your code goes here
            board[row][column] = playerTurn;
        }

        public static bool CheckForWin()
        {
            return (HorizontalWin() || VerticalWin() || DiagonalWin());
        }

        public static bool CheckForTie()
        {
            // your code goes here
            return (!CheckForWin() && board[0][0] != " " && board[0][1] != " " && board[0][2] != " "
                && board[1][0] != " " && board[1][1] != " " && board[1][2] != " "
                && board[2][0] != " " && board[2][1] != " " && board[2][2] != " ");
        }

        public static bool HorizontalWin()
        {
            // your code goes here
            bool row1 = (board[0][0] == playerTurn && board[0][1] == playerTurn && board[0][2] == playerTurn);
            bool row2 = (board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn);
            bool row3 = (board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn);

            return (row1 || row2 || row3);
        }

        public static bool VerticalWin()
        {
            // your code goes here
            bool column1 = (board[0][0] == playerTurn && board[1][0] == playerTurn && board[2][0] == playerTurn);
            bool column2 = (board[0][1] == playerTurn && board[1][1] == playerTurn && board[2][1] == playerTurn);
            bool column3 = (board[0][2] == playerTurn && board[1][2] == playerTurn && board[2][2] == playerTurn);
            return (column1 || column2 || column3);
        }

        public static bool DiagonalWin()
        {
            // your code goes here
            bool diagonal1 = (board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2] == playerTurn);
            bool diagonal2 = (board[0][2] == playerTurn && board[1][1] == playerTurn && board[2][0] == playerTurn);
            return (diagonal1 || diagonal2);
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}
