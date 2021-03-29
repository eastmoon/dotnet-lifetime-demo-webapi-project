using System;

namespace WebService.Services
{
    public class DemoService
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string Desc { get; set; }
    }
}
