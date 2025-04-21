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
using dominio;

namespace TP2Grupo1B
{
    public partial class frmModificar : Form
    {
        private List<Producto> listaArticulos;
        private Producto ArticuloModificar = new Producto();
        public frmModificar()
        {
            InitializeComponent();
        }

        private void frmModificar_Load(object sender, EventArgs e)
        {
           CargarArticulos();
            /* 
            ProductoNegocio ProductoCbobox = new ProductoNegocio();
            try
            {
                cboModCategoria.DataSource = ProductoCbobox.listar();
                cboModMarca.DataSource=ProductoCbobox.listar();
            }
            catch (Exception)
            {

                throw;
            }*/

        }


        private void txModImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txModImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxProductoModificar.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxProductoModificar.Load("https://media.istockphoto.com/id/1396814518/es/vector/imagen-pr%C3%B3ximamente-sin-foto-sin-imagen-en-miniatura-disponible-ilustraci%C3%B3n-vectorial.jpg?s=612x612&w=0&k=20&c=aA0kj2K7ir8xAey-SaPc44r5f-MATKGN0X0ybu_A774=");
            }
        }

        private void CargarArticulos()
        {
            ProductoNegocio listadoArticulos = new ProductoNegocio();
            listaArticulos = listadoArticulos.listar();
            dgvModListado.DataSource = listaArticulos;


            generarLista(cboModMarca, "Marca");      //|Emma| Algo rústico que se me ocurrió, porque no funcionaba de la manera del profe.
            generarLista(cboModCategoria, "Categoria");

        }

        private void generarLista(ComboBox combo, string atributo)
        {
            List<string> listaDesp = new List<string>();
            for (int i = 0; i < listaArticulos.Count; i++)
            {
                switch (atributo)
                {
                    case "Marca":
                        listaDesp.Add(listaArticulos[i].Marca.Descripcion);
                        break;
                    case "Categoria":
                        listaDesp.Add(listaArticulos[i].Categoria.Descripcion);
                        break;
                }
            }

            List<string> listaDesplegables = listaDesp.Distinct().ToList();     //|Emma| para que no se repitan
            combo.DataSource = listaDesplegables;
        }

        private void txModCodigo_TextChanged(object sender, EventArgs e)
        {
            string filtro = txModCodigo.Text;
            List<Producto> listaFiltrada;
            try
            {
                if (filtro != null || filtro != "")
                {
                    listaFiltrada = listaArticulos.FindAll(x => x.Codigo.ToUpper().Contains(filtro.ToUpper()));

                    if (listaFiltrada.Count > 0)      //|Emma|verifica que no este vacía
                    {

                        /*|Emma|
                        en [0] para que muestre el primero encontrado, a medida que se va refinando la busqueda van 
                        quedando menos opciones (siempre teniendo en cuenta que está visible para el usuario la grid view
                        */
                        txModNombre.Text = listaFiltrada[0].Nombre;
                        txModDescripcion.Text = listaFiltrada[0].Descripcion;
                        cboModMarca.Text = listaFiltrada[0].Marca.Descripcion;
                        cboModCategoria.Text = listaFiltrada[0].Categoria.Descripcion;
                        txModImagen.Text = listaFiltrada[0].UrlImagen;
                        txModPrecio.Text = listaFiltrada[0].Precio.ToString();
                        txIdOcutlto.Text = listaFiltrada[0].Id.ToString();

                        cargarImagen(txModImagen.Text);
                    }
                    else { limpiarCampos(); }
                }
                else
                { listaFiltrada = listaArticulos; }

                if (filtro == "") { limpiarCampos(); }

                dgvModListado.DataSource = null;
                dgvModListado.DataSource = listaFiltrada;
            }
            catch (Exception ex) { throw ex; }

        }

        private void limpiarCampos()
        {
            txModNombre.Text = "";
            txModDescripcion.Text = "";
            txModImagen.Text = "";
            txModPrecio.Text = "";
            cargarImagen("");
        }

        private void CargarArticuloModificado()
        {
            ArticuloModificar.Codigo = txModCodigo.Text;
            ArticuloModificar.Nombre = txModNombre.Text;
            ArticuloModificar.Descripcion = txModDescripcion.Text;
            ArticuloModificar.UrlImagen = txModImagen.Text;
            ArticuloModificar.Precio = Convert.ToDecimal(txModPrecio.Text);

            ArticuloModificar.Id = int.Parse(txIdOcutlto.Text);

            ArticuloModificar.Marca = new Marca();
            ArticuloModificar.Marca.Descripcion = (string)cboModMarca.SelectedItem;
            ArticuloModificar.Categoria = new Categoria();
            ArticuloModificar.Categoria.Descripcion = (string)cboModCategoria.SelectedItem;

        }

        private void btnModModificar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarArticuloModificado();
                //MessageBox.Show(ArticuloModificar.Id.ToString());

                if (ArticuloModificar.Id != 0)
                {
                    ProductoNegocio ArticuloModificado = new ProductoNegocio();
                    ArticuloModificado.Modificar(ArticuloModificar);
                    MessageBox.Show("Se modifico el Artículo");
                    CargarArticulos();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
    }
}
