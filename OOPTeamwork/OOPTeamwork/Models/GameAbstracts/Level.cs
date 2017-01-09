using OOPTeamwork.Core.Contracts;
using OOPTeamwork.Models.Contracts;

namespace OOPTeamwork.Models.GameAbstracts
{
    public abstract class Level : ILevel
    {
        protected Level(IGameField gameField, IWriter writer, IReader reader)
        {
            this.GameField = gameField;
            this.Writer = writer;
            this.Reader = reader;
        }

        protected IGameField GameField { get; }

        protected IWriter Writer { get; }

        protected IReader Reader { get; }

        public abstract void StartLevel();
    }
}
