namespace WindowsFormsApp
{
    partial class DondePedimos
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
            this.dgvDondePedimos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDondePedimos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDondePedimos
            // 
            this.dgvDondePedimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDondePedimos.Location = new System.Drawing.Point(12, 80);
            this.dgvDondePedimos.Name = "dgvDondePedimos";
            this.dgvDondePedimos.RowHeadersWidth = 51;
            this.dgvDondePedimos.RowTemplate.Height = 24;
            this.dgvDondePedimos.Size = new System.Drawing.Size(833, 238);
            this.dgvDondePedimos.TabIndex = 0;
            // 
            // DondePedimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 450);
            this.Controls.Add(this.dgvDondePedimos);
            this.Name = "DondePedimos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donde Pedimos?";
            this.Load += new System.EventHandler(this.DondePedimos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDondePedimos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDondePedimos;
    }
}