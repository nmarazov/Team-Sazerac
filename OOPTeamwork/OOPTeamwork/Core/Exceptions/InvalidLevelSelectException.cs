using System;

namespace OOPTeamwork.Core.Exceptions
{
    public class InvalidLevelSelectException : Exception
    {
        public InvalidLevelSelectException()
        { 
        }

        public InvalidLevelSelectException(string message)
            : base(message)
        {    
        }

        public InvalidLevelSelectException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
