using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_10_14_Odev_OyunBebis_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void oyunButonAyarlari(bool deger)
        {
            btnYemekYe.Enabled = deger;
            btnUyut.Enabled = deger;
            btnTuvaleteGit.Enabled = deger;
            btnOldur.Enabled = deger;
            btnOyunaBasla.Enabled = !deger;
        }
        public void yasamDegisimi(int degisim)
        {
            yeniBebek.life = yeniBebek.life + degisim;
            lblLife.Text = yeniBebek.life.ToString();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            oyunButonAyarlari(false);
            Image resmmim = Image.FromFile("../../img/img (1).jpg");
            pictureBox1.Image = resmmim;
        }
        
        Bebis yeniBebek = new Bebis();

        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            oyunButonAyarlari(true);
            yeniBebek.life = 1000;
            yeniBebek.UstUsteTuvaletSayaci = 0;
            yeniBebek.UstUsteYemekSayaci = 0;
            lblLife.Text = yeniBebek.life.ToString();
            lblDurum.Text = "Hadi Göreyim Seni";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yasamDegisimi(-50);          
        }

        private void btnYemekYe_Click(object sender, EventArgs e)
        {
            yasamDegisimi(50);
            yeniBebek.UstUsteYemekSayaci += 1;
            yeniBebek.UstUsteTuvaletSayaci = 0;

            if (yeniBebek.UstUsteYemekSayaci == 5)
            {
                yeniBebek.life = -1;
                lblLife.Text = yeniBebek.life.ToString();
            }
            else if (yeniBebek.UstUsteYemekSayaci >= 4)
            {
                lblDurum.Text = "Çok Yedirdin Acil Tuvalet";
            }
            else
            {
                lblDurum.Text = "Çocuğun Yaşamı Sana Bağlı";
            }
        }

        private void btnTuvaleteGit_Click(object sender, EventArgs e)
        {
            yasamDegisimi(-50);
            yeniBebek.UstUsteTuvaletSayaci += 1;
            yeniBebek.UstUsteYemekSayaci = 0;

            if (yeniBebek.UstUsteTuvaletSayaci == 5)
            {
                yeniBebek.life = -1;
                lblLife.Text = yeniBebek.life.ToString();
            }
            else if (yeniBebek.UstUsteTuvaletSayaci >= 4)
            {
                lblDurum.Text = "Çok Acıktı Acil Yemek";
            }
            else
            {
                lblDurum.Text = "Çocuğun Yaşamı Sana Bağlı";
            }

        }

        private void btnUyut_Click(object sender, EventArgs e)
        {
            yasamDegisimi(+20);
        }

        private void btnOldur_Click(object sender, EventArgs e)
        {
            yeniBebek.life = -1;
            lblLife.Text = yeniBebek.life.ToString();
        }

        private void lblLife_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(lblLife.Text) > 1000)
            {
                lblDurum.Text = "Çok Yedirdin Tuvalete Gitmelisin";
            }
            else if(int.Parse(lblLife.Text) <= 0)
            {
                lblDurum.Text = "Çoçuğu öldürdün bakamayacaksan yapma";
                timer1.Stop();
                oyunButonAyarlari(false);
            }
            
        }

     

        
    }
}
