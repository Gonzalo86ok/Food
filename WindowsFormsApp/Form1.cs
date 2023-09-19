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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void queComemosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(QueComemos))
                {
                    return;
                }
            }

            QueComemos ventana = new QueComemos();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void dondePedimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(DondePedimos))
                {
                    return;
                }
            }

            DondePedimos ventana = new DondePedimos();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void dondeComemosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(DondeComemos))
                {
                    return;
                }
            }

            DondeComemos ventana = new DondeComemos();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
