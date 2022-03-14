using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
namespace Homeworktwo.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class VersionMiddleware
    {
        private readonly RequestDelegate _next;
        private IConfiguration configuration;

        public VersionMiddleware(RequestDelegate next,IConfiguration iConfig)
        {
            configuration = iConfig;
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {   
     
            var Request = httpContext.Request.Path;
            if (Request == "/api/home/register" || Request == "/api/home/login")
            {
                return _next(httpContext);
            }
            else
            {
                String appHeaderVersionString =  httpContext.Request?.Headers["app-version"];
                float appHeader;
                float.TryParse(appHeaderVersionString, out appHeader);
                String appSetVersionString = configuration.GetValue<String>("Version");
                float appSetVersion;
                float.TryParse(appSetVersionString, out appSetVersion);
                //Version conntrl
                if (appHeader > appSetVersion)
                {
                    //Return exception
                    return VersionException(httpContext);
                }
                return _next(httpContext);
                
            }

        }
        private async Task VersionException(HttpContext httpContext)
        {
            httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await httpContext.Response.WriteAsync("Versiyon Hatası");
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
