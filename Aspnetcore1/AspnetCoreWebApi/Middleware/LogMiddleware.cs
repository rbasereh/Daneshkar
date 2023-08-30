namespace AspnetCoreWebApi.Middleware
{
    public static class LogDataBase
    {
        public static List<string> Requests = new List<string>();
    }

    public class LogMiddleware //: IMiddleware
    {

        public LogMiddleware(RequestDelegate next)
        {
            Next = next;
        }

        public RequestDelegate Next { get; }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"before Log middleware" + context.Request.Path);
            //logic
            await Next(context);
            Console.WriteLine($"after Log middleware" + context.Request.Path);
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
