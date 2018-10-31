using Commander.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition.SrgsGrammar;
using System.Speech.Recognition;


namespace Commander.controller
{
    interface SpeachRecognition
    {
        void startRecognition();

        void stopRecognition();

        void setActionHandler(ActionHandler actionHandler);
    }

    class SpeachRecognitionImpl : SpeachRecognition
    {
        private Status Status;
        private SpeechRecognitionEngine Engine;
        private SrgsDocument grammarDocument;
        private ActionHandler actionHandler;

        public SpeachRecognitionImpl(List<String> grammarRules)
        {
            Status = Status.OFF;
            Engine = new SpeechRecognitionEngine();

            SrgsOneOf oneOfRules = new SrgsOneOf();
            foreach (String el in grammarRules)
            {
                oneOfRules.Add(new SrgsItem(el));
            }

            SrgsRule rule = new SrgsRule("SpeachRecognitionRule");
            rule.Add(oneOfRules);
            grammarDocument = new SrgsDocument();
            grammarDocument.Rules.Add(rule);
            grammarDocument.Root = rule;
            Engine.LoadGrammar(new System.Speech.Recognition.Grammar(grammarDocument));
            Engine.SetInputToDefaultAudioDevice();
        }

        public void startRecognition()
        {
            switch (Status)
            {
                case Status.ON:
                    MessageBox.Show("Alreday started");
                    break;
                case Status.OFF:
                    StartListening();
                    break;
                default: throw new NotImplementedException();
            }

        }

        internal void StartListening()
        {
            Status = Status.ON;
            Engine.RecognizeAsync();
            Engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(speechRecognized);

        }

        private void speechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //TODO
            actionHandler.execute(e.Result.Text);

        }

        public void stopRecognition()
        {
            switch (Status)
            {
                case Status.ON:
                    StopListening();
                    break;
                case Status.OFF:
                    MessageBox.Show("Alreday stoped");
                    break;
                default: throw new NotImplementedException();
            }
        }

        internal void StopListening()
        {
            Engine.RecognizeAsyncStop();
            Status = Status.OFF;
        }

        public void setActionHandler(ActionHandler actionHandler)
        {
            this.actionHandler = actionHandler;
        }
    }
}
