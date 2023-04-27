using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ErrorHandling.Middleware
{
    public class InternalServerErrorExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.Result = new ObjectResult(new ProblemDetails()
            {
                Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1",
                Title = "The server has encountered an error while processing your request.",
                Detail = context.Exception.Message,
                Status = StatusCodes.Status500InternalServerError
            });
            context.ExceptionHandled = true;
        }
    }
}
