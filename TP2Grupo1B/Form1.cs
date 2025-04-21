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

namespace TP2Grupo1B
{//esto es una prueba
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al Catálogo de Artículos del Comercio.");
        }

        private void tlsBtnListadoDeArtículos_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(LstadoArticulo))
                    return;
            }

            LstadoArticulo ventana = new LstadoArticulo();
            ventana.Show();
        }

        private void tlsBtnBusquedaDeArticulos_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Buscar))
                    return;
            }

            Buscar ventana = new Buscar();
            ventana.Show();
        }

        private void tlsBtnAgregar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Agregar))
                    return;
            }

            Agregar ventana = new Agregar();
            ventana.Show();
        }

        private void tlsBtnModificarArtículo_Click(object sender, EventArgs e)
        {
            frmModificar vtnModificar = new frmModificar();
            vtnModificar.ShowDialog();
        }
    }
}
