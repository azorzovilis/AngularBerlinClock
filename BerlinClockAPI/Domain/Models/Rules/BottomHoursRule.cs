using System;
using BerlinClockAPI.Domain.Interfaces;

namespace BerlinClockAPI.Domain.Models.Rules
{
    internal class BottomHoursRule : IRule
    {
        public Func<int, int, LampLight> LampRule => (hours, index) => (index + 1) <= hours % 5 ? LampLight.Red : LampLight.Off;
    }
}
