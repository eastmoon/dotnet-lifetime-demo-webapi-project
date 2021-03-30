using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Infrastructure.Filters
{
    public class CustomExceptionFilter : Attribute, IExceptionFilter
    {
        // Sync method
        public void OnException(ExceptionContext context)
        {
            Program.Output($"[Filters] {GetType().Name} in");
        }


        // Async method, it will mutually exclusive with sync method.
        /*
        public Task OnExceptionAsync(ExceptionContext context)
        {
            Program.Output($"[Filters] {GetType().Name} in");
            return Task.CompletedTask;
        }
        */
    }
}
