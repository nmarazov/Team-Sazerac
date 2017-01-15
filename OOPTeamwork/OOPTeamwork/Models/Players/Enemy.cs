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

        private int position;
        
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
                position = Constants.InitialPositionEnemy;

                if (GameLogic.IsPosTakenForEnemy(position + 1) == false)
                {
                    board[position] = X;
                }
                else
                {
                    board[position + 1] = X;
                }

                this.computerMoves.Add(position);
            }
            else if (this.computerMoves.Count() > 0)
            {
                position = this.computerMoves.Last(); ;

                if (position == 0)
                {
                    if (GameLogic.IsPosTakenForEnemy(position + 2) == false &&
                        (GameLogic.IsPosTakenForEnemy(position + 3) == false ||
                         board[position + 2] == X))
                    {
                        board[position + 1] = X;
                        this.computerMoves.Add(position + 1);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 5) == false &&
                             (GameLogic.IsPosTakenForEnemy(position + 9) == false ||
                              board[position + 8] == X))
                    {
                        board[position + 4] = X;
                        this.computerMoves.Add(position + 4);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 4) == false &&
                             (GameLogic.IsPosTakenForEnemy(position + 7) == false ||
                              board[position + 6] == X))
                    {
                        board[position + 3] = X;
                        this.computerMoves.Add(position + 3);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 3) == false)
                    {
                        board[position + 2] = X;
                        this.computerMoves.Add(position + 2);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 7) == false)
                    {
                        board[position + 6] = X;
                        this.computerMoves.Add(position + 6);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 9) == false)
                    {
                        board[position + 8] = X;
                        this.computerMoves.Add(position + 8);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 6) == false)
                    {
                        board[position + 5] = X;
                        this.computerMoves.Add(position + 5);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(8) == false)
                    {
                        board[7] = X;
                        this.computerMoves.Add(position + 7);
                    }
                }
                else if (position == 1)
                {
                    if (GameLogic.IsPosTakenForEnemy(position + 2) == false &&
                        (GameLogic.IsPosTakenForEnemy(position) == false ||
                         board[position - 1] == X))
                    {
                        board[position + 1] = X;
                        this.computerMoves.Add(position + 1);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 4) == false &&
                             (GameLogic.IsPosTakenForEnemy(position + 7) == false ||
                              board[position + 6] == X))
                    {
                        board[position + 3] = X;
                        this.computerMoves.Add(position + 3);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(7) == false)
                    {
                        board[6] = X;
                        this.computerMoves.Add(position + 6);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position) == false)
                    {
                        board[position - 1] = X;
                        this.computerMoves.Add(position - 1);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 3) == false)
                    {
                        board[position + 2] = X;
                        this.computerMoves.Add(position + 2);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 5) == false)
                    {
                        board[position + 4] = X;
                        this.computerMoves.Add(position + 4);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 7) == false)
                    {
                        board[position + 6] = X;
                        this.computerMoves.Add(position + 6);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 6) == false)
                    {
                        board[position + 5] = X;
                        this.computerMoves.Add(position + 5);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 8) == false)
                    {
                        board[position + 7] = X;
                        this.computerMoves.Add(position + 7);
                    }
                }
                else if (position == 2)
                {
                    if (GameLogic.IsPosTakenForEnemy(position + 4) == false &&
                        (GameLogic.IsPosTakenForEnemy(position + 7) == false ||
                         board[position + 6] == X))
                    {
                        board[position + 3] = X;
                        this.computerMoves.Add(position + 3);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 3) == false &&
                             (GameLogic.IsPosTakenForEnemy(position + 5) == false ||
                              board[position + 4] == X))
                    {
                        board[position + 2] = X;
                        this.computerMoves.Add(position + 2);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position) == false &&
                             (GameLogic.IsPosTakenForEnemy(position - 1) == false ||
                              board[position - 2] == X))
                    {
                        board[position - 1] = X;
                        this.computerMoves.Add(position - 1);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 5) == false)
                    {
                        board[position + 4] = X;
                        this.computerMoves.Add(position + 4);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 7) == false)
                    {
                        board[position + 6] = X;
                        this.computerMoves.Add(position + 6);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position) == false)
                    {
                        board[position - 1] = X;
                        this.computerMoves.Add(position - 2);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 2) == false)
                    {
                        board[position + 1] = X;
                        this.computerMoves.Add(position + 1);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 6) == false)
                    {
                        board[position + 5] = X;
                        this.computerMoves.Add(position + 5);
                    }
                }
                else if (position == 3)
                {
                    if (GameLogic.IsPosTakenForEnemy(position + 2) == false &&
                        (GameLogic.IsPosTakenForEnemy(position + 3) == false ||
                         board[position + 2] == X))
                    {
                        board[position + 1] = X;
                        this.computerMoves.Add(position + 1);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 4) == false &&
                             (GameLogic.IsPosTakenForEnemy(position - 2) == false ||
                              board[position - 3] == X))
                    {
                        board[position + 3] = X;
                        this.computerMoves.Add(position + 3);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 3) == false)
                    {
                        board[position + 2] = X;
                        this.computerMoves.Add(position + 2);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 2) == false)
                    {
                        board[position - 3] = X;
                        this.computerMoves.Add(position - 3);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 5) == false)
                    {
                        board[position + 4] = X;
                        this.computerMoves.Add(position + 4);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 1) == false)
                    {
                        board[position - 2] = X;
                        this.computerMoves.Add(position - 2);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position) == false)
                    {
                        board[position - 1] = X;
                        this.computerMoves.Add(position - 1);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 6) == false)
                    {
                        board[position + 5] = X;
                        this.computerMoves.Add(position + 5);
                    }
                }
                else if (position == 4)
                {
                    if (GameLogic.IsPosTakenForEnemy(position + 2) == false &&
                        (GameLogic.IsPosTakenForEnemy(position) == false || //!!!!
                         board[position - 1] == Constants.FirstPlayerSymbol))
                    {
                        board[position + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position + 1);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 4) == false &&
                             (GameLogic.IsPosTakenForEnemy(position - 2) == false ||
                              board[position - 3] == Constants.FirstPlayerSymbol))
                    {
                        board[position + 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position + 3);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 5) == false &&
                             (GameLogic.IsPosTakenForEnemy(position - 3) == false ||
                              board[position - 4] == Constants.FirstPlayerSymbol))
                    {
                        board[position + 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position + 4);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position) == false)
                    {
                        board[position - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 1);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 2) == false)
                    {
                        board[position - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 3);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 3) == false)
                    {
                        board[position - 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 4);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 1) == false)
                    {
                        board[position - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 2);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 3) == false)
                    {
                        board[position + 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position + 2);
                    }
                }
                else if (position == 5)
                {
                    if (GameLogic.IsPosTakenForEnemy(position) == false &&
                        (GameLogic.IsPosTakenForEnemy(position - 1) == false ||
                         board[position - 2] == Constants.FirstPlayerSymbol))
                    {
                        board[position - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 1);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 4) == false &&
                             (GameLogic.IsPosTakenForEnemy(position - 2) == false ||
                              board[position - 3] == Constants.FirstPlayerSymbol))
                    {
                        board[position + 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position + 3);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 1) == false)
                    {
                        board[position - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 2);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 2) == false)
                    {
                        board[position - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 3);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 3) == false)
                    {
                        board[position + 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position + 2);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 2) == false)
                    {
                        board[position + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position + 1);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 4) == false)
                    {
                        board[position - 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 5);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 3) == false)
                    {
                        board[position - 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 4);
                    }
                }
                else if (position == 6)
                {
                    if (GameLogic.IsPosTakenForEnemy(position + 2) == false &&
                        (GameLogic.IsPosTakenForEnemy(position + 3) == false ||
                         board[position + 2] == Constants.FirstPlayerSymbol))
                    {
                        board[position + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position + 1);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 1) == false &&
                             (GameLogic.IsPosTakenForEnemy(position - 3) == false ||
                              board[position - 4] == Constants.FirstPlayerSymbol))
                    {
                        board[position - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 2);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 5) == false &&
                             (GameLogic.IsPosTakenForEnemy(position - 2) == false ||
                              board[position - 3] == Constants.FirstPlayerSymbol))
                    {
                        board[position - 6] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 6);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 4) == false)
                    {
                        board[position + 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position + 3);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position + 3) == false)
                    {
                        board[position + 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position + 2);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 3) == false)
                    {
                        board[position - 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 4);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 4) == false)
                    {
                        board[position - 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 5);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position) == false)
                    {
                        board[position - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 1);
                    }
                }
                else if (position == 7)
                {
                    if (GameLogic.IsPosTakenForEnemy(position + 2) == false &&
                        (GameLogic.IsPosTakenForEnemy(position) == false ||
                         board[position - 1] == Constants.FirstPlayerSymbol))
                    {
                        board[position + 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position + 1);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 2) == false &&
                             (GameLogic.IsPosTakenForEnemy(position - 5) == false ||
                              board[position - 6] == Constants.FirstPlayerSymbol))
                    {
                        board[position - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 3);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position) == false)
                    {
                        board[position - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 1);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 5) == false)
                    {
                        board[position - 6] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 6);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 4) == false)
                    {
                        board[position - 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 5);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 3) == false)
                    {
                        board[position - 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 4);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 6) == false)
                    {
                        board[position - 7] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 7);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 1) == false)
                    {
                        board[position - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 2);
                    }
                }
                else if (position == 8)
                {
                    if (GameLogic.IsPosTakenForEnemy(position) == false &&
                        (GameLogic.IsPosTakenForEnemy(position - 1) == false ||
                         board[position - 2] == Constants.FirstPlayerSymbol))
                    {
                        board[position - 1] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 1);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 3) == false &&
                             (GameLogic.IsPosTakenForEnemy(position - 7) == false ||
                              board[position - 8] == Constants.FirstPlayerSymbol))
                    {
                        board[position - 4] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 4);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 2) == false &&
                             (GameLogic.IsPosTakenForEnemy(position - 5) == false ||
                              board[position - 6] == Constants.FirstPlayerSymbol))
                    {
                        board[position - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 3);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 1) == false)
                    {
                        board[position - 2] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 2);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 5) == false)
                    {
                        board[position - 6] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 6);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 2) == false)
                    {
                        board[position - 3] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 3);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 4) == false)
                    {
                        board[position - 5] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 5);
                    }
                    else if (GameLogic.IsPosTakenForEnemy(position - 6) == false)
                    {
                        board[position - 7] = Constants.FirstPlayerSymbol;
                        this.computerMoves.Add(position - 7);
                    }
                }
            }
        }
    }
}