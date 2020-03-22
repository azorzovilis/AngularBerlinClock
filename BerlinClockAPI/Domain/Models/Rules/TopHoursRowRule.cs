namespace BerlinClockAPI.Domain.Models.Rules
{
    using System;
    using Interfaces;

    internal class TopHoursRowRule : IRowRule
    {
        public Func<int, int, Lamp> Rule => 
            (hours, index) => 
                hours / (5 * (index + 1)) >= 1
                    ? new Lamp(LampLight.Red, true)
                    : new Lamp(LampLight.Red, false);
    }
}
