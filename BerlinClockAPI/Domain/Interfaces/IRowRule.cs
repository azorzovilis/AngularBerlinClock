using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("BerlinClockAPI.UnitTests")]
namespace BerlinClockAPI.Domain.Interfaces
{
    using System;
    using Models;

    internal interface IRowRule
    {
        Func<int, int, Lamp> Rule { get; }
    }
}
