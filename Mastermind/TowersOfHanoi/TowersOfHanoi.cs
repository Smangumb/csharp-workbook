using System;
using System.Collections;
using System.Collections.Generic;

namespace Tower
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.PrintBoard();
        }
    }
    class Block
    {
        public int weight { get; private set; }

        public Block(int weight)
        {
            this.weight = weight;
        }
    }
    class Tower
    {
        public Stack blocks = new Stack();
    }
    class Game
    {
        Dictionary<string, Tower> towers = new Dictionary<string, Tower>();

        public Game()
        {
            Tower towerA = new Tower();
            Tower towerB = new Tower();
            Tower towerC = new Tower();
            towers["A"] = towerA;
            towers["B"] = towerB;
            towers["C"] = towerC;
            towerA.blocks.Push(new Block(1));
            towerA.blocks.Push(new Block(2));
            towerA.blocks.Push(new Block(3));
            towerA.blocks.Push(new Block(4));
        }

        public void PrintBoard()
        {
            foreach (KeyValuePair<string, Tower> item in towers)
            {
                string blocks = "";
                foreach (Block block in item.Value.blocks)
                {
                    blocks += block.weight.ToString();
                }
                System.Console.WriteLine(item.Key + "| " + blocks);

            }
        }
        public void MovePiece()
        {
            foreach (KeyValuePair<string, Tower> item in towers)
            {
                
            }
        }
    }
}
