using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Infrastructure.Filters
{
    public class CustomAuthorizationFilter : Attribute, IAuthorizationFilter
    {
        // Sync method
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            Program.Output($"[Filters] {GetType().Name} in");
        }


        // Async method, it will mutually exclusive with sync method.
        /*
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            Program.Output($"[Filters] {GetType().Name} in");
        }
        */
    }
}
