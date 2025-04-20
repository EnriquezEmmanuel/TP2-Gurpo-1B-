using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TP2Grupo1B
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           

            Producto producto = new Producto();
            ProductoNegocio negocio = new ProductoNegocio();
            
            try
            {
                producto.Codigo = txtCodigo.Text;
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.UrlImagen = txtUrlimagen.Text;
                producto.Marca = (Marca)cboMarca.SelectedItem; 
                producto.Categoria = (Categoria) cboCategoria.SelectedItem;
                producto.Precio = decimal.Parse(txtPrecio.Text);

                                
                negocio.agregar(producto);
                MessageBox.Show("Agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboMarca.DataSource = marcaNegocio.listar();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }

        }

        private void txtUrlimagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtUrlimagen.Text);
        }

        private void validarFormulario()
        {
            
            bool codigoValido = !string.IsNullOrWhiteSpace(txtCodigo.Text);
            bool nombreValido = !string.IsNullOrWhiteSpace(txtNombre.Text);
            bool precioValido = true;
            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                errorProvider.SetError(txtPrecio, "");
                precioValido = false;
            }
            else if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                errorProvider.SetError(txtPrecio, "El Precio debe ser un número mayor a 0");
                precioValido = false;
            }
            else
            {
                errorProvider.SetError(txtPrecio, "");
            }

            lblAstCodigo.Visible = !codigoValido;
            lblAstNombre.Visible = !nombreValido;
            lblAstPrecio.Visible = string.IsNullOrWhiteSpace(txtPrecio.Text);

            btnAceptar.Enabled = codigoValido && nombreValido && precioValido;
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            validarFormulario();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validarFormulario();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            validarFormulario();
        }

    }
}
