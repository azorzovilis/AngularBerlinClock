using System.Text;
using BerlinClockAPI.Domain.Interfaces;

namespace BerlinClockAPI.Domain.Models
{
    internal class Clock : IClock
    {
        internal Clock()
        {
            TopSecondsRow = new LampRow();
            TopMinutesRow = new LampRow();
            BottomMinutesRow = new LampRow();
            TopHoursRow = new LampRow();
            BottomHoursRow = new LampRow();
        }

        public LampRow TopSecondsRow { get; set; }
        public LampRow TopMinutesRow { get; set; }
        public LampRow BottomMinutesRow { get; set; }
        public LampRow TopHoursRow { get; set; }
        public LampRow BottomHoursRow { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Join(string.Empty, TopSecondsRow.ToString()));
            sb.AppendLine(string.Join(string.Empty, TopHoursRow.ToString()));
            sb.AppendLine(string.Join(string.Empty, BottomHoursRow.ToString()));
            sb.AppendLine(string.Join(string.Empty, TopMinutesRow.ToString()));
            sb.Append(string.Join(string.Empty, BottomMinutesRow.ToString()));

            return sb.ToString();
        }
    }
}