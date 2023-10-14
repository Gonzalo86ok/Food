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
    public partial class QueComemos : Form
    {
        private List<Cooking> listarHome;
        public QueComemos()
        {
            InitializeComponent();
        }

        private void QueComemos_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
            {
                Negocio negocio = new Negocio();
                listarHome = negocio.listarHome();
                dgvQueComemos.DataSource = listarHome;
                ocultarColumnas();
                cargarImagen(listarHome[0].imagen.name);
            }
        private void ocultarColumnas()
            {
                dgvQueComemos.Columns["id"].Visible = false;
                dgvQueComemos.Columns["imagen"].Visible = false;
            }   
        private void btCancelar_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        private void dgvDondeComemos_SelectionChanged(object sender, EventArgs e)
            {
                if (dgvQueComemos.CurrentRow != null)
                {
                    Cooking seleccionado = (Cooking)dgvQueComemos.CurrentRow.DataBoundItem;
                    cargarImagen(seleccionado.imagen.name);
                }
            }
        private void cargarImagen(string imagen)
            {
                try
                {
                    pbImagen.Load(imagen);
                }
                catch (Exception ex)
                {
                    pbImagen.Load("https://i.stack.imgur.com/y9DpT.jpg");
                }
            }
        private void btAgregar_Click(object sender, EventArgs e)
            {
                Agregar alta = new Agregar();
                alta.ShowDialog();
                cargar();
            }
        private void btModificar_Click(object sender, EventArgs e)
            {
                Cooking seleccionado = (Cooking)dgvQueComemos.CurrentRow.DataBoundItem;

                AgregarCook modificar = new AgregarCook(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
        private void btEliminar_Click(object sender, EventArgs e)
            {
                Negocio negocio = new Negocio();
                Cooking seleccionado;
                try
                {
                    DialogResult respuesta = MessageBox.Show("Realment desea eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Cooking)dgvQueComemos.CurrentRow.DataBoundItem;
                        negocio.eliminarImagen(seleccionado.id);
                        negocio.eliminar(seleccionado.id);
                        cargar();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }       
        private void txtFiltro_TextChanged(object sender, EventArgs e)
            {
                List<Cooking> listaFiltrada;
                string filtro = txtFiltro.Text;
                if (filtro.Length > 3)
                {
                    listaFiltrada = listarHome.FindAll(x => x.nombre.ToUpper().Contains(filtro.ToUpper()));
                }
                else
                {
                    listaFiltrada = listarHome;
                }
                dgvQueComemos.DataSource = null;
                dgvQueComemos.DataSource = listaFiltrada;
                ocultarColumnas();
            }     
    }
}
