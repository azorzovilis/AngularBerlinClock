namespace BerlinClockAPI.Services.Interfaces
{
    using System;
    using Domain.Interfaces;

    public interface IBerlinClockContext
    {
        IClock SetBerlinClockTime(TimeSpan time);

        IClock GetBerlinClock();
    }
}