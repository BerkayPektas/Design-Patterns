﻿using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    internal class RemoteControl
    {
        Command[] onCommands = new Command[7];
        Command[] offCommands = new Command[7];
        List<Command> undoList = new List<Command>();

        public RemoteControl()
        {
            Command noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }
            undoList.Add(noCommand);
        }

        // This method must set the On and Off command to the slot provided
        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        // This method must call the OnCommand.Execute() method of the slot provided
        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoList.Add(onCommands[slot]);
        }

        // This method must call the OffCommand.Execute() method of the slot provided
        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoList.Add(offCommands[slot]);
        }
        public void UndoButtonWasPushed()
        {
            int commandHistory = undoList.Count - 1;
            undoList[commandHistory].Undo();
            undoList.RemoveAt(commandHistory);
        }

        // Overwritten ToString() to print out each slot and its corresponding command.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n----- Remote Control ----- \n");
            for(int i = 0;i < onCommands.Length;i++)
            {
                sb.Append("[slot " + i + "] "+ onCommands[i] + " \t\t  " + offCommands[i] + "\n");
            }
            return sb.ToString();
        }
    }
}
