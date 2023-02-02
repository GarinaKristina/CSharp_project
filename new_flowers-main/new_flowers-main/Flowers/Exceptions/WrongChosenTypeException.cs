using System;

namespace Flowers
{
    public class WrongChosenTypeException : Exception
    {
       
        public WrongChosenTypeException(string message)
      : base(message)
        {
           
        }
    }
}
