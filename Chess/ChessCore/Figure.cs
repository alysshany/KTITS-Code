//Galieva Zilya 220, ChessTask, 12/04/22
using System;

namespace ChessCore
{
    abstract public class Figure
    { 
        public int X;
        public int Y;

        public Figure(string s)
        {
            int[] array = Checking.Check(s);
            X = array[0];
            Y = array[1];
        }

        public abstract bool IsRightMove(int x1, int y1);

        public virtual bool Move(string s)
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