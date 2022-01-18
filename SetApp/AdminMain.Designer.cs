
namespace SetApp
{
    partial class AdminMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.logs_btn = new System.Windows.Forms.Button();
            this.stocks_btn = new System.Windows.Forms.Button();
            this.add_user_btn = new System.Windows.Forms.Button();
            this.last_activities_btn = new System.Windows.Forms.Button();
            this.warning_btn = new System.Windows.Forms.Button();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Sayfası";
            // 
            // logs_btn
            // 
            this.logs_btn.Location = new System.Drawing.Point(125, 109);
            this.logs_btn.Name = "logs_btn";
            this.logs_btn.Size = new System.Drawing.Size(116, 29);
            this.logs_btn.TabIndex = 1;
            this.logs_btn.Text = "Giriş Kayıtları";
            this.logs_btn.UseVisualStyleBackColor = true;
            this.logs_btn.Click += new System.EventHandler(this.logs_btn_Click);
            // 
            // stocks_btn
            // 
            this.stocks_btn.Location = new System.Drawing.Point(349, 109);
            this.stocks_btn.Name = "stocks_btn";
            this.stocks_btn.Size = new System.Drawing.Size(94, 29);
            this.stocks_btn.TabIndex = 2;
            this.stocks_btn.Text = "Stoklar";
            this.stocks_btn.UseVisualStyleBackColor = true;
            this.stocks_btn.Click += new System.EventHandler(this.stocks_btn_Click);
            // 
            // add_user_btn
            // 
            this.add_user_btn.Location = new System.Drawing.Point(560, 109);
            this.add_user_btn.Name = "add_user_btn";
            this.add_user_btn.Size = new System.Drawing.Size(120, 29);
            this.add_user_btn.TabIndex = 3;
            this.add_user_btn.Text = "Kullanıcı Ekle";
            this.add_user_btn.UseVisualStyleBackColor = true;
            this.add_user_btn.Click += new System.EventHandler(this.add_user_btn_Click);
            // 
            // last_activities_btn
            // 
            this.last_activities_btn.Location = new System.Drawing.Point(235, 194);
            this.last_activities_btn.Name = "last_activities_btn";
            this.last_activities_btn.Size = new System.Drawing.Size(105, 29);
            this.last_activities_btn.TabIndex = 4;
            this.last_activities_btn.Text = "Son İşlemler";
            this.last_activities_btn.UseVisualStyleBackColor = true;
            // 
            // warning_btn
            // 
            this.warning_btn.Location = new System.Drawing.Point(457, 194);
            this.warning_btn.Name = "warning_btn";
            this.warning_btn.Size = new System.Drawing.Size(94, 29);
            this.warning_btn.TabIndex = 5;
            this.warning_btn.Text = "Uyarılar";
            this.warning_btn.UseVisualStyleBackColor = true;
            this.warning_btn.Click += new System.EventHandler(this.warning_btn_Click);
            // 
            // cikis_btn
            // 
            this.cikis_btn.Location = new System.Drawing.Point(614, 365);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(94, 29);
            this.cikis_btn.TabIndex = 6;
            this.cikis_btn.Text = "Çıkış";
            this.cikis_btn.UseVisualStyleBackColor = true;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.warning_btn);
            this.Controls.Add(this.last_activities_btn);
            this.Controls.Add(this.add_user_btn);
            this.Controls.Add(this.stocks_btn);
            this.Controls.Add(this.logs_btn);
            this.Controls.Add(this.label1);
            this.Name = "AdminMain";
            this.Text = "Setvana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logs_btn;
        private System.Windows.Forms.Button stocks_btn;
        private System.Windows.Forms.Button add_user_btn;
        private System.Windows.Forms.Button last_activities_btn;
        private System.Windows.Forms.Button warning_btn;
        private System.Windows.Forms.Button cikis_btn;
    }
}