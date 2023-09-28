using System;

namespace board
{
    class BoardException : Exception
    {
        public BoardException (string ErrorMessage) : base (ErrorMessage)
        {}
    }
}