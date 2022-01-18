
namespace SetApp
{
    partial class Log_form
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
            this.giris_kayit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.giris_kayit)).BeginInit();
            this.SuspendLayout();
            // 
            // giris_kayit
            // 
            this.giris_kayit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.giris_kayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.giris_kayit.Location = new System.Drawing.Point(76, 95);
            this.giris_kayit.Name = "giris_kayit";
            this.giris_kayit.RowHeadersWidth = 51;
            this.giris_kayit.RowTemplate.Height = 29;
            this.giris_kayit.Size = new System.Drawing.Size(655, 285);
            this.giris_kayit.TabIndex = 0;
            // 
            // Log_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giris_kayit);
            this.Name = "Log_form";
            this.Text = "Log_form";
            this.Load += new System.EventHandler(this.Log_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.giris_kayit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView giris_kayit;
    }
}