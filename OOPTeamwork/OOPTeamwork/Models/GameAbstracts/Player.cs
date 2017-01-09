using OOPTeamwork.Models.Contracts;

namespace OOPTeamwork.Models.GameAbstracts
{
    public abstract class Player : IPlayer
    {
        private int playerIndex;

        public int PlayerIndex
        {
            get
            {
                return this.playerIndex;
            }

            protected set
            {
                this.playerIndex = value;
            }
        }

        public abstract void PlayerNextMove();
            
    }
}
