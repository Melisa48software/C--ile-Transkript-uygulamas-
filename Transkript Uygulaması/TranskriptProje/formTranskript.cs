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
    public partial class formTranskript : Form
    {
        public formTranskript()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localHost; port=5432; Database= dbtranskript; username = postgres; password = 1234");

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = " select * from ders where harf_notu IS NOT NULL ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewKayitlar.DataSource = ds.Tables[0];
        }

        private void btnGanoHesapla_Click(object sender, EventArgs e)
        {
            double gano;
            double DersKredi;
            double DersNotu;
            string harfnotu;
            int DersSayisi;
            double ToplamNot;
            double ToplamKredi;

            ToplamNot = 0;
            ToplamKredi = 0;
            gano = 0;

            for (int rows = 0; rows < dataGridViewKayitlar.Rows.Count; rows++)
            {
                DersKredi = Convert.ToDouble(dataGridViewKayitlar.Rows[rows].Cells[2].Value);

                harfnotu = Convert.ToString(dataGridViewKayitlar.Rows[rows].Cells[6].Value);
                
                switch ((harfnotu))
                {   
                    case "AA":
                        DersNotu = 4.00;
                        ToplamNot += DersKredi * DersNotu;
                        break;

                    case "BA":
                        DersNotu = 3.50;
                        ToplamNot += DersKredi * DersNotu;
                        break;

                    case "BB":
                        DersNotu = 3.00;
                        ToplamNot += DersKredi * DersNotu;
                        break;

                    case "CB":
                        DersNotu = 2.50;
                        ToplamNot += DersKredi * DersNotu;
                        break;
                    case "CC":
                        DersNotu = 2.00;
                        ToplamNot += DersKredi * DersNotu;
                        
                        break;
                    case "DC":
                        DersNotu = 1.50;
                        ToplamNot += DersKredi * DersNotu;
                        
                        break;
                    case "DD":
                        DersNotu = 1.00;
                        ToplamNot += DersKredi * DersNotu;
                       

                        break;
                    case "FD":
                        DersNotu = 0.50;
                        ToplamNot += DersKredi * DersNotu;
                        
                        break;

                    case "FF":
                        DersNotu = 0.00;
                        ToplamNot += DersKredi * DersNotu;
                       
                        break;

                    default:

                        break;
                       

                }

                ToplamKredi += DersKredi;
                gano = ToplamNot / ToplamKredi;

            }

       
            txtGano.Text = gano.ToString();
        }

        private void txtGano_TextChanged(object sender, EventArgs e)
        {

        }
    }
}