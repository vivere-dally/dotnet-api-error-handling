using System.Runtime.Serialization;

namespace ErrorHandling.Exceptions
{
    public class UnluckyException : MyAwesomeAppException
    {
        public UnluckyException() : base(StatusCodes.Status500InternalServerError)
        {
        }

        public UnluckyException(string? message) : base(StatusCodes.Status500InternalServerError, message)
        {
        }

        public UnluckyException(string? message, Exception? innerException) : base(StatusCodes.Status500InternalServerError, message, innerException)
        {
        }

        protected UnluckyException(SerializationInfo info, StreamingContext context) : base(StatusCodes.Status500InternalServerError, info, context)
        {
        }
    }
}
