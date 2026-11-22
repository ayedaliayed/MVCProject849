using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace MVCProject849.ActionFilters
{
    public class ExecutionTimeFilter : ActionFilterAttribute
    {
        private Stopwatch _stopwatch;

        public override void OnActionExecuting(
            ActionExecutingContext context)
        {
            _stopwatch = Stopwatch.StartNew();
        }

        public override void OnActionExecuted(
            ActionExecutedContext context)
        {
            _stopwatch.Stop();

            Console.WriteLine(
                $"Execution Time: {_stopwatch.ElapsedMilliseconds} ms"
            );
        }

    }
}
