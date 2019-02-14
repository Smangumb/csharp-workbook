using System;
using System.Collections.Generic;

namespace Mastermind
{

    class Game
    {
        private List<Row> rows = new List<Row>();
        private string[] answer = new string[4];

        public Game(string[] answer)
        {
            this.answer = answer;
        }

        private string Score(Row row)
        {
            string[] answerClone = (string[])this.answer.Clone();
            // red is correct letter and correct position
            // white is correct letters minus red
            // this.answer => ["a", "b", "c", "d"]
            // row.balls => [{ Letter: "c" }, { Letter: "b" }, { Letter: "d" }, { Letter: "a" }]
            int red = 0;
            for (int i = 0; i < 4; i++)
            {
                if (answerClone[i] == row.balls[i].letter)
                {
                    red++;
                }
            }

            int white = 0;
            for (int i = 0; i < 4; i++)
            {
                int foundIndex = Array.IndexOf(answerClone, row.balls[i].letter);
                if (foundIndex > -1)
                {
                    white++;
                    answerClone[foundIndex] = null;
                }
            }
            return $" {red} - {white - red}";
        }

        public void AddRow(Row row)
        {
            this.rows.Add(row);
        }

        public string Rows
        {
            get
            {
                string temp = "";
                foreach (var row in this.rows)
                {
                    string score = this.Score(row);
                    temp = temp + row.Balls + score + "\n";
                }
                return temp;
            }
        }
    }
}