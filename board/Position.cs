using System.Reflection.Emit;
using System.Text;

namespace board 
{
    class Position 
    {
        public (int, int) Coordinates { get; set; }

        public Position(int Line, int Column) 
        {
            this.Coordinates = (Line, Column);
        }

        public override string ToString()
        {
            StringBuilder myStringBuilder = new();
            myStringBuilder.Append("Position: ");
            myStringBuilder.Append('(');
            myStringBuilder.Append(Coordinates.Item1);
            myStringBuilder.Append(',');
            myStringBuilder.Append(Coordinates.Item2);
            myStringBuilder.Append(')');
            return myStringBuilder.ToString();
        }
    }
}