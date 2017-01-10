using OOPTeamwork.Models.Contracts;
using OOPTeamwork.Models.Enums;

namespace OOPTeamwork.Core.Contracts
{
    public interface ILevelFactory
    {
        ILevel GetLevel(int level);
    }
}