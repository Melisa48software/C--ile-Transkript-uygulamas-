
namespace TranskriptProje
{
    partial class formTranskript
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewKayitlar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGanoHesapla = new System.Windows.Forms.Button();
            this.txtGano = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKayitlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKayitlar
            // 
            this.dataGridViewKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKayitlar.Location = new System.Drawing.Point(259, -2);
            this.dataGridViewKayitlar.Name = "dataGridViewKayitlar";
            this.dataGridViewKayitlar.RowHeadersWidth = 51;
            this.dataGridViewKayitlar.RowTemplate.Height = 24;
            this.dataGridViewKayitlar.Size = new System.Drawing.Size(988, 549);
            this.dataGridViewKayitlar.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 36);
            this.label1.TabIndex = 35;
            this.label1.Text = "TRANSKRİPT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "YIL SONU GANONUZ:";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.SteelBlue;
            this.btnListele.Location = new System.Drawing.Point(12, 89);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(155, 52);
            this.btnListele.TabIndex = 37;
            this.btnListele.Text = "DERSLERİ LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGanoHesapla
            // 
            this.btnGanoHesapla.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGanoHesapla.Location = new System.Drawing.Point(12, 162);
            this.btnGanoHesapla.Name = "btnGanoHesapla";
            this.btnGanoHesapla.Size = new System.Drawing.Size(155, 54);
            this.btnGanoHesapla.TabIndex = 38;
            this.btnGanoHesapla.Text = "Gano Hesapla";
            this.btnGanoHesapla.UseVisualStyleBackColor = false;
            this.btnGanoHesapla.Click += new System.EventHandler(this.btnGanoHesapla_Click);
            // 
            // txtGano
            // 
            this.txtGano.Location = new System.Drawing.Point(12, 382);
            this.txtGano.Name = "txtGano";
            this.txtGano.Size = new System.Drawing.Size(136, 22);
            this.txtGano.TabIndex = 39;
            this.txtGano.TextChanged += new System.EventHandler(this.txtGano_TextChanged);
            // 
            // formTranskript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1242, 547);
            this.Controls.Add(this.txtGano);
            this.Controls.Add(this.btnGanoHesapla);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewKayitlar);
            this.Name = "formTranskript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transkript";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKayitlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewKayitlar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGanoHesapla;
        private System.Windows.Forms.TextBox txtGano;
    }
}