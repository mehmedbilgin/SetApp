
namespace SetApp
{
    partial class StokEkle
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
            this.tur = new System.Windows.Forms.ComboBox();
            this.olcu = new System.Windows.Forms.ComboBox();
            this.sertifika = new System.Windows.Forms.ComboBox();
            this.sekil = new System.Windows.Forms.ComboBox();
            this.dokum = new System.Windows.Forms.ComboBox();
            this.adet = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tur
            // 
            this.tur.FormattingEnabled = true;
            this.tur.Location = new System.Drawing.Point(148, 64);
            this.tur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tur.Name = "tur";
            this.tur.Size = new System.Drawing.Size(133, 23);
            this.tur.TabIndex = 0;
            // 
            // olcu
            // 
            this.olcu.FormattingEnabled = true;
            this.olcu.Location = new System.Drawing.Point(148, 110);
            this.olcu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.olcu.Name = "olcu";
            this.olcu.Size = new System.Drawing.Size(133, 23);
            this.olcu.TabIndex = 1;
            // 
            // sertifika
            // 
            this.sertifika.FormattingEnabled = true;
            this.sertifika.Location = new System.Drawing.Point(148, 159);
            this.sertifika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sertifika.Name = "sertifika";
            this.sertifika.Size = new System.Drawing.Size(133, 23);
            this.sertifika.TabIndex = 2;
            // 
            // sekil
            // 
            this.sekil.FormattingEnabled = true;
            this.sekil.Location = new System.Drawing.Point(148, 209);
            this.sekil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sekil.Name = "sekil";
            this.sekil.Size = new System.Drawing.Size(133, 23);
            this.sekil.TabIndex = 3;
            // 
            // dokum
            // 
            this.dokum.FormattingEnabled = true;
            this.dokum.Location = new System.Drawing.Point(491, 64);
            this.dokum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dokum.Name = "dokum";
            this.dokum.Size = new System.Drawing.Size(133, 23);
            this.dokum.TabIndex = 4;
            // 
            // adet
            // 
            this.adet.Location = new System.Drawing.Point(491, 110);
            this.adet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(133, 23);
            this.adet.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(511, 204);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(88, 26);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "EKLE";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "TÜR :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "ADET :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "DÖKÜM :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "ŞEKİL :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "SERTİFİKA :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "ÖLÇÜ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "FİYAT :";
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(491, 165);
            this.fiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(133, 23);
            this.fiyat.TabIndex = 14;
            // 
            // StokEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.dokum);
            this.Controls.Add(this.sekil);
            this.Controls.Add(this.sertifika);
            this.Controls.Add(this.olcu);
            this.Controls.Add(this.tur);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StokEkle";
            this.Text = "Stok Ekle";
            this.Load += new System.EventHandler(this.StokEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tur;
        private System.Windows.Forms.ComboBox olcu;
        private System.Windows.Forms.ComboBox sertifika;
        private System.Windows.Forms.ComboBox sekil;
        private System.Windows.Forms.ComboBox dokum;
        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fiyat;
    }
}