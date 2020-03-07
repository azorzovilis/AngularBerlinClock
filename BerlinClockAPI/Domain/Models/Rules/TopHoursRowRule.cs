namespace BerlinClockAPI.Domain.Models.Rules
{
    using System;
    using Interfaces;

    internal class TopHoursRowRule : IRowRule
    {
        public Func<int, int, LampLight> Rule => (hours, index) => hours / (5 * (index + 1)) >= 1 ? LampLight.Red : LampLight.Off;
    }
}
