using OOPTeamwork.Models.Contracts;

namespace OOPTeamwork.Models.GameAbstracts
{
    public abstract class Player : IPlayer
    {
        private int playerIndex;

        private char playerSymbol;

        public Player(int playerIndex, char playerSymbol)
        {
            this.PlayerIndex = playerIndex;
            this.PlayerSymbol = playerSymbol;
        }

        public int PlayerIndex
        {
            get
            {
                return this.playerIndex;
            }

            private set
            {
                this.playerIndex = value;
            }
        }

        public char PlayerSymbol
        {
            get
            {
                return this.playerSymbol;                
            }

            private set
            {
                this.playerSymbol = value;
            }
        }

        public abstract void PlayerNextMove();
            
    }
}
