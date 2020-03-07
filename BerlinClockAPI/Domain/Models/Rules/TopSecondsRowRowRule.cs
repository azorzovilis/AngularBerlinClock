namespace BerlinClockAPI.Domain.Models.Rules
{
    using System;
    using Interfaces;

    internal class TopSecondsRowRowRule : IRowRule
    {
        public Func<int, int, LampLight> Rule => (seconds, index) => seconds % 2 == 0 ? LampLight.Yellow : LampLight.Off;
    }
}
