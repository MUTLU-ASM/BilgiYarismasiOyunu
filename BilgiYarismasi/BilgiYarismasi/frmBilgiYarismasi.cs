using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class frmBilgiYarismasi : Form
    {
        public frmBilgiYarismasi()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            lblVeriTutma.Text = btnA.Text;
            if (lblCevap.Text == lblVeriTutma.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
            }
        }

        private void btnB_Click_1(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            lblVeriTutma.Text = btnB.Text;
            if (lblCevap.Text == lblVeriTutma.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
            }
        }

        private void btnC_Click_1(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            lblVeriTutma.Text = btnC.Text;
            if (lblCevap.Text == lblVeriTutma.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rctxtboxEkran.Text = "Bilgi Yarışmasına Hoşgeldiniz.Sorularımız altı sorudan oluşup Her doğru cevap 5 puan her yanlış cevap -3 puandır.";
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void btnD_Click_1(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            lblVeriTutma.Text = btnD.Text;
            if (lblCevap.Text == lblVeriTutma.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
            }
        }


        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            soruno++;
            lblSoruNo.Text = soruno.ToString();

            if (soruno==1)
            {
                rctxtboxEkran.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btnA.Text = "1925";
                btnB.Text = "1924";
                btnC.Text = "1923";
                btnD.Text = "1922";
                lblCevap.Text = "1923";
            }
            if (soruno == 2)
            {
                rctxtboxEkran.Text = "Türkiye'nin başkenti neresidir?";
                btnA.Text = "Ankara";
                btnB.Text = "İstanbul";
                btnC.Text = "Çorum";
                btnD.Text = "İzmir";
                lblCevap.Text = "Ankara";
            }
            if (soruno == 3)
            {
                rctxtboxEkran.Text = "Hangisi sırasında Atatürk 40'lı yaşlarının başındaydı?";
                btnA.Text = "Trablusgarp Savaşı";
                btnB.Text = "I. Balkan Savaşı";
                btnC.Text = "Cumhuriyetin ilanı";
                btnD.Text = "Hatay'ın Türkiye'ye katılması";
                lblCevap.Text = "Cumhuriyetin ilanı";
            }
            if (soruno == 4)
            {
                rctxtboxEkran.Text = "Guinness Dünya Rekorlarına göre Hintli Karate Nataraj ellerini kullanmadan ağzında kaç tane pipet tutabilmiştir?";
                btnA.Text = "50";
                btnB.Text = "250";
                btnC.Text = "450";
                btnD.Text = "650";
                lblCevap.Text = "650";
            }
            if (soruno == 5)
            {
                rctxtboxEkran.Text = "Hangisi Türkçe sözlüklerde tanımı olan bir kelime değildir?";
                btnA.Text = "Galoş";
                btnB.Text = "Gamboç";
                btnC.Text = "Gayzer";
                btnD.Text = "Gayda";
                lblCevap.Text = "Gamboç";
            }
            if (soruno == 6)
            {
                rctxtboxEkran.Text = "Fransa'dan trene binip deniz altındaki Manş Tüneli'nden geçen biri hangi ülkeye ulaşır?";
                btnA.Text = "Birleşik Krallık";
                btnB.Text = "Almanya";
                btnC.Text = "İzlanda";
                btnD.Text = "Portekiz";
                lblCevap.Text = "Birleşik Krallık";
            }
            if (soruno == 7)
            {
                int sonuc;
                sonuc = dogru *5+yanlis*-3;
                MessageBox.Show("Oyun Sonucu =  "+ sonuc);
                lblDogru.Text = "0";
                lblYanlis.Text = "0";
                lblSoruNo.Text = "0";
                rctxtboxEkran.Text = "Bilgi Yarışmasına Hoşgeldiniz.Sorularımız altı sorudan oluşup Her doğru cevap 5 puan her yanlış cevap -3 puandır.";
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = true;
                soruno = 0;
                dogru = 0;
                yanlis = 0;
            }
        }
    }
}
