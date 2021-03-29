using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Infrastructure.ApplicationModels
{
    public class CustomControllerModelConvention : Attribute, IControllerModelConvention
    {
        private readonly string _description;

        public CustomControllerModelConvention(string description)
        {
            // Program.Output("[CustomConConv] Constructor - Called");
            _description = description;
        }

        public void Apply(ControllerModel controllerModel)
        {
            // Program.Output("[CustomConConv] Apply - Called");
            controllerModel.Properties["controllerDescription"] = _description;
        }
    }
}
