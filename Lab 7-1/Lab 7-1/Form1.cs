namespace Lab_7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ElectricalAppliance objElec;
        TV objTV;
        Fan objFAN;
        private void ShowProperty(ElectricalAppliance oe)
        {
            string strOut = "";
            strOut += "Brand : " + oe.BRAND + "\r\n";
            strOut += "Electric Type : " + oe.ELECType + "\r\n";
            strOut += "LifeTime : " + oe.LT + "\r\n";
            strOut += "Save Electric NO. : " + oe.SEN;
            MessageBox.Show(strOut);
        }

        private void btnELECcreate_Click(object sender, EventArgs e)
        {
            objElec = new ElectricalAppliance();

            objElec.BRAND = txtBrand.Text;
            objElec.ELECType = txtType.Text;
            objElec.LT = txtLT.Text;
            objElec.SEN = txtSN.Text;
            ShowProperty(objElec);

            btnELECcreate.Enabled = false;
            btnWorkE.Enabled = true;
        }

        private void btnWorkE_Click(object sender, EventArgs e)
        {
            string strIN = txtONOFF.Text;
            objElec = new ElectricalAppliance();

            string strELEC = objElec.Working(strIN);
            MessageBox.Show(strELEC);
        }

        private void ShowPropertyTV(TV oe)
        {
            string strOut = "";
            strOut += "Type : " + oe.TYPE + "\r\n";
            strOut += "Monitor : " + oe.SCREEN + "\r\n";
            strOut += "TV Save NO. : " + oe.SNTV;
            MessageBox.Show(strOut);
        }

        private void btnCreateTV_Click(object sender, EventArgs e)
        {
            objTV = new TV();

            objTV.TYPE = txtTypeTV.Text;
            objTV.SCREEN = txtMonitor.Text;
            objTV.SNTV = txtTVsn.Text;
            ShowPropertyTV(objTV);

            btnCreateTV.Enabled = false;
            btnTV.Enabled = true;
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            string strChannel = txtChannel.Text;
            string strDay = txtDay.Text;
            string strTime = txtTime.Text;
            objTV = new TV();

            string strTV = objTV.TVShow(strChannel, strDay, strTime);
            MessageBox.Show(strTV);
        }
    }
}
