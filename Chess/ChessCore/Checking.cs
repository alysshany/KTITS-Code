//Galieva Zilya 220, ChessTask, 12/04/22
using System;

namespace ChessCore
{
    public static class Checking
    {
        public static int[] Check(string s)
        {
            int x1;
            int y1;
            if (!Char.IsDigit(s[0]))
            {
                Globals.dict2.TryGetValue(s[0], out int value);
                x1 = value;
                y1 = int.Parse(s[1].ToString());
            }
            else
            {
                x1 = int.Parse(s[0].ToString());
                y1 = int.Parse(s[1].ToString());
            }
            int[] array = new int[] { x1, y1 };
            return array;
        }
    }
}