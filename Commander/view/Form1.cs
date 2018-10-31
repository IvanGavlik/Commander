using Commander.controller;
using Commander.model;
using System;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace Commander
{
    public partial class Form1 : Form
    {
        private SpeachRecognition speachRecognition;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Choices listOfChoices = new Choices();
            listOfChoices.Add(new string[] { Command.ONE, Command.TWO, Command.THREE, Command.FOUR, Command.FIVE });
            Grammar grammar = new Grammar(new GrammarBuilder(listOfChoices));
            grammar.Name = "Commander grammar";
            speachRecognition = new SpeachRecognitionImpl(grammar);
            speachRecognition.setActionHandler(new ActionHandlerImpl());
        }

        private void start_Click(object sender, EventArgs e)
        {
            speachRecognition.startRecognition();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            speachRecognition.stopRecognition();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result =  MessageBox.Show("Do you whant to exit ?", "Exit Command aplication" , MessageBoxButtons.YesNo);
            if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
