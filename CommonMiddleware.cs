using System.Net;

namespace DotNetCore_MVC
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CommonMiddleware
    {
        private readonly RequestDelegate _next;

        public CommonMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            string authHeader = httpContext.Request.Headers["Authorization"];
            if (authHeader != null && authHeader.StartsWith("Bearer"))
            {
                string token = authHeader.Substring("Bearer ".Length).Trim();

                try
                {
                    // Validate the token
                    int claimsPrincipal = ValidateToken();
                    // httpContext.User = claimsPrincipal;
                }
                catch (Exception ex)
                {
                    // Return unauthorized status code if the token is invalid
                    httpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;

                    Console.Write(ex.ToString());

                    return;
                }
            }

            await _next(httpContext);
        }

        private int ValidateToken()
        {
            // Implement validation logic here

            return 1;

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CommonMiddlewareExtensions
    {
        public static IApplicationBuilder UseCommonMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CommonMiddleware>();
        }
    }
}
