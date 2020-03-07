namespace BerlinClockAPI.Services
{
    using System;
    using Domain.Interfaces;
    using Domain.Models;
    using Domain.Models.Rules;
    using Interfaces;

    public class BerlinClockFactory : IBerlinClockFactory
    {
        public IClock GenerateBerlinClock(TimeSpan time)
        {
            var parts = GetTimeParts(time);

            return new Clock
            {
                TopSecondsRow = GenerateLine(parts.Seconds, new LampRow(numberOfLamps: 1), new TopSecondsRowRule()),
                TopHoursRow = GenerateLine(parts.Hours, new LampRow(numberOfLamps: 4), new TopHoursRule()),
                BottomHoursRow = GenerateLine(parts.Hours, new LampRow(numberOfLamps: 4), new BottomHoursRule()),
                TopMinutesRow = GenerateLine(parts.Minutes, new LampRow(numberOfLamps: 11), new TopMinutesRule()),
                BottomMinutesRow = GenerateLine(parts.Minutes, new LampRow(numberOfLamps: 4), new BottomMinutesRule())
            };
        }

        private LampRow GenerateLine(int timeUnit, LampRow lampRow, IRule rule)
        {
            for (int index = 0; index < lampRow.Lamps.Length; index++)
            {
                var lightColour = rule.LampRule(timeUnit, index);
                lampRow.Lamps[index] = new Lamp(lightColour);
            }
            return lampRow;
        }

        // 24:00:00 is an exception since TimeSpan cannot represent this value
        private dynamic GetTimeParts(TimeSpan time)
        {
            return time.Days == 1
                ? new { Hours = 24, time.Minutes, time.Seconds }
                : new { time.Hours, time.Minutes, time.Seconds };
        }
    }
}
