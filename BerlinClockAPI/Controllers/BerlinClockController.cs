namespace BerlinClockAPI.Controllers
{
    using System;
    using Domain.Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Services.Interfaces;

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
        public IClock Get(string time)
        {
            try
            {
                return _timeConverter.ConvertTimeToBerlinClock(time);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Time conversion failed", time);
                throw;
            }
        }
    }
}
