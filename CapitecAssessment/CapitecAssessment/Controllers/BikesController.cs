using CapitecAssessment.Model;
using CapitecAssessment.Models;
using CapitecAssessment.Reposatory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitecAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikesController : ControllerBase
    {


         private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<BikesController> _logger;

        public BikesController(ILogger<BikesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Bike> Get()
        { 
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Bike
            {
                bike_Make = "bugatti",
                bike_Description = "bugatti XX",
                bike_Model = "bugattu XX Model"
             })
            .ToArray();
        }
       

    }
}
