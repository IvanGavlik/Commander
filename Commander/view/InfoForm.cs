using Commander.model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Commander.view
{
    public partial class InfoForm : Form
    {
        private Timer t1;

        public InfoForm()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#57b846");
            info.Text = Info.GetInstance().Value;

            t1 = new Timer();
            t1.Tick += t1_Tick;
            t1.Interval = 2000; // 1.5 seconds
            t1.Start();
        }

        void t1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            t1.Stop();
        }

        private void Info_Click(object sender, EventArgs e)
        {

        }
    }
}
