using board;

namespace board 
{
    class King : Piece
    {
        public King(Color PieceColor, Board GameBoard) : base(PieceColor, GameBoard)
        { 
        }

        public override string ToString()
        {
            return "K";
        }
    }
}