using System;

namespace LatexToMathML
{
    public class ExceptionEventArgs : EventArgs
    {
        public ExceptionEventArgs(String message)
        {
            this.Message = message;
        }

        public String Message { get; private set; }
    }
}
