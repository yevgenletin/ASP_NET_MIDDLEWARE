namespace ASP_NET_MIDDLEWARE.Middleware
{
    public class ErrorHandlerMiddleware
    {

        public readonly RequestDelegate _next;
        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            { 
                await _next(context);
                    
            }
            catch (Exception ex)
            {
                switch (ex)
                {
                    
                }
                throw;
            }
        }
    }
}
