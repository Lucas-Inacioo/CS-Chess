using System.Reflection.Metadata;

namespace board {
    class Piece {
        public Position PiecePosition { get; set; }
        public Color PieceColor { get; set; }
        public int NumberOfMoves { get; set; }
        public Board GameBoard { get; set; }

        public Piece(Position PiecePosition, Color PieceColor, Board GameBoard) {
            this.PiecePosition = PiecePosition;
            this.PieceColor = PieceColor;
            this.GameBoard = GameBoard;
            this.NumberOfMoves = 0;
        }
    }
}