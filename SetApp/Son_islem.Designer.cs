
namespace SetApp
{
    partial class Son_islem
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
            this.islem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.islem)).BeginInit();
            this.SuspendLayout();
            // 
            // islem
            // 
            this.islem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.islem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.islem.Location = new System.Drawing.Point(65, 70);
            this.islem.Name = "islem";
            this.islem.RowHeadersWidth = 51;
            this.islem.RowTemplate.Height = 29;
            this.islem.Size = new System.Drawing.Size(666, 321);
            this.islem.TabIndex = 0;
            // 
            // Son_islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.islem);
            this.Name = "Son_islem";
            this.Text = "Son_islem";
            this.Load += new System.EventHandler(this.Son_islem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.islem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView islem;
    }
}