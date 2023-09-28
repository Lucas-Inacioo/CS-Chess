using System.Reflection.Metadata;

namespace board 
{
    abstract class Piece 
    {
        public Position PiecePosition { get; set; }
        public Color PieceColor { get; set; }
        public int NumberOfMoves { get; set; }
        public Board GameBoard { get; set; }

        public Piece(Color PieceColor, Board GameBoard) 
        {
            this.PieceColor = PieceColor;
            this.GameBoard = GameBoard;
            this.PiecePosition = null;
            this.NumberOfMoves = 0;
        }
    }
}