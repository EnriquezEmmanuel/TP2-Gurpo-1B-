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
using dominio;
using negocio;

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

            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string Marca = cboMarca.Text;
            string Categoria = cboCategoria.Text;
            decimal? precio = null; 

            if (!string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                string precioTexto = txtPrecio.Text.Replace(",", ".");

                decimal valor;
                bool esValido = decimal.TryParse(precioTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out valor); 

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
            //dataGridViewListado.Columns["id"].Visible = false;
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
            cboMarca.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
            txtPrecio.Text = "";
            dataGridViewListado.DataSource = "";
            pbxImagen.Image= TP2Grupo1B.Properties.Resources.istockphoto_1409329028_612x612;

        }

        private void dataGridViewListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewListado.CurrentRow == null) return;

            Producto seleccionado = (Producto)dataGridViewListado.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.UrlImagen);
        }
        private void CargarImagen(string imagen)
        {
           
            try
            {
                pbxImagen.Load(imagen);

            }
            catch
            {
                pbxImagen.Image = TP2Grupo1B.Properties.Resources.istockphoto_1409329028_612x612;
            }
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.SelectedIndex = -1;
                cboCategoria.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            Producto seleccionado;

            try
            {
                if (dataGridViewListado.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, seleccioná un producto para eliminar.");
                    return;
                }

                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro que quieres eliminar este producto?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    seleccionado = (Producto)dataGridViewListado.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.Id);

                    Cargar();
                    dataGridViewListado.DataSource = null;
                    pbxImagen.Image = TP2Grupo1B.Properties.Resources.istockphoto_1409329028_612x612;
                }
                else
                {
                    MessageBox.Show("El producto no ha sido eliminado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }




        private void Cargar()
        {
            ProductoNegocio negocio = new ProductoNegocio();
            List<Producto> articulos = negocio.listar(); // Obtener la lista de productos actualizada
            dataGridViewListado.DataSource = articulos;
            dataGridViewListado.Columns["UrlImagen"].Visible = false; // Ocultar la columna de la imagen
        }
    }

}
