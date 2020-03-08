namespace BerlinClockAPI.Services.Interfaces
{
    using Domain.Interfaces;

    public interface ITimeConverter
    {
        string ConvertTime(string time);

        IClock ConvertTimeToBerlinClock(string time);
    }
}
