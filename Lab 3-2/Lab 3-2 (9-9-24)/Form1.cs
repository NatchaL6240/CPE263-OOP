using System.Diagnostics.Eventing.Reader;

namespace Lab_3_2__9_9_24_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (rad1.Checked == true)
            {
                MessageBox.Show(rad1.Text);
            }
            else if (rad2.Checked == true)
            {
                MessageBox.Show(rad2.Text);
            }
            else
            {
                MessageBox.Show(rad3.Text);
            }
        }
    }
}
