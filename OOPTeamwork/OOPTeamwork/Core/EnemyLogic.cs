using System;
using System.Collections.Generic;
using System.Linq;
using OOPTeamwork.Models.Contracts;
using OOPTeamwork.Models.GameAbstracts;

namespace OOPTeamwork.Core
{
    public class EnemyLogic : Player
    {
        public List<int> ComputerMoves = new List<int>();

        public EnemyLogic(int playerIndex, char playerSymbol) 
            : base(playerIndex, playerSymbol)
        {
        }

        public override void PlayerNextMove()
        {
            Console.Write($"Player {this.PlayerIndex} is the computer: ");
            var position = 0; //the first position is always 0 for the computer
            ComputerMoves.Add(0);
            if (ComputerMoves.Count == 0)
            {
                ComputerMoves.Add(0);
                if (GameLogic.CheckIfPositionIsTaken(position) == false)
                {
                    GameField.Instance.InputSelection[position] = Constants.SecondPlayerSymbol;
                }
            }
            else if (ComputerMoves.Count() > 0)
            {
                position = ComputerMoves.Last();

                if (ComputerMoves.Last() == 0)
                {
                    if (GameLogic.CheckIfPositionIsTaken(position + 1) == false &&
                        (GameLogic.CheckIfPositionIsTaken(position + 2) == false ||
                         GameField.Instance.InputSelection[position + 2] == Constants.SecondPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[position + 1] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 4) == false &&
                             (GameLogic.CheckIfPositionIsTaken(position + 8) == false ||
                              GameField.Instance.InputSelection[position + 8] == Constants.SecondPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[position + 4] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 3) == false &&
                             (GameLogic.CheckIfPositionIsTaken(position + 6) == false ||
                              GameField.Instance.InputSelection[position + 6] == Constants.SecondPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[position + 3] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 3);
                    }

                    else if (GameLogic.CheckIfPositionIsTaken(position + 2) == false)
                    {

                        GameField.Instance.InputSelection[position + 2] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 2);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 6) == false)
                    {
                        GameField.Instance.InputSelection[position + 6] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 6);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 8) == false)
                    {
                        GameField.Instance.InputSelection[position + 8] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 8);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 5) == false)
                    {

                        GameField.Instance.InputSelection[position + 5] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 5);

                    }

                    else if (GameLogic.CheckIfPositionIsTaken(7) == false)
                    {
                        GameField.Instance.InputSelection[7] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 7);
                    }

                }
                else if (ComputerMoves.Last() == 1)
                {
                    if (GameLogic.CheckIfPositionIsTaken(position + 1) == false &&
                        (GameLogic.CheckIfPositionIsTaken(position - 1) == false ||
                         GameField.Instance.InputSelection[position - 1] == Constants.SecondPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[position + 1] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 3) == false &&
                             (GameLogic.CheckIfPositionIsTaken(position + 6) == false ||
                              GameField.Instance.InputSelection[position + 6] == Constants.SecondPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[position + 3] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(6) == false)
                    {
                        GameField.Instance.InputSelection[6] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 6);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position - 1) == false)
                    {

                        GameField.Instance.InputSelection[position - 1] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() - 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 2) == false)
                    {

                        GameField.Instance.InputSelection[position + 2] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 2);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 4) == false)
                    {

                        GameField.Instance.InputSelection[position + 4] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 4);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 6) == false)
                    {

                        GameField.Instance.InputSelection[position + 6] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 6);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 5) == false)
                    {

                        GameField.Instance.InputSelection[position + 5] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 5);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 7) == false)
                    {

                        GameField.Instance.InputSelection[position + 7] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 7);

                    }

                }
                else if (ComputerMoves.Last() == 2)
                {
                    if (GameLogic.CheckIfPositionIsTaken(position + 3) == false &&
                        (GameLogic.CheckIfPositionIsTaken(position + 6) == false ||
                         GameField.Instance.InputSelection[position + 6] == Constants.SecondPlayerSymbol))
                    {

                        GameField.Instance.InputSelection[position + 3] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 3);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 2) == false &&
                             (GameLogic.CheckIfPositionIsTaken(position + 4) == false ||
                              GameField.Instance.InputSelection[position + 4] == Constants.SecondPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[position + 2] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 2);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position - 1) == false &&
                             (GameLogic.CheckIfPositionIsTaken(position - 2) == false ||
                              GameField.Instance.InputSelection[position - 2] == Constants.SecondPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[position - 1] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() - 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 4) == false)
                    {

                        GameField.Instance.InputSelection[position + 4] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 6) == false)
                    {

                        GameField.Instance.InputSelection[position + 6] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 6);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position - 2) == false)
                    {

                        GameField.Instance.InputSelection[position - 2] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() - 2);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 1) == false)
                    {

                        GameField.Instance.InputSelection[position + 1] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 5) == false)
                    {

                        GameField.Instance.InputSelection[position + 5] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 5);

                    }

                }
                else if (ComputerMoves.Last() == 3)
                {
                    if (GameLogic.CheckIfPositionIsTaken(position + 1) == false &&
                        (GameLogic.CheckIfPositionIsTaken(position + 2) == false ||
                         GameField.Instance.InputSelection[position + 2] == Constants.SecondPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[position + 1] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 1);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 3) == false &&
                             (GameLogic.CheckIfPositionIsTaken(position - 3) == false ||
                              GameField.Instance.InputSelection[position - 3] == Constants.SecondPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[position + 3] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 2) == false)
                    {

                        GameField.Instance.InputSelection[position + 2] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 2);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position - 3) == false)
                    {

                        GameField.Instance.InputSelection[position - 3] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() - 3);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 4) == false)
                    {

                        GameField.Instance.InputSelection[position + 4] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 4);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position - 2) == false)
                    {

                        GameField.Instance.InputSelection[position - 2] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() - 2);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position - 1) == false)
                    {

                        GameField.Instance.InputSelection[position - 1] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() - 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 5) == false)
                    {

                        GameField.Instance.InputSelection[position + 5] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 5);

                    }


                }
                else if (ComputerMoves.Last() == 4)
                {
                    if (GameLogic.CheckIfPositionIsTaken(position + 1) == false &&
                        (GameLogic.CheckIfPositionIsTaken(position - 1) == false ||
                         GameField.Instance.InputSelection[position - 1] == Constants.SecondPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[position + 1] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 3) == false &&
                             (GameLogic.CheckIfPositionIsTaken(position - 3) == false ||
                              GameField.Instance.InputSelection[position - 3] == Constants.SecondPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[position + 3] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 4) == false &&
                             (GameLogic.CheckIfPositionIsTaken(position - 4) == false ||
                              GameField.Instance.InputSelection[position - 4] == Constants.SecondPlayerSymbol))
                    {
                        GameField.Instance.InputSelection[position + 4] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 4);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position - 1) == false)
                    {

                        GameField.Instance.InputSelection[position - 1] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() - 1);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position - 3) == false)
                    {

                        GameField.Instance.InputSelection[position - 3] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() - 3);
                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position - 4) == false)
                    {

                        GameField.Instance.InputSelection[position - 4] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() - 4);
                    }

                    else if (GameLogic.CheckIfPositionIsTaken(position - 2) == false)
                    {

                        GameField.Instance.InputSelection[position - 2] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() - 2);

                    }
                    else if (GameLogic.CheckIfPositionIsTaken(position + 2) == false)
                    {

                        GameField.Instance.InputSelection[position + 2] = Constants.SecondPlayerSymbol;
                        ComputerMoves.Add(ComputerMoves.Last() + 2);


                    }
                    else if (ComputerMoves.Last() == 5)
                    {
                        if (GameLogic.CheckIfPositionIsTaken(position - 1) == false &&
                            (GameLogic.CheckIfPositionIsTaken(position - 2) == false ||
                             GameField.Instance.InputSelection[position - 2] == Constants.SecondPlayerSymbol))
                        {
                            GameField.Instance.InputSelection[position - 1] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(position - 1);

                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position + 3) == false &&
                                 (GameLogic.CheckIfPositionIsTaken(position - 3) == false ||
                                  GameField.Instance.InputSelection[position - 3] == Constants.SecondPlayerSymbol))
                        {
                            GameField.Instance.InputSelection[position + 3] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() + 3);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 2) == false)
                        {

                            GameField.Instance.InputSelection[position - 2] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 2);

                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 3) == false)
                        {

                            GameField.Instance.InputSelection[position - 3] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 3);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position + 2) == false)
                        {

                            GameField.Instance.InputSelection[position + 2] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() + 2);

                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position + 1) == false)
                        {

                            GameField.Instance.InputSelection[position + 1] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() + 1);

                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 5) == false)
                        {

                            GameField.Instance.InputSelection[position - 5] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 5);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 4) == false)
                        {

                            GameField.Instance.InputSelection[position - 4] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 4);
                        }

                    }
                    else if (ComputerMoves.Last() == 6)
                    {
                        if (GameLogic.CheckIfPositionIsTaken(position + 1) == false &&
                            (GameLogic.CheckIfPositionIsTaken(position + 2) == false ||
                             GameField.Instance.InputSelection[position + 2] == Constants.SecondPlayerSymbol))
                        {
                            GameField.Instance.InputSelection[position + 1] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() + 1);

                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 2) == false &&
                                 (GameLogic.CheckIfPositionIsTaken(position - 4) == false ||
                                  GameField.Instance.InputSelection[position - 4] == Constants.SecondPlayerSymbol))
                        {
                            GameField.Instance.InputSelection[position - 2] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 2);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 6) == false &&
                                 (GameLogic.CheckIfPositionIsTaken(position - 3) == false ||
                                  GameField.Instance.InputSelection[position - 3] == Constants.SecondPlayerSymbol))
                        {
                            GameField.Instance.InputSelection[position - 6] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 6);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position + 3) == false)
                        {

                            GameField.Instance.InputSelection[position + 3] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() + 3);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position + 2) == false)
                        {

                            GameField.Instance.InputSelection[position + 2] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() + 2);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 4) == false)
                        {

                            GameField.Instance.InputSelection[position - 4] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 4);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 5) == false)
                        {

                            GameField.Instance.InputSelection[position - 5] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 5);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 1) == false)
                        {

                            GameField.Instance.InputSelection[position - 1] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 1);
                        }

                    }
                    else if (ComputerMoves.Last() == 7)
                    {
                        if (GameLogic.CheckIfPositionIsTaken(position + 1) == false &&
                            (GameLogic.CheckIfPositionIsTaken(position - 1) == false ||
                             GameField.Instance.InputSelection[position - 1] == Constants.SecondPlayerSymbol))
                        {
                            GameField.Instance.InputSelection[position + 1] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() + 1);

                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 3) == false &&
                                 (GameLogic.CheckIfPositionIsTaken(position - 6) == false ||
                                  GameField.Instance.InputSelection[position - 6] == Constants.SecondPlayerSymbol))
                        {
                            GameField.Instance.InputSelection[position - 3] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 3);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 1) == false)
                        {

                            GameField.Instance.InputSelection[position - 1] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 1);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 6) == false)
                        {

                            GameField.Instance.InputSelection[position - 6] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 6);
                        }

                        else if (GameLogic.CheckIfPositionIsTaken(position - 5) == false)
                        {

                            GameField.Instance.InputSelection[position - 5] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 5);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 4) == false)
                        {

                            GameField.Instance.InputSelection[position - 4] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 4);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 7) == false)
                        {

                            GameField.Instance.InputSelection[position - 7] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 7);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 2) == false)
                        {

                            GameField.Instance.InputSelection[position - 2] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 2);

                        }

                    }
                    else if (ComputerMoves.Last() == 8)
                    {
                        if (GameLogic.CheckIfPositionIsTaken(position - 1) == false &&
                            (GameLogic.CheckIfPositionIsTaken(position - 2) == false ||
                             GameField.Instance.InputSelection[position - 2] == Constants.SecondPlayerSymbol))
                        {
                            GameField.Instance.InputSelection[position - 1] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 1);

                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 4) == false &&
                                 (GameLogic.CheckIfPositionIsTaken(position - 8) == false ||
                                  GameField.Instance.InputSelection[position - 8] == Constants.SecondPlayerSymbol))
                        {
                            GameField.Instance.InputSelection[position - 4] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 4);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 3) == false &&
                                 (GameLogic.CheckIfPositionIsTaken(position - 6) == false ||
                                  GameField.Instance.InputSelection[position - 6] == Constants.SecondPlayerSymbol))
                        {
                            GameField.Instance.InputSelection[position - 3] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 3);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 2) == false)
                        {

                            GameField.Instance.InputSelection[position - 2] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 2);

                        }

                        else if (GameLogic.CheckIfPositionIsTaken(position - 6) == false)
                        {

                            GameField.Instance.InputSelection[position - 6] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 6);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 3) == false)
                        {

                            GameField.Instance.InputSelection[position - 3] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 3);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 5) == false)
                        {

                            GameField.Instance.InputSelection[position - 5] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 5);
                        }
                        else if (GameLogic.CheckIfPositionIsTaken(position - 7) == false)
                        {

                            GameField.Instance.InputSelection[position - 7] = Constants.SecondPlayerSymbol;
                            ComputerMoves.Add(ComputerMoves.Last() - 7);
                        }

                    }
                }
            }

        }
    }
}
