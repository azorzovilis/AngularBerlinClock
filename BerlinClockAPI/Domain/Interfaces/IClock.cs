namespace BerlinClockAPI.Domain.Interfaces
{
    using Models;

    public interface IClock
    {
        public string UtcTime { get; set; }

        public LampRow[] LampRows { get; set; }
    }
}