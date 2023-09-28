using board;

namespace chess 
{
    class Screen 
    {
        public static void PrintBoard(Board GameBoard) 
        {
            for (int index = 0; index < Board.size; index++) 
            {
                for (int subIndex = 0; subIndex < Board.size; subIndex++)
                {
                    Piece piece = GameBoard.PieceAtPosition(index, subIndex);
                    
                    if (piece == null)
                    {
                        Console.Write("-");
                    }
                    Console.Write(piece + " ");
                }
                Console.WriteLine();
            }
        }
    }
}