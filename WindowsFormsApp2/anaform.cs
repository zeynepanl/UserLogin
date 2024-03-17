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
    public partial class anaform : Form
    {
        public anaform(Kullanıcı bulunanKullanıcı)
        {
            InitializeComponent();
            txtisim.Text = bulunanKullanıcı.isim;
            txtsoyisim.Text = bulunanKullanıcı.soyisim;
            txtkullaniciadi.Text = bulunanKullanıcı.kullaniciadi;
            txtkullaniciadi.Enabled = false;    
            txtsifre.Text = bulunanKullanıcı.sifre;
            txtaciklama.Text = bulunanKullanıcı.aciklama;
            btnguncelle.Tag = bulunanKullanıcı.id;



        }

        private void anaform_Load(object sender, EventArgs e)
        {

        }

        private void txtisim_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            // Button B1= (Button)sender;
            int id = (int)btnguncelle.Tag;
            int index =SanalDatabase.kullaniciadıListe.FindIndex(i => i.id == id);
            SanalDatabase.kullaniciadıListe[index].isim=txtisim.Text;
            SanalDatabase.kullaniciadıListe[index].soyisim = txtsoyisim.Text;
            SanalDatabase.kullaniciadıListe[index].sifre = txtsifre.Text;
            SanalDatabase.kullaniciadıListe[index].aciklama = txtaciklama.Text;

            MessageBox.Show("Kullanıcı Güncellendi.");
            Close();


        }
    }
}
