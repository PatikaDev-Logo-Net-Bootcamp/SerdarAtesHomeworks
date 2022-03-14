using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Homeworktwo.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class VersionMiddleware
    {
        private readonly RequestDelegate _next;

        public VersionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
     
            var Request = httpContext.Request.Path;
            if (Request == "api/home/Register" && Request == "api/home/Login")
            {
                return _next(httpContext);
            }
            else
            {
                //Version conntrl
                return _next(httpContext);
            }
            
          


        }
    
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class VersionMiddlewareExtensions
    {
        public static IApplicationBuilder UseVersionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<VersionMiddleware>();
        }
    }
}
