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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.Transparent;
            panel2.Parent = pictureBox1;
            panel2.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label12.Text = Program.statu.ToString();
            label34.Text = Program.seviye.ToString();
            label33.Text = Program.tecrube.ToString() + "/" + ((Program.seviye * 100).ToString());
            if (Program.yeni == true)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
                acilis();
            }
            button5.Visible = false;
            statuGosterim();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Program.move = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            statüHesap(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            Program.sinif = "Cengaver";
            Program.kritikOran = 1;
            Program.canOran = 1.5;
            Program.saldiriOran = 1.5;
            Program.defansOran = 1.5;
            Program.sinifSonrasi();
            acilis();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            Program.sinif = "Süikastçi";
            Program.kritikOran = 2;
            Program.canOran = 1;
            Program.saldiriOran = 2;
            Program.defansOran = 0.5;
            Program.sinifSonrasi();
            acilis();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            Program.sinif = "Öncü";
            Program.kritikOran = 0.5;
            Program.canOran = 2;
            Program.saldiriOran = 1;
            Program.defansOran = 2;
            Program.sinifSonrasi();
            acilis();
        }
        void acilis()
        {
            label22.Text = Program.sinif;
            label17.Text = Program.can.ToString();
            label18.Text = Program.saldiri.ToString();
            label19.Text = Program.defans.ToString();
            label20.Text = Program.kritik.ToString();
            Program.yeni = false;
            label7.Text = Program.guc.ToString();
            label8.Text = Program.ceviklik.ToString();
            label9.Text = Program.canlilik.ToString();
            label10.Text = Program.odak.ToString();
        }
        void statüHesap(int deger)
        {
            if (deger == 1)
            {
                Program.guc += 1;
                Program.saldiri += Program.saldiriOran * 1;
                Program.can += Program.canOran * 5;
            }
            else if (deger==2)
            {
                 Program.ceviklik += 1;
                 Program.saldiri += Program.saldiriOran * 1;
                 Program.kritik += Program.kritikOran * 1;
            }
            else if (deger==3)
            {
                Program.canlilik += 1;
                Program.can += Program.canOran * 10;
                Program.defans += Program.defansOran * 5;
            }
            else if (deger==4)
            {
                Program.odak += 1;
                Program.kritik += Program.kritikOran * 1;
                Program.defans += Program.defansOran * 5;
            }
            Program.statu -= 1;
            acilis();
            statuGosterim();
            label12.Text = Program.statu.ToString();
        }
        void statuGosterim()
        {
            if (Program.statu>0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            statüHesap(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            statüHesap(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            statüHesap(4);
        }
    }
}
