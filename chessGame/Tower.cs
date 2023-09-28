using board;

namespace board 
{
    class Tower : Piece
    {
        public Tower(Color PieceColor, Board GameBoard) : base(PieceColor, GameBoard)
        { 
        }

        public override string ToString()
        {
            return "T";
        }
    }
}