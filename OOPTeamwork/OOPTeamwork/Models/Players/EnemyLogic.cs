using System;
using System.Collections.Generic;
using System.Linq;
using OOPTeamwork.Models.Contracts;
using OOPTeamwork.Models.GameAbstracts;
using System.Threading;
using OOPTeamwork.Common;

namespace OOPTeamwork.Core
{
    public class EnemyLogic : Player, IEnemy
    {
        private readonly ICollection<int> computerMoves = new List<int>();

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
 
            if (computerMoves.Count == 0)

            {
                this.Position = Constants.InitialPositionEnemy;

                if (GameLogic.CheckIfPositionIsTaken(Position + 1) == false)
                {
                    GameField.Instance.InputSelection[Position] = Constants.FirstPlayerSymbol;
                }
                else
                {
                    GameField.Instance.InputSelection[Position + 1] = Constants.FirstPlayerSymbol;
                }
                computerMoves.Add(Position);
            }
            else if (computerMoves.Count() > 0)
            {
                Position = computerMoves.Last();

                if (computerMoves.Last() == 0)
                {
                    if (GameLogic.CheckIfPositionIsTaken(Position + 2) == false &&
                        (GameLogic.CheckIfPositionIsTaken(Position + 3) == false ||
                         GameField.Instance.InputSelection[Position + 2] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position + 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 5) == false &&
                             (GameLogic.CheckIfPositionIsTaken(Position + 9) == false ||
                              GameField.Instance.InputSelection[Position + 8] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position + 4] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 4) == false &&
                             (GameLogic.CheckIfPositionIsTaken(Position + 7) == false ||
                              GameField.Instance.InputSelection[Position + 6] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position + 3] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 3);
                    }

                    else if (GameLogic.CheckIfPositionIsTaken(Position + 3) == false)
                    {

                        GameField.Instance.InputSelection[Position + 2] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 2);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 7) == false)
                    {
                        GameField.Instance.InputSelection[Position + 6] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 6);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 9) == false)
                    {
                        GameField.Instance.InputSelection[Position + 8] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 8);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 6) == false)
                    {

                        GameField.Instance.InputSelection[Position + 5] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 5);

                    }

                    else if (GameLogic.CheckIfPositionIsTaken(8) == false)
                    {
                        GameField.Instance.InputSelection[7] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 7);
                    }

                }
                else if (computerMoves.Last() == 1)
                {
                    if (GameLogic.CheckIfPositionIsTaken(Position + 2) == false &&
                        (GameLogic.CheckIfPositionIsTaken(Position) == false ||
                         GameField.Instance.InputSelection[Position - 1] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position + 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 4) == false &&
                             (GameLogic.CheckIfPositionIsTaken(Position + 7) == false ||
                              GameField.Instance.InputSelection[Position + 6] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position + 3] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(7) == false)
                    {
                        GameField.Instance.InputSelection[6] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 6);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position) == false)
                    {

                        GameField.Instance.InputSelection[Position - 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 3) == false)
                    {

                        GameField.Instance.InputSelection[Position + 2] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 2);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 5) == false)
                    {

                        GameField.Instance.InputSelection[Position + 4] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 4);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 7) == false)
                    {

                        GameField.Instance.InputSelection[Position + 6] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 6);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 6) == false)
                    {

                        GameField.Instance.InputSelection[Position + 5] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 5);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 8) == false)
                    {

                        GameField.Instance.InputSelection[Position + 7] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 7);

                    }

                }
                else if (computerMoves.Last() == 2)
                {
                    if (GameLogic.CheckIfPositionIsTaken(Position + 4) == false &&
                        (GameLogic.CheckIfPositionIsTaken(Position + 7) == false ||
                         GameField.Instance.InputSelection[Position + 6] == Constants.FirstPlayerSymbol))
                    {

                        GameField.Instance.InputSelection[Position + 3] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 3);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 3) == false &&
                             (GameLogic.CheckIfPositionIsTaken(Position + 5) == false ||
                              GameField.Instance.InputSelection[Position + 4] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position + 2] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position) == false &&
                             (GameLogic.CheckIfPositionIsTaken(Position - 1) == false ||
                              GameField.Instance.InputSelection[Position - 2] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position - 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 5) == false)
                    {

                        GameField.Instance.InputSelection[Position + 4] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 7) == false)
                    {

                        GameField.Instance.InputSelection[Position + 6] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 6);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 3) == false)
                    {

                        GameField.Instance.InputSelection[Position - 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 2);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 2) == false)
                    {

                        GameField.Instance.InputSelection[Position + 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 6) == false)
                    {

                        GameField.Instance.InputSelection[Position + 5] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 5);

                    }

                }
                else if (computerMoves.Last() == 3)
                {
                    if (GameLogic.CheckIfPositionIsTaken(Position + 2) == false &&
                        (GameLogic.CheckIfPositionIsTaken(Position + 3) == false ||
                         GameField.Instance.InputSelection[Position + 2] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position + 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 4) == false &&
                             (GameLogic.CheckIfPositionIsTaken(Position - 2) == false ||
                              GameField.Instance.InputSelection[Position - 3] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position + 3] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 3) == false)
                    {

                        GameField.Instance.InputSelection[Position + 2] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 2);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 2) == false)
                    {

                        GameField.Instance.InputSelection[Position - 3] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 3);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 5) == false)
                    {

                        GameField.Instance.InputSelection[Position + 4] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 4);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 1) == false)
                    {

                        GameField.Instance.InputSelection[Position - 2] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 2);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position) == false)
                    {

                        GameField.Instance.InputSelection[Position - 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 6) == false)
                    {

                        GameField.Instance.InputSelection[Position + 5] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 5);

                    }


                }
                else if (computerMoves.Last() == 4)
                {
                    if (GameLogic.CheckIfPositionIsTaken(Position + 2) == false &&
                        (GameLogic.CheckIfPositionIsTaken(Position) == false ||//!!!!
                         GameField.Instance.InputSelection[Position - 1] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position + 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 4) == false &&
                             (GameLogic.CheckIfPositionIsTaken(Position - 2) == false ||
                              GameField.Instance.InputSelection[Position - 3] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position + 3] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 5) == false &&
                             (GameLogic.CheckIfPositionIsTaken(Position - 3) == false ||
                              GameField.Instance.InputSelection[Position - 4] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position + 4] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position) == false)
                    {

                        GameField.Instance.InputSelection[Position - 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 2) == false)
                    {

                        GameField.Instance.InputSelection[Position - 3] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 3) == false)
                    {

                        GameField.Instance.InputSelection[Position - 4] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 4);
                    }

                    else if (GameLogic.CheckIfPositionIsTaken(Position - 1) == false)
                    {

                        GameField.Instance.InputSelection[Position - 2] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 2);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 3) == false)
                    {

                        GameField.Instance.InputSelection[Position + 2] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 2);


                    }
                }
                else if (computerMoves.Last() == 5)
                {
                    if (GameLogic.CheckIfPositionIsTaken(Position) == false &&
                        (GameLogic.CheckIfPositionIsTaken(Position - 1) == false ||
                         GameField.Instance.InputSelection[Position - 2] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position - 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(Position - 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 4) == false &&
                             (GameLogic.CheckIfPositionIsTaken(Position - 2) == false ||
                              GameField.Instance.InputSelection[Position - 3] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position + 3] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 1) == false)
                    {

                        GameField.Instance.InputSelection[Position - 2] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 2);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 2) == false)
                    {

                        GameField.Instance.InputSelection[Position - 3] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 3) == false)
                    {

                        GameField.Instance.InputSelection[Position + 2] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 2);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 2) == false)
                    {

                        GameField.Instance.InputSelection[Position + 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 4) == false)
                    {

                        GameField.Instance.InputSelection[Position - 5] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 5);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 3) == false)
                    {

                        GameField.Instance.InputSelection[Position - 4] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 4);
                    }

                }
                else if (computerMoves.Last() == 6)
                {
                    if (GameLogic.CheckIfPositionIsTaken(Position + 2) == false &&
                        (GameLogic.CheckIfPositionIsTaken(Position + 3) == false ||
                         GameField.Instance.InputSelection[Position + 2] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position + 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 1) == false &&
                             (GameLogic.CheckIfPositionIsTaken(Position - 3) == false ||
                              GameField.Instance.InputSelection[Position - 4] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position - 2] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 5) == false &&
                             (GameLogic.CheckIfPositionIsTaken(Position - 2) == false ||
                              GameField.Instance.InputSelection[Position - 3] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position - 6] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 6);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 4) == false)
                    {

                        GameField.Instance.InputSelection[Position + 3] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position + 3) == false)
                    {

                        GameField.Instance.InputSelection[Position + 2] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 3) == false)
                    {

                        GameField.Instance.InputSelection[Position - 4] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 4) == false)
                    {

                        GameField.Instance.InputSelection[Position - 5] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 5);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position) == false)
                    {

                        GameField.Instance.InputSelection[Position - 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 1);
                    }

                }
                else if (computerMoves.Last() == 7)
                {
                    if (GameLogic.CheckIfPositionIsTaken(Position + 2) == false &&
                        (GameLogic.CheckIfPositionIsTaken(Position) == false ||
                         GameField.Instance.InputSelection[Position - 1] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position + 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() + 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 2) == false &&
                             (GameLogic.CheckIfPositionIsTaken(Position - 5) == false ||
                              GameField.Instance.InputSelection[Position - 6] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position - 3] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position) == false)
                    {

                        GameField.Instance.InputSelection[Position - 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 5) == false)
                    {

                        GameField.Instance.InputSelection[Position - 6] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 6);
                    }

                    else if (GameLogic.CheckIfPositionIsTaken(Position - 4) == false)
                    {

                        GameField.Instance.InputSelection[Position - 5] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 5);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 3) == false)
                    {

                        GameField.Instance.InputSelection[Position - 4] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 6) == false)
                    {

                        GameField.Instance.InputSelection[Position - 7] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 7);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 1) == false)
                    {

                        GameField.Instance.InputSelection[Position - 2] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 2);

                    }

                }
                else if (computerMoves.Last() == 8)
                {
                    if (GameLogic.CheckIfPositionIsTaken(Position) == false &&
                        (GameLogic.CheckIfPositionIsTaken(Position - 1) == false ||
                         GameField.Instance.InputSelection[Position - 2] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position - 1] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 3) == false &&
                             (GameLogic.CheckIfPositionIsTaken(Position - 7) == false ||
                              GameField.Instance.InputSelection[Position - 8] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position - 4] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 2) == false &&
                             (GameLogic.CheckIfPositionIsTaken(Position - 5) == false ||
                              GameField.Instance.InputSelection[Position - 6] == Constants.FirstPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[Position - 3] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 1) == false)
                    {

                        GameField.Instance.InputSelection[Position - 2] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 2);

                    }

                    else if (GameLogic.CheckIfPositionIsTaken(Position - 5) == false)
                    {

                        GameField.Instance.InputSelection[Position - 6] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 6);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 2) == false)
                    {

                        GameField.Instance.InputSelection[Position - 3] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 4) == false)
                    {

                        GameField.Instance.InputSelection[Position - 5] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 5);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(Position - 6) == false)
                    {

                        GameField.Instance.InputSelection[Position - 7] = Constants.FirstPlayerSymbol;
                        computerMoves.Add(computerMoves.Last() - 7);
                    }
                }
            }
        }
    }
}

