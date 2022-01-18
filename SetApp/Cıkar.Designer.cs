
namespace SetApp
{
    partial class Cıkar
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
            ((System.ComponentModel.ISupportInitialize)(this.secilcek)).BeginInit();
            this.SuspendLayout();
            // 
            // secilcek
            // 
            this.secilcek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.secilcek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secilcek.Location = new System.Drawing.Point(63, 66);
            this.secilcek.Name = "secilcek";
            this.secilcek.RowHeadersWidth = 51;
            this.secilcek.RowTemplate.Height = 29;
            this.secilcek.Size = new System.Drawing.Size(643, 315);
            this.secilcek.TabIndex = 0;
            // 
            // Cıkar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secilcek);
            this.Name = "Cıkar";
            this.Text = "Cıkar";
            ((System.ComponentModel.ISupportInitialize)(this.secilcek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView secilcek;
    }
}