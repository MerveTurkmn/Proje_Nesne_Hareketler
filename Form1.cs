using System.Windows.Forms;

namespace Proje_Nesne_Hareketler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= -1)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, System.EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 651)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, System.EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 297)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, System.EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 129)
            {
                timer4.Stop();
                timer5.Start();
            }
        }

        private void timer5_Tick(object sender, System.EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 74)
            {
                timer5.Stop();
                timer6.Start();
            }

        }

        private void timer6_Tick(object sender, System.EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 521)
            {
                timer6.Stop();
                timer7.Start();
            }
        }

        private void timer7_Tick(object sender, System.EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 229)
            {
                timer7.Stop();
                timer8.Start();
            }
        }

        private void timer8_Tick(object sender, System.EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 243)
            {
                timer8.Stop();
                timer9.Start();
            }
        }

        private void timer9_Tick(object sender, System.EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 146)
            {
                timer9.Stop();
                timer10.Start();
            }
        }

        private void timer10_Tick(object sender, System.EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 406)
            {
                timer10.Stop();
                MessageBox.Show("Sona geldiniz.");
            }
        }
    }
}
