using Microsoft.AspNetCore.Http;

using System;
using System.Threading.Tasks;


namespace NovaPlace.Host.Logger
{
    public class Logger
    {
        private readonly RequestDelegate _next;

        public Logger(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {

                Console.WriteLine(httpContext.Request.Path.ToString());


                await _next.Invoke(httpContext);
            }
            catch (Exception exception)
            {

            }
        }
    }
}
