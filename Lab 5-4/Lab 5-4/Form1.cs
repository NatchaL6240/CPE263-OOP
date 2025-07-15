namespace Lab_5_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int[,] A = new int[3, 3] { { 1, 2, 3 },
                                        { 4, 5, 6 },
                                        { 7, 8, 9 } };
            int[,] B = new int[3, 3] { { 1, 2, 3 },
                                        { 4, 5, 6 },
                                        { 7, 8, 9 } };
            int[,] C = new int[3, 3];
            string strOut = "Matrix C " + "\n";
            for (int y = C.GetLowerBound(1); y <= C.GetUpperBound(1); y++)
            {
                for (int x = C.GetLowerBound(0); x <= C.GetUpperBound(0); x++)
                {
                    C[x,y] = A[x,y] + B[x,y];

                    strOut += C[x,y] + " ";
                }

                strOut += "\n";
            }
            MessageBox.Show(strOut);
        }
    }
}
