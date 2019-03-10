using Commander.controller;
using Commander.exception;
using Commander.model;
using Commander.view;
using System;
using System.Globalization;
using System.Speech.Recognition;
using System.Windows.Forms;


namespace Commander
{
    public partial class Form1 : Form
    {
        private Speach speach;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Settings.GetInstance().Port = 6060; //SET default port, save to file obavezno, kod gašenja aplikacije 
            Choices listOfChoices = new Choices();
            listOfChoices.Add(Command.GetEclipseCommands());
            GrammarBuilder grammarBuilder = new GrammarBuilder(listOfChoices);
            CultureInfo culture = new CultureInfo("en-US");

            Grammar grammar = new Grammar(grammarBuilder);
            grammar.Name = "Commander grammar";

            try
            {
                speach = new SpeechImpl(grammar);
                speach.setActionHandler(new EclipseActionHandler());
            }
            catch (SpeechRecognitionCreationException ex)
            {
                MessageBox.Show(ex.Message, "Command aplication", MessageBoxButtons.OK);
                Environment.Exit(-1);
            }

            info.Text = "OFF";
            info.ForeColor = System.Drawing.Color.OrangeRed;
            start.Enabled = true;
            stop.Enabled = false;
        }    

        private void start_Click(object sender, EventArgs e)
        {
            Template t = new Template();
            t.Show();
           /**/
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (speach.GetStatus().Equals(Status.ON))
            {
                speach.stopRecognition();
                updateViewComponents();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result =  MessageBox.Show("Do you whant to exit ?", "Exit Command aplication" , MessageBoxButtons.YesNo);
            if(result == DialogResult.No)
            {
                //TODO save port number to file
                e.Cancel = true;
            }
        }

        private void updateViewComponents()
        {
            start.Enabled = !start.Enabled;
            stop.Enabled = !stop.Enabled;

            if (info.ForeColor != System.Drawing.Color.OrangeRed)
            {
                info.Text = "OFF";
                info.ForeColor = System.Drawing.Color.OrangeRed;
            }
            else
            {
                info.Text = "ON";
                info.ForeColor = System.Drawing.Color.GreenYellow;
            }


        }

        private void setSettings(object sender, EventArgs e)
        {
            SettingsFormOld settings = new SettingsFormOld();
            settings.Show();
        }
    }
}
