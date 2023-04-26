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
                context.Result = new ObjectResult(e.Message)
                {
                    StatusCode = e.StatusCode
                };

                context.ExceptionHandled = true;
            }
        }
    }
}
