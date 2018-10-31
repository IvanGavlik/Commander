using Commander.controller;
using Commander.model;
using System;
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


            Grammar grammar = new Grammar();         
            grammar.addGrammarRule(Command.FIVE);
            speachRecognition = new SpeachRecognitionImpl(grammar.Rules);
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
}
}
