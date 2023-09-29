using board;

namespace chessGame 
{
    class ChessMatch
    {
        public Board GameBoard { get; set; }
        private int Turn;
        private Color PlayerTurn;
        public bool MatchEnd { get; private set; }

        public ChessMatch()
        {
            GameBoard = new Board();
            Turn = 1;
            PlayerTurn = Color.White;
            MatchEnd = false;
            SetMatch();
        }

        public void MakeMove(Position InitialPosition, Position FinalPosition)
        {
            Piece MovedPiece = GameBoard.removePiece(InitialPosition);
            MovedPiece.IncrementNumberOfMoves();
            Piece CapturedPiece = GameBoard.removePiece(FinalPosition);
            GameBoard.SetPiece(MovedPiece, FinalPosition);
        }
    
        private void SetMatch()
        {
            GameBoard.SetPiece(new Tower(Color.White, GameBoard), new ChessPosition('A', 1).ToPosition());
            GameBoard.SetPiece(new Tower(Color.White, GameBoard), new ChessPosition('H', 1).ToPosition());
            GameBoard.SetPiece(new King(Color.White, GameBoard), new ChessPosition('E', 1).ToPosition());

            GameBoard.SetPiece(new Tower(Color.Black, GameBoard), new ChessPosition('A', 8).ToPosition());
            GameBoard.SetPiece(new Tower(Color.Black, GameBoard), new ChessPosition('H', 8).ToPosition());
            GameBoard.SetPiece(new King(Color.Black, GameBoard), new ChessPosition('E', 8).ToPosition());
        }
    }
}