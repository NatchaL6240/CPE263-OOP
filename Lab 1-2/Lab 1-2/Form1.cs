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
            MessageBox.Show("����: " + txtName.Text + "\n"
                + "���ʡ��: " + txtSurname.Text + "\n"
                + "����: " + txtNum.Text + "\n"
                + "�ô C#: " + txtGrade.Text);
        }
    }
}
