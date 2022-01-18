
namespace SetApp
{
    partial class Cikar
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
            this.secilcek = new System.Windows.Forms.DataGridView();
            this.adet = new System.Windows.Forms.TextBox();
            this.btn_cikar = new System.Windows.Forms.Button();
            this.azaltilacak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.secilcek)).BeginInit();
            this.SuspendLayout();
            // 
            // secilcek
            // 
            this.secilcek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.secilcek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secilcek.Location = new System.Drawing.Point(55, 91);
            this.secilcek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secilcek.Name = "secilcek";
            this.secilcek.RowHeadersWidth = 51;
            this.secilcek.RowTemplate.Height = 29;
            this.secilcek.Size = new System.Drawing.Size(563, 236);
            this.secilcek.TabIndex = 0;
            this.secilcek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.secilcek_CellClick);
            // 
            // adet
            // 
            this.adet.Location = new System.Drawing.Point(93, 62);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(100, 23);
            this.adet.TabIndex = 1;
            // 
            // btn_cikar
            // 
            this.btn_cikar.Location = new System.Drawing.Point(543, 63);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(75, 23);
            this.btn_cikar.TabIndex = 2;
            this.btn_cikar.Text = "Cikar";
            this.btn_cikar.UseVisualStyleBackColor = true;
            this.btn_cikar.Click += new System.EventHandler(this.btn_cikar_Click);
            // 
            // azaltilacak
            // 
            this.azaltilacak.Location = new System.Drawing.Point(279, 63);
            this.azaltilacak.Name = "azaltilacak";
            this.azaltilacak.Size = new System.Drawing.Size(100, 23);
            this.azaltilacak.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Eksiltilecek";
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(428, 62);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(100, 23);
            this.fiyat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fiyat";
            // 
            // Cikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.azaltilacak);
            this.Controls.Add(this.btn_cikar);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.secilcek);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cikar";
            this.Text = "Cıkar";
            this.Load += new System.EventHandler(this.Cikar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.secilcek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView secilcek;
        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.Button btn_cikar;
        private System.Windows.Forms.TextBox azaltilacak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Label label3;
    }
}