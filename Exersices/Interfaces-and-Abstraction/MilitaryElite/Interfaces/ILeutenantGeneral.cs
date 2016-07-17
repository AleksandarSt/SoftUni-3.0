using System.Collections.Generic;
using MilitaryElite.Models;

namespace MilitaryElite.Interfaces
{
    public interface ILeutenantGeneral : IPrivate
    {
        Dictionary<int, Private> Army { get; }
    }
}
