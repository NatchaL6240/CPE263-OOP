namespace Lab_8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            if(radBlocks.Checked) //if(redBlocks.Checked == true)
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
            }
            else if (radCont.Checked)
            {
                progressBar1.Style = ProgressBarStyle.Continuous;
            }
            else if (radMarq.Checked)
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
            }
            progressBar1.Value = 0;
            for(int i = progressBar1.Minimum; i <=progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
                this.Text = i.ToString() + "%";
                System.Threading.Thread.Sleep(50); //หยุดทำงาน 50 millisec | .Sleep = หลับ/หยุดทำงาน
            }
            btnStart.Enabled = true;
            if(progressBar1.Style == ProgressBarStyle.Marquee)
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
            }
        }
    }
}
