
namespace SetApp
{
    partial class Vana_ekle
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
            this.fiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.adet = new System.Windows.Forms.TextBox();
            this.dokum = new System.Windows.Forms.ComboBox();
            this.sekil = new System.Windows.Forms.ComboBox();
            this.sertifika = new System.Windows.Forms.ComboBox();
            this.olcu = new System.Windows.Forms.ComboBox();
            this.tur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(567, 249);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(151, 27);
            this.fiyat.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "FİYAT :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "ÖLÇÜ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "SERTİFİKA :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "ŞEKİL :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "DÖKÜM :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "ADET :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "TÜR :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // adet
            // 
            this.adet.Location = new System.Drawing.Point(567, 176);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(151, 27);
            this.adet.TabIndex = 20;
            // 
            // dokum
            // 
            this.dokum.FormattingEnabled = true;
            this.dokum.Items.AddRange(new object[] {
            "PİK",
            "SFERO"});
            this.dokum.Location = new System.Drawing.Point(567, 115);
            this.dokum.Name = "dokum";
            this.dokum.Size = new System.Drawing.Size(151, 28);
            this.dokum.TabIndex = 19;
            // 
            // sekil
            // 
            this.sekil.FormattingEnabled = true;
            this.sekil.Items.AddRange(new object[] {
            "DÜZ",
            "KÖŞE",
            "FIRTINA"});
            this.sekil.Location = new System.Drawing.Point(175, 308);
            this.sekil.Name = "sekil";
            this.sekil.Size = new System.Drawing.Size(151, 28);
            this.sekil.TabIndex = 18;
            // 
            // sertifika
            // 
            this.sertifika.FormattingEnabled = true;
            this.sertifika.Items.AddRange(new object[] {
            "CART SERTİFİKASI",
            "CURT SERTİFİKASI",
            "-NON CERTİFİCATE-"});
            this.sertifika.Location = new System.Drawing.Point(175, 241);
            this.sertifika.Name = "sertifika";
            this.sertifika.Size = new System.Drawing.Size(151, 28);
            this.sertifika.TabIndex = 17;
            // 
            // olcu
            // 
            this.olcu.FormattingEnabled = true;
            this.olcu.Items.AddRange(new object[] {
            "10",
            "16",
            "20",
            "30",
            "40",
            "50",
            "60",
            "80",
            "100",
            "120",
            "150",
            "200",
            "250",
            "300"});
            this.olcu.Location = new System.Drawing.Point(175, 175);
            this.olcu.Name = "olcu";
            this.olcu.Size = new System.Drawing.Size(151, 28);
            this.olcu.TabIndex = 16;
            // 
            // tur
            // 
            this.tur.FormattingEnabled = true;
            this.tur.Items.AddRange(new object[] {
            "PN",
            "DN"});
            this.tur.Location = new System.Drawing.Point(175, 115);
            this.tur.Name = "tur";
            this.tur.Size = new System.Drawing.Size(151, 28);
            this.tur.TabIndex = 15;
            // 
            // Vana_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.dokum);
            this.Controls.Add(this.sekil);
            this.Controls.Add(this.sertifika);
            this.Controls.Add(this.olcu);
            this.Controls.Add(this.tur);
            this.Name = "Vana_ekle";
            this.Text = "Vana_ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.ComboBox dokum;
        private System.Windows.Forms.ComboBox sekil;
        private System.Windows.Forms.ComboBox sertifika;
        private System.Windows.Forms.ComboBox olcu;
        private System.Windows.Forms.ComboBox tur;
    }
}