namespace MiddlewareMVC.Middleware
{
    public class MyMiddleware
    {
        // Middleware اللي بعدنا في الـ Pipeline
        private readonly RequestDelegate _next;
        // Constructor
        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        // Main Middleware Method
        public async Task InvokeAsync(HttpContext context)
        {
            // Before Controller
            // Execute logic before the controller action is executed
            // For example, you can log the request details, perform authentication checks, etc.
            Console.WriteLine("Before Controller");
            // Execute Next Middleware
            await _next(context);// response from the next action
            // After Controller4
            // Execute logic after the controller action is executed
            Console.WriteLine("After Controller");

        }
    }
}