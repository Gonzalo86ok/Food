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
        public DondePedimos()
        {
            InitializeComponent();
        }

        private void DondePedimos_Load(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            dgvDondePedimos.DataSource = negocio.listarTakeWay();
        }
    }
}
