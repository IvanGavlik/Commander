using Commander.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition.SrgsGrammar;
using System.Speech.Recognition;
using System.Globalization;

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
        private ActionHandler actionHandler;

        public SpeachRecognitionImpl(Grammar grammar)
        {
            Status = Status.OFF;
            Engine = new SpeechRecognitionEngine(new CultureInfo("en-US"));
            Engine.SetInputToDefaultAudioDevice();
            Engine.RequestRecognizerUpdate();
            Engine.LoadGrammar(grammar);
            Engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(speechRecognized);
        }


        public void startRecognition()
        {
            switch (Status)
            {
                case Status.ON:
                    MessageBox.Show("Listening alreday started");
                    break;
                case Status.OFF:
                    StartListening();
                    MessageBox.Show("Listening started");
                    break;
                default: throw new NotImplementedException();
            }
        }

        internal void StartListening()
        {
            Status = Status.ON;
            Engine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void speechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            actionHandler.execute(e.Result.Text);
        }

        public void stopRecognition()
        {
            switch (Status)
            {
                case Status.ON:
                    StopListening();
                    MessageBox.Show("Listening stoped");
                    break;
                case Status.OFF:
                    MessageBox.Show("Listening alreday stoped");
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
