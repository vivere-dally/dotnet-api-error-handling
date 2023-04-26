using System.Runtime.Serialization;

namespace ErrorHandling.Exceptions
{
    public class MyAwesomeAppException : Exception
    {
        public int StatusCode { get; init; }

        public MyAwesomeAppException(int statusCode)
        {
            StatusCode = statusCode;
        }

        public MyAwesomeAppException(int statusCode, string? message) : base(message)
        {
            StatusCode = statusCode;
        }

        public MyAwesomeAppException(int statusCode, string? message, Exception? innerException) : base(message, innerException)
        {
            StatusCode = statusCode;
        }

        protected MyAwesomeAppException(int statusCode, SerializationInfo info, StreamingContext context) : base(info, context)
        {
            StatusCode = statusCode;
        }
    }
}
