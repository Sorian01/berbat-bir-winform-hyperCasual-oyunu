using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGame
{
    public partial class OyunEkran : Form
    {
        public int sure;
        public int para = 0;
        public float saglik = 100;
        public float dusmanSaglik = 100;
        public int fiyatC = 40;
        public int fiyatH = 40;
        public int fiyatP = 40;
        public float artmaMiktari = 10;
        public float ekleSaglik = 5;
        public int paraEkle = 7;

        public int karHasar = 10;
        public int dusHasar = 3;
        bool oldu = false;


        Random rand = new Random();

        public OyunEkran()
        {
            
            InitializeComponent();
            MessageBox.Show("Olabildiğince hızlı bir şekilde saldırı butonuna tıklayın");
            DPS.Start();
            CanFiyat.Text = fiyatC + " altın";
            HasarFiyat.Text = fiyatH + " altın";
            ParaFiyat.Text = fiyatP + " altın";
            dusmanSaglik = 100;
        }
        //Saldiri Butonu Methodları
        private void Saldiri_MouseDown(object sender, MouseEventArgs e)
        {
            Saldiri.BorderStyle = BorderStyle.Fixed3D;
        }
        private void Saldiri_MouseUp(object sender, MouseEventArgs e)
        {
            Saldiri.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Saldiri_Click(object sender, EventArgs e)
        {
            DusmanaHasarVer();
            DusmanSaglikPuani.Text = dusmanSaglik.ToString("0");
            if (dusmanSaglik <= 0)
            {
                DusmanSec();
            }
        }



        //Bazı methodlar işte ya
        private void DPS_Tick(object sender, EventArgs e)
        {
            sure++;
            Para.Text = para.ToString();
            Saat.Text = sure.ToString();
            KarakterHasarAl();
            SaglikPuani.Text = saglik.ToString("0");
            if (saglik <= 0 && !oldu)
            {
                oldu = true;
                MessageBox.Show("Öldün");
                this.Close();
            }

            if (para > 30000)
            {
                MessageBox.Show("Hile yapmasana puşt");
                this.Close();
            }
        }

        void KarakterHasarAl()
        {
            saglik -= dusHasar;
        }

        void DusmanaHasarVer()
        {
            dusmanSaglik -= karHasar;
        }

        void DusmanSec()
        {
            artmaMiktari += artmaMiktari * 0.5f;
            int rastgele = rand.Next(1, 4);
            dusmanSaglik = 100 + artmaMiktari;
            para += paraEkle;
            Para.Text = para.ToString();
            switch (rastgele)
            {
                case 1:
                    DusmanResim.Image = RPGGame.Properties.Resources.Battle_turtle;
                    
                    break;
                case 2:
                    DusmanResim.Image = RPGGame.Properties.Resources.Centipede;

                    break;
                case 3:
                    DusmanResim.Image = RPGGame.Properties.Resources.Big_bloated;

                    break;


            }
        }

        private void CanArtır_Click(object sender, EventArgs e)
        {
            if(para >= fiyatC)
            {
                para -= fiyatC;
                ekleSaglik += ekleSaglik * 0.3f;
                saglik += ekleSaglik;
                fiyatC += 20;
                CanFiyat.Text = fiyatC + " altın";
            }
            
        }

        private void HasarArtır_Click(object sender, EventArgs e)
        {
            if (para >= fiyatH)
            {
                para -= fiyatH;
                karHasar += 10;
                fiyatH += 20;
                HasarFiyat.Text = fiyatH + " altın";
            }
        }

        private void ParaArtır_Click(object sender, EventArgs e)
        {
            if (para >= fiyatC)
            {
                para -= fiyatC;
                paraEkle += 5;
                fiyatP += 20;
                ParaFiyat.Text = fiyatP + " altın";
            }
        }

        //BAzı Denemelik Methodlar
    }
}
