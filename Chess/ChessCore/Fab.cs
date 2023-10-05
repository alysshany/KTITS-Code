//Galieva Zilya 220, ChessTask, 20/06/22

namespace ChessCore
{
    public class Fab
    {
        public static Figure FiguresMaking(string str)
        {
            Figure figure = null;
            string[] s = str.Split(" ");
            switch (s[0])
            {
                case "Pawn":
                    figure = new Pawn(s[1] + "" + s[2]);
                    break;
                case "King":
                    figure = new King(s[1] + "" + s[2]);
                    break;
                case "Knight":
                    figure = new Knight(s[1] + "" + s[2]);
                    break;
                case "Bishop":
                    figure = new Bishop(s[1] + "" + s[2]);
                    break;
                case "Rook":
                    figure = new Rook(s[1] + "" + s[2]);
                    break;
                case "Queen":
                    figure = new Queen(s[1] + "" + s[2]);
                    break;
            }
            return figure;
        }
    }
}
