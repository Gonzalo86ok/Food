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
        private OutSide local = null;
        public Agregar()
        {
            InitializeComponent();
        }
        public Agregar(OutSide local)
        {
            InitializeComponent();
            this.local = local;
            Text = "modificar";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {           
            Negocio negocio = new Negocio();
            Imagen imagen = new Imagen();
            try
            {
                if (string.IsNullOrEmpty(txtbNombre.Text) ||
                    string.IsNullOrEmpty(txtBarrio.Text) ||
                    string.IsNullOrEmpty(txtbDireccion.Text) ||
                    string.IsNullOrEmpty(txtbDescripcion.Text) ||
                    string.IsNullOrEmpty(txtbImagen.Text))
                {
                    MessageBox.Show("Hay campos sin completar");
                }
                else
                {
                    if (local == null)
                    {
                        local = new OutSide();
                    }
                    local.name = (txtbNombre.Text);
                    local.adress = (txtbDireccion.Text);
                    local.barrio = (txtBarrio.Text);
                    local.localidad = (Localidad)cbLocalidad.SelectedItem;
                    local.descripcion = (txtbDescripcion.Text);
                    local.categoria = (Categoria)cbCategoria.SelectedItem;

                    if(local.id != 0)
                    {
                        negocio.modificar(local);
                        imagen.id = local.imagen.id;
                        imagen.Id_Food = local.id;
                        imagen.name = (txtbImagen.Text);
                        negocio.modificarImagen(imagen);
                        MessageBox.Show("Modificado exitosamente");
                    }
                    else 
                    {
                        negocio.addOut(local);
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

                if(local != null) 
                {
                    txtbNombre.Text = local.name;
                    txtbDireccion.Text = local.adress;
                    txtBarrio.Text = local.barrio;
                    cbLocalidad.SelectedValue = local.localidad.id;
                    txtbDescripcion.Text = local.descripcion;
                    cbCategoria.SelectedValue = local.categoria.id;
                    txtbImagen.Text = local.imagen.name;
                    cargarImagen(local.imagen.name);
                }
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
