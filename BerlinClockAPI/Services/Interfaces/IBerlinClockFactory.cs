namespace BerlinClockAPI.Services.Interfaces
{
    using System;
    using Domain.Interfaces;

    public interface IBerlinClockFactory
    {
        IClock GenerateBerlinClock(TimeSpan time);
    }
}