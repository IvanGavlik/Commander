using Commander.model;
using System;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Globalization;
using Commander.exception;
using Commander.log;

namespace Commander.controller
{
    interface Speach
    {
        Status GetStatus(); 

        void startRecognition();

        void stopRecognition();

        void setActionHandler(ActionHandler actionHandler);
    }

    class SpeechImpl : Speach
    {
        private Status Status;
        private SpeechRecognitionEngine Engine;
        private ActionHandler actionHandler;

        public SpeechImpl(Grammar grammar)
        {
            try
            {
                Status = Status.OFF;
                Engine = new SpeechRecognitionEngine(new CultureInfo("en-US"));
                Engine.SetInputToDefaultAudioDevice();
                Engine.RequestRecognizerUpdate();
                Engine.LoadGrammar(grammar);
                Engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(speechRecognized);
            }  catch(Exception ex)
            {
                throw new SpeechRecognitionCreationException("Speech Recognition Creation Failed", ex);
            }

        }


        public void startRecognition()
        {
            LogFile.info("Speech", "startRecognition");
            Status = Status.ON;
            Engine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void speechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            actionHandler.execute(e.Result.Text);
        }

        public void stopRecognition()
        {
            LogFile.info("Speech", "stopRecognition");
            Engine.RecognizeAsyncStop();
            Status = Status.OFF;
        }


        public void setActionHandler(ActionHandler actionHandler)
        {
            this.actionHandler = actionHandler;
        }

        public Status GetStatus()
        {
            return this.Status;
        }
    }
}
