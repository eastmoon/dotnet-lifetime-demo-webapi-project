using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Infrastructure.ApplicationModels
{
    public class CustomActionModelConvention : Attribute, IActionModelConvention
    {
        private readonly string _description;

        public CustomActionModelConvention(string description)
        {
            // Program.Output("[CustomActionConv] Constructor - Called");
            _description = description;
        }

        public void Apply(ActionModel actionModel)
        {
            // Program.Output("[CustomActionConv] Apply - Called");
            actionModel.Properties["actionDescription"] = _description;
        }
    }
}
