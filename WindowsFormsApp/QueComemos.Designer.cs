namespace WindowsFormsApp
{
    partial class QueComemos
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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lbFiltroRapido = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btDetalle = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.dgvQueComemos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueComemos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(172, 17);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(215, 22);
            this.txtFiltro.TabIndex = 24;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged_1);
            // 
            // lbFiltroRapido
            // 
            this.lbFiltroRapido.AutoSize = true;
            this.lbFiltroRapido.Location = new System.Drawing.Point(113, 18);
            this.lbFiltroRapido.Name = "lbFiltroRapido";
            this.lbFiltroRapido.Size = new System.Drawing.Size(52, 16);
            this.lbFiltroRapido.TabIndex = 23;
            this.lbFiltroRapido.Text = "Buscar:";
            this.lbFiltroRapido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(882, 32);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(373, 324);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 22;
            this.pbImagen.TabStop = false;
            // 
            // btDetalle
            // 
            this.btDetalle.Location = new System.Drawing.Point(22, 191);
            this.btDetalle.Name = "btDetalle";
            this.btDetalle.Size = new System.Drawing.Size(79, 31);
            this.btDetalle.TabIndex = 21;
            this.btDetalle.Text = "Detalle";
            this.btDetalle.UseVisualStyleBackColor = true;
            this.btDetalle.Click += new System.EventHandler(this.btDetalle_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(22, 325);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(79, 31);
            this.btCancelar.TabIndex = 20;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(22, 256);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(79, 31);
            this.btEliminar.TabIndex = 19;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click_1);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(22, 120);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(79, 31);
            this.btModificar.TabIndex = 18;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click_1);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(22, 49);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(79, 31);
            this.btAgregar.TabIndex = 17;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click_1);
            // 
            // dgvQueComemos
            // 
            this.dgvQueComemos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueComemos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQueComemos.Location = new System.Drawing.Point(116, 49);
            this.dgvQueComemos.MultiSelect = false;
            this.dgvQueComemos.Name = "dgvQueComemos";
            this.dgvQueComemos.RowHeadersWidth = 51;
            this.dgvQueComemos.RowTemplate.Height = 24;
            this.dgvQueComemos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQueComemos.Size = new System.Drawing.Size(736, 307);
            this.dgvQueComemos.TabIndex = 16;
            this.dgvQueComemos.SelectionChanged += new System.EventHandler(this.dgvQueComemos_SelectionChanged);
            // 
            // QueComemos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 395);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lbFiltroRapido);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btDetalle);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.dgvQueComemos);
            this.Name = "QueComemos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Que Comemos?";
            this.Load += new System.EventHandler(this.QueComemos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueComemos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lbFiltroRapido;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btDetalle;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.DataGridView dgvQueComemos;
    }
}