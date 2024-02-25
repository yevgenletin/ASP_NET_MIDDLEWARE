namespace ASP_NET_MIDDLEWARE.Exceptions
{
    public class ApiException: Exception
    {
        public ApiException() :base(){ }
        public ApiException(string messagge) :base(messagge){ }
    }
}
