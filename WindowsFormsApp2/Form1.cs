using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtKullanıcı.Text;
            string sifre = txtSifre.Text;   

            Kullanıcı bulunan = SanalDatabase.kullaniciadıListe.Find(i => i.kullaniciadi == kullaniciadi && i.sifre==sifre);

            if(bulunan != null)
            {
                anaform _anaform = new anaform(bulunan);
                _anaform.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı bilgileri","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtKullanıcı_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKullanıcı_Enter(object sender, EventArgs e)
        {
            TextBox T2 =(TextBox)sender;
            T2.BackColor = Color.Pink;
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            TextBox T3 = (TextBox)sender;
            T3.BackColor = Color.Pink;
        }

        private void txtKullanıcı_Leave(object sender, EventArgs e)
        {
            TextBox T2 = (TextBox)sender;
            T2.BackColor = Color.White;
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            TextBox T2 = (TextBox)sender;
            T2.BackColor = Color.White;
        }
    }
}
