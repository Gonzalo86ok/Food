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
            this.lbFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.dgvDondeComemos.Size = new System.Drawing.Size(736, 257);
            this.dgvDondeComemos.TabIndex = 0;
            this.dgvDondeComemos.SelectionChanged += new System.EventHandler(this.dgvDondeComemos_SelectionChanged);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(19, 57);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(79, 31);
            this.btAgregar.TabIndex = 1;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(19, 111);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(79, 31);
            this.btModificar.TabIndex = 2;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(19, 226);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(79, 31);
            this.btEliminar.TabIndex = 3;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(19, 283);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(79, 31);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btDetalle
            // 
            this.btDetalle.Location = new System.Drawing.Point(19, 170);
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
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Location = new System.Drawing.Point(110, 26);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(39, 16);
            this.lbFiltro.TabIndex = 7;
            this.lbFiltro.Text = "Filtro:";
            this.lbFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(155, 23);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(215, 22);
            this.txtFiltro.TabIndex = 8;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(774, 341);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 9;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 333);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(336, 341);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(544, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 15;
            // 
            // DondeComemos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 387);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lbFiltro);
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
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}