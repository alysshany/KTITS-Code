//Galieva Zilya 220, ChessTask, 12/04/22
using System;

namespace Chess3Game
{
    class Figure
    { 
        public int X;
        public int Y;

        public Figure(string s)
        {
            int[] array = Checking.Check(s);
            X = array[0];
            Y = array[1];
        }
    }
}