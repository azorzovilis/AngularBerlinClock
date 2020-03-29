namespace BerlinClockAPI.Domain.Models
{
    using Interfaces;
    using System.Text;

    internal class Clock : IClock
    {
        private const int NUMBER_OF_ROWS = 5;

        internal Clock()
        {
            LampRows = new LampRow[NUMBER_OF_ROWS];
        }

        public string UtcTime { get; set; }

        public LampRow[] LampRows { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Join(string.Empty, LampRows[0].ToString()));
            sb.AppendLine(string.Join(string.Empty, LampRows[1].ToString()));
            sb.AppendLine(string.Join(string.Empty, LampRows[2].ToString()));
            sb.AppendLine(string.Join(string.Empty, LampRows[3].ToString()));
            sb.Append(string.Join(string.Empty, LampRows[4].ToString()));

            return sb.ToString();
        }
    }
}