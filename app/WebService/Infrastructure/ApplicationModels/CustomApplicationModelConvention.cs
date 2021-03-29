using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Infrastructure.ApplicationModels
{
    public class CustomApplicationModelConvention : IApplicationModelConvention
    {
        private readonly string _description;

        public CustomApplicationModelConvention(string description)
        {
            // Program.Output("[CustomAppConv] Constructor - Called");
            _description = description;
        }

        public void Apply(ApplicationModel application)
        {
            // Program.Output("[CustomAppConv] Apply - Called");
            application.Properties["appDescription"] = _description;
        }
    }
}
