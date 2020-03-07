using System;
//using System.Runtime.CompilerServices;
using BerlinClockAPI.Domain.Models;

//[assembly: InternalsVisibleTo("UnitTests")]
namespace BerlinClockAPI.Domain.Interfaces
{
    internal interface IRule
    {
        Func<int, int, LampLight> LampRule { get; }
    }
}
