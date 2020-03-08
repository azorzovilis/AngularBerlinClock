namespace BerlinClockAPI.Domain.Models.Rules
{
    using System;
    using Interfaces;

    internal class TopSecondsRowRowRule : IRowRule
    {
        public Func<int, int, Lamp> Rule => 
            (seconds, index) => 
                seconds % 2 == 0
                    ? new Lamp(LampLight.Yellow, true)
                    : new Lamp(LampLight.Yellow, false);
    }
}
