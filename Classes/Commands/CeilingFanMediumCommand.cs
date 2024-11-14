﻿using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes.Commands
{
    internal class CeilingFanMediumCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;
        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.Medium();
        }

        public void Undo()
        {
            switch (prevSpeed)
            {
                case 0:
                    ceilingFan.Off();
                    break;
                case 1:
                    ceilingFan.Low();
                    break;
                case 2:
                    ceilingFan.Medium();
                    break;
                case 3:
                    ceilingFan.High();
                    break;
            }
        }
    }
}
