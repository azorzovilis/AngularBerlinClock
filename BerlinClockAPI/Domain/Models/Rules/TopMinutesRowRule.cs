namespace BerlinClockAPI.Domain.Models.Rules
{
    using System;
    using Interfaces;

    internal class TopMinutesRowRule : IRowRule
    {
        private readonly Func<int, bool> _isThirdLamp = i => i == (3 - 1) || i == (6 - 1) || i == (9 - 1);

        public Func<int, int, Lamp> Rule => 
            (minutes, index) => 
            minutes / (5 * (index + 1)) >= 1 
                ? _isThirdLamp(index) ? new Lamp(LampLight.Red, true) : new Lamp(LampLight.Yellow, true) 
                : _isThirdLamp(index) ? new Lamp(LampLight.Red, false) : new Lamp(LampLight.Yellow, false);
    }
}
