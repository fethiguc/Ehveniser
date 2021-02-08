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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        double acan = Program.can;
        double hasar = 0;
        string metin;
        Rakip rakip = new Rakip();
        private void Form4_Load(object sender, EventArgs e)
        {
            rakip.rakipTipi(Form3.dusman);
            if (Form3.dusman == 1)
            {
                pictureBox1.Image = Image.FromFile("savas1.gif");
            }
            else if (Form3.dusman == 2)
            {
                pictureBox1.Image = Image.FromFile("savas2.gif");
            }
            else if (Form3.dusman == 3)
            {
                pictureBox1.Image = Image.FromFile("savas3.gif");
            }
            else if (Form3.dusman == 4)
            {
                pictureBox1.Image = Image.FromFile("savas4.gif");
            }
            else if (Form3.dusman == 5)
            {
                pictureBox1.Image = Image.FromFile("savas5.gif");
            }
            else if (Form3.dusman == 6)
            {
                pictureBox1.Image = Image.FromFile("savas6.gif");
            }
            label2.Text = Program.sinif;
            label7.Text = acan.ToString();
            label8.Text = Program.saldiri.ToString();
            label9.Text = Program.defans.ToString();
            label10.Text = Program.kritik.ToString();
            label14.Text = rakip.rcan.ToString();
            label13.Text = rakip.rsaldiri.ToString();
            label12.Text = rakip.rdefans.ToString();
            label11.Text = rakip.rkrit.ToString();
            label19.Text = rakip.radi;
            button2.Enabled = false;
            button1.Enabled = true;
            label23.Text = Program.seviye.ToString();
            button3.Visible = false;
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
            metin = "";
            hasar = Program.saldiri - (rakip.rdefans * 0.1);
            hasar = Math.Floor(hasar);
            hasar = kritHesap(hasar, Program.kritik);
            ozelPasif();
            rakip.rcan -= hasar;
            metin += "Rakibe " + hasar.ToString() + "vurdunuz.";
            label14.Text = rakip.rcan.ToString();
            button1.Enabled = false;
            button2.Enabled = true;
            rakipOlum();
            label28.Text = metin;

        }
        void ozelPasif()
        {
            int rastgele = rnd.Next(100);
            if (rastgele > 85)
            {
                if (Program.sinif == "Cengaver")
                {
                    if (hasar + acan > Program.can)
                    {
                        acan = Program.can;
                    }
                    else
                    {
                        acan = acan + hasar;
                    }
                    metin += "Hortlağın pençesi çalıştı can yenilediniz. ";
                    label7.Text = acan.ToString();
                }
                else if (Program.sinif == "Süikastçi")
                {
                    hasar = hasar * 2;
                    metin += "Keskin hançer çalıştı 2 kar hasar vurulacak. ";
                }
            }
        }
        void oncuPasif()
        {
            int rastgele = rnd.Next(100);
            if (rastgele > 85)
            {
                if (Program.sinif == "Öncü")
                {
                    hasar = 0;
                    metin += "Korkutucu zırh çalıştı yediğiniz hasar 0 a indi. ";
                }
            }
        }
        void rakipOlum()
        {
            if (rakip.rcan < 1)
            {
                metin += "Rakibinize öldürücü darbe yaptınız.";
                rakip.rcan = 0;
                label14.Text = rakip.rcan.ToString();
                button3.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
                if (Form3.dusman == 1)
                {
                    Program.tecrube += 45;
                    Program.altin += 10;
                }
                else if (Form3.dusman == 2)
                {
                    Program.tecrube += 85;
                    Program.altin += 25;
                }
                else if (Form3.dusman == 1)
                {
                    Program.tecrube += 145;
                    Program.altin += 65;
                }
                else if (Form3.dusman == 1)
                {
                    Program.tecrube += 200;
                    Program.altin += 125;
                }
                else if (Form3.dusman == 1)
                {
                    Program.tecrube += 280;
                    Program.altin += 255;
                }
                else if (Form3.dusman == 1)
                {
                    Program.tecrube += 350;
                    Program.altin += 560;
                }
            }
        }
        void olum()
        {
            if (acan < 1)
            {
                metin += "Öldünüz.";
                acan = 0;
                label7.Text = acan.ToString();
                button3.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }
        double kritHesap(double hasar, double krit)
        {
            int rastgele = rnd.Next(100);
            if (rastgele < krit)
            {
                hasar = hasar * 2;
                metin += "Kritik çalıştı";
            }
            return hasar;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            metin = "";
            hasar = rakip.rsaldiri - (Program.defans * 0.10);
            hasar = Math.Floor(hasar);
            oncuPasif();
            hasar = kritHesap(hasar, rakip.rkrit);
            acan -= hasar;
            metin += "Rakip " + hasar.ToString() + "vurdu.";
            label7.Text = acan.ToString();
            button2.Enabled = false;
            button1.Enabled = true;
            olum();
            label28.Text = metin;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.tecrube>=Program.seviye*100)
            {
                Program.tecrube =Program.tecrube- (Program.seviye * 100);
                Program.seviye += 1;
                Program.statu += 2;
                Form2 frm2=new Form2();
                frm2.Show();
                this.Hide();
            }
            else
            {
                Form3 frm3 = new Form3();
                frm3.Show();
                this.Hide();
            }
        }
    }
}
