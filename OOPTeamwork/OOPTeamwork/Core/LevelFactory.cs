using OOPTeamwork.Core.Contracts;
using OOPTeamwork.Core.Exceptions;
using OOPTeamwork.Core.Providers;
using OOPTeamwork.Models.Contracts;
using OOPTeamwork.Models.Enums;
using OOPTeamwork.Models.Levels;

namespace OOPTeamwork.Core
{
    public class LevelFactory : ILevelFactory
    {
        public ILevel GetLevel(int level)
        {
            switch (level)
            {
                case (int)LevelType.Оne:
                    return new FirstLevel(GameField.Instance, new ConsoleWriterProvider(), new ConsoleReaderProvider());
                case (int)LevelType.Тwo:
                    return new SecondLevel(GameField.Instance, new ConsoleWriterProvider(), new ConsoleReaderProvider());
                default: throw new InvalidLevelSelectException("Incorect level selection");
            }
        }
    }
}
    

