namespace BerlinClockAPI.Domain.Models.Rules
{
    using System;
    using Interfaces;

    internal class BottomMinutesRowRule : IRowRule
    {
        public Func<int, int, Lamp> Rule => 
            (minutes, index) => 
                index + 1 <= minutes % 5
                    ? new Lamp(LampLight.Yellow, true)
                    : new Lamp(LampLight.Yellow, false);
    }
}
