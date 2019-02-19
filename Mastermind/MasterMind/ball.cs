using System;
namespace Mastermind
{

    class Ball
    {
        public string letter { get; private set; }

        public Ball(string letter)
        {
            this.letter = letter;

        }
    }
}