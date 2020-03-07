namespace BerlinClockAPI.Domain.Models
{
    public class Lamp
    {
        internal Lamp(LampLight light)
        {
            Light = light;
        }

        public LampLight Light { get; set; }
    }
}