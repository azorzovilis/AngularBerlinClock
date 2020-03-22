namespace BerlinClockAPI.Domain.Models.Rules
{
    using System;
    using Interfaces;

    internal class BottomHoursRowRule : IRowRule
    {
        public Func<int, int, Lamp> Rule => 
            (hours, index) => 
                index + 1 <= hours % 5 
                    ? new Lamp(LampLight.Red, true) 
                    : new Lamp(LampLight.Red, false);
    }
}
