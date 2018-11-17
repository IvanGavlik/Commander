using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander.exception
{
    class SpeechRecognitionCreationException : Exception
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
}
