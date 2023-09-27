using System.Reflection.Emit;
using System.Text;

namespace board {
    class Position {
        public int Line { get; set; }
        public int Column { get; set; }

        public Position(int Line, int Column) {
            this.Line = Line;
            this.Column = Column;
        }

        public override string ToString()
        {
            StringBuilder myStringBuilder = new();
            myStringBuilder.Append("Position: ");
            myStringBuilder.Append('(');
            myStringBuilder.Append(Line);
            myStringBuilder.Append(',');
            myStringBuilder.Append(Column);
            myStringBuilder.Append(')');
            return myStringBuilder.ToString();
        }
    }
}