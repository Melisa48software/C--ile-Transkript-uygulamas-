
namespace TranskriptProje
{
    partial class formGuncelleme
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
            this.lblSorgu = new System.Windows.Forms.Label();
            this.txtGirilenDersKodu = new System.Windows.Forms.TextBox();
            this.dataGridViewKayitlar = new System.Windows.Forms.DataGridView();
            this.btnGuncelleme = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtDersKredi = new System.Windows.Forms.TextBox();
            this.cmbDonem = new System.Windows.Forms.ComboBox();
            this.cmbHarfNotu = new System.Windows.Forms.ComboBox();
            this.numericUpDownDersAkts = new System.Windows.Forms.NumericUpDown();
            this.txtOgretimUyesi = new System.Windows.Forms.TextBox();
            this.txtDersAdı = new System.Windows.Forms.TextBox();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.lblHarfNotu = new System.Windows.Forms.Label();
            this.lblDonem = new System.Windows.Forms.Label();
            this.lblOgretimUyesi = new System.Windows.Forms.Label();
            this.lblDersAkts = new System.Windows.Forms.Label();
            this.lblDersKredi = new System.Windows.Forms.Label();
            this.lblDersAdı = new System.Windows.Forms.Label();
            this.lblDersKodu = new System.Windows.Forms.Label();
            this.btnGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKayitlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDersAkts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSorgu
            // 
            this.lblSorgu.AutoSize = true;
            this.lblSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSorgu.Location = new System.Drawing.Point(12, 19);
            this.lblSorgu.Name = "lblSorgu";
            this.lblSorgu.Size = new System.Drawing.Size(441, 29);
            this.lblSorgu.TabIndex = 27;
            this.lblSorgu.Text = "Güncellenecek Ders Kodunu Giriniz: ";
            // 
            // txtGirilenDersKodu
            // 
            this.txtGirilenDersKodu.Location = new System.Drawing.Point(16, 65);
            this.txtGirilenDersKodu.Name = "txtGirilenDersKodu";
            this.txtGirilenDersKodu.Size = new System.Drawing.Size(167, 22);
            this.txtGirilenDersKodu.TabIndex = 28;
            this.txtGirilenDersKodu.TextChanged += new System.EventHandler(this.txtGirilenDersKodu_TextChanged_1);
            // 
            // dataGridViewKayitlar
            // 
            this.dataGridViewKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKayitlar.Location = new System.Drawing.Point(546, -2);
            this.dataGridViewKayitlar.Name = "dataGridViewKayitlar";
            this.dataGridViewKayitlar.RowHeadersWidth = 51;
            this.dataGridViewKayitlar.RowTemplate.Height = 24;
            this.dataGridViewKayitlar.Size = new System.Drawing.Size(514, 407);
            this.dataGridViewKayitlar.TabIndex = 29;
            // 
            // btnGuncelleme
            // 
            this.btnGuncelleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuncelleme.Location = new System.Drawing.Point(34, 419);
            this.btnGuncelleme.Name = "btnGuncelleme";
            this.btnGuncelleme.Size = new System.Drawing.Size(149, 66);
            this.btnGuncelleme.TabIndex = 30;
            this.btnGuncelleme.Text = "GÜNCELLE";
            this.btnGuncelleme.UseVisualStyleBackColor = false;
            this.btnGuncelleme.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FloralWhite;
            this.btnIptal.Location = new System.Drawing.Point(249, 419);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(144, 66);
            this.btnIptal.TabIndex = 31;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click_1);
            // 
            // txtDersKredi
            // 
            this.txtDersKredi.Location = new System.Drawing.Point(186, 195);
            this.txtDersKredi.Name = "txtDersKredi";
            this.txtDersKredi.Size = new System.Drawing.Size(186, 22);
            this.txtDersKredi.TabIndex = 45;
            // 
            // cmbDonem
            // 
            this.cmbDonem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbDonem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonem.FormattingEnabled = true;
            this.cmbDonem.Items.AddRange(new object[] {
            "2020/1",
            "2021/2",
            "2021/1",
            "2022/2",
            "2022/1",
            "2023/2",
            "2023/1",
            "2024/2"});
            this.cmbDonem.Location = new System.Drawing.Point(184, 296);
            this.cmbDonem.Name = "cmbDonem";
            this.cmbDonem.Size = new System.Drawing.Size(187, 24);
            this.cmbDonem.TabIndex = 44;
            // 
            // cmbHarfNotu
            // 
            this.cmbHarfNotu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbHarfNotu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHarfNotu.FormattingEnabled = true;
            this.cmbHarfNotu.Items.AddRange(new object[] {
            "AA",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FD",
            "FF"});
            this.cmbHarfNotu.Location = new System.Drawing.Point(184, 336);
            this.cmbHarfNotu.Name = "cmbHarfNotu";
            this.cmbHarfNotu.Size = new System.Drawing.Size(187, 24);
            this.cmbHarfNotu.TabIndex = 43;
            // 
            // numericUpDownDersAkts
            // 
            this.numericUpDownDersAkts.Location = new System.Drawing.Point(184, 228);
            this.numericUpDownDersAkts.Name = "numericUpDownDersAkts";
            this.numericUpDownDersAkts.Size = new System.Drawing.Size(188, 22);
            this.numericUpDownDersAkts.TabIndex = 42;
            // 
            // txtOgretimUyesi
            // 
            this.txtOgretimUyesi.Location = new System.Drawing.Point(184, 261);
            this.txtOgretimUyesi.Name = "txtOgretimUyesi";
            this.txtOgretimUyesi.Size = new System.Drawing.Size(187, 22);
            this.txtOgretimUyesi.TabIndex = 41;
            // 
            // txtDersAdı
            // 
            this.txtDersAdı.Location = new System.Drawing.Point(184, 158);
            this.txtDersAdı.Name = "txtDersAdı";
            this.txtDersAdı.Size = new System.Drawing.Size(186, 22);
            this.txtDersAdı.TabIndex = 40;
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Location = new System.Drawing.Point(186, 123);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(187, 22);
            this.txtDersKodu.TabIndex = 39;
            // 
            // lblHarfNotu
            // 
            this.lblHarfNotu.AutoSize = true;
            this.lblHarfNotu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHarfNotu.Location = new System.Drawing.Point(12, 336);
            this.lblHarfNotu.Name = "lblHarfNotu";
            this.lblHarfNotu.Size = new System.Drawing.Size(110, 25);
            this.lblHarfNotu.TabIndex = 38;
            this.lblHarfNotu.Text = "Harf Notu:";
            // 
            // lblDonem
            // 
            this.lblDonem.AutoSize = true;
            this.lblDonem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDonem.Location = new System.Drawing.Point(12, 295);
            this.lblDonem.Name = "lblDonem";
            this.lblDonem.Size = new System.Drawing.Size(87, 25);
            this.lblDonem.TabIndex = 37;
            this.lblDonem.Text = "Dönem:";
            // 
            // lblOgretimUyesi
            // 
            this.lblOgretimUyesi.AutoSize = true;
            this.lblOgretimUyesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgretimUyesi.Location = new System.Drawing.Point(11, 261);
            this.lblOgretimUyesi.Name = "lblOgretimUyesi";
            this.lblOgretimUyesi.Size = new System.Drawing.Size(155, 25);
            this.lblOgretimUyesi.TabIndex = 36;
            this.lblOgretimUyesi.Text = "Öğretim Üyesi:";
            // 
            // lblDersAkts
            // 
            this.lblDersAkts.AutoSize = true;
            this.lblDersAkts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersAkts.Location = new System.Drawing.Point(16, 228);
            this.lblDersAkts.Name = "lblDersAkts";
            this.lblDersAkts.Size = new System.Drawing.Size(129, 25);
            this.lblDersAkts.TabIndex = 35;
            this.lblDersAkts.Text = "Ders AKTS:";
            // 
            // lblDersKredi
            // 
            this.lblDersKredi.AutoSize = true;
            this.lblDersKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersKredi.Location = new System.Drawing.Point(11, 192);
            this.lblDersKredi.Name = "lblDersKredi";
            this.lblDersKredi.Size = new System.Drawing.Size(121, 25);
            this.lblDersKredi.TabIndex = 34;
            this.lblDersKredi.Text = "Ders Kredi:";
            // 
            // lblDersAdı
            // 
            this.lblDersAdı.AutoSize = true;
            this.lblDersAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersAdı.Location = new System.Drawing.Point(12, 158);
            this.lblDersAdı.Name = "lblDersAdı";
            this.lblDersAdı.Size = new System.Drawing.Size(102, 25);
            this.lblDersAdı.TabIndex = 33;
            this.lblDersAdı.Text = "Ders Adı:";
            // 
            // lblDersKodu
            // 
            this.lblDersKodu.AutoSize = true;
            this.lblDersKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersKodu.Location = new System.Drawing.Point(11, 120);
            this.lblDersKodu.Name = "lblDersKodu";
            this.lblDersKodu.Size = new System.Drawing.Size(121, 25);
            this.lblDersKodu.TabIndex = 32;
            this.lblDersKodu.Text = "Ders Kodu:";
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.HotPink;
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(231, 59);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(153, 35);
            this.btnGetir.TabIndex = 46;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // formGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1056, 516);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.txtDersKredi);
            this.Controls.Add(this.cmbDonem);
            this.Controls.Add(this.cmbHarfNotu);
            this.Controls.Add(this.numericUpDownDersAkts);
            this.Controls.Add(this.txtOgretimUyesi);
            this.Controls.Add(this.txtDersAdı);
            this.Controls.Add(this.txtDersKodu);
            this.Controls.Add(this.lblHarfNotu);
            this.Controls.Add(this.lblDonem);
            this.Controls.Add(this.lblOgretimUyesi);
            this.Controls.Add(this.lblDersAkts);
            this.Controls.Add(this.lblDersKredi);
            this.Controls.Add(this.lblDersAdı);
            this.Controls.Add(this.lblDersKodu);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGuncelleme);
            this.Controls.Add(this.dataGridViewKayitlar);
            this.Controls.Add(this.txtGirilenDersKodu);
            this.Controls.Add(this.lblSorgu);
            this.Name = "formGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formGuncelleme";
            this.Load += new System.EventHandler(this.formGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKayitlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDersAkts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSorgu;
        public System.Windows.Forms.TextBox txtGirilenDersKodu;
        public System.Windows.Forms.DataGridView dataGridViewKayitlar;
        public System.Windows.Forms.Button btnGuncelleme;
        public System.Windows.Forms.Button btnIptal;
        public System.Windows.Forms.TextBox txtDersKredi;
        public System.Windows.Forms.ComboBox cmbDonem;
        public System.Windows.Forms.ComboBox cmbHarfNotu;
        public System.Windows.Forms.NumericUpDown numericUpDownDersAkts;
        public System.Windows.Forms.TextBox txtOgretimUyesi;
        public System.Windows.Forms.TextBox txtDersAdı;
        public System.Windows.Forms.TextBox txtDersKodu;
        public System.Windows.Forms.Label lblHarfNotu;
        public System.Windows.Forms.Label lblDonem;
        public System.Windows.Forms.Label lblOgretimUyesi;
        public System.Windows.Forms.Label lblDersAkts;
        public System.Windows.Forms.Label lblDersKredi;
        public System.Windows.Forms.Label lblDersAdı;
        public System.Windows.Forms.Label lblDersKodu;
        private System.Windows.Forms.Button btnGetir;
    }
}