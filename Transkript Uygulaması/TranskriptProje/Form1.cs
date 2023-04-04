using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranskriptProje
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database= dbtranskript; username = postgres; password = 1234");

        private void btnGoster_Click(object sender, EventArgs e)
        {
            string sorgu = " select * from ders";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewVeriler.DataSource = ds.Tables[0];
        }

        public void Ekle()
        {
            baglanti.Open();
            string ekle = "insert into ders (ders_kodu,ders_adi,ders_kredi,ders_akts,ogretim_uyesi,donem,harf_notu) values(@p1, @p2, @p3, @p4, @p5, @p6, @p7)";
            NpgsqlCommand cmd = new NpgsqlCommand(ekle, baglanti);
            cmd.Parameters.AddWithValue("@p1", txtDersKodu.Text);
            cmd.Parameters.AddWithValue("@p2", txtDersAdı.Text);
            cmd.Parameters.AddWithValue("@p3", int.Parse(txtDersKredi.Text));
            cmd.Parameters.AddWithValue("@p4", int.Parse(numericUpDownDersAkts.Text));
            cmd.Parameters.AddWithValue("@p5", txtOgretimUyesi.Text);
            cmd.Parameters.AddWithValue("@p6", cmbDonem.Text);
            cmd.Parameters.AddWithValue("@p7", cmbHarfNotu.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ders Kaydı Eklendi");
        }

        private void btnEkle(object sender, EventArgs e)
        {
            Ekle();
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            formSilme f2 = new formSilme();
            f2.ShowDialog();
        }

       

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnDersGuncelleme_Click(object sender, EventArgs e)
        {
            formGuncelleme f3 = new formGuncelleme();
            f3.ShowDialog();
        }

        private void btnTranskript_Click(object sender, EventArgs e)
        {
            formTranskript f4 = new formTranskript();
            f4.ShowDialog();
        }
    }
}
