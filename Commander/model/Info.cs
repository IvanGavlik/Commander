using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander.model
{
    class Info
    {
        private string infoValue;

        public string Value
        {
            get { return infoValue; }
            set { infoValue = value; }
        }

        //Singeleton

        private static Info instance;

        public static Info GetInstance()
        {
            if(instance == null)
            {
                instance = new Info();
            }
            return instance;
        }
    }
}
