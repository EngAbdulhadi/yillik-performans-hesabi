using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NDP_1.Odevi
{
    public class yiyecek
    {
        public string adi;
        public string cins;
        public double fiyat;
        public double kdvOrani;

        public yiyecek()
        {
            adi = "";
            cins = "";
            fiyat = 0.0;
            kdvOrani = 0.0;
        }

        public yiyecek(string a, string c, double f, double kdv)
        {
            adi = a;
            cins = c;
            fiyat = f;
            kdvOrani = kdv;
        }

        public virtual string yazdir()
        {
            return $"Adı: {adi}, Cinsi: {cins}, Fiyat: {fiyat}, KDV: {kdvOrani}";
        }
        public class Meyve : yiyecek
        {
            public int kalori;

            public Meyve(string a, string c, double f, double kdv, int kalori)
                : base(a, c, f, kdv)
            {
                this.kalori = kalori;
            }

            public override string yazdir()
            {
                return base.yazdir() + $", Kalori: {kalori}";
            }
        }
        public class Salata : yiyecek
        {
            public int kalori;

            public Salata(string a, string c, double f, double kdv, int kalori)
                : base(a, c, f, kdv)
            {
                this.kalori = kalori;
            }

            public override string yazdir()
            {
                return base.yazdir() + $", Kalori: {kalori}";
            }
        }
        public class Tatli : yiyecek
        {
            public int kalori;

            public Tatli(string a, string c, double f, double kdv, int kalori)
                : base(a, c, f, kdv)
            {
                this.kalori = kalori;
            }

            public override string yazdir()
            {
                return base.yazdir() + $", Kalori: {kalori}";
            }
        }
        public class Icecek : yiyecek
        {
            public int kalori;

            public Icecek(string a, string c, double f, double kdv, int kalori)
                : base(a, c, f, kdv)
            {
                this.kalori = kalori;
            }

            public override string yazdir()
            {
                return base.yazdir() + $", Kalori: {kalori}";
            }
        }
    }
    public class Menu
    {
        private List<yiyecek> yiyecekler = new List<yiyecek>();

        public void ekle(yiyecek yemek)
        {
            yiyecekler.Add(yemek);
        }

        public void sil(int index)
        {
            if (index >= 0 && index < yiyecekler.Count)
            {
                yiyecekler.RemoveAt(index);
            }
        }

        public List<yiyecek> menuYazdir()
        {
            return yiyecekler;
        }
    }

    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           yiyecek y =new yiyecek();
           Menu menu = new Menu();
        
            
           
        }
    }
}
