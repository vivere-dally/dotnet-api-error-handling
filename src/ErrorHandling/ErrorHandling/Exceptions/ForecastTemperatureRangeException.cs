using System.Runtime.Serialization;

namespace ErrorHandling.Exceptions
{
    public class ForecastTemperatureRangeException : MyAwesomeAppException
    {
        public ForecastTemperatureRangeException() : base(StatusCodes.Status400BadRequest)
        {
        }

        public ForecastTemperatureRangeException(string? message) : base(StatusCodes.Status400BadRequest, message)
        {
        }

        public ForecastTemperatureRangeException(string? message, Exception? innerException) : base(StatusCodes.Status400BadRequest, message, innerException)
        {
        }

        protected ForecastTemperatureRangeException(SerializationInfo info, StreamingContext context) : base(StatusCodes.Status400BadRequest, info, context)
        {
        }
    }
}
