namespace WindowsFormsApp
{
    partial class DondeComemos
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
            this.dgvDondeComemos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDondeComemos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDondeComemos
            // 
            this.dgvDondeComemos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDondeComemos.Location = new System.Drawing.Point(12, 69);
            this.dgvDondeComemos.Name = "dgvDondeComemos";
            this.dgvDondeComemos.RowHeadersWidth = 51;
            this.dgvDondeComemos.RowTemplate.Height = 24;
            this.dgvDondeComemos.Size = new System.Drawing.Size(830, 267);
            this.dgvDondeComemos.TabIndex = 0;
            // 
            // DondeComemos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 450);
            this.Controls.Add(this.dgvDondeComemos);
            this.Name = "DondeComemos";
            this.Text = "Donde Comemos?";
            this.Load += new System.EventHandler(this.DondeComemos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDondeComemos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDondeComemos;
    }
}