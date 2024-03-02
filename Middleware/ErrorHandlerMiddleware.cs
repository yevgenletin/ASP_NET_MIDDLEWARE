
using System.Net;
using System.Text.Json;

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
                var response = context.Response;
                response.ContentType = "application/json";
                //var responseModel = new Response <string>() {Succeded=false, Message= ex };
                //Son errores personalizados
                switch (ex)
                {
                    case Exceptions.ApiException e:
                        //custom exception
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;
                    //case Exceptions.ValidationException e:
                    //response.StatusCode = (int)HttpStatusCode.BadRequest;
                    //    break;
                    case KeyNotFoundException e:
                        //not found error
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        break;
                    default:
                        //unhandled error
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }
                var result = JsonSerializer.Serialize("ejemplo");
                await response.WriteAsync(result);
            }
        }
    }
}
