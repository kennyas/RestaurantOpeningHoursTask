using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantOpeningHoursTask.API.Query;
using RestaurantOpeningHoursTask.Shared.OpeningAndClosingHoursModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOpeningHoursTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenHourFormatter : ControllerBase
    {
        private readonly ILogger<OpenHourFormatter> _logger;
        private readonly IMediator _mediator;


        public OpenHourFormatter(ILogger<OpenHourFormatter> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        [Produces("application/json")]
        [HttpPost, Route("GetFormattedOpenHours")]
        /// <summary>  
        /// This action enables users to format Unix time into UTC date time and returns the open hours for the restaurant provided 
        /// </summary>  
        /// <param name="OpenningAndClosingHoursReqest">Model to Format unix time from JSON</param>  
        /// <returns>Returns the formatted Open Hours</returns>  
        /// <response code="200">Returned if operation was successful</response>  
        /// <response code="400">Returned if the model could not be parsed </response>  
        /// <response code="422">Returned when the validation failed</response>
        public IActionResult GetFormattedOpenHours([FromBody] OpeningAndClosingHoursRequest Model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _logger.LogInformation("Valid Model");
                    var Querry = new FetchOpeningAndClosingHoursQuery(Model);
                    var result = _mediator.Send(Querry);
                    if (result.Result != null || !result.IsFaulted) return new OkObjectResult(result.Result);
                    return BadRequest();

                }
                return BadRequest(ModelState);

            }
            catch
            {
                return BadRequest();

            }
        }
    }
}
