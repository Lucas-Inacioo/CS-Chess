using board;

namespace chess 
{
    class Program 
    {
        public static void Main(String[] args) 
        {
            try
            {
                Board B = new();
                B.SetPiece(new Tower(Color.White, B), new Position(7, 4));
                B.SetPiece(new King(Color.White, B), new Position(0, 0));
                Screen.PrintBoard(B);
            }
            catch (BoardException ErrorMessage)
            {
                Console.WriteLine(ErrorMessage.Message);
            }
        }
    }
}
