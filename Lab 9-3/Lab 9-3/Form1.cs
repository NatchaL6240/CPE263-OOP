namespace Lab_9_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int power2(int z)
        {
            z = z * z;
            return z;
        }

        private void Form1_Load(object sender, EventArgs e) // red tab is break point
        {
            int x = 0, y = 0;
            for(int i =1; i < 5; i++)
            {
                x += i;
                y = power2(x) + 1;
            }
        }
    }
}
