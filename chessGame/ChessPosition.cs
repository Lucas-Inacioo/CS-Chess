using System.Text;
using board;

namespace chessGame
{
    class ChessPosition
    {
        public char Column { get; set; }
        public int Line { get; set; }

        public ChessPosition(char Column, int Line)
        {
            this.Column = Column;
            this.Line = Line;
        }

        public Position ToPosition()
        {
            return new Position(8 - Line, Char.ToLower(Column) - 'a');
        }
        public override string ToString()
        {
            StringBuilder myStringBuilder = new();
            myStringBuilder.Append(Column);
            myStringBuilder.Append(Line);
            return myStringBuilder.ToString();
        }
    }
}