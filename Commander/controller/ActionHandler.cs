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
                throw new Exception("Command is null");
            }
            else if (command.Equals(Command.FIVE))
            {
                System.Diagnostics.Process.Start("https://www.youtube.com");
            }
            else
            {
                throw new Exception("Not Implemented");
            }

          
        }
    }
}
