using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuess
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int tahminEdilecekSayi = 0;
        int kalanHakkiniz = 3;
        int girdigiTahminSayisi = 1;
        int chipPuan = Form1.kazanilanChip;
        int turSayisi = 1;

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            int tahmini = Convert.ToInt32(txtTahminSayisi.Text);

            if (kalanHakkiniz != 0)
            {
                if (tahmini == tahminEdilecekSayi)
                {
                    if (kalanHakkiniz == 3)
                    {
                        MessageBox.Show("1. tahminde bildiniz ve 200 chip kazandınız. Güncel Bakiyeniz: " + chipPuan.ToString());
                        chipPuan += 200;
                        txtKasa.Text = chipPuan.ToString();
                        txtTahminSayisi.Clear();
                        btnTahmin.Enabled = false;
                    }
                    else if (kalanHakkiniz == 2)
                    {
                        MessageBox.Show("2. tahminde bildiniz ve 100 chip kazandınız. Güncel Bakiyeniz: " + chipPuan.ToString());
                        chipPuan += 100;
                        txtKasa.Text = chipPuan.ToString();
                        txtTahminSayisi.Clear();
                        btnTahmin.Enabled = false;
                    }
                    else if (kalanHakkiniz == 1)
                    {
                        MessageBox.Show("3. tahminde bildiniz ve 50 chip kazandınız. Güncel Bakiyeniz: " + chipPuan.ToString());
                        chipPuan += 50;
                        txtKasa.Text = chipPuan.ToString();
                        txtTahminSayisi.Clear();
                        btnTahmin.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Tahmin hakkınız bitmiştir.");
                        btnTahmin.Enabled = false;
                    }
                }
                else if (tahmini > tahminEdilecekSayi || tahmini < tahminEdilecekSayi)
                {
                    kalanHakkiniz--;
                    txtKalanHak.Text = kalanHakkiniz.ToString();
                    chipPuan -= 100;
                    txtKasa.Text = chipPuan.ToString();
                    girdigiTahminSayisi++;
                    MessageBox.Show("Bilemediniz 100 chip keybetiniz. Güncel Bakiyeniz: " + chipPuan.ToString());
                    txtTahminSayisi.Clear();

                    if (kalanHakkiniz == 0)
                    {
                        MessageBox.Show("Tahmin hakkınız bitmiştir..!");
                        btnTahmin.Enabled = false;
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int gelenPuan = Form1.kazanilanChip;
            txtKasa.Text = gelenPuan.ToString();

            Random rdn = new Random();
            tahminEdilecekSayi = rdn.Next(0, 100);
            lblBackDoor.Text = tahminEdilecekSayi.ToString();

            txtKalanHak.Text = kalanHakkiniz.ToString();
            txtTurSayisi.Text = turSayisi.ToString();
        }

        private void btnYenidenOyna_Click(object sender, EventArgs e)
        {
            txtKalanHak.Text = string.Empty;
            kalanHakkiniz = 3;
            txtKalanHak.Text = kalanHakkiniz.ToString();

            tahminEdilecekSayi = 0;

            Random rdn = new Random();
            tahminEdilecekSayi = rdn.Next(0, 100);
            lblBackDoor.Text = tahminEdilecekSayi.ToString();

            btnTahmin.Enabled = true;
            turSayisi++;
            txtTurSayisi.Text = turSayisi.ToString();

        }
    }
    {
    }
}
