using Commander.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander.controller
{
    interface ActionHandler
    {
        void execute(String command);
    }

    class ActionHandlerImpl : ActionHandler
    {
        public void execute(String command)
        {
            if (command == null)
            {
                throw new NullReferenceException();
            }
            else if (command.Equals(Command.ONE))
            {
                System.Diagnostics.Process.Start("notepad.exe");
            }
            else if (command.Equals(Command.TWO))
            {
                System.Diagnostics.Process.Start("Calc");
            }
            else if (command.Equals(Command.THREE))
            {
                System.Diagnostics.Process.Start("wordpad.exe");
            }
            else if (command.Equals(Command.FOUR))
            {
                System.Diagnostics.Process.Start("https://www.google.com/");
            }
            else if (command.Equals(Command.FIVE))
            {
                System.Diagnostics.Process.Start("https://www.youtube.com");
            }
            else
            {
                 throw new NotImplementedException();
            }

          
        }
    }
}
