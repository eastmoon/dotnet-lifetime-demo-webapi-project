using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Infrastructure.Filters
{
    public class CustomActionFilter : Attribute, IActionFilter
    {
        // Sync method
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Program.Output($"[Filters] {GetType().Name} in");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Program.Output($"[Filters] {GetType().Name} out");
        }


        // Async method, it will mutually exclusive with sync method.
        /*
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await Program.Output($"[Filters] {GetType().Name} in");

            await next();

            await Program.Output($"[Filters] {GetType().Name} out");
        }
        */
    }
}
