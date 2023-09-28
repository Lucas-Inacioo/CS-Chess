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
    }
}