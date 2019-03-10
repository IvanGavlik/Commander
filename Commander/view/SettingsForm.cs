using Commander.log;
using Commander.model;
using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Commander.view
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            LogFile.info("Settings", "start");
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#57b846");
            portNumber.Text = Settings.GetInstance().Port.ToString();
            displayDialog.Checked = Settings.GetInstance().DispalyInfo;
            this.logFilePath.Text = Settings.GetInstance().LogFilePath;
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
                if (port != -1)
                {
                    Settings.GetInstance().Port = port;
                    LogFile.info("Settings", "save_Click", "port " + port);
                }
            }
            catch (Exception ex)
            {
                info.Text = "Port number mut be in range\nfrom xxx to yyy";
                info.ForeColor = System.Drawing.Color.OrangeRed;
                LogFile.info("Settings", "save_Click", "port " + port, info.Text);
            }
           
            Settings.GetInstance().DispalyInfo = displayDialog.Checked;

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
                    info.Text = "Connection is sucessful.";
                    info.ForeColor = System.Drawing.Color.GreenYellow;
                    LogFile.info("Settings", "testConnection_Click", "port " + port, info.Text);
                }
                else
                {
                    info.Text = "Connection falied.";
                    info.ForeColor = System.Drawing.Color.OrangeRed;
                    LogFile.info("Settings", "testConnection_Click", "port " + port, info.Text);
                }
            }
            catch (Exception ex)
            {
                info.Text = "Port number mut be in range from xxx to yyy";
                info.ForeColor = System.Drawing.Color.OrangeRed;
                LogFile.info("Settings", "testConnection_Click", "port " + port, info.Text);
            }
        }

        private bool testEcliseServer(int port)
        {
            LogFile.info("Settings testEcliseServer","port " + port, info.Text);
            byte[] receivedData = null;
            try
            {
                UdpClient client = new UdpClient();
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
                client.Connect(ep);
                // send data
                client.Send(new byte[] { 1, 2, 3, 4, 5 }, 5);
                // then receive data
                receivedData = client.Receive(ref ep);
            }
            catch (Exception ex)
            {
                LogFile.info("Settings testEcliseServer", "port " + port, ex.Message);
                return false;
            }

            return receivedData != null;
        }
    }
}
