﻿using dominio;
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
    public partial class DondePedimos : Form
    {
        private List<OutSide> listaOut;
        public DondePedimos()
        {
            InitializeComponent();
        }
        private void DondePedimos_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            Negocio negocio = new Negocio();
            listaOut = negocio.listarOutSide(0);
            dgvDondePedimos.DataSource = listaOut;
            ocultarColumnas();
            cargarImagen(listaOut[0].imagen.name);
        }
        private void ocultarColumnas()
        {
            dgvDondePedimos.Columns["Outside"].Visible = false;
            dgvDondePedimos.Columns["id"].Visible = false;
            dgvDondePedimos.Columns["imagen"].Visible = false;
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
            OutSide seleccionado = (OutSide)dgvDondePedimos.CurrentRow.DataBoundItem;

            Agregar modificar = new Agregar(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<OutSide> listaFiltrada;
            string filtro = txtFiltro.Text;
            if (filtro.Length > 3)
            {
                listaFiltrada = listaOut.FindAll(x => x.name.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaOut;
            }
            dgvDondePedimos.DataSource = null;
            dgvDondePedimos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
        private void btEliminar_Click(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            OutSide seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Realment desea eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (OutSide)dgvDondePedimos.CurrentRow.DataBoundItem;
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
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvDondePedimos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDondePedimos.CurrentRow != null)
            {
                OutSide seleccionado = (OutSide)dgvDondePedimos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.imagen.name);
            }
        }
    }
}
