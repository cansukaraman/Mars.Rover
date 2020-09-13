﻿using Mars.Rover.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using static Mars.Rover.Core.Components.Enums;

namespace Mars.Rover.Core.Bussiness.Redirection
{
    class TurnRight : IExplore
    {
        public void Explore(RoverLocation roverLocation)
        {
            switch (roverLocation.Direction)
            {
                case Direction.N:
                    roverLocation.Direction = Direction.E;
                    break;
                case Direction.E:
                    roverLocation.Direction = Direction.S;
                    break;
                case Direction.S:
                    roverLocation.Direction = Direction.W;
                    break;
                case Direction.W:
                    roverLocation.Direction = Direction.N;
                    break;
            }
        }
    }
}
