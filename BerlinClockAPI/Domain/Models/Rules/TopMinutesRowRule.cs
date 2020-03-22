namespace BerlinClockAPI.Domain.Models.Rules
{
    using System;
    using Interfaces;

    internal class TopMinutesRowRule : IRowRule
    {
        private readonly Func<int, bool> _isThirdLamp = index => index == (3 - 1) || index == (6 - 1) || index == (9 - 1);
        private readonly Func<int, int, bool> _isSwitchedOn = (minutes, index) => minutes / (5 * (index + 1)) >= 1;

        public Func<int, int, Lamp> Rule =>
            (minutes, index) =>
                _isThirdLamp(index)
                    ? new Lamp(LampLight.Red, _isSwitchedOn(minutes, index))
                    : new Lamp(LampLight.Yellow, _isSwitchedOn(minutes, index));
    }
}
