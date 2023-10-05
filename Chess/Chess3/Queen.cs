//Galieva Zilya 220, ChessTask, 12/04/22
using System;

namespace Chess3Game
{
    class Queen : Figure
    {
        public Queen(string s) : base(s) { }

        public bool IsRightMove(int x1, int y1)
        {
            return (X == x1 || Y == y1 ||
                    Math.Abs(X - x1) == Math.Abs(Y - y1));
        }

        public void Move(string s)
        {
            int[] array = Checking.Check(s);
            if (IsRightMove(array[0], array[1]))
            {
                Console.WriteLine("You can go there");
                Console.WriteLine("Your move - " + s);
            }
            else
            {
                Console.WriteLine("You can't go there");
            }
        }
    }
}