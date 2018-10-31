using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander.model
{
    public class Command
    {
      
        private Command() { }

        ///  Say ONE to start notepad
        public readonly static string ONE = "one";

        ///  Say TWO start calculator
        public readonly static string TWO = "two";

        ///  Say THREE start wordpad
        public readonly static string THREE = "three";

        ///  Say THREE start google
        public readonly static string FOUR = "four";

        ///  Say FIVE start youtube
        public readonly static string FIVE = "five";

    }
}
