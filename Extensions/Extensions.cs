using ASP_NET_MIDDLEWARE.Middleware;
using Microsoft.AspNetCore.Builder;



namespace ASP_NET_MIDDLEWARE.Extensions
{
    public static class AppExtensions
    {
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
