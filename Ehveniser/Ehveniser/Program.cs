using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ehveniser
{
    static class Program
    {
        public static bool yeni=true;
        public static bool move;
        public static int mouse_x;
        public static int mouse_y;
        public static int statu = 4;
        public static int guc = 0;
        public static int ceviklik = 0;
        public static int canlilik = 0; 
        public static int odak = 0;
        public static string sinif = "";
        public static double saldiriOran = 0;
        public static double defansOran = 0;
        public static double canOran = 0;
        public static double kritikOran = 0;
        public static double can=0;
        public static double defans=0;
        public static double saldiri=0;
        public static double kritik=0;
        public static int seviye=1;
        public static int tecrube = 0;
        public static int altin=0;
        public static int kaderCan = 0;
        public static int kaderSaldiri = 0;
        public static int kaderDefans = 0;
        public static int kaderKritik = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static void sinifSonrasi()
        {
            saldiri += 10 * saldiriOran;
            can += 100 * canOran;
            defans += 10 * defansOran;
            kritik += kritikOran * 2;
        }
    }
    public class Rakip
    {
        public double rcan { get; set; }
        public int rsaldiri { get; set; }
        public int rdefans { get; set; }
        public double rkrit { get; set; }
        public string radi { get; set; }

        public void rakipTipi(int rakipTipi)
        {
            Random rastgele = new Random();
            if (rakipTipi == 1)
            {
                radi = "Ork Gözcüsü";
                rcan = rastgele.Next(70) + 100;
                rsaldiri = rastgele.Next(5) + 10;
                rdefans = rastgele.Next(5) +10;
                rkrit = rastgele.Next(2) + 2;
            }
            else if (rakipTipi == 2)
            {
                radi = "Ork Muhafızı";
                rcan = rastgele.Next(100) + 250;
                rsaldiri = rastgele.Next(15) + 15;
                rdefans = rastgele.Next(25) + 15;
                rkrit = rastgele.Next(4) + 5;
            }
            else if (rakipTipi==3)
            {
                radi = "Ork Reisi";
                rcan = rastgele.Next(200) + 500;
                rsaldiri = rastgele.Next(25) + 25;
                rdefans = rastgele.Next(25) + 25;
                rkrit = rastgele.Next(10) + 5;
            }
            else if (rakipTipi == 4)
            {
                radi = "Kadim Bekçi";
                rcan = rastgele.Next(200) + 1000;
                rsaldiri = rastgele.Next(35) + 60;
                rdefans = rastgele.Next(35) + 60;
                rkrit = rastgele.Next(10) + 10;
            }
            else if (rakipTipi == 5)
            {
                radi = "Zaun Süvarisi";
                rcan = rastgele.Next(1500) + 400;
                rsaldiri = rastgele.Next(35) + 85;
                rdefans = rastgele.Next(35) + 85;
                rkrit = rastgele.Next(12) + 5;
            }
            else if (rakipTipi==6)
            {
                radi = "Anduril";
                rcan = rastgele.Next(1500) + 400;
                rsaldiri = rastgele.Next(35) + 85;
                rdefans = rastgele.Next(35) + 85;
                rkrit = rastgele.Next(12) + 5;
            }
        }
    }
}
