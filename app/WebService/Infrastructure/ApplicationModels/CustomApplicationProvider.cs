using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Infrastructure.ApplicationModels
{
    public class CustomApplicationProvider : IApplicationModelProvider
    {
        public CustomApplicationProvider()
        {
            Program.Output("[CustomAppModels] Constructor - Called");
            Order = 0;
        }
        public int Order { get; }

        public void OnProvidersExecuted(ApplicationModelProviderContext context)
        {
            Program.Output("[CustomAppModels] OnProvidersExecuted - Called");
            // throw new NotImplementedException();
        }

        public void OnProvidersExecuting(ApplicationModelProviderContext context)
        {
            Program.Output("[CustomAppModels] OnProvidersExecuting - Called");
            // throw new NotImplementedException();
        }
    }
}
