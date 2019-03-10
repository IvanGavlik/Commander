using Commander.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commander.view
{
    public partial class InfoFormOld : Form
    {
        public InfoFormOld()
        {
            InitializeComponent();
            info.Text = Info.GetInstance().Value;
        }

        Timer t1;
        private void InfoForm_Load(object sender, EventArgs e)
        {
            t1 = new Timer();
            t1.Tick += t1_Tick;
            t1.Interval = 2000; //2000 ms = 5 seconds
            t1.Start();
        }

        void t1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            t1.Stop();
        }
    }
}
