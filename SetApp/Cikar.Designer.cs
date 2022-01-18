
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
            this.adet.Location = new System.Drawing.Point(55, 63);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(100, 23);
            this.adet.TabIndex = 1;
            // 
            // btn_cikar
            // 
            this.btn_cikar.Location = new System.Drawing.Point(267, 62);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(75, 23);
            this.btn_cikar.TabIndex = 2;
            this.btn_cikar.Text = "Cikar";
            this.btn_cikar.UseVisualStyleBackColor = true;
            // 
            // azaltilacak
            // 
            this.azaltilacak.Location = new System.Drawing.Point(161, 64);
            this.azaltilacak.Name = "azaltilacak";
            this.azaltilacak.Size = new System.Drawing.Size(100, 23);
            this.azaltilacak.TabIndex = 3;
            // 
            // Cikar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
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
    }
}