using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer1
{
    public class MoodAnalyzerException : Exception
    {
        ExceptionType type;  //Create instance of custom exception type
        public string message;

        public enum ExceptionType
        {
            NULL_EXCEPTION, EMPTY_EXCEPTION,
            CLASS_NOT_FOUND ,CONSTRUCTOR_NOT_FOUND,NO_SUCH_METHOD, NULL_MOOD, NO_SUCH_FIELD
        }
        public MoodAnalyzerException(ExceptionType type, string message) : base(message)  //parameterized constructor and also using bsae method
        {
            this.type = type;
        }
    }
}
