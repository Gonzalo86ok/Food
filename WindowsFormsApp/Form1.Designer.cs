namespace WindowsFormsApp
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queComemosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dondePedimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dondeComemosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queComemosToolStripMenuItem,
            this.dondePedimosToolStripMenuItem,
            this.dondeComemosToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // queComemosToolStripMenuItem
            // 
            this.queComemosToolStripMenuItem.Name = "queComemosToolStripMenuItem";
            this.queComemosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.queComemosToolStripMenuItem.Text = "Que Comemos?";
            this.queComemosToolStripMenuItem.Click += new System.EventHandler(this.queComemosToolStripMenuItem_Click);
            // 
            // dondePedimosToolStripMenuItem
            // 
            this.dondePedimosToolStripMenuItem.Name = "dondePedimosToolStripMenuItem";
            this.dondePedimosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dondePedimosToolStripMenuItem.Text = "Donde Pedimos?";
            this.dondePedimosToolStripMenuItem.Click += new System.EventHandler(this.dondePedimosToolStripMenuItem_Click);
            // 
            // dondeComemosToolStripMenuItem
            // 
            this.dondeComemosToolStripMenuItem.Name = "dondeComemosToolStripMenuItem";
            this.dondeComemosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dondeComemosToolStripMenuItem.Text = "Donde Comemos?";
            this.dondeComemosToolStripMenuItem.Click += new System.EventHandler(this.dondeComemosToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queComemosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dondePedimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dondeComemosToolStripMenuItem;
    }
}

