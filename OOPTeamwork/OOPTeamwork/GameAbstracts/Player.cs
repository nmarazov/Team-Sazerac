using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OOPTeamwork.GameStructure;

namespace OOPTeamwork.GameAbstracts
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
