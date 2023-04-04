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
    public partial class formSilme : Form
    {
        public formSilme()
        {
            InitializeComponent();
        }

        
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database= dbtranskript; username = postgres; password = 1234");

        

        public void Sil()
        {
            baglanti.Open();
            string sil = "delete from ders where ders_kodu=@p1";
            NpgsqlCommand cmd = new NpgsqlCommand(sil, baglanti);
            cmd.Parameters.AddWithValue("@p1", (txtDersKodu.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ders Kaydı Silindi");
        }
        
       
        private void btn_Silme_Click(object sender, EventArgs e)
        {
            Sil();
            this.Close();
        }
        
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
