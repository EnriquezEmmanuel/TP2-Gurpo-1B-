using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2Grupo1B
{
    public partial class LstadoArticulo : Form
    {
        public LstadoArticulo()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            dgvListadoArticulos.DataSource = negocio.listar();
            dgvListadoArticulos.Columns["UrlImagen"].Visible = false;
        }
    }
}
