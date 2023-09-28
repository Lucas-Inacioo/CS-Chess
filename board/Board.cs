using System.Threading.Channels;

namespace board 
{
    class Board 
    {
        public const int size = 8;
        private Piece[,] GamePieces;

        public Board() 
        {    
            GamePieces = new Piece[size, size];
        }

        public Piece PieceAtPosition(int PiecePositionX, int PiecePositionY)
        {
            return GamePieces[PiecePositionX, PiecePositionY];
        }

        public Piece PieceAtPosition(Position position)
        {
            return GamePieces[position.Coordinates.Item1, position.Coordinates.Item2];
        }

        public bool PieceExists(Position position)
        {
            ValidatePosition(position);
            return GamePieces[position.Coordinates.Item1, position.Coordinates.Item2] != null;
        }

        public void SetPiece(Piece WantedPiece, Position WantedPosition)
        {
            if (PieceExists(WantedPosition))
            {
                throw new BoardException("Occupied position!");
            }
            GamePieces[WantedPosition.Coordinates.Item1, WantedPosition.Coordinates.Item2] = WantedPiece;
            WantedPiece.PiecePosition = WantedPosition;
        }

        public bool ValidPosition(Position position)
        {
            if (
                position.Coordinates.Item1 < 0 ||
                position.Coordinates.Item2 < 0 ||
                position.Coordinates.Item1 > size - 1 ||
                position.Coordinates.Item2 > size - 1
                )
                {
                    return false;
                }
            return true;
        }

        public void ValidatePosition(Position position)
        {
            if (!ValidPosition(position))
            {
                throw new BoardException("Invalid position!");
            }
        }
    }
}