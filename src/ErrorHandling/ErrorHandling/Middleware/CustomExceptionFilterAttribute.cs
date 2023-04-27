using ErrorHandling.Exceptions;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ErrorHandling.Middleware
{
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is MyAwesomeAppException e)
            {
                context.Result = new ObjectResult(new ProblemDetails()
                {
                    Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1",
                    Title = "The server has encountered a domain exception while processing your request.",
                    Status = e.StatusCode,
                    Detail = e.Message
                });
                context.ExceptionHandled = true;
            }
        }
    }
}
