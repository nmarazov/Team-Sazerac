using System;
using OOPTeamwork.Common;
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

        public virtual void CheckWhoIsTheWinner(int flag, int player)
        {
            if (flag == 1)
            {
                var winningPlayer = player % 2;

                if (winningPlayer == 0)
                {
                    winningPlayer = Constants.SecondPlayerIndex;
                }

                this.Writer.WriteLine($"Player { winningPlayer } wins!");
            }
            else if (flag == -1)
            {
                this.Writer.WriteLine("Draw");
            }
        }

        public virtual void PrintGameField(string gameField)
        {
            this.Writer.Clear();
            foreach (char c in this.GameField.PrintGameField())
            {
                if (c == 'X')
                {
                    this.Writer.ChangeColor(ConsoleColor.Red);
                    this.Writer.Write(c);
                }
                else if (c == 'O')
                {
                    this.Writer.ChangeColor(ConsoleColor.Blue);
                    this.Writer.Write(c);
                }
                else
                {
                    this.Writer.ResetColor();
                    this.Writer.Write(c);
                }
            }
        }
    }
}
