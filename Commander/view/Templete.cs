using System;
using System.Drawing;
using System.Windows.Forms;
using Commander.controller;
using Commander.exception;
using Commander.model;
using System.Globalization;
using System.Speech.Recognition;
using Commander.log;

//TODO LOGIRANJE
//TODO EMAIL -> Greška
//TODO IZGLED -> data table šta sam rekao 
//TODO IME 
//TODO DISPLAY INFO U SEINGE STAVITI
//TODO VOICE CAN STart, stoped
namespace Commander.view
{
    public partial class Template : Form
    {
        private Speach speach;

        public Template()
        {
            LogFile.info("Application", "start");
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#57b846");
            header.BackColor = ColorTranslator.FromHtml("#57b846");
            start.BackColor = ColorTranslator.FromHtml("#ebebeb");
            stop.BackColor = ColorTranslator.FromHtml("#ebebeb");
            settings.ForeColor = ColorTranslator.FromHtml("#57b846");
            help.ForeColor = ColorTranslator.FromHtml("#57b846");

            //load
            Settings.GetInstance().Port = 6060; //SET default port, save to file obavezno, kod gašenja aplikacije 
            Settings.GetInstance().DispalyInfo= true; 

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
                LogFile.info("Application", "new SpeechImpl()", ex.Message);
                MessageBox.Show(ex.Message, "Command aplication", MessageBoxButtons.OK);
                Environment.Exit(-1);
            }

            start.Enabled = true;
            settings.Enabled = true;
            stop.Enabled = false;
      
        }

    
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you whant to exit ?", "Exit Command aplication", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                //TODO save port number to file
                e.Cancel = true;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (speach.GetStatus().Equals(Status.OFF))
            {
                speach.startRecognition();
                Info.GetInstance().Value = "You can start now"; 
                InfoForm info = new InfoForm();
                info.Show();
                updateViewComponents();
                LogFile.info("Application", "start_Click");
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (speach.GetStatus().Equals(Status.ON))
            {
                speach.stopRecognition();
                Info.GetInstance().Value = "Speach recognition stoped";
                InfoForm info = new InfoForm();
                info.Show();

                updateViewComponents();
                LogFile.info("Application", "stop_Click");
            }

        }

        private void updateViewComponents()
        {
            start.Enabled = !start.Enabled;
            stop.Enabled = !stop.Enabled;
            settings.Enabled = !settings.Enabled;
        }

        private void setSettings(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Show();
        }

        private void Template_Load(object sender, EventArgs e)
        {

        }
    }
}
