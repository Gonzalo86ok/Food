namespace WindowsFormsApp
{
    partial class AgregarCook
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
            this.pbAgregarImagen = new System.Windows.Forms.PictureBox();
            this.txtbImagen = new System.Windows.Forms.TextBox();
            this.lbImagen = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAgregarImagen
            // 
            this.pbAgregarImagen.Location = new System.Drawing.Point(259, 23);
            this.pbAgregarImagen.Name = "pbAgregarImagen";
            this.pbAgregarImagen.Size = new System.Drawing.Size(285, 237);
            this.pbAgregarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAgregarImagen.TabIndex = 29;
            this.pbAgregarImagen.TabStop = false;
            // 
            // txtbImagen
            // 
            this.txtbImagen.Location = new System.Drawing.Point(112, 173);
            this.txtbImagen.Name = "txtbImagen";
            this.txtbImagen.Size = new System.Drawing.Size(121, 22);
            this.txtbImagen.TabIndex = 23;
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Location = new System.Drawing.Point(47, 176);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(55, 16);
            this.lbImagen.TabIndex = 28;
            this.lbImagen.Text = "Imagen:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(112, 121);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cbCategoria.TabIndex = 21;
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Location = new System.Drawing.Point(112, 69);
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Size = new System.Drawing.Size(121, 22);
            this.txtbDescripcion.TabIndex = 19;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(112, 23);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(121, 22);
            this.txtbNombre.TabIndex = 15;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(37, 124);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(69, 16);
            this.lbCategoria.TabIndex = 25;
            this.lbCategoria.Text = "Categoria:";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(24, 72);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lbDescripcion.TabIndex = 24;
            this.lbDescripcion.Text = "Descripcion:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(47, 26);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(59, 16);
            this.lbNombre.TabIndex = 18;
            this.lbNombre.Text = "Nombre:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(158, 237);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 30);
            this.BtnCancelar.TabIndex = 27;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(64, 237);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 30);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // AgregarCook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 297);
            this.Controls.Add(this.pbAgregarImagen);
            this.Controls.Add(this.txtbImagen);
            this.Controls.Add(this.lbImagen);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtbDescripcion);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "AgregarCook";
            this.Text = "AgregarCook";
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAgregarImagen;
        private System.Windows.Forms.TextBox txtbImagen;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtbDescripcion;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnAgregar;
    }
}