﻿using System;
using OOPTeamwork.Core.Contracts;
using OOPTeamwork.Models.GameAbstracts;

namespace OOPTeamwork.Models.Levels
{
    public class SecondLevel : Level
    {
        public override void StartLevel()
        {
            throw new NotImplementedException();
        }

        public SecondLevel(IGameField gameField, IWriter writer, IReader reader)
            : base(gameField, writer, reader)
        {
        }
    }
}
