
namespace SetApp
{
    partial class StokGor
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
            this.label2 = new System.Windows.Forms.Label();
            this.tur = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.stok_gor = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stok_gor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "STOKLAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tür Seçin";
            // 
            // tur
            // 
            this.tur.FormattingEnabled = true;
            this.tur.Location = new System.Drawing.Point(225, 82);
            this.tur.Name = "tur";
            this.tur.Size = new System.Drawing.Size(178, 28);
            this.tur.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stok_gor
            // 
            this.stok_gor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stok_gor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stok_gor.Location = new System.Drawing.Point(81, 124);
            this.stok_gor.Name = "stok_gor";
            this.stok_gor.RowHeadersWidth = 51;
            this.stok_gor.RowTemplate.Height = 29;
            this.stok_gor.Size = new System.Drawing.Size(637, 293);
            this.stok_gor.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(590, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Hepsini Göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StokGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.stok_gor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StokGor";
            this.Text = "StokGor";
            this.Load += new System.EventHandler(this.StokGor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stok_gor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader TÜR;
        private System.Windows.Forms.ColumnHeader ÖLÇÜ;
        private System.Windows.Forms.ColumnHeader SERTİFİKA;
        private System.Windows.Forms.ColumnHeader ŞEKİL;
        private System.Windows.Forms.ColumnHeader DÖKÜM;
        private System.Windows.Forms.ColumnHeader ADET;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView stok_gor;
        private System.Windows.Forms.Button button2;
    }
}