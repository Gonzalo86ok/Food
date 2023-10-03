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
            this.btAgregar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btDetalle = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lbFiltroRapido = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDondeComemos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDondeComemos
            // 
            this.dgvDondeComemos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDondeComemos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDondeComemos.Location = new System.Drawing.Point(113, 57);
            this.dgvDondeComemos.MultiSelect = false;
            this.dgvDondeComemos.Name = "dgvDondeComemos";
            this.dgvDondeComemos.RowHeadersWidth = 51;
            this.dgvDondeComemos.RowTemplate.Height = 24;
            this.dgvDondeComemos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDondeComemos.Size = new System.Drawing.Size(736, 307);
            this.dgvDondeComemos.TabIndex = 0;
            this.dgvDondeComemos.SelectionChanged += new System.EventHandler(this.dgvDondeComemos_SelectionChanged);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(12, 57);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(79, 31);
            this.btAgregar.TabIndex = 1;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(12, 117);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(79, 31);
            this.btModificar.TabIndex = 2;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(12, 260);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(79, 31);
            this.btEliminar.TabIndex = 3;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(12, 333);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(79, 31);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btDetalle
            // 
            this.btDetalle.Location = new System.Drawing.Point(12, 185);
            this.btDetalle.Name = "btDetalle";
            this.btDetalle.Size = new System.Drawing.Size(79, 31);
            this.btDetalle.TabIndex = 5;
            this.btDetalle.Text = "Detalle";
            this.btDetalle.UseVisualStyleBackColor = true;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(879, 40);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(373, 324);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 6;
            this.pbImagen.TabStop = false;
            // 
            // lbFiltroRapido
            // 
            this.lbFiltroRapido.AutoSize = true;
            this.lbFiltroRapido.Location = new System.Drawing.Point(110, 26);
            this.lbFiltroRapido.Name = "lbFiltroRapido";
            this.lbFiltroRapido.Size = new System.Drawing.Size(65, 20);
            this.lbFiltroRapido.TabIndex = 7;
            this.lbFiltroRapido.Text = "Buscar:";
            this.lbFiltroRapido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(169, 25);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(215, 22);
            this.txtFiltro.TabIndex = 8;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // DondeComemos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 387);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lbFiltroRapido);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btDetalle);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.dgvDondeComemos);
            this.Name = "DondeComemos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donde Comemos?";
            this.Load += new System.EventHandler(this.DondeComemos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDondeComemos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDondeComemos;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btDetalle;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lbFiltroRapido;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}