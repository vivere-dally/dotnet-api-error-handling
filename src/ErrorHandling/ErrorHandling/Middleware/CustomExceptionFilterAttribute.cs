using ErrorHandling.Exceptions;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ErrorHandling.Middleware
{
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            switch (context.Exception)
            {
                case ForecastTemperatureRangeException:
                    context.Result = new BadRequestObjectResult(context.Exception.Message);
                    context.ExceptionHandled = true;
                    break;
                case UnluckyException:
                    context.Result = new ObjectResult(context.Exception.Message)
                    {
                        StatusCode = StatusCodes.Status500InternalServerError
                    };
                    context.ExceptionHandled = true;
                    break;

                default:
                    break;
            }
        }
    }
}
