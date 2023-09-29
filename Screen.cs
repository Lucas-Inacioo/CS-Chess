using board;

namespace chess 
{
    class Screen 
    {
        public static void PrintBoard(Board GameBoard) 
        {
            for (int index = 0; index < Board.size; index++) 
            {
                Console.Write(8 - index + " ");
                for (int subIndex = 0; subIndex < Board.size; subIndex++)
                {
                    Piece PrintedPiece = GameBoard.PieceAtPosition(index, subIndex);
                    
                    if (PrintedPiece == null)
                        Console.Write("- ");
                    else
                        PrintPiece(PrintedPiece);
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void PrintPiece(Piece PrintedPiece)
        {
            if (PrintedPiece.PieceColor == Color.White)
            {
                Console.Write(PrintedPiece + " ");
            }
            else
            {
                ConsoleColor OriginalColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(PrintedPiece + " ");
                Console.ForegroundColor = OriginalColor;
            }
        }
    }
}