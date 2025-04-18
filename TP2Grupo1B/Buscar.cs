using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2Grupo1B
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();

            // Inicializar variables con valores nulos
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string Marca = txtMarca.Text;
            string Categoria = txtCategoria.Text;
            decimal? precio = null; // Inicializa como null

            if (!string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                string precioTexto = txtPrecio.Text.Replace(",", ".");

                decimal valor;
                bool esValido = decimal.TryParse(precioTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out valor); //Intenta convertir el texto a decimal sin tirar error si lo logra lo guarda en valor
                                                                                                                          // y a esValido pasa a true, si el texto no es un número válido, esValido queda en false.

                if (esValido)
                {
                    precio = valor;
                }
                else
                {
                    MessageBox.Show("Ingrese un precio válido (por ejemplo: 123.45)");
                    return;
                }
            }



            // Ejecutar la búsqueda con los parámetros validados
            List<Producto> articulos = new List<Producto>();
            articulos.AddRange(negocio.buscar(codigo, nombre, descripcion, Marca, Categoria, precio));
            dataGridViewListado.DataSource = articulos;
            dataGridViewListado.Columns["UrlImagen"].Visible = false;
            if (articulos == null || articulos.Count == 0)
            {
                MessageBox.Show("Realice una busqueda con valores existentes");
                return;
            }



        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtCategoria.Text = "";
            txtPrecio.Text = "";
            dataGridViewListado.DataSource = "";
            pbxImagen.Image= TP2Grupo1B.Properties.Resources.istockphoto_1409329028_612x612;

        }

        private void dataGridViewListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewListado.CurrentRow == null) return;

            Producto seleccionado = (Producto)dataGridViewListado.CurrentRow.DataBoundItem;// hago un casteo para poder usar el DataBoundItem
            CargarImagen(seleccionado.UrlImagen);
        }
        private void CargarImagen(string imagen)
        {
           
            try
            {
                // Opción síncrona (Load), con catch para evitar excepciones
                pbxImagen.Load(imagen);

            }
            catch
            {
                // Si falla (403, 404, timeouts…), limpio la imagen para evitar crasheo 
                pbxImagen.Image = TP2Grupo1B.Properties.Resources.istockphoto_1409329028_612x612;
            }
        }

 
    }
}
