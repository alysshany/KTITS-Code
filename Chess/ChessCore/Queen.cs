//Galieva Zilya 220, ChessTask, 12/04/22
using System;

namespace ChessCore
{
    public class Queen : Figure
    {
        public Queen(string s) : base(s) { }

        public override bool IsRightMove(int x1, int y1)
        {
            return X == x1 || Y == y1 ||
                    Math.Abs(X - x1) == Math.Abs(Y - y1);
        }
        public override bool Move(string s)
        {
            int[] array = Checking.Check(s);
            if (IsRightMove(array[0], array[1]))
            {
                X = array[0];
                Y = array[1];
                return true;
            }
            return false;
        }
    }
}