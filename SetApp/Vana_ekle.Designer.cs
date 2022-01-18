
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.tur = new System.Windows.Forms.TextBox();
            this.olcu = new System.Windows.Forms.TextBox();
            this.sertifika = new System.Windows.Forms.TextBox();
            this.sekil = new System.Windows.Forms.TextBox();
            this.dokum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "ÖLÇÜ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "SERTİFİKA :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "ŞEKİL :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "DÖKÜM :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "TÜR :";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(432, 126);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 26);
            this.btn_add.TabIndex = 21;
            this.btn_add.Text = "EKLE";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tur
            // 
            this.tur.Location = new System.Drawing.Point(157, 89);
            this.tur.Name = "tur";
            this.tur.Size = new System.Drawing.Size(100, 23);
            this.tur.TabIndex = 29;
            // 
            // olcu
            // 
            this.olcu.Location = new System.Drawing.Point(157, 129);
            this.olcu.Name = "olcu";
            this.olcu.Size = new System.Drawing.Size(100, 23);
            this.olcu.TabIndex = 30;
            // 
            // sertifika
            // 
            this.sertifika.Location = new System.Drawing.Point(157, 166);
            this.sertifika.Name = "sertifika";
            this.sertifika.Size = new System.Drawing.Size(100, 23);
            this.sertifika.TabIndex = 31;
            // 
            // sekil
            // 
            this.sekil.Location = new System.Drawing.Point(157, 205);
            this.sekil.Name = "sekil";
            this.sekil.Size = new System.Drawing.Size(100, 23);
            this.sekil.TabIndex = 32;
            // 
            // dokum
            // 
            this.dokum.Location = new System.Drawing.Point(432, 89);
            this.dokum.Name = "dokum";
            this.dokum.Size = new System.Drawing.Size(100, 23);
            this.dokum.TabIndex = 33;
            // 
            // Vana_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.dokum);
            this.Controls.Add(this.sekil);
            this.Controls.Add(this.sertifika);
            this.Controls.Add(this.olcu);
            this.Controls.Add(this.tur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Vana_ekle";
            this.Text = "Vana_ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tur;
        private System.Windows.Forms.TextBox olcu;
        private System.Windows.Forms.TextBox sertifika;
        private System.Windows.Forms.TextBox sekil;
        private System.Windows.Forms.TextBox dokum;
    }
}