using System;
using BerlinClockAPI.Domain.Interfaces;

namespace BerlinClockAPI.Domain.Models.Rules
{
    internal class BottomMinutesRule : IRule
    {
        public Func<int, int, LampLight> LampRule => (minutes, index) => (index + 1) <= minutes % 5 ? LampLight.Yellow : LampLight.Off;
    }
}
