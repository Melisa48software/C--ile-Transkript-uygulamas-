using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TranskriptProje
{
    public partial class formGuncelleme : Form
    {
        public formGuncelleme()
        {
            InitializeComponent();
        }

        private void dataGridViewKayitlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database= dbtranskript; username = postgres; password = 1234");

        public void Guncelle()
        {
            baglanti.Open();
            string guncelle = "update ders set ders_adi=@p1, ders_kredi=@p2, ders_akts=@p3, ogretim_uyesi=@p4, donem=@p5,  harf_notu=@p6 where ders_kodu=@p7 ";
            NpgsqlCommand cmd = new NpgsqlCommand(guncelle, baglanti);
            cmd.Parameters.AddWithValue("@p1", txtDersAdı.Text);
            cmd.Parameters.AddWithValue("@p2", int.Parse(txtDersKredi.Text));
            cmd.Parameters.AddWithValue("@p3", int.Parse(numericUpDownDersAkts.Text));
            cmd.Parameters.AddWithValue("@p4", txtOgretimUyesi.Text);
            cmd.Parameters.AddWithValue("@p5", cmbDonem.Text);
            cmd.Parameters.AddWithValue("@p6", cmbHarfNotu.Text);
            cmd.Parameters.AddWithValue("@p7", txtDersKodu.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ders Kaydi Güncellendi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
            this.Close();
        }
       
        private void txtGirilenDersKodu_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void formGuncelleme_Load(object sender, EventArgs e)
        {

        }
        private void btnIptal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {

            string sorgu = "select * from ders where ders_kodu Like  '" + txtGirilenDersKodu.Text + "'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewKayitlar.DataSource = ds.Tables[0];
        }
    }
}
