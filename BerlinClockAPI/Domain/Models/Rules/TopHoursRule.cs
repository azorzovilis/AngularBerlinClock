using System;
using BerlinClockAPI.Domain.Interfaces;

namespace BerlinClockAPI.Domain.Models.Rules
{
    internal class TopHoursRule : IRule
    {
        public Func<int, int, LampLight> LampRule => (hours, index) => hours / (5 * (index + 1)) >= 1 ? LampLight.Red : LampLight.Off;
    }
}
