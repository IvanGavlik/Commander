
using System.Windows.Forms;

namespace Commander.model
{
    class Settings
    {
        private int portNumber;
        private bool displayRecDialog;
        private string fullPath;
       

        public int Port
        {
            get {
                return portNumber;
            }
            set
            {
                portNumber = value;
            }
        }

        public bool DispalyInfo
        {
            get
            {
                return displayRecDialog;
            }
            set
            {
                displayRecDialog = value;
            }
        }

        public string LogFilePath
        {
            get
            {
                return fullPath;
            }
            set
            {
                fullPath = value;
            }
        }


        //Singleton
        private static Settings instance;

        public static Settings GetInstance()
        {
            if (instance == null)
            {
                instance = new Settings();
            }
            return instance;
        }

    }
}
