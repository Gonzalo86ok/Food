using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class AgregarCook : Form
    {
        private Cooking cocina = null;
        public AgregarCook()
        {
            InitializeComponent();
        }
        public AgregarCook(Cooking cocina)
        {
            InitializeComponent();
            this.cocina = cocina;
            Text = "modificar";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            Imagen imagen = new Imagen();
            try
            {
                if (string.IsNullOrEmpty(txtbNombre.Text) ||                   
                    string.IsNullOrEmpty(txtbDescripcion.Text) ||
                    string.IsNullOrEmpty(txtbImagen.Text))
                {
                    MessageBox.Show("Hay campos sin completar");
                }
                else
                {
                    if (cocina == null)
                    {
                        cocina = new Cooking();
                    }
                    cocina.nombre = (txtbNombre.Text);
                    cocina.descripcion = (txtbDescripcion.Text);
                    cocina.categoria = (Categoria)cbCategoria.SelectedItem;

                    if (cocina.id != 0)
                    {
                        negocio.modificarCook(cocina);
                        imagen.id = cocina.imagen.id;
                        imagen.Id_Food = cocina.id;
                        imagen.name = (txtbImagen.Text);
                        negocio.modificarImagen(imagen);
                        MessageBox.Show("Modificado exitosamente");

                    }
                    else
                    {
                        negocio.addCook(cocina);
                        imagen.Id_Food = negocio.UltimoRegistro();
                        imagen.name = (txtbImagen.Text);
                        negocio.addImagen(imagen);
                        MessageBox.Show("Agregado exitosamente");
                    }
                }
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
        /*
        private void Agregar_Load(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            try
            {
                cbLocalidad.DataSource = negocio.listarLocalidad();
                cbLocalidad.ValueMember = "id";
                cbLocalidad.DisplayMember = "descripcion";

                cbCategoria.DataSource = negocio.listarCategoria();
                cbCategoria.ValueMember = "id";
                cbCategoria.DisplayMember = "nombre";

                if (cocina != null)
                {
                    txtbNombre.Text = cocina.nombre;                                 
                    txtbDescripcion.Text = cocina.descripcion;
                    cbCategoria.SelectedValue = cocina.categoria.id;
                    txtbImagen.Text = cocina.imagen.name;
                    cargarImagen(cocina.imagen.name);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        */
        private void txtbImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtbImagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbAgregarImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbAgregarImagen.Load("https://i.stack.imgur.com/y9DpT.jpg");
            }
        }
    }
}

    

