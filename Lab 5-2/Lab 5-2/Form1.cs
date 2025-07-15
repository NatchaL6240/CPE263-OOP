namespace Lab_5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int[] intA = new int[6] { 2, 4, 6, 8, 10, 12 };
            int[] intB = intA;
            int[] intC = new int[6];
            string strOut = " C = A + B " + "\n";
            int idx = 0;
            foreach (int iTemp in intC)
            {

                intC[idx] = intA[idx] + intB[idx];
                idx++;

            }
            idx = 0;
            foreach (int iTemp in intC)
            {
                strOut += "intC[" + idx.ToString() + "] = " + intC[idx] + "\n";

                idx++;

            }
            MessageBox.Show(strOut, "อาร์เรย์ intC");
        }
    }
}
