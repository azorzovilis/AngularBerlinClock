namespace BerlinClockAPI.Services
{
    using System;
    using System.Linq;
    using BerlinClockAPI.Domain.Interfaces;
    using Interfaces;

    public class TimeConverter : ITimeConverter
    {
        private readonly IBerlinClockContext _berlinClockContext;
        private readonly ITimeValidator _timeValidator;

        public TimeConverter(IBerlinClockContext berlinClockContext, ITimeValidator timeValidator)
        {
            _berlinClockContext = berlinClockContext;
            _timeValidator = timeValidator;
        }

        public string ConvertTime(string time)
        {
            return ConvertTimeToBerlinClock(time).ToString();
        }

        public IClock ConvertTimeToBerlinClock(string time)
        {
            if (!_timeValidator.IsValidTime(time))
            {
                throw new ArgumentException($"{time} is an invalid time", time);
            }

            var parsedTime = ParseGivenTime(time);
            _berlinClockContext.SetBerlinClockTime(parsedTime);

            return _berlinClockContext.GetBerlinClock();
        }

        private TimeSpan ParseGivenTime(string time)
        {
            var timeArray = time.Split(':').Select(int.Parse).ToArray();
            return new TimeSpan(timeArray[0], timeArray[1], timeArray[2]);
        }
    }
}