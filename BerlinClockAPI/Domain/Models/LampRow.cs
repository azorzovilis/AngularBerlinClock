using System.Linq;

namespace BerlinClockAPI.Domain.Models
{
    public class LampRow
    {
        //Create empty row
        internal LampRow()
            : this(numberOfLamps: 0)
        {
        }

        internal LampRow(int numberOfLamps)
        {
            Lamps = new Lamp[numberOfLamps];
        }

        public Lamp[] Lamps { get; set; }

        public override string ToString()
        {
            return string.Concat(Lamps.Select(lamp => (char)lamp.Light));
        }
    }
}