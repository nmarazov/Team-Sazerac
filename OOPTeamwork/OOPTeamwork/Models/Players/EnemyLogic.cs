using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OOPTeamwork.Common;
using OOPTeamwork.Core;
using OOPTeamwork.Models.Contracts;
using OOPTeamwork.Models.GameAbstracts;

namespace OOPTeamwork.Models.Players
{
    public class EnemyLogic : Player, IEnemy
    {
        private readonly ICollection<int> computerMoves;

        private int position;

        public EnemyLogic(int playerIndex, char playerSymbol)
            : base(playerIndex, playerSymbol)
        {
            this.computerMoves = new List<int>();
        }

        public int Position
        {
            get
            {
                return this.position;
            }

            private set
            {
                this.position = value;
            }
        }
        
        ICollection<int> IEnemy.ComputerMoves
        {
            get
            {
                return this.computerMoves;
            }
        }

        public override void PlayerNextMove()
        {
            Console.Write($"Player {this.PlayerIndex} is the computer: ");

            Thread.Sleep(1500);
 
            if (this.computerMoves.Count == 0)
            {
                this.Position = Constants.InitialPositionEnemy;

                if (GameLogic.CheckIfPositionIsTaken(this.Position + 1) == false)
                {
                    GameField.Instance.InputSelection[this.Position] = Constants.FirstPlayerSymbol;
                }
                else
                {
                    GameField.Instance.InputSelection[this.Position + 1] = Constants.FirstPlayerSymbol;
                }

                this.computerMoves.Add(this.Position);
            }
            else if (this.computerMoves.Count() > 0)
            {
                this.Position = this.computerMoves.Last();

                if (this.computerMoves.Last() == 0)
                {
                    if (GameLogic.CheckIfPositionIsTaken(this.Position + 2) == false &&
                        (GameLogic.CheckIfPositionIsTaken(this.Position + 3) == false ||
                         GameField.Instance.InputSelection[this.Position + 2] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 5) == false &&
                             (GameLogic.CheckIfPositionIsTaken(this.Position + 9) == false ||
                              GameField.Instance.InputSelection[this.Position + 8] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position + 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 4) == false &&
                             (GameLogic.CheckIfPositionIsTaken(this.Position + 7) == false ||
                              GameField.Instance.InputSelection[this.Position + 6] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position + 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 3) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 7) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 6] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 6);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 9) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 8] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 8);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 6) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 5);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(8) == false)
                    {
                        GameField.Instance.InputSelection[7] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 7);
                    }
                }
                else if (this.computerMoves.Last() == 1)
                {
                    if (GameLogic.CheckIfPositionIsTaken(this.Position + 2) == false &&
                        (GameLogic.CheckIfPositionIsTaken(this.Position) == false ||
                         GameField.Instance.InputSelection[this.Position - 1] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 4) == false &&
                             (GameLogic.CheckIfPositionIsTaken(this.Position + 7) == false ||
                              GameField.Instance.InputSelection[this.Position + 6] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position + 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(7) == false)
                    {
                        GameField.Instance.InputSelection[6] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 6);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 3) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 5) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 7) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 6] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 6);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 6) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 5);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 8) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 7] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 7);
                    }
                }
                else if (this.computerMoves.Last() == 2)
                {
                    if (GameLogic.CheckIfPositionIsTaken(this.Position + 4) == false &&
                        (GameLogic.CheckIfPositionIsTaken(this.Position + 7) == false ||
                         GameField.Instance.InputSelection[this.Position + 6] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position + 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 3) == false &&
                             (GameLogic.CheckIfPositionIsTaken(this.Position + 5) == false ||
                              GameField.Instance.InputSelection[this.Position + 4] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position + 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position) == false &&
                             (GameLogic.CheckIfPositionIsTaken(this.Position - 1) == false ||
                              GameField.Instance.InputSelection[this.Position - 2] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 5) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 7) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 6] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 6);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 3) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 2) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 6) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 5);
                    }
                }
                else if (this.computerMoves.Last() == 3)
                {
                    if (GameLogic.CheckIfPositionIsTaken(this.Position + 2) == false &&
                        (GameLogic.CheckIfPositionIsTaken(this.Position + 3) == false ||
                         GameField.Instance.InputSelection[this.Position + 2] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 4) == false &&
                             (GameLogic.CheckIfPositionIsTaken(this.Position - 2) == false ||
                              GameField.Instance.InputSelection[this.Position - 3] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position + 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 3) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 2) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 5) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 1) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 6) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 5);
                    }
                }
                else if (this.computerMoves.Last() == 4)
                {
                    if (GameLogic.CheckIfPositionIsTaken(this.Position + 2) == false &&
                        (GameLogic.CheckIfPositionIsTaken(this.Position) == false || //!!!!
                         GameField.Instance.InputSelection[this.Position - 1] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 4) == false &&
                             (GameLogic.CheckIfPositionIsTaken(this.Position - 2) == false ||
                              GameField.Instance.InputSelection[this.Position - 3] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position + 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 5) == false &&
                             (GameLogic.CheckIfPositionIsTaken(this.Position - 3) == false ||
                              GameField.Instance.InputSelection[this.Position - 4] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position + 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 2) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 3) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 1) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 3) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 2);
                    }
                }
                else if (this.computerMoves.Last() == 5)
                {
                    if (GameLogic.CheckIfPositionIsTaken(this.Position) == false &&
                        (GameLogic.CheckIfPositionIsTaken(this.Position - 1) == false ||
                         GameField.Instance.InputSelection[this.Position - 2] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.Position - 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 4) == false &&
                             (GameLogic.CheckIfPositionIsTaken(this.Position - 2) == false ||
                              GameField.Instance.InputSelection[this.Position - 3] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position + 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 1) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 2) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 3) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 2) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 4) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 5);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 3) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 4);
                    }
                }
                else if (this.computerMoves.Last() == 6)
                {
                    if (GameLogic.CheckIfPositionIsTaken(this.Position + 2) == false &&
                        (GameLogic.CheckIfPositionIsTaken(this.Position + 3) == false ||
                         GameField.Instance.InputSelection[this.Position + 2] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 1) == false &&
                             (GameLogic.CheckIfPositionIsTaken(this.Position - 3) == false ||
                              GameField.Instance.InputSelection[this.Position - 4] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 5) == false &&
                             (GameLogic.CheckIfPositionIsTaken(this.Position - 2) == false ||
                              GameField.Instance.InputSelection[this.Position - 3] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position - 6] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 6);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 4) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position + 3) == false)
                    {
                        GameField.Instance.InputSelection[this.Position + 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 3) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 4) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 5);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 1);
                    }
                }
                else if (this.computerMoves.Last() == 7)
                {
                    if (GameLogic.CheckIfPositionIsTaken(this.Position + 2) == false &&
                        (GameLogic.CheckIfPositionIsTaken(this.Position) == false ||
                         GameField.Instance.InputSelection[this.Position - 1] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 2) == false &&
                             (GameLogic.CheckIfPositionIsTaken(this.Position - 5) == false ||
                              GameField.Instance.InputSelection[this.Position - 6] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 5) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 6] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 6);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 4) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 5);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 3) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 6) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 7] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 7);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 1) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 2);
                    }
                }
                else if (this.computerMoves.Last() == 8)
                {
                    if (GameLogic.CheckIfPositionIsTaken(this.Position) == false &&
                        (GameLogic.CheckIfPositionIsTaken(this.Position - 1) == false ||
                         GameField.Instance.InputSelection[this.Position - 2] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 3) == false &&
                             (GameLogic.CheckIfPositionIsTaken(this.Position - 7) == false ||
                              GameField.Instance.InputSelection[this.Position - 8] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position - 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 2) == false &&
                             (GameLogic.CheckIfPositionIsTaken(this.Position - 5) == false ||
                              GameField.Instance.InputSelection[this.Position - 6] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[this.Position - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 1) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 5) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 6] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 6);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 2) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 4) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 5);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(this.Position - 6) == false)
                    {
                        GameField.Instance.InputSelection[this.Position - 7] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 7);
                    }
                }
            }
        }
    }
}