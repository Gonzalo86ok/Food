using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace WindowsFormsApp
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OutSide cena = new OutSide();
            Negocio negocio = new Negocio();
            try
            {
                cena.name = (txtbNombre.Text);
                cena.adress = (txtbDireccion.Text);
                cena.localidad = (Localidad)cbLocalidad.SelectedItem;
                cena.descripcion = (txtbDescripcion.Text);
                cena.categoria = (Categoria)cbCategoria.SelectedItem;
                cena.imagen.name = (txtbImagen.Text);               

                negocio.addOut(cena);
                MessageBox.Show("Agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            try
            {
                cbCategoria.DataSource = negocio.listarOutSide(1);
                cbLocalidad.DataSource = negocio.listarOutSide(1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
