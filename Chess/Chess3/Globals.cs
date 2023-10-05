//Galieva Zilya 220, ChessTask, 12/04/22
using System.Collections.Generic;

namespace Chess3Game
{
    public static class Globals
    {
        public static Dictionary<int, string> dict = new Dictionary<int, string>()
        {
            {1, "a"},
            {2, "b"},
            {3, "c"},
            {4, "d"},
            {5, "e"},
            {6, "f"},
            {7, "g"},
            {8, "h"}
        };

        public static Dictionary<char, int> dict2 = new Dictionary<char, int>()
        {
            {'a', 1},
            {'b', 2},
            {'c', 3},
            {'d', 4},
            {'e', 5},
            {'f', 6},
            {'g', 7},
            {'h', 8}
        };
    }
}