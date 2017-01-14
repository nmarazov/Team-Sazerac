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
    public class Enemy : Player, IEnemy
    {
        private readonly ICollection<int> computerMoves;

        private int pos;
        char X = Constants.FirstPlayerSymbol;
        char[] board = GameField.Instance.InputSelection;

        public Enemy(int playerIndex, char playerSymbol)
            : base(playerIndex, playerSymbol)
        {
            this.computerMoves = new List<int>();
        }

        public int Position
        {
            get
            {
                return this.pos;
            }

            private set
            {
                this.pos = value;
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
                pos = Constants.InitialPositionEnemy;

                if (GameLogic.IsPosTaken(pos + 1) == false)
                {
                    board[pos] = X;
                }
                else
                {
                    board[pos + 1] = X;
                }

                this.computerMoves.Add(pos);
            }
            else if (this.computerMoves.Count() > 0)
            {
                pos = this.computerMoves.Last();

                if (this.computerMoves.Last() == 0)
                {
                    if (GameLogic.IsPosTaken(pos + 2) == false &&
                        (GameLogic.IsPosTaken(pos + 3) == false ||
                         board[pos + 2] == X))
                    {
                        board[pos + 1] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.IsPosTaken(pos + 5) == false &&
                             (GameLogic.IsPosTaken(pos + 9) == false ||
                              board[pos + 8] == X))
                    {
                        board[pos + 4] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 4);
                    }
                    else if (GameLogic.IsPosTaken(pos + 4) == false &&
                             (GameLogic.IsPosTaken(pos + 7) == false ||
                              board[pos + 6] == X))
                    {
                        board[pos + 3] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 3);
                    }
                    else if (GameLogic.IsPosTaken(pos + 3) == false)
                    {
                        board[pos + 2] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 2);
                    }
                    else if (GameLogic.IsPosTaken(pos + 7) == false)
                    {
                        board[pos + 6] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 6);
                    }
                    else if (GameLogic.IsPosTaken(pos + 9) == false)
                    {
                        board[pos + 8] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 8);
                    }
                    else if (GameLogic.IsPosTaken(pos + 6) == false)
                    {
                        board[pos + 5] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 5);
                    }
                    else if (GameLogic.IsPosTaken(8) == false)
                    {
                        board[7] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 7);
                    }
                }
                else if (this.computerMoves.Last() == 1)
                {
                    if (GameLogic.IsPosTaken(pos + 2) == false &&
                        (GameLogic.IsPosTaken(pos) == false ||
                         board[pos - 1] == X))
                    {
                        board[pos + 1] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.IsPosTaken(pos + 4) == false &&
                             (GameLogic.IsPosTaken(pos + 7) == false ||
                              board[pos + 6] == X))
                    {
                        board[pos + 3] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 3);
                    }
                    else if (GameLogic.IsPosTaken(7) == false)
                    {
                        board[6] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 6);
                    }
                    else if (GameLogic.IsPosTaken(pos) == false)
                    {
                        board[pos - 1] = X;
                        this.computerMoves.Add(this.computerMoves.Last() - 1);
                    }
                    else if (GameLogic.IsPosTaken(pos + 3) == false)
                    {
                        board[pos + 2] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 2);
                    }
                    else if (GameLogic.IsPosTaken(pos + 5) == false)
                    {
                        board[pos + 4] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 4);
                    }
                    else if (GameLogic.IsPosTaken(pos + 7) == false)
                    {
                        board[pos + 6] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 6);
                    }
                    else if (GameLogic.IsPosTaken(pos + 6) == false)
                    {
                        board[pos + 5] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 5);
                    }
                    else if (GameLogic.IsPosTaken(pos + 8) == false)
                    {
                        board[pos + 7] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 7);
                    }
                }
                else if (this.computerMoves.Last() == 2)
                {
                    if (GameLogic.IsPosTaken(pos + 4) == false &&
                        (GameLogic.IsPosTaken(pos + 7) == false ||
                         board[pos + 6] == X))
                    {
                        board[pos + 3] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 3);
                    }
                    else if (GameLogic.IsPosTaken(pos + 3) == false &&
                             (GameLogic.IsPosTaken(pos + 5) == false ||
                              board[pos + 4] == X))
                    {
                        board[pos + 2] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 2);
                    }
                    else if (GameLogic.IsPosTaken(pos) == false &&
                             (GameLogic.IsPosTaken(pos - 1) == false ||
                              board[pos - 2] == X))
                    {
                        board[pos - 1] = X;
                        this.computerMoves.Add(this.computerMoves.Last() - 1);
                    }
                    else if (GameLogic.IsPosTaken(pos + 5) == false)
                    {
                        board[pos + 4] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 4);
                    }
                    else if (GameLogic.IsPosTaken(pos + 7) == false)
                    {
                        board[pos + 6] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 6);
                    }
                    else if (GameLogic.IsPosTaken(pos - 3) == false)
                    {
                        board[pos - 1] = X;
                        this.computerMoves.Add(this.computerMoves.Last() - 2);
                    }
                    else if (GameLogic.IsPosTaken(pos + 2) == false)
                    {
                        board[pos + 1] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.IsPosTaken(pos + 6) == false)
                    {
                        board[pos + 5] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 5);
                    }
                }
                else if (this.computerMoves.Last() == 3)
                {
                    if (GameLogic.IsPosTaken(pos + 2) == false &&
                        (GameLogic.IsPosTaken(pos + 3) == false ||
                         board[pos + 2] == X))
                    {
                        board[pos + 1] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.IsPosTaken(pos + 4) == false &&
                             (GameLogic.IsPosTaken(pos - 2) == false ||
                              board[pos - 3] == X))
                    {
                        board[pos + 3] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 3);
                    }
                    else if (GameLogic.IsPosTaken(pos + 3) == false)
                    {
                        board[pos + 2] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 2);
                    }
                    else if (GameLogic.IsPosTaken(pos - 2) == false)
                    {
                        board[pos - 3] = X;
                        this.computerMoves.Add(this.computerMoves.Last() - 3);
                    }
                    else if (GameLogic.IsPosTaken(pos + 5) == false)
                    {
                        board[pos + 4] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 4);
                    }
                    else if (GameLogic.IsPosTaken(pos - 1) == false)
                    {
                        board[pos - 2] = X;
                        this.computerMoves.Add(this.computerMoves.Last() - 2);
                    }
                    else if (GameLogic.IsPosTaken(pos) == false)
                    {
                        board[pos - 1] = X;
                        this.computerMoves.Add(this.computerMoves.Last() - 1);
                    }
                    else if (GameLogic.IsPosTaken(pos + 6) == false)
                    {
                        board[pos + 5] = X;
                        this.computerMoves.Add(this.computerMoves.Last() + 5);
                    }
                }
                else if (this.computerMoves.Last() == 4)
                {
                    if (GameLogic.IsPosTaken(pos + 2) == false &&
                        (GameLogic.IsPosTaken(pos) == false || //!!!!
                         board[pos - 1] == Constants.FirstPlayerSymbol))
                    {
                        board[pos + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.IsPosTaken(pos + 4) == false &&
                             (GameLogic.IsPosTaken(pos - 2) == false ||
                              board[pos - 3] == Constants.FirstPlayerSymbol))
                    {
                        board[pos + 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 3);
                    }
                    else if (GameLogic.IsPosTaken(pos + 5) == false &&
                             (GameLogic.IsPosTaken(pos - 3) == false ||
                              board[pos - 4] == Constants.FirstPlayerSymbol))
                    {
                        board[pos + 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 4);
                    }
                    else if (GameLogic.IsPosTaken(pos) == false)
                    {
                        board[pos - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 1);
                    }
                    else if (GameLogic.IsPosTaken(pos - 2) == false)
                    {
                        board[pos - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 3);
                    }
                    else if (GameLogic.IsPosTaken(pos - 3) == false)
                    {
                        board[pos - 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 4);
                    }
                    else if (GameLogic.IsPosTaken(pos - 1) == false)
                    {
                        board[pos - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 2);
                    }
                    else if (GameLogic.IsPosTaken(pos + 3) == false)
                    {
                        board[pos + 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 2);
                    }
                }
                else if (this.computerMoves.Last() == 5)
                {
                    if (GameLogic.IsPosTaken(pos) == false &&
                        (GameLogic.IsPosTaken(pos - 1) == false ||
                         board[pos - 2] == Constants.FirstPlayerSymbol))
                    {
                        board[pos - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(pos - 1);
                    }
                    else if (GameLogic.IsPosTaken(pos + 4) == false &&
                             (GameLogic.IsPosTaken(pos - 2) == false ||
                              board[pos - 3] == Constants.FirstPlayerSymbol))
                    {
                        board[pos + 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 3);
                    }
                    else if (GameLogic.IsPosTaken(pos - 1) == false)
                    {
                        board[pos - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 2);
                    }
                    else if (GameLogic.IsPosTaken(pos - 2) == false)
                    {
                        board[pos - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 3);
                    }
                    else if (GameLogic.IsPosTaken(pos + 3) == false)
                    {
                        board[pos + 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 2);
                    }
                    else if (GameLogic.IsPosTaken(pos + 2) == false)
                    {
                        board[pos + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.IsPosTaken(pos - 4) == false)
                    {
                        board[pos - 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 5);
                    }
                    else if (GameLogic.IsPosTaken(pos - 3) == false)
                    {
                        board[pos - 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 4);
                    }
                }
                else if (this.computerMoves.Last() == 6)
                {
                    if (GameLogic.IsPosTaken(pos + 2) == false &&
                        (GameLogic.IsPosTaken(pos + 3) == false ||
                         board[pos + 2] == Constants.FirstPlayerSymbol))
                    {
                        board[pos + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.IsPosTaken(pos - 1) == false &&
                             (GameLogic.IsPosTaken(pos - 3) == false ||
                              board[pos - 4] == Constants.FirstPlayerSymbol))
                    {
                        board[pos - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 2);
                    }
                    else if (GameLogic.IsPosTaken(pos - 5) == false &&
                             (GameLogic.IsPosTaken(pos - 2) == false ||
                              board[pos - 3] == Constants.FirstPlayerSymbol))
                    {
                        board[pos - 6] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 6);
                    }
                    else if (GameLogic.IsPosTaken(pos + 4) == false)
                    {
                        board[pos + 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 3);
                    }
                    else if (GameLogic.IsPosTaken(pos + 3) == false)
                    {
                        board[pos + 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 2);
                    }
                    else if (GameLogic.IsPosTaken(pos - 3) == false)
                    {
                        board[pos - 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 4);
                    }
                    else if (GameLogic.IsPosTaken(pos - 4) == false)
                    {
                        board[pos - 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 5);
                    }
                    else if (GameLogic.IsPosTaken(pos) == false)
                    {
                        board[pos - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 1);
                    }
                }
                else if (this.computerMoves.Last() == 7)
                {
                    if (GameLogic.IsPosTaken(pos + 2) == false &&
                        (GameLogic.IsPosTaken(pos) == false ||
                         board[pos - 1] == Constants.FirstPlayerSymbol))
                    {
                        board[pos + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() + 1);
                    }
                    else if (GameLogic.IsPosTaken(pos - 2) == false &&
                             (GameLogic.IsPosTaken(pos - 5) == false ||
                              board[pos - 6] == Constants.FirstPlayerSymbol))
                    {
                        board[pos - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 3);
                    }
                    else if (GameLogic.IsPosTaken(pos) == false)
                    {
                        board[pos - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 1);
                    }
                    else if (GameLogic.IsPosTaken(pos - 5) == false)
                    {
                        board[pos - 6] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 6);
                    }
                    else if (GameLogic.IsPosTaken(pos - 4) == false)
                    {
                        board[pos - 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 5);
                    }
                    else if (GameLogic.IsPosTaken(pos - 3) == false)
                    {
                        board[pos - 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 4);
                    }
                    else if (GameLogic.IsPosTaken(pos - 6) == false)
                    {
                        board[pos - 7] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 7);
                    }
                    else if (GameLogic.IsPosTaken(pos - 1) == false)
                    {
                        board[pos - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 2);
                    }
                }
                else if (this.computerMoves.Last() == 8)
                {
                    if (GameLogic.IsPosTaken(pos) == false &&
                        (GameLogic.IsPosTaken(pos - 1) == false ||
                         board[pos - 2] == Constants.FirstPlayerSymbol))
                    {
                        board[pos - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 1);
                    }
                    else if (GameLogic.IsPosTaken(pos - 3) == false &&
                             (GameLogic.IsPosTaken(pos - 7) == false ||
                              board[pos - 8] == Constants.FirstPlayerSymbol))
                    {
                        board[pos - 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 4);
                    }
                    else if (GameLogic.IsPosTaken(pos - 2) == false &&
                             (GameLogic.IsPosTaken(pos - 5) == false ||
                              board[pos - 6] == Constants.FirstPlayerSymbol))
                    {
                        board[pos - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 3);
                    }
                    else if (GameLogic.IsPosTaken(pos - 1) == false)
                    {
                        board[pos - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 2);
                    }
                    else if (GameLogic.IsPosTaken(pos - 5) == false)
                    {
                        board[pos - 6] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 6);
                    }
                    else if (GameLogic.IsPosTaken(pos - 2) == false)
                    {
                        board[pos - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 3);
                    }
                    else if (GameLogic.IsPosTaken(pos - 4) == false)
                    {
                        board[pos - 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 5);
                    }
                    else if (GameLogic.IsPosTaken(pos - 6) == false)
                    {
                        board[pos - 7] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(this.computerMoves.Last() - 7);
                    }
                }
            }
        }
    }
}