using System.Runtime.Serialization;

namespace ErrorHandling.Exceptions
{
    public class ForecastTemperatureRangeException : Exception
    {
        public ForecastTemperatureRangeException()
        {
        }

        public ForecastTemperatureRangeException(string? message) : base(message)
        {
        }

        public ForecastTemperatureRangeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ForecastTemperatureRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
