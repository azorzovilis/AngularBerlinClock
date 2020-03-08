namespace BerlinClockAPI.Domain.Interfaces
{
    using Models;

    public interface IClock
    {
        public LampRow[] BerlinClock { get; set; }
    }
}