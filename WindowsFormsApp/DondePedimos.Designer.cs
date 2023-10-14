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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lbFiltroRapido = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btDetalle = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.dgvDondePedimos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDondePedimos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(167, 18);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(215, 22);
            this.txtFiltro.TabIndex = 24;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lbFiltroRapido
            // 
            this.lbFiltroRapido.AutoSize = true;
            this.lbFiltroRapido.Location = new System.Drawing.Point(108, 19);
            this.lbFiltroRapido.Name = "lbFiltroRapido";
            this.lbFiltroRapido.Size = new System.Drawing.Size(52, 16);
            this.lbFiltroRapido.TabIndex = 23;
            this.lbFiltroRapido.Text = "Buscar:";
            this.lbFiltroRapido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(877, 33);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(373, 324);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 22;
            this.pbImagen.TabStop = false;
            // 
            // btDetalle
            // 
            this.btDetalle.Location = new System.Drawing.Point(17, 191);
            this.btDetalle.Name = "btDetalle";
            this.btDetalle.Size = new System.Drawing.Size(79, 31);
            this.btDetalle.TabIndex = 21;
            this.btDetalle.Text = "Detalle";
            this.btDetalle.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(17, 326);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(79, 31);
            this.btCancelar.TabIndex = 20;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(17, 262);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(79, 31);
            this.btEliminar.TabIndex = 19;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(17, 120);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(79, 31);
            this.btModificar.TabIndex = 18;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(17, 50);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(79, 31);
            this.btAgregar.TabIndex = 17;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // dgvDondePedimos
            // 
            this.dgvDondePedimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDondePedimos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDondePedimos.Location = new System.Drawing.Point(111, 50);
            this.dgvDondePedimos.MultiSelect = false;
            this.dgvDondePedimos.Name = "dgvDondePedimos";
            this.dgvDondePedimos.RowHeadersWidth = 51;
            this.dgvDondePedimos.RowTemplate.Height = 24;
            this.dgvDondePedimos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDondePedimos.Size = new System.Drawing.Size(736, 307);
            this.dgvDondePedimos.TabIndex = 16;
            this.dgvDondePedimos.SelectionChanged += new System.EventHandler(this.dgvDondePedimos_SelectionChanged);
            // 
            // DondePedimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 393);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lbFiltroRapido);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btDetalle);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.dgvDondePedimos);
            this.Name = "DondePedimos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donde Pedimos?";
            this.Load += new System.EventHandler(this.DondePedimos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDondePedimos)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDondePedimos;
    }
}