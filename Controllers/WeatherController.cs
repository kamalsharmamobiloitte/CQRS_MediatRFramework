using MediatR;
using MediatRPattern.Commands;
using MediatRPattern.DbModels;
using MediatRPattern.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace MediatRPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherController> _logger;

        private readonly IMediator _mediator;

        public WeatherController(ILogger<WeatherController> logger, IMediator mediatR)
        {
            _logger = logger;

            _mediator = mediatR;
        }

        [HttpPost]
        public IActionResult AddWorkshop(CreateWorkshopCommand workshop)
        {
            _mediator.Send(workshop);

            return Ok();
        }

        
        [HttpGet]        
        public IEnumerable<Workshop> GetWorkshops()
        {
            var query = new GetAllWorkshopQuery();

            return _mediator.Send(query).Result;
            
        }


    }
}
