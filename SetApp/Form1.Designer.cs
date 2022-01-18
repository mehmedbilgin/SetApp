
namespace SetApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.kullanici_adi = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.giris_btn = new System.Windows.Forms.Button();
            this.admin_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(316, 35);
            this.title.MaximumSize = new System.Drawing.Size(131, 60);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(59, 15);
            this.title.TabIndex = 0;
            this.title.Text = "SET VANA";
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.Location = new System.Drawing.Point(278, 97);
            this.kullanici_adi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.Size = new System.Drawing.Size(171, 23);
            this.kullanici_adi.TabIndex = 1;
            // 
            // passwd
            // 
            this.passwd.Location = new System.Drawing.Point(278, 143);
            this.passwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(171, 23);
            this.passwd.TabIndex = 2;
            this.passwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre : ";
            // 
            // giris_btn
            // 
            this.giris_btn.Location = new System.Drawing.Point(303, 197);
            this.giris_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(111, 30);
            this.giris_btn.TabIndex = 5;
            this.giris_btn.Text = "Giriş";
            this.giris_btn.UseVisualStyleBackColor = true;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // admin_giris
            // 
            this.admin_giris.Location = new System.Drawing.Point(316, 272);
            this.admin_giris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_giris.Name = "admin_giris";
            this.admin_giris.Size = new System.Drawing.Size(82, 22);
            this.admin_giris.TabIndex = 6;
            this.admin_giris.Text = "Admin Giriş";
            this.admin_giris.UseVisualStyleBackColor = true;
            this.admin_giris.Click += new System.EventHandler(this.admin_giris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.admin_giris);
            this.Controls.Add(this.giris_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.kullanici_adi);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Setvana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox kullanici_adi;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.Button admin_giris;
    }
}

