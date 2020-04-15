namespace BerlinClockAPI.Controllers
{//testing 3
    using Domain.Interfaces;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Services.Interfaces;
    using System;

    [ApiController]
    [Route("[controller]")]
    public class BerlinClockController : ControllerBase
    {
        private readonly ITimeConverter _timeConverter;
        private readonly ILogger<BerlinClockController> _logger;

        public BerlinClockController(ITimeConverter timeConverter, ILogger<BerlinClockController> logger)
        {
            _timeConverter = timeConverter;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IClock> Get([FromQuery] string time)
        {
            try
            {
                if (time == null)
                {
                    time = DateTime.UtcNow.ToString("HH:mm:ss");
                }

                return Ok(_timeConverter.ConvertTimeToBerlinClock(time));
            }
            catch (Exception e)
            {
                _logger.LogError(e, "UtcTime conversion failed", time);
                
                return BadRequest($"UtcTime conversion failed for '{time}'." 
                                  + Environment.NewLine
                                  + "UtcTime should be supplied in HH:mm:ss format.");
            }
        }

        [HttpGet]
        [Route("internal-clock")]
        public ActionResult<string> Get()
        {
            try
            {
                var time = DateTime.UtcNow.ToString("HH:mm:ss");

                return _timeConverter.ConvertTime(time);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "UtcTime conversion failed");

                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
