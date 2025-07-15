namespace Lab_9_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TextBox _tbx;

        private void textbox_TextChanged(object sender, EventArgs e) // make text the same thing in textbox and label
        {
            label1.Text = _tbx.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e) //create textbox
        {
            _tbx = new TextBox();
            _tbx.Location = new Point(20, 20);
            _tbx.Size = new Size(250, 30);
            this.Controls.Add(_tbx);
            _tbx.TextChanged += new EventHandler(textbox_TextChanged);
        }

        private void btnDelete_Click(object sender, EventArgs e) //delete textbox
        {
            _tbx.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
