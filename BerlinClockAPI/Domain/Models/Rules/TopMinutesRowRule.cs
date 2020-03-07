namespace BerlinClockAPI.Domain.Models.Rules
{
    using System;
    using Interfaces;

    internal class TopMinutesRowRule : IRowRule
    {
        public Func<int, int, LampLight> Rule => (minutes, index) => 
            minutes / (5 * (index + 1)) >= 1 
                ? ((index == (3 - 1) || index == (6 - 1) || index == (9 - 1)) ? LampLight.Red : LampLight.Yellow) 
                : LampLight.Off;
    }
}
