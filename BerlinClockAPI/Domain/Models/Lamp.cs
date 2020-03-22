namespace BerlinClockAPI.Domain.Models
{
    public class Lamp
    {
        internal Lamp(LampLight colour, bool isSwitchedOn)
        {
            Colour = ConvertLightToString(colour);
            IsSwitchedOn = isSwitchedOn;
            Light = isSwitchedOn ? colour : LampLight.Off;
        }

        public string Colour { get; }

        public bool IsSwitchedOn { get; }

        internal LampLight Light { get; }

        internal static string ConvertLightToString(LampLight light)
        {
            return light switch
            {
                LampLight.Red => "R",
                LampLight.Yellow => "Y",
                _ => "O"
            };
        }
    }
}