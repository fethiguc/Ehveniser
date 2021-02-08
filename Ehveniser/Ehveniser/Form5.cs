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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sans = 0;
        private void Form5_Load(object sender, EventArgs e)
        {
            buttonKontrol();
            label21.Text = "Altin :"+Program.altin.ToString();
            label7.Text = Program.kaderCan.ToString();
            label8.Text = Program.kaderSaldiri.ToString();
            label9.Text = Program.kaderDefans.ToString();
            label10.Text = Program.kaderKritik.ToString();
        }
        void buttonKontrol()
        {
            if (Program.altin<250)
            {
                button5.Enabled = false;
            }
            if (Program.altin < 100)
            {
                button4.Enabled = false;
            }
            if (Program.altin < 50)
            {
                button3.Enabled = false;
            }
            if (Program.altin < 20)
            {
                button2.Enabled = false;
            }
            if (Program.altin < 10)
            {
                button1.Enabled = false;
            }
            label21.Text = "Altin :" + Program.altin.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.altin -= 10;
            buttonKontrol();
            kader(10);
        }
        void kader(int i)
        {
            sans=rastgele.Next(100);
            if (sans<i)
            {
                if (i==10)
                {
                    ekle(1);
                }
                else if (i==20)
                {
                    ekle(1);
                }
                else if (i==30)
                {
                    ekle(2);
                }
                else if (i==40)
                {
                    ekle(5);
                }
                else if (i==50)
                {
                     ekle(10);
                }
            }
            else
            {
                MessageBox.Show("Güç kayboldu");
            }
        }
        void ekle(int j)
        {
            if (sans % 4 == 0)
            {
                Program.kaderSaldiri += j;
                Program.saldiri += j;
            }
            else if (sans % 4 == 1)
            {
                Program.kaderCan += j;
                Program.can += j;
            }
            else if (sans % 4 == 2)
            {
                Program.kaderDefans += j;
                Program.defans += j;
            }
            else
            {
                Program.kaderKritik += j;
                Program.kritik += j;
            }
            MessageBox.Show("Özellik ekleme başarılı :"+j);
            label7.Text = Program.kaderCan.ToString();
            label8.Text = Program.kaderSaldiri.ToString();
            label9.Text = Program.kaderDefans.ToString();
            label10.Text = Program.kaderKritik.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.altin -= 20;
            buttonKontrol();
            kader(20);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.altin -= 50;
            buttonKontrol();
            kader(30);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.altin -= 100;
            buttonKontrol();
            kader(40);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.altin -= 250;
            buttonKontrol();
            kader(50);
        }
    }
}
