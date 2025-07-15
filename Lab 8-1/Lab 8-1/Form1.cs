namespace Lab_8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // มี _ ข้างหน้า = ตัวแปร global
        private int _red = 255;
        private int _green = 255;
        private int _blue = 255;


        private void updateRGB()
        {
            lblRGB.BackColor = Color.FromArgb(_red, _green, _blue);
            lblText.Text = "(" + _red + ", " + _green + ", " + _blue + ")";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tckRed_Scroll(sender, e);
            tckGreen_Scroll(sender, e);
            tckBlue_Scroll(sender, e);
        }

        private void tckRed_Scroll(object sender, EventArgs e)
        {
            _red = tckRed.Value;
            lblRed.BackColor = Color.FromArgb(tckRed.Value, 0, 0);
            updateRGB();
        }

        private void tckGreen_Scroll(object sender, EventArgs e)
        {
            _green = tckGreen.Value;
            lblGreen.BackColor = Color.FromArgb(0, tckGreen.Value, 0);
            updateRGB();
        }

        private void tckBlue_Scroll(object sender, EventArgs e)
        {
            _blue = tckBlue.Value;
            lblBlue.BackColor = Color.FromArgb(0, 0, tckBlue.Value);
            updateRGB();
        }
    }
}
