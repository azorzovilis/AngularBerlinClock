using System;
using BerlinClockAPI.Domain.Interfaces;

namespace BerlinClockAPI.Domain.Models.Rules
{
    internal class TopSecondsRowRule : IRule
    {
        public Func<int, int, LampLight> LampRule => (seconds, index) => seconds % 2 == 0 ? LampLight.Yellow : LampLight.Off;
    }
}
