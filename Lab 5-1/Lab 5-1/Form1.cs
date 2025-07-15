namespace Lab_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int odd = 0, even = 0;
            //การสร้างตัวแปร Array พร้อมก าหนดค่าเริ่มต้น

            int[] arr = { 1, 2, 5, 7, 8, 11, 13, 25, 28, 99, 22, 33, 75 };
            foreach (int i in arr)
            {

                if (i % 2 == 0)
                    even++;
                else
                    odd++;

            }
            string str = "จำนวนคู่ = " +even + Environment.NewLine +
                           "จำนวนคี่ = " +odd;
            MessageBox.Show(str);
        }
    }
}
