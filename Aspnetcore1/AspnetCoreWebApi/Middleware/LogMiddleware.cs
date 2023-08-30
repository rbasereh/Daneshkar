namespace AspnetCoreWebApi.Middleware
{
    public static class LogDataBase
    {
        public static List<string> Requests = new List<string>();
    }
    public class ExceptionMiddleware //: IMiddleware
    {

        public ExceptionMiddleware(RequestDelegate next)
        {
            Next = next;
        }

        public RequestDelegate Next { get; }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"before ex middleware" + context.Request.Path);
            //logic
            await Next(context);
            //try
            //{
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());

            //}
            Console.WriteLine($"after ex middleware" + context.Request.Path);
        }
    }
    public class LogMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine($"Before Auth middleware" + context.Request.Path);
            await next(context);
            Console.WriteLine($"after Auth middleware" + context.Request.Path);
        }
    }

    public class AuthMiddleware
    {

        public AuthMiddleware(RequestDelegate next)
        {
            Next = next;
        }

        public RequestDelegate Next { get; }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"Before Auth middleware" + context.Request.Path);
            await Next(context);
            Console.WriteLine($"after Auth middleware" + context.Request.Path);
        }
    }
}
