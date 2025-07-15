namespace Lab_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCellbit_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\cellbit.jpg";
        }

        private void btnNuang_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Application.StartupPath + "\\nuang.jpg";
        }
    }
}
