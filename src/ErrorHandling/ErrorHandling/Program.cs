using System.Net.Mime;

using ErrorHandling.Middleware;
using ErrorHandling.Services;

using Microsoft.AspNetCore.Mvc;

namespace ErrorHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<TemperatureService>();

            builder.Services.AddControllers(ops =>
            {
                ops.Filters.Add<InternalServerErrorExceptionFilterAttribute>();
            }).ConfigureApiBehaviorOptions(ops =>
            {
                // https://learn.microsoft.com/en-us/aspnet/core/web-api/handle-errors?view=aspnetcore-7.0#validation-failure-error-response
                ops.InvalidModelStateResponseFactory = ctx =>
                    new BadRequestObjectResult(ctx.ModelState)
                    {
                        ContentTypes =
                        {
                            MediaTypeNames.Application.Json,
                        }
                    };
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}