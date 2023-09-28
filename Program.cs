using board;

namespace chess 
{
    class Program 
    {
        public static void Main(String[] args) 
        {
            Position P;
            Board B = new();

            Screen.PrintBoard(B);
        }
    }
}
