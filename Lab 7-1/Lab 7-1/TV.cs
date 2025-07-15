using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7_1
{
    internal class TV:ElectricalAppliance
    {
        private string type = "";
        private string screen = "";
        private string SaveTVNo = "";


        public string TYPE
        {
            get { return type; }
            set { type = value; }
        }

        public string SCREEN
        {
            get { return screen; }
            set { screen = value; }
        }
        public string SNTV
        {
            get
            { return SaveTVNo; }
            set
            { SaveTVNo = value; }
        }

        public string TVShow(string channel, string day, string strTime)
        {
            string strOut = "";
            strOut = "รายการ : " + channel + "\r\n" + "ออกอากาศวัน : " + day + "\r\n" + "เป็นเวลา : " + strTime + " ชม.";
            return strOut;
        }
    }
}
