
using System.Windows.Forms;

namespace Commander.model
{
    class Settings
    {
        private int portNumber;
        private bool displayRecDialog;
        private readonly string path = Application.UserAppDataPath;
        private readonly string fileName = "\\commanderLog.txt";

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
                return path + fileName;
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
