namespace CarGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isGas = false;
        bool isR = false;
        private void button1_Click(object sender, EventArgs e)
        {
            isGas = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isGas == true && pictureBox1.Location.Y > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
            }
            else
            {
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            isR = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isR == true && pictureBox1.Location.Y <= 361)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (isGas == true && pictureBox1.Location.X > 12)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 200, pictureBox1.Location.Y);
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (isGas == true && pictureBox1.Location.X <205)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 200, pictureBox1.Location.Y);
            }
        }
    }
}
