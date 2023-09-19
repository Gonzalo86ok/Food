namespace WindowsFormsApp
{
    partial class Form1
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
            this.btHome = new System.Windows.Forms.Button();
            this.btTakeWay = new System.Windows.Forms.Button();
            this.btOutSide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btHome
            // 
            this.btHome.Location = new System.Drawing.Point(124, 173);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(98, 61);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "What do we eat?";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btTakeWay
            // 
            this.btTakeWay.Location = new System.Drawing.Point(324, 173);
            this.btTakeWay.Name = "btTakeWay";
            this.btTakeWay.Size = new System.Drawing.Size(97, 61);
            this.btTakeWay.TabIndex = 1;
            this.btTakeWay.Text = "Where are we buying?";
            this.btTakeWay.UseCompatibleTextRendering = true;
            this.btTakeWay.UseVisualStyleBackColor = true;
            this.btTakeWay.Click += new System.EventHandler(this.btTakeWay_Click);
            // 
            // btOutSide
            // 
            this.btOutSide.Location = new System.Drawing.Point(529, 173);
            this.btOutSide.Name = "btOutSide";
            this.btOutSide.Size = new System.Drawing.Size(87, 61);
            this.btOutSide.TabIndex = 2;
            this.btOutSide.Text = "Where are we eating?";
            this.btOutSide.UseVisualStyleBackColor = true;
            this.btOutSide.Click += new System.EventHandler(this.btOutSide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btOutSide);
            this.Controls.Add(this.btTakeWay);
            this.Controls.Add(this.btHome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btTakeWay;
        private System.Windows.Forms.Button btOutSide;
    }
}

