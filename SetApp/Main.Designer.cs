
namespace SetApp
{
    partial class Main
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
            this.greeting = new System.Windows.Forms.Label();
            this.add_stock = new System.Windows.Forms.Button();
            this.t_out_stock = new System.Windows.Forms.Button();
            this.show_stock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Location = new System.Drawing.Point(368, 36);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(103, 20);
            this.greeting.TabIndex = 0;
            this.greeting.Text = "HOŞGELDİNİZ";
            // 
            // add_stock
            // 
            this.add_stock.Location = new System.Drawing.Point(236, 183);
            this.add_stock.Name = "add_stock";
            this.add_stock.Size = new System.Drawing.Size(132, 46);
            this.add_stock.TabIndex = 1;
            this.add_stock.Text = "Stok Ekle";
            this.add_stock.UseVisualStyleBackColor = true;
            this.add_stock.Click += new System.EventHandler(this.add_stock_Click);
            // 
            // t_out_stock
            // 
            this.t_out_stock.Location = new System.Drawing.Point(402, 183);
            this.t_out_stock.Name = "t_out_stock";
            this.t_out_stock.Size = new System.Drawing.Size(139, 46);
            this.t_out_stock.TabIndex = 2;
            this.t_out_stock.Text = "Stok Çıkar";
            this.t_out_stock.UseVisualStyleBackColor = true;
            // 
            // show_stock
            // 
            this.show_stock.Location = new System.Drawing.Point(580, 183);
            this.show_stock.Name = "show_stock";
            this.show_stock.Size = new System.Drawing.Size(140, 46);
            this.show_stock.TabIndex = 3;
            this.show_stock.Text = "Stokları Gör";
            this.show_stock.UseVisualStyleBackColor = true;
            this.show_stock.Click += new System.EventHandler(this.show_stock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adınız:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Vana Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 484);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show_stock);
            this.Controls.Add(this.t_out_stock);
            this.Controls.Add(this.add_stock);
            this.Controls.Add(this.greeting);
            this.Name = "Main";
            this.Text = "Setvana";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Button add_stock;
        private System.Windows.Forms.Button t_out_stock;
        private System.Windows.Forms.Button show_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}