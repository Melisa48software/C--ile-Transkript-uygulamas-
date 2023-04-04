
namespace TranskriptProje
{
    partial class formSilme
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.btn_Silme = new System.Windows.Forms.Button();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FloralWhite;
            this.btnIptal.Location = new System.Drawing.Point(252, 242);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(144, 66);
            this.btnIptal.TabIndex = 36;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btn_Silme
            // 
            this.btn_Silme.BackColor = System.Drawing.Color.Plum;
            this.btn_Silme.Location = new System.Drawing.Point(56, 242);
            this.btn_Silme.Name = "btn_Silme";
            this.btn_Silme.Size = new System.Drawing.Size(149, 66);
            this.btn_Silme.TabIndex = 35;
            this.btn_Silme.Text = "SİL";
            this.btn_Silme.UseVisualStyleBackColor = false;
            this.btn_Silme.Click += new System.EventHandler(this.btn_Silme_Click);
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Location = new System.Drawing.Point(38, 117);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(167, 22);
            this.txtDersKodu.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Silinecek Ders Kodunu Giriniz: ";
            // 
            // formSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(565, 427);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btn_Silme);
            this.Controls.Add(this.txtDersKodu);
            this.Controls.Add(this.label1);
            this.Name = "formSilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnIptal;
        public System.Windows.Forms.Button btn_Silme;
        public System.Windows.Forms.TextBox txtDersKodu;
        public System.Windows.Forms.Label label1;
    }
}