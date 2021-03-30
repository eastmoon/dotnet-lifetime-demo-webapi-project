using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Infrastructure.Filters
{
    public class CustomResultFilter : Attribute, IResultFilter
    {
        // Sync method
        public void OnResultExecuting(ResultExecutingContext context)
        {
            Program.Output($"[Filters] {GetType().Name} in");
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            Program.Output($"[Filters] {GetType().Name} out");
        }


        // Async method, it will mutually exclusive with sync method.
        /*
        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            await Program.Output($"[Filters] {GetType().Name} in");

            await next();

            await Program.Output($"[Filters] {GetType().Name} out");
        }
        */
    }
}
