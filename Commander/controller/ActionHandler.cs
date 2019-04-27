using Commander.model;
using Commander.view;
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

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

    class EclipseActionHandler : ActionHandler
    {
        private UdpClient udpClient = new UdpClient();

        public void execute(String command)
        {
            LogFile.info("EclipseActionHandler", "execute", command);
            udpClient.Connect("127.0.0.1", Settings.GetInstance().Port);
            Byte[] sendBytes = Encoding.UTF8.GetBytes(command);
            udpClient.Send(sendBytes, sendBytes.Length);

            if (Settings.GetInstance().DispalyInfo)
            {
                Info.GetInstance().Value = "Recognized: " + command;
                InfoForm info = new InfoForm();
                info.Show();
            }
        }
    }
}
