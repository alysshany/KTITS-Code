//Galieva Zilya 220, ChessTask, 12/04/22
using System;

namespace Chess3Game
{
    class Program
    {
        static void Main()
        {
            King king = new King(Console.ReadLine()); //for example e2
            king.Move(Console.ReadLine());

            Queen queen = new Queen(Console.ReadLine());
            queen.Move(Console.ReadLine());

            Rook rook = new Rook(Console.ReadLine()); 
            rook.Move(Console.ReadLine());

            Bishop bishop = new Bishop(Console.ReadLine()); 
            bishop.Move(Console.ReadLine());

            Knight knight = new Knight(Console.ReadLine()); 
            knight.Move(Console.ReadLine());
        }
    }
}