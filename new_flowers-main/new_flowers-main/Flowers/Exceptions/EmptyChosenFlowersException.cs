using System;

namespace Flowers
{
    public class EmptyChosenFlowersException : Exception
    {
        public EmptyChosenFlowersException(string message)
      : base(message)
        {
           
        }
    }
}
