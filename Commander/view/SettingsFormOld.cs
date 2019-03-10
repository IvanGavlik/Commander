using Commander.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commander.view
{
    public partial class SettingsFormOld : Form
    {
        public SettingsFormOld()
        {
            InitializeComponent();
            portNumber.Text = Settings.GetInstance().Port.ToString();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you whant to exit ?", "Exit Setings", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            int port = -1;
            try
            {
                port = Int32.Parse(portNumber.Text);
            }
            catch (Exception ex)
            {
                info.Text = "Port number mut be in range\nfrom xxx to yyy";
                info.ForeColor = System.Drawing.Color.OrangeRed;
            }
            if(port != -1)
            {
                Settings.GetInstance().Port = port;
            }
            this.Hide();
        }

        private void txtNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void testConnection_Click(object sender, EventArgs e)
        {
            int port = -1;
            try
            {
                port = Int32.Parse(portNumber.Text);
                if (port > 1000 && port < 9999 && testEcliseServer(port))
                {
                    info.Text = "Connection is sucessful";
                    info.ForeColor = System.Drawing.Color.GreenYellow;
                }
                else
                {
                    info.Text = "Connection falied!\nSeee for help";
                    info.ForeColor = System.Drawing.Color.OrangeRed;
                }
            }
            catch (Exception ex)
            {
                info.Text = "Port number mut be in range\nfrom xxx to yyy";
                info.ForeColor = System.Drawing.Color.OrangeRed;
            }
        }

        private bool testEcliseServer(int port)
        {
            byte[] receivedData = null;
            try {
                UdpClient client = new UdpClient();
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                client.Connect(ep);
                // send data
                client.Send(new byte[] { 1, 2, 3, 4, 5 }, 5);
                // then receive data
                receivedData = client.Receive(ref ep);
            } catch(Exception ex)
            {
                return false;
            }

            return receivedData != null;
        }

       
    }
}
