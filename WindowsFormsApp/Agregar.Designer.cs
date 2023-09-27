namespace WindowsFormsApp
{
    partial class Agregar
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbDireccion = new System.Windows.Forms.TextBox();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lbImagen = new System.Windows.Forms.Label();
            this.txtbImagen = new System.Windows.Forms.TextBox();
            this.pbAgregarImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(70, 270);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(164, 270);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(53, 59);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(59, 16);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(45, 94);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(67, 16);
            this.lbDireccion.TabIndex = 3;
            this.lbDireccion.Text = "Direccion:";
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Location = new System.Drawing.Point(42, 128);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(70, 16);
            this.lbLocalidad.TabIndex = 4;
            this.lbLocalidad.Text = "Localidad:";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(30, 159);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lbDescripcion.TabIndex = 5;
            this.lbDescripcion.Text = "Descripcion:";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(43, 193);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(69, 16);
            this.lbCategoria.TabIndex = 6;
            this.lbCategoria.Text = "Categoria:";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(118, 56);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(121, 22);
            this.txtbNombre.TabIndex = 0;
            // 
            // txtbDireccion
            // 
            this.txtbDireccion.Location = new System.Drawing.Point(118, 91);
            this.txtbDireccion.Name = "txtbDireccion";
            this.txtbDireccion.Size = new System.Drawing.Size(121, 22);
            this.txtbDireccion.TabIndex = 1;
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Location = new System.Drawing.Point(118, 156);
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.Size = new System.Drawing.Size(121, 22);
            this.txtbDescripcion.TabIndex = 3;
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(118, 125);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(121, 24);
            this.cbLocalidad.TabIndex = 2;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(118, 190);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cbCategoria.TabIndex = 4;
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Location = new System.Drawing.Point(57, 227);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(55, 16);
            this.lbImagen.TabIndex = 12;
            this.lbImagen.Text = "Imagen:";
            // 
            // txtbImagen
            // 
            this.txtbImagen.Location = new System.Drawing.Point(118, 224);
            this.txtbImagen.Name = "txtbImagen";
            this.txtbImagen.Size = new System.Drawing.Size(121, 22);
            this.txtbImagen.TabIndex = 5;
            this.txtbImagen.Leave += new System.EventHandler(this.txtbImagen_Leave);
            // 
            // pbAgregarImagen
            // 
            this.pbAgregarImagen.Location = new System.Drawing.Point(265, 56);
            this.pbAgregarImagen.Name = "pbAgregarImagen";
            this.pbAgregarImagen.Size = new System.Drawing.Size(285, 237);
            this.pbAgregarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAgregarImagen.TabIndex = 14;
            this.pbAgregarImagen.TabStop = false;
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 331);
            this.Controls.Add(this.pbAgregarImagen);
            this.Controls.Add(this.txtbImagen);
            this.Controls.Add(this.lbImagen);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbLocalidad);
            this.Controls.Add(this.txtbDescripcion);
            this.Controls.Add(this.txtbDireccion);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbLocalidad);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Agregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbLocalidad;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbDireccion;
        private System.Windows.Forms.TextBox txtbDescripcion;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.TextBox txtbImagen;
        private System.Windows.Forms.PictureBox pbAgregarImagen;
    }
}