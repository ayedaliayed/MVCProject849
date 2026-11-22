using Microsoft.AspNetCore.Mvc.Filters;

namespace MVCProject849.ActionFilters
{
    public class MyActionFilter : IActionFilter
    {
        // Before Action Execution
        public void OnActionExecuting(
            ActionExecutingContext context)
        {
            Console.WriteLine("Before Action");
        }

        // After Action Execution
        public void OnActionExecuted(
            ActionExecutedContext context)
        {
            Console.WriteLine("After Action");
        }

    }
}
   
