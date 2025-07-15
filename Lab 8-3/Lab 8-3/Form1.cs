namespace Lab_8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string trafLamp;

        private void lampOff()
        {
            btnRed.BackColor = Color.White;
            btnGreen.BackColor = Color.White;
            btnYellow.BackColor = Color.White;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lampOff();
            switch (trafLamp)
            {
                case "red":
                    btnGreen.BackColor = Color.Green;
                    timer1.Interval = Convert.ToInt16(numGreen.Value) * 1000; //1000 millisec = 1 sec
                    trafLamp = "green";
                    break;

                case "green":
                    btnYellow.BackColor = Color.Yellow;
                    timer1.Interval = Convert.ToInt16(numYellow.Value) * 1000;
                    trafLamp = "yellow";
                    break;

                case "yellow":
                    btnRed.BackColor = Color.Red;
                    timer1.Interval = Convert.ToInt16(numRed.Value) * 1000;
                    trafLamp = "red";
                    break;
            }
        }

        private void radOn_CheckedChanged(object sender, EventArgs e)
        {
            if (radOn.Checked)
            {
                trafLamp = "yellow";
                timer1.Interval = 1;
                timer1.Start(); //เริ่มตั้งเวลา
            }
            else
            {
                lampOff();
                timer1.Stop(); //หยุด
            }
        }
    }
}
