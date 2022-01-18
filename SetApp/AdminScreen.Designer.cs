
namespace SetApp
{
    partial class AdminScreen
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
            this.title = new System.Windows.Forms.Label();
            this.admin_sifre = new System.Windows.Forms.TextBox();
            this.şifre = new System.Windows.Forms.Label();
            this.admin_login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(359, 60);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(97, 20);
            this.title.TabIndex = 0;
            this.title.Text = "ADMİN GİRİŞ";
            // 
            // admin_sifre
            // 
            this.admin_sifre.Location = new System.Drawing.Point(309, 134);
            this.admin_sifre.Name = "admin_sifre";
            this.admin_sifre.Size = new System.Drawing.Size(203, 27);
            this.admin_sifre.TabIndex = 1;
            // 
            // şifre
            // 
            this.şifre.AutoSize = true;
            this.şifre.Location = new System.Drawing.Point(122, 134);
            this.şifre.Name = "şifre";
            this.şifre.Size = new System.Drawing.Size(98, 20);
            this.şifre.TabIndex = 2;
            this.şifre.Text = "Admin Şifre : ";
            // 
            // admin_login_btn
            // 
            this.admin_login_btn.Location = new System.Drawing.Point(359, 226);
            this.admin_login_btn.Name = "admin_login_btn";
            this.admin_login_btn.Size = new System.Drawing.Size(102, 45);
            this.admin_login_btn.TabIndex = 3;
            this.admin_login_btn.Text = "Giriş";
            this.admin_login_btn.UseVisualStyleBackColor = true;
            this.admin_login_btn.Click += new System.EventHandler(this.admin_login_btn_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 471);
            this.Controls.Add(this.admin_login_btn);
            this.Controls.Add(this.şifre);
            this.Controls.Add(this.admin_sifre);
            this.Controls.Add(this.title);
            this.Name = "AdminScreen";
            this.Text = "Setvana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox admin_sifre;
        private System.Windows.Forms.Label şifre;
        private System.Windows.Forms.Button admin_login_btn;
    }
}