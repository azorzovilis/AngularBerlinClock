namespace BerlinClockAPI.Domain.Interfaces
{
    using Models;

    public interface IClock
    {
        LampRow TopSecondsRow { get; set; }
        public LampRow TopMinutesRow { get; set; }
        public LampRow BottomMinutesRow { get; set; }
        public LampRow TopHoursRow { get; set; }
        public LampRow BottomHoursRow { get; set; }
    }
}