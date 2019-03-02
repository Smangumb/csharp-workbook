using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Checker
    {
        public string Symbol { get; set; }
        public int[] Position { get; set; }
        public string Color { get; set; }

        public Checker(string color, int[] position)
        {
            // Your code here
        }
    }

    public class Board
    {
        public string[][] Grid { get; set; }



        public List<Checker> Checkers { get; set; }

        public Board()
        {
            // Your code here
            return;
        }

        public void CreateBoard()
        {
            // Your code here
            this.Grid = new string[][] {
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
            return;
        }

        public void GenerateCheckers()
        {
            // Your code here
            int[][] whitePositions = new int[][]
            {
                new int[] {0,1},new int[] {0,3},new int[] {0,5}, new int[] {0,7},
                new int[] {1,0},new int[] {1,2},new int[] {1,4},new int[] {1,6},
                new int[] {2,1},new int[] {2,3},new int[] {2,5},new int[] {2,7}
            };
            int[][] blackPositions = new int[][]
            {
                new int[] {5,0},new int[] {5,2},new int[] {5,4}, new int[] {5,6},
                new int[] {6,1},new int[] {6,3},new int[] {6,5},new int[] {6,7},
                new int[] {7,0},new int[] {7,2},new int[] {7,4},new int[] {7,6}
            };
            for (int i = 0; i < 12; i++)
            {
                Checker white = new Checker("white", whitePositions[i]);
                Checker black = new Checker("black", blackPositions[i]);
                this.Checkers.Add(white);
                this.Checkers.Add(black);
            }
            return;
        }

        public void PlaceCheckers()
        {
            // Your code here
            for (var i = 0; i < Checkers.Count; i++)
            {
                int[] position = Checkers[i].Position;
                Grid[position[0]][position[1]] = Checkers[i].Symbol;
            }
            return;
        }

        public void DrawBoard()
        {
            // Your code here
            return;
        }

        public Checker SelectChecker(int row, int column)
        {
            return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
        }

        public void RemoveChecker(int row, int column)
        {
            // Your code here
            return;
        }

        public bool CheckForWin()
        {
            return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
        }
    }

    class Game
    {
        public Game()
        {
            // Your code here
        }
    }
}
