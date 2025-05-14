using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NDP_1.Odevi.yiyecek;
using static NDP_1.Odevi.Menu;
using static NDP_1.Odevi.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI...._1_......:
**				ÖĞRENCİ ADI ABDULHADI KRIMESH:
**				ÖĞRENCİ NUMARASI G231210577:
**                         DERSİN ALINDIĞI GRUP.B.:
****************************************************************************/


namespace NDP_1.Odevi
{
    public partial class Form1 : Form
    {
        Menu menu = new Menu(); // Menü nesnesini oluştur

        public Form1()
        {
            InitializeComponent();
            // ComboBox'a öğeler ekle
            Yiyecek.Items.Add("Meyve");
            Yiyecek.Items.Add("Salata");
            Yiyecek.Items.Add("Tatlı");
            Yiyecek.Items.Add("İçecek");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan veriler
            string adi = txtAdi.Text;
            string cins = txtCinsi.Text;
            double fiyat = double.Parse(txtFiyat.Text);
            double kdv = double.Parse(txtKdv.Text);
            int kalori = int.Parse(txtKalori.Text);

            yiyecek yeniYiyecek = null;

            // Tür seçimine göre nesne oluşturma
            switch (Yiyecek.SelectedItem.ToString())
            {
                case "Meyve":
                    yeniYiyecek = new Meyve(adi, cins, fiyat, kdv, kalori);
                    break;
                case "Salata":
                    yeniYiyecek = new Salata(adi, cins, fiyat, kdv, kalori);
                    break;
                case "Tatlı":
                    yeniYiyecek = new Tatli(adi, cins, fiyat, kdv, kalori);
                    break;
                case "İçecek":
                    yeniYiyecek = new Icecek(adi, cins, fiyat, kdv, kalori);
                    break;
            }

            // Değerlerin kontrolü
            if (fiyat < 10 || fiyat > 100 || kalori > 500)
            {
                MessageBox.Show("Girilen değerler uygun değil, menü kabul edilmedi!");
            }
            else
            {
                // Değerler uygunsa menüye ekleme
                menu.ekle(yeniYiyecek);
                MessageBox.Show("Menüye başarıyla eklendi!");
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            double toplamTutar = 0; // Toplam tutarı hesaplamak için değişken
            listBoxMenu.Items.Clear(); // ListBox'ı temizle

            // Menüyü dolaş ve öğeleri ekle
            foreach (var item in menu.menuYazdir())
            {
                listBoxMenu.Items.Add(item.yazdir()); // Öğeyi ListBox'a ekle

                // Fiyat ve KDV'yi hesaba kat
                toplamTutar += item.fiyat + (item.fiyat * item.kdvOrani / 100);
            }

            lblTotal.Text = $"Toplam Tutar (KDV Dahil): {toplamTutar:C}"; // Toplam tutarı göster
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // ListBox'ta bir öğe seçili mi kontrol et
            if (listBoxMenu.SelectedIndex != -1)
            {
                // Seçilen öğeyi menüden ve ListBox'tan sil
                int index = listBoxMenu.SelectedIndex;
                menu.sil(index);
                listBoxMenu.Items.RemoveAt(index);

                MessageBox.Show("Öğe başarıyla silindi!");
            }
            else
            {
                // Hiçbir öğe seçilmediyse uyarı göster
                MessageBox.Show("Lütfen silmek için bir öğe seçin.");
            }
        }
    }
}