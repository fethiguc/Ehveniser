using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ehveniser
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static int dusman=0;
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = Program.sinif;
            label7.Text = Program.can.ToString();
            label8.Text = Program.saldiri.ToString();
            label9.Text = Program.defans.ToString();
            label10.Text = Program.kritik.ToString();
            label12.Text = "Altin :" + Program.altin.ToString();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Program.move == true)
            {
                this.SetDesktopLocation(MousePosition.X - Program.mouse_x, MousePosition.Y - Program.mouse_y);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Program.move = true;
            Program.mouse_x = e.X;
            Program.mouse_y = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Program.move = false;
        }
        void savasMenu()
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dusman = 1;
            savasMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dusman = 2;
            savasMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dusman = 3;
            savasMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dusman = 4;
            savasMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dusman = 5;
            savasMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dusman = 6;
            savasMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }
    }
}
