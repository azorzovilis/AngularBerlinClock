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
                LampRows = new LampRow[]
                {
                    GenerateLine(parts.Seconds, new LampRow(numberOfLamps: 1), new TopSecondsRowRowRule()),
                    GenerateLine(parts.Hours, new LampRow(numberOfLamps: 4), new TopHoursRowRule()),
                    GenerateLine(parts.Hours, new LampRow(numberOfLamps: 4), new BottomHoursRowRule()),
                    GenerateLine(parts.Minutes, new LampRow(numberOfLamps: 11), new TopMinutesRowRule()),
                    GenerateLine(parts.Minutes, new LampRow(numberOfLamps: 4), new BottomMinutesRowRule())
                }
            };
        }

        private static LampRow GenerateLine(int timeUnit, LampRow lampRow, IRowRule rowRule)
        {
            for (var index = 0; index < lampRow.Lamps.Length; index++)
            {
                lampRow.Lamps[index] = rowRule.Rule(timeUnit, index);
            }

            return lampRow;
        }

        // 24:00:00 is an exception since TimeSpan cannot represent this value
        private static dynamic GetTimeParts(TimeSpan time)
        {
            return time.Days == 1
                ? new { Hours = 24, time.Minutes, time.Seconds }
                : new { time.Hours, time.Minutes, time.Seconds };
        }
    }
}
