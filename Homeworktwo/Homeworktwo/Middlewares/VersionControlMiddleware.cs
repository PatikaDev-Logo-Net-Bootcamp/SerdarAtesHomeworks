using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Homeworktwo.Middlewares
{
    public class VersionControlMiddleware : IMiddleware
    {
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            throw new System.NotImplementedException();
        }
    }
}
