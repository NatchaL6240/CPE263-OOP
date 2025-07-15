using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_1
{
    internal class ElectricalAppliance
    {
        private string brand = "";
        private string ElecType = "";
        private string life = "";
        private string SaveNo = "";

        //properties
        public string BRAND
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }

        public string ELECType
        {
            get
            {
                return ElecType;
            }
            set
            {
                ElecType = value;
            }
        }

        public string LT
        {
            get 
            { 
                return life;
            }
            set 
            { 
                life = value; 
            }
        }

        public string SEN
        {
            get
            {
                return SaveNo;
            }
            set
            {
                SaveNo = value;
            }
        }

        // Method

        public string Working(string state)
        {

            string strOut = "";

            if (state == "ON")
                strOut = "อุปกรณ์ทำงาน";
            else if (state == "OFF")
                strOut = "อุปกรณ์ไม่ทำงาน";
            else
                strOut = "พิมพ์ 'ON' หรือ 'OFF' เท่านั้น";

            return strOut;
        }

        // Constructor

        public ElectricalAppliance() 
        {
            brand = "";
            ElecType = "";
            life = "";
            SaveNo = "";
        }

        
    }
}
