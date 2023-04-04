
namespace TranskriptProje
{
    partial class formMenu
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
            this.dataGridViewVeriler = new System.Windows.Forms.DataGridView();
            this.btnEkleme = new System.Windows.Forms.Button();
            this.btnDersSilme = new System.Windows.Forms.Button();
            this.btnDersGuncelleme = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnTranskript = new System.Windows.Forms.Button();
            this.lblDersKodu = new System.Windows.Forms.Label();
            this.lblDersAdı = new System.Windows.Forms.Label();
            this.lblDersKredi = new System.Windows.Forms.Label();
            this.lblDersAkts = new System.Windows.Forms.Label();
            this.lblOgretimUyesi = new System.Windows.Forms.Label();
            this.lblDonem = new System.Windows.Forms.Label();
            this.lblHarfNotu = new System.Windows.Forms.Label();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.txtDersAdı = new System.Windows.Forms.TextBox();
            this.txtOgretimUyesi = new System.Windows.Forms.TextBox();
            this.numericUpDownDersAkts = new System.Windows.Forms.NumericUpDown();
            this.cmbHarfNotu = new System.Windows.Forms.ComboBox();
            this.cmbDonem = new System.Windows.Forms.ComboBox();
            this.txtDersKredi = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDersAkts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVeriler
            // 
            this.dataGridViewVeriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVeriler.Location = new System.Drawing.Point(623, -2);
            this.dataGridViewVeriler.Name = "dataGridViewVeriler";
            this.dataGridViewVeriler.RowHeadersWidth = 51;
            this.dataGridViewVeriler.RowTemplate.Height = 24;
            this.dataGridViewVeriler.Size = new System.Drawing.Size(731, 645);
            this.dataGridViewVeriler.TabIndex = 0;
            // 
            // btnEkleme
            // 
            this.btnEkleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(252)))), ((int)(((byte)(172)))));
            this.btnEkleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkleme.Location = new System.Drawing.Point(417, 215);
            this.btnEkleme.Name = "btnEkleme";
            this.btnEkleme.Size = new System.Drawing.Size(174, 67);
            this.btnEkleme.TabIndex = 1;
            this.btnEkleme.Text = "Ders Ekleme";
            this.btnEkleme.UseVisualStyleBackColor = false;
            this.btnEkleme.Click += new System.EventHandler(this.btnEkle);
            // 
            // btnDersSilme
            // 
            this.btnDersSilme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(252)))), ((int)(((byte)(172)))));
            this.btnDersSilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDersSilme.Location = new System.Drawing.Point(417, 319);
            this.btnDersSilme.Name = "btnDersSilme";
            this.btnDersSilme.Size = new System.Drawing.Size(174, 70);
            this.btnDersSilme.TabIndex = 2;
            this.btnDersSilme.Text = "Ders Silme";
            this.btnDersSilme.UseVisualStyleBackColor = false;
            this.btnDersSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // btnDersGuncelleme
            // 
            this.btnDersGuncelleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(252)))), ((int)(((byte)(172)))));
            this.btnDersGuncelleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDersGuncelleme.Location = new System.Drawing.Point(417, 421);
            this.btnDersGuncelleme.Name = "btnDersGuncelleme";
            this.btnDersGuncelleme.Size = new System.Drawing.Size(174, 70);
            this.btnDersGuncelleme.TabIndex = 3;
            this.btnDersGuncelleme.Text = "Ders Güncelleme";
            this.btnDersGuncelleme.UseVisualStyleBackColor = false;
            this.btnDersGuncelleme.Click += new System.EventHandler(this.btnDersGuncelleme_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(252)))), ((int)(((byte)(172)))));
            this.btnGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoster.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoster.Location = new System.Drawing.Point(417, 105);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(174, 72);
            this.btnGoster.TabIndex = 4;
            this.btnGoster.Text = "GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnTranskript
            // 
            this.btnTranskript.BackColor = System.Drawing.Color.Yellow;
            this.btnTranskript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranskript.Location = new System.Drawing.Point(181, 529);
            this.btnTranskript.Name = "btnTranskript";
            this.btnTranskript.Size = new System.Drawing.Size(212, 80);
            this.btnTranskript.TabIndex = 6;
            this.btnTranskript.Text = "TRANSKRİPT";
            this.btnTranskript.UseVisualStyleBackColor = false;
            this.btnTranskript.Click += new System.EventHandler(this.btnTranskript_Click);
            // 
            // lblDersKodu
            // 
            this.lblDersKodu.AutoSize = true;
            this.lblDersKodu.Location = new System.Drawing.Point(11, 129);
            this.lblDersKodu.Name = "lblDersKodu";
            this.lblDersKodu.Size = new System.Drawing.Size(116, 26);
            this.lblDersKodu.TabIndex = 7;
            this.lblDersKodu.Text = "Ders Kodu:";
            this.lblDersKodu.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDersAdı
            // 
            this.lblDersAdı.AutoSize = true;
            this.lblDersAdı.Location = new System.Drawing.Point(11, 185);
            this.lblDersAdı.Name = "lblDersAdı";
            this.lblDersAdı.Size = new System.Drawing.Size(99, 26);
            this.lblDersAdı.TabIndex = 8;
            this.lblDersAdı.Text = "Ders Adı:";
            // 
            // lblDersKredi
            // 
            this.lblDersKredi.AutoSize = true;
            this.lblDersKredi.Location = new System.Drawing.Point(11, 236);
            this.lblDersKredi.Name = "lblDersKredi";
            this.lblDersKredi.Size = new System.Drawing.Size(117, 26);
            this.lblDersKredi.TabIndex = 9;
            this.lblDersKredi.Text = "Ders Kredi:";
            // 
            // lblDersAkts
            // 
            this.lblDersAkts.AutoSize = true;
            this.lblDersAkts.Location = new System.Drawing.Point(11, 290);
            this.lblDersAkts.Name = "lblDersAkts";
            this.lblDersAkts.Size = new System.Drawing.Size(116, 26);
            this.lblDersAkts.TabIndex = 10;
            this.lblDersAkts.Text = "Ders AKTS:";
            // 
            // lblOgretimUyesi
            // 
            this.lblOgretimUyesi.AutoSize = true;
            this.lblOgretimUyesi.Location = new System.Drawing.Point(11, 342);
            this.lblOgretimUyesi.Name = "lblOgretimUyesi";
            this.lblOgretimUyesi.Size = new System.Drawing.Size(156, 26);
            this.lblOgretimUyesi.TabIndex = 11;
            this.lblOgretimUyesi.Text = "Öğretim Üyesi:";
            // 
            // lblDonem
            // 
            this.lblDonem.AutoSize = true;
            this.lblDonem.Location = new System.Drawing.Point(21, 394);
            this.lblDonem.Name = "lblDonem";
            this.lblDonem.Size = new System.Drawing.Size(86, 26);
            this.lblDonem.TabIndex = 12;
            this.lblDonem.Text = "Dönem:";
            // 
            // lblHarfNotu
            // 
            this.lblHarfNotu.AutoSize = true;
            this.lblHarfNotu.Location = new System.Drawing.Point(11, 448);
            this.lblHarfNotu.Name = "lblHarfNotu";
            this.lblHarfNotu.Size = new System.Drawing.Size(114, 26);
            this.lblHarfNotu.TabIndex = 13;
            this.lblHarfNotu.Text = "Harf Notu:";
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Location = new System.Drawing.Point(181, 125);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(187, 30);
            this.txtDersKodu.TabIndex = 14;
            // 
            // txtDersAdı
            // 
            this.txtDersAdı.Location = new System.Drawing.Point(182, 181);
            this.txtDersAdı.Name = "txtDersAdı";
            this.txtDersAdı.Size = new System.Drawing.Size(186, 30);
            this.txtDersAdı.TabIndex = 15;
            this.txtDersAdı.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtOgretimUyesi
            // 
            this.txtOgretimUyesi.Location = new System.Drawing.Point(183, 338);
            this.txtOgretimUyesi.Name = "txtOgretimUyesi";
            this.txtOgretimUyesi.Size = new System.Drawing.Size(187, 30);
            this.txtOgretimUyesi.TabIndex = 17;
            // 
            // numericUpDownDersAkts
            // 
            this.numericUpDownDersAkts.Location = new System.Drawing.Point(182, 286);
            this.numericUpDownDersAkts.Name = "numericUpDownDersAkts";
            this.numericUpDownDersAkts.Size = new System.Drawing.Size(188, 30);
            this.numericUpDownDersAkts.TabIndex = 21;
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
            this.cmbHarfNotu.Location = new System.Drawing.Point(181, 441);
            this.cmbHarfNotu.Name = "cmbHarfNotu";
            this.cmbHarfNotu.Size = new System.Drawing.Size(187, 33);
            this.cmbHarfNotu.TabIndex = 23;
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
            this.cmbDonem.Location = new System.Drawing.Point(183, 387);
            this.cmbDonem.Name = "cmbDonem";
            this.cmbDonem.Size = new System.Drawing.Size(187, 33);
            this.cmbDonem.TabIndex = 24;
            // 
            // txtDersKredi
            // 
            this.txtDersKredi.Location = new System.Drawing.Point(182, 233);
            this.txtDersKredi.Name = "txtDersKredi";
            this.txtDersKredi.Size = new System.Drawing.Size(186, 30);
            this.txtDersKredi.TabIndex = 25;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(7, 23);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(514, 50);
            this.lblBaslik.TabIndex = 28;
            this.lblBaslik.Text = "BAKIRÇAY ÜNİVERSİTESİ ";
            this.lblBaslik.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(204)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1354, 643);
            this.Controls.Add(this.lblBaslik);
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
            this.Controls.Add(this.btnTranskript);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnDersGuncelleme);
            this.Controls.Add(this.btnDersSilme);
            this.Controls.Add(this.btnEkleme);
            this.Controls.Add(this.dataGridViewVeriler);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDersAkts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.DataGridView dataGridViewVeriler;
        public System.Windows.Forms.Button btnEkleme;
        public System.Windows.Forms.Button btnDersSilme;
        public System.Windows.Forms.Button btnDersGuncelleme;
        public System.Windows.Forms.Button btnGoster;
        public System.Windows.Forms.Button btnTranskript;
        public System.Windows.Forms.Label lblDersKodu;
        public System.Windows.Forms.Label lblDersAdı;
        public System.Windows.Forms.Label lblDersKredi;
        public System.Windows.Forms.Label lblDersAkts;
        public System.Windows.Forms.Label lblOgretimUyesi;
        public System.Windows.Forms.Label lblDonem;
        public System.Windows.Forms.Label lblHarfNotu;
        public System.Windows.Forms.TextBox txtDersKodu;
        public System.Windows.Forms.TextBox txtDersAdı;
        public System.Windows.Forms.TextBox txtOgretimUyesi;
        public System.Windows.Forms.NumericUpDown numericUpDownDersAkts;
        public System.Windows.Forms.ComboBox cmbHarfNotu;
        public System.Windows.Forms.ComboBox cmbDonem;
        public System.Windows.Forms.TextBox txtDersKredi;
    }
}

