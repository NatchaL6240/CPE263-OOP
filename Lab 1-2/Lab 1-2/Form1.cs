namespace Lab_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ชื่อ: " + txtName.Text + "\n"
                + "นามสกุล: " + txtSurname.Text + "\n"
                + "รหัส: " + txtNum.Text + "\n"
                + "เกรด C#: " + txtGrade.Text);
        }
    }
}
