using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuess
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int kazanilanChip;

        private void btnOynaBasla_Click(object sender, EventArgs e)
        {
            if (kazanilanChip != 0)
            {
                Form2 frm = new Form2();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Öncelikle chip kazan butonuna tıklayınız ve bedava chip kazanın..!");
            }
        }

        private void btnChipKazan_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            kazanilanChip = rdn.Next(1000, 2000);
            MessageBox.Show(kazanilanChip + " PUANLIK CHIP KAZANDIN");
            btnChipKazan.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
