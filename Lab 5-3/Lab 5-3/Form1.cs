namespace Lab_5_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string strIn = "";
            string strOut = "";
            int idx = 0;

            strIn = txtIn.Text;
            strOut = "ข้อความ String = " + strIn + "\n";
            foreach (char sTemp in strIn)
            {
                strOut += "strIn[" + idx + "] = "            //put incoming string in to arrays & print format
                + sTemp + "\n";
                idx++;
            }
            MessageBox.Show(strOut, "อาร์เรย์ strIn");          //print through MessageBox
        }

        private void btnVowels_Click(object sender, EventArgs e)
        {
            string strIn = "";

            int A = 0, E = 0, I = 0, O = 0, U = 0;          
            strIn = txtIn.Text;
            foreach (char sTemp in strIn)
            {
                switch (char.ToUpper(sTemp))
                {
                    case 'A':
                        A++;
                        break;

                    case 'E':
                        E++;
                        break;

                    case 'I':
                        I++;
                        break;

                    case 'O':
                        O++;
                        break;

                    case 'U':
                        U++;
                        break;
                }
            }
            MessageBox.Show($"A = {A}, E = {E}, I = {I}, O = {O}, U = {U}");
        }
    }
}
