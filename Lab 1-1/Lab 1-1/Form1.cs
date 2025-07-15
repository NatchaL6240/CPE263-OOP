namespace Lab_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtName.Text);
            lblText.Text = ("พิมพ์ชื่อ-นามกสุล");
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtName.Text);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGreeting.Enabled = false;
            btnName.Enabled = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                btnGreeting.Enabled = false;
                btnName.Enabled = false;
            }
            else
            {
                btnGreeting.Enabled = true;
                btnName.Enabled = true;
            }
        }
    }
}
