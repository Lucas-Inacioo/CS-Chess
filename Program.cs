using System.Text.RegularExpressions;
using board;
using chessGame;

namespace chess 
{
    class Program 
    {
        public static void Main(String[] args) 
        {
            try
            {
                ChessMatch match = new();
                while (!match.MatchEnd)
                {
                    Console.Clear();
                    Screen.PrintBoard(match.GameBoard);

                    Console.Write("Initial Position: ");
                    Position InitialPosition = Screen.ReadMove().ToPosition();
                    Console.Write("Final Position: ");
                    Position FinalPosition = Screen.ReadMove().ToPosition();

                    match.MakeMove(InitialPosition, FinalPosition);
                }
            }
            catch (BoardException ErrorMessage)
            {
                Console.WriteLine(ErrorMessage.Message);
            }
        }
    }
}
