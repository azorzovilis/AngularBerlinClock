namespace BerlinClockAPI.Domain.Models.Rules
{
    using System;
    using Interfaces;

    internal class BottomMinutesRowRule : IRowRule
    {
        public Func<int, int, LampLight> Rule => (minutes, index) => (index + 1) <= minutes % 5 ? LampLight.Yellow : LampLight.Off;
    }
}
