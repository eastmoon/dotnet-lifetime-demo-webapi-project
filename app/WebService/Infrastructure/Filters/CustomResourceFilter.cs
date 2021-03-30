using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Infrastructure.Filters
{
    public class CustomResourceFilter : Attribute, IResourceFilter
    {
        // Sync method
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Program.Output($"[Filters] {GetType().Name} in");
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Program.Output($"[Filters] {GetType().Name} out");
        }

        // Async method, it will mutually exclusive with sync method.
        /*
        public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
        {
            await Program.Output($"[Filters] {GetType().Name} in");

            await next();

            await Program.Output($"[Filters] {GetType().Name} out");
        }
        */
    }
}
