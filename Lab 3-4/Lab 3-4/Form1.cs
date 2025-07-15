namespace Lab_3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string fw = "";
            int version;
            version = Convert.ToInt16(txtYear.Text);
            switch(version)
            {
                case 2002:
                    fw = ".NET Framework 1.0";
                    break;

                case 2005:
                    fw = ".NET Framework 2.0";
                    break;

                case 2008:
                    fw = ".NET Framework 3.5";
                    break;

                case 2010:
                    fw = ".NET Framework 4.0";
                    break;

                case 2019:
                    fw = ".NET Framework 5.0";
                    break;

                default:
                    fw = "พิมพ์ปีไม่ถูกต้อง";
                    break;
            }
            MessageBox.Show(fw);
        }
    }
}
