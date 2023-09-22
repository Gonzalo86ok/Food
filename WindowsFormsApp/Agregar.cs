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
            Imagen imagen = new Imagen();
            try
            {
                if (string.IsNullOrEmpty(txtbNombre.Text) ||
                    string.IsNullOrEmpty(txtbDireccion.Text) ||
                    string.IsNullOrEmpty(txtbDescripcion.Text) ||
                    string.IsNullOrEmpty(txtbImagen.Text))
                {
                    MessageBox.Show("Hay campos sin completar");
                }
                else
                {
                    cena.name = (txtbNombre.Text);
                    cena.adress = (txtbDireccion.Text);
                    cena.localidad = (Localidad)cbLocalidad.SelectedItem;
                    cena.descripcion = (txtbDescripcion.Text);
                    cena.categoria = (Categoria)cbCategoria.SelectedItem;
                    negocio.addOut(cena);

                    imagen.Id_Food = negocio.UltimoRegistro();
                    imagen.name = (txtbImagen.Text);
                    negocio.addImagen(imagen);
                    MessageBox.Show("Agregado exitosamente");
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
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

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
