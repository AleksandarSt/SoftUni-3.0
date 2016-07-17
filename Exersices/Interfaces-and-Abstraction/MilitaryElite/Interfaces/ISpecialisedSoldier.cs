using MilitaryElite.Models;

namespace MilitaryElite.Interfaces
{
    public interface ISpecialisedSoldier:IPrivate
    {
        CorpTypes CorpType { get; }
    }
}
