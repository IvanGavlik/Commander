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

        public readonly static string TASK = "eclipse task";

        public readonly static string SEARCH = "eclipse search";

        public readonly static string SKIP_ALL_BREAK_POINTS = "eclipse skip";

        public readonly static string GETTER_SETTER = "eclipse get";

        public readonly static string HASHCODE_EQUALS = "eclipse hash";

        public readonly static string TO_STRING = "eclipse string";

        public readonly static string FORMAT = "eclipse format";

        public readonly static string NEW = "eclipse new";

        public readonly static string SAVE = "eclipse save";

        public readonly static string RENAME = "eclipse rename";

        public readonly static string CUT = "eclipse cut";

        public readonly static string COPY = "eclipse copy";

        public readonly static string PASTE = "eclipse paste";

        public readonly static string SELECT_ALL = "eclipse all";

        public readonly static string DELETE = "eclipse delete";

        public readonly static string CLOSE = "eclipse close";

        public static string[] GetEclipseCommands()
        {
            string[] commands = {
                TASK, SEARCH, SKIP_ALL_BREAK_POINTS, GETTER_SETTER,
                HASHCODE_EQUALS, TO_STRING, FORMAT, NEW, SAVE,
                RENAME, CUT, COPY, PASTE,
                SELECT_ALL, DELETE, CLOSE
            };
            return commands;
        }
    }

}
