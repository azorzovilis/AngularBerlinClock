namespace BerlinClockAPI.Domain.Models
{
    using Interfaces;
    using System.Text;

    internal class Clock : IClock
    {
        private const int NUMBER_OF_ROWS = 5;

        internal Clock()
        {
            BerlinClock = new LampRow[NUMBER_OF_ROWS];
        }

        public LampRow[] BerlinClock { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Join(string.Empty, BerlinClock[0].ToString()));
            sb.AppendLine(string.Join(string.Empty, BerlinClock[1].ToString()));
            sb.AppendLine(string.Join(string.Empty, BerlinClock[2].ToString()));
            sb.AppendLine(string.Join(string.Empty, BerlinClock[3].ToString()));
            sb.Append(string.Join(string.Empty, BerlinClock[4].ToString()));

            return sb.ToString();
        }
    }
}