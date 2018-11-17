using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander.util.exception
{
    public class SpeechRecognitionCreationException : Exception
    {
        public SpeechRecognitionCreationException()
        {
        }

        public SpeechRecognitionCreationException(string message)
            : base(message)
        {    
        }

        public SpeechRecognitionCreationException(string message, Exception inner)
            : base(message, inner)
        {  
        }

    }

    public class SpeechRecognitionLoadGrammarException : Exception
    {
        public SpeechRecognitionLoadGrammarException()
        {
        }

        public SpeechRecognitionLoadGrammarException(string message)
            : base(message)
        {
        }

        public SpeechRecognitionLoadGrammarException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
