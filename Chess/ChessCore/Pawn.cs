//Galieva Zilya 220, ChessTask, 12/04/22
using System;

namespace ChessCore
{
    public class Pawn : Figure
    {
        public Pawn(string s) : base(s) { }

        public override bool IsRightMove(int x1, int y1)
        {
            return (X == x1 && Y == 2 && Y + 2 >= y1) ||
                    (X == x1 && Y + 1 == y1);
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