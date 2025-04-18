using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2Grupo1B
{
    internal class ProductoNegocio
    {
        public List<Producto> listar()
        {
            List<Producto> lista = new List<Producto>();

            // para obtener los datos de la base de datos

            SqlConnection conexion = new SqlConnection(); /// es un atributo para la coneccion
            SqlCommand comando = new SqlCommand(); // para realizar aciones
            SqlDataReader lector; // ya recibe un objeto por eso no se le crea una instancia 

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; Integrated Security=true"; ;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT  A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion AS Marca, C.Descripcion AS Categoria FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id WHERE 1=1";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    Producto aux = new Producto(); // creo un catalogo auxiliar para cargarlo con los datos de la base de datos
                    // guardo los datos que necesito
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca = (string)lector["Marca"];
                    aux.Categoria = (string)lector["Categoria"];
                    aux.Precio = (decimal)lector["Precio"];


                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
        public List<Producto> buscar(string Codigo, string Nombre, string Descripcion, string Marca, string Categoria, decimal? precio)
        {
            List<Producto> buscar = new List<Producto>();

            // para obtener los datos de la base de datos

            SqlConnection conexion = new SqlConnection(); /// es un atributo para la coneccion
            SqlCommand comando = new SqlCommand(); // para realizar aciones
            SqlDataReader lector; // ya recibe un objeto por eso no se le crea una instancia 

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; Integrated Security=true"; ;
                comando.CommandType = System.Data.CommandType.Text;

                //Armo una consulta de manera dinamica
                string consulta = "SELECT A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion AS Marca, C.Descripcion AS Categoria, I.ImagenUrl FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN IMAGENES I on I.IdArticulo = A.id WHERE 1=1";
                comando.Connection = conexion;

                if (!string.IsNullOrEmpty(Codigo))
                {
                    consulta += " AND Codigo = @Codigo";
                    comando.Parameters.AddWithValue("@Codigo", Codigo);// Remplazo el @codigo por el valor ingresado en le cuadro de texto
                }
                if (!string.IsNullOrEmpty(Nombre))
                {
                    consulta += " AND Nombre LIKE @Nombre";
                    comando.Parameters.AddWithValue("@Nombre", "%" + Nombre + "%");
                }
                if (!string.IsNullOrEmpty(Descripcion))
                {
                    consulta += " AND A.Descripcion LIKE @Descripcion";
                    comando.Parameters.AddWithValue("@Descripcion", "%" + Descripcion + "%");
                }
                if (!string.IsNullOrEmpty(Marca))
                {
                    consulta += " AND M.Descripcion LIKE @Marca";
                    comando.Parameters.AddWithValue("@Marca", "%" + Marca + "%");
                }
                if (!string.IsNullOrEmpty(Categoria))
                {
                    consulta += " AND C.Descripcion LIKE @Categoria";
                    comando.Parameters.AddWithValue("@Categoria", "%" + Categoria + "%");
                }
                if (precio.HasValue)
                {
                    consulta += " AND Precio = @Precio";
                    comando.Parameters.AddWithValue("@Precio", precio.Value);
                }


                comando.CommandText = consulta;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    Producto aux = new Producto(); // creo un catalogo auxiliar para cargarlo con los datos de la base de datos
                    // guardo los datos que necesito
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca = (string)lector["Marca"];
                    aux.Categoria = (string)lector["Categoria"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.UrlImagen = (string)lector["ImagenUrl"];

                    buscar.Add(aux);
                }

                conexion.Close();
                return buscar;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    }




}

