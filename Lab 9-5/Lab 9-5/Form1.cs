namespace Lab_9_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //����Ҵ��鹵ç
            /*Graphics g = this.CreateGraphics();
            Pen myPen = new Pen(Color.Blue, 2);
            Point p1 = new Point(0, 0);
            Point p2 = new Point(500, 200);
            g.DrawLine(myPen, p1, p2);*/

            //����Ҵ��鹵ç�������
            /*Point[] myPoints = new Point[]
            {
            new Point(10,100),
            new Point(10,10),
            new Point(100,100),
            new Point(190,10),
            new Point(190,100)
            };
            Graphics g = this.CreateGraphics();
            Pen myPen = new Pen(Color.Red, 3);
            g.DrawLines(myPen, myPoints);*/

            //����Ҵ�����
            /*Point[] myPoints = new Point[]
            {
            new Point(10,100),
            new Point(10,10),
            new Point(100,100),
            new Point(190,10),
            new Point(190,100)
            };
            Graphics g = this.CreateGraphics();
            Pen myPen = new Pen(Color.Purple, 3);
            g.DrawCurve(myPen, myPoints);
            this.BackColor = Color.Turquoise;*/

            //����Ҵ�ٻ����������
            //�����ʹ DrawRectangle(Pen,x,y,width,height)
            Graphics g = this.CreateGraphics();
            Pen myPen = new Pen(Color.Purple, 3);
            g.DrawRectangle(myPen, 20, 20, 100, 100);

            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            g.FillRectangle(blueBrush, 130, 20, 100, 100);

            //����Ҵǧ���ǧ��
            /*Graphics g = this.CreateGraphics();
            Pen myPen = new Pen(Color.Green, 3);
            g.DrawEllipse(myPen,20,20,300,100);

            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            g.FillEllipse(blueBrush, 120,20,100,100);*/

        }
    }
}
