﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ErrorHandling.Services
{
    public class MyProblemDetailsFactory : ProblemDetailsFactory
    {
        public override ProblemDetails CreateProblemDetails(HttpContext httpContext, int? statusCode = null, string? title = null, string? type = null, string? detail = null, string? instance = null)
        {
            return new()
            {
                Type = type,
                Title = title,
                Detail = detail,
                Status = statusCode,
                Instance = instance
            };
        }

        public override ValidationProblemDetails CreateValidationProblemDetails(HttpContext httpContext, ModelStateDictionary modelStateDictionary, int? statusCode = null, string? title = null, string? type = null, string? detail = null, string? instance = null)
        {
            return new(modelStateDictionary)
            {
                Type = type,
                Title = title,
                Detail = detail,
                Status = statusCode,
                Instance = instance
            };
        }
    }
}
