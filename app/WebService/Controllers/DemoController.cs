using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebService.Services;

namespace WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Infrastructure.ApplicationModels.CustomControllerModelConvention("Custom Controller Description")]
    public class DemoController : ControllerBase
    {
        private readonly ILogger<DemoController> _logger;
        private readonly IDISample _singleton;
        private readonly IDISample _scoped;
        private readonly IDISample _transient;


        public DemoController(
            ILogger<DemoController> logger,
            IDISampleSingleton singleton,
            IDISampleScoped scoped,
            IDISampleTransient transient)
        {
            _logger = logger;
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;
            
        }

        [HttpGet]
        [Infrastructure.ApplicationModels.CustomActionModelConvention("Custom Action Description")]
        public IEnumerable<DemoService> Get(
            [FromServices] IDISampleSingleton actionSingleton,
            [FromServices] IDISampleScoped actionScoped,
            [FromServices] IDISampleTransient actionTransient)
        {
            // Retrieve Injection service from HttpContext
            IDISample retrieveSingleton = HttpContext.RequestServices.GetService(typeof(IDISampleSingleton)) as IDISample;
            IDISample retrieveScoped = HttpContext.RequestServices.GetService(typeof(IDISampleScoped)) as IDISample;
            IDISample retrieveTransient = HttpContext.RequestServices.GetService(typeof(IDISampleTransient)) as IDISample;
            // Show injection object
            Program.Output("[ApplicationModels] Appliction : " + ControllerContext.ActionDescriptor.Properties["appDescription"]);
            Program.Output("[ApplicationModels] Controller : " + ControllerContext.ActionDescriptor.Properties["controllerDescription"]);
            Program.Output("[ApplicationModels] Action : " + ControllerContext.ActionDescriptor.Properties["actionDescription"]);
            Program.Output("[DemoController] Http Request : " + HttpContext.GetHashCode());
            Program.Output("[DemoController] Controller Singleton \t" + _singleton.Id + ", " + _singleton.GetHashCode());
            Program.Output("[DemoController] Controller Scoped \t" + _scoped.Id + ", " + _scoped.GetHashCode());
            Program.Output("[DemoController] Controller Transient \t" + _transient.Id + ", " + _transient.GetHashCode());
            Program.Output("[DemoController] Action Singleton \t" + actionSingleton.Id + ", " + actionSingleton.GetHashCode());
            Program.Output("[DemoController] Action Scoped  \t\t" + actionScoped.Id + ", " + actionScoped.GetHashCode());
            Program.Output("[DemoController] Action Transient \t" + actionTransient.Id + ", " + actionTransient.GetHashCode());
            Program.Output("[DemoController] HttpContext Singleton \t" + retrieveSingleton.Id + ", " + retrieveSingleton.GetHashCode());
            Program.Output("[DemoController] HttpContext Scoped  \t" + retrieveScoped.Id + ", " + retrieveScoped.GetHashCode());
            Program.Output("[DemoController] HttpContext Transient \t" + retrieveTransient.Id + ", " + retrieveTransient.GetHashCode());

            // Process DemoService 
            var rng = new Random();
            return Enumerable.Range(1, 2).Select(index => new DemoService
            {
                Desc = "Hello World " + index,
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55)
            })
            .ToArray();
        }
    }
}
