namespace BerlinClockAPI.Domain.Models.Rules
{
    using System;
    using Interfaces;

    internal class BottomHoursRowRule : IRowRule
    {
        public Func<int, int, LampLight> Rule => (hours, index) => (index + 1) <= hours % 5 ? LampLight.Red : LampLight.Off;
    }
}
