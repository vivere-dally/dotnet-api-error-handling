using System.Runtime.Serialization;

namespace ErrorHandling.Exceptions
{
    public class ForecastTemperatureRangeException : MyAwesomeAppException
    {
        public ForecastTemperatureRangeException(int statusCode) : base(statusCode)
        {
        }

        public ForecastTemperatureRangeException(int statusCode, string? message) : base(statusCode, message)
        {
        }

        public ForecastTemperatureRangeException(int statusCode, string? message, Exception? innerException) : base(statusCode, message, innerException)
        {
        }

        protected ForecastTemperatureRangeException(int statusCode, SerializationInfo info, StreamingContext context) : base(statusCode, info, context)
        {
        }
    }
}
