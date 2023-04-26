using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ErrorHandling.Middleware
{
    public class ArgumentExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is ArgumentException e)
            {
                context.Result = new BadRequestObjectResult(e.Message);
                context.ExceptionHandled = true;
            }
        }
    }
}
