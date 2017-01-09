using OOPTeamwork.Core.Contracts;
using OOPTeamwork.Core.Exceptions;
using OOPTeamwork.Models.Contracts;
using OOPTeamwork.Models.Levels;

namespace OOPTeamwork.Core
{
    public class LevelFactory : ILevelFactory
    {
        public ILevel GetLevel(string level)
        {
            switch (level)
            {
                case "1":
                    return new FirstLevel();
                case "2":
                    return new SecondLevel();
                default:
                    throw new InvalidLevelSelectException("Incorect level selection");
            }
        }
    }
}
