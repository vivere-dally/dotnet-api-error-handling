using System.Runtime.Serialization;

namespace ErrorHandling.Exceptions
{
    public class UnluckyException : MyAwesomeAppException
    {
        public UnluckyException(int statusCode) : base(statusCode)
        {
        }

        public UnluckyException(int statusCode, string? message) : base(statusCode, message)
        {
        }

        public UnluckyException(int statusCode, string? message, Exception? innerException) : base(statusCode, message, innerException)
        {
        }

        protected UnluckyException(int statusCode, SerializationInfo info, StreamingContext context) : base(statusCode, info, context)
        {
        }
    }
}
