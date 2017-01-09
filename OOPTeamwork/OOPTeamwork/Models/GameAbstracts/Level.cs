using OOPTeamwork.Core;
using OOPTeamwork.Models.Contracts;

namespace OOPTeamwork.Models.GameAbstracts
{
    public abstract class Level : ILevel
    {
        private readonly GameField gameField;
        public Level()
        {
            
        }

        public abstract void StartLevel();
    }
}
