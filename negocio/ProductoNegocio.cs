using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ProductoNegocio
    {
        public List<Producto> listar()
        {
            List<Producto> lista = new List<Producto>();

            // para obtener los datos de la base de datos
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT A.id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion AS Marca, C.Descripcion AS Categoria, I.ImagenUrl FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id LEFT JOIN (SELECT IdArticulo, MIN(ImagenUrl) AS ImagenUrl FROM IMAGENES GROUP BY IdArticulo) I ON I.IdArticulo = A.id;");
                datos.ejecutarLectura();
                
                while (datos.Lector.Read())
                {

                    Producto aux = new Producto(); // creo un catalogo auxiliar para cargarlo con los datos de la base de datos
                    // guardo los datos que necesito
                    aux.Id = (int)datos.Lector["id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    // Verifica si la categoría es NULL antes de asignarla
                    if (datos.Lector["Categoria"] == DBNull.Value)
                    {
                        aux.Categoria = null;  // Asigna null si la categoría es NULL
                    }
                    else
                    {
                        aux.Categoria = new Categoria();
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    }
                    aux.Precio = (decimal)datos.Lector["Precio"];


                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }

        public void agregar(Producto nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("BEGIN TRANSACTION; INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio); DECLARE @IdArticulo INT = SCOPE_IDENTITY(); INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl); COMMIT TRANSACTION;");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@ImagenUrl", nuevo.UrlImagen);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Producto> buscar(string Codigo, string Nombre, string Descripcion, string Marca, string Categoria, decimal? precio)
        {
            List<Producto> buscar = new List<Producto>();

            // para obtener los datos de la base de datos
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //Armo una consulta de manera dinamica
                string consulta = "SELECT A.id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion AS Marca, C.Descripcion AS Categoria, I.ImagenUrl FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id LEFT JOIN (SELECT IdArticulo, MIN(ImagenUrl) AS ImagenUrl FROM IMAGENES GROUP BY IdArticulo) I ON I.IdArticulo = A.id;";

                if (!string.IsNullOrEmpty(Codigo))
                {
                    consulta += " AND Codigo = @Codigo";
                    datos.setearParametro("@Codigo", Codigo);
                }
                if (!string.IsNullOrEmpty(Nombre))
                {
                    consulta += " AND Nombre LIKE @Nombre";
                    datos.setearParametro("@Nombre", "%" + Nombre + "%");
                }
                if (!string.IsNullOrEmpty(Descripcion))
                {
                    consulta += " AND A.Descripcion LIKE @Descripcion";
                    datos.setearParametro("@Descripcion", "%" + Descripcion + "%");
                }
                if (!string.IsNullOrEmpty(Marca))
                {
                    consulta += " AND M.Descripcion LIKE @Marca";
                    datos.setearParametro("@Marca", "%" + Marca + "%");
                }
                if (!string.IsNullOrEmpty(Categoria))
                {
                    consulta += " AND C.Descripcion LIKE @Categoria";
                    datos.setearParametro("@Categoria", "%" + Categoria + "%");
                }
                if (precio.HasValue)
                {
                    consulta += " AND Precio = @Precio";
                    datos.setearParametro("@Precio", precio.Value);
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = datos.Lector["Marca"] == DBNull.Value ? null : (string)datos.Lector["Marca"];

                    // Si la categoría es NULL en la base de datos, no se asigna ninguna categoría al producto
                    if (datos.Lector["Categoria"] == DBNull.Value)
                    {
                        aux.Categoria = null;
                    }
                    else
                    {
                        aux.Categoria = new Categoria();
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    }

                    aux.Precio = (decimal)datos.Lector["Precio"];

                    // Si no hay una imagen registrada (valor NULL en la base de datos), se asigna una imagen por defecto
                    if (datos.Lector["ImagenUrl"] == DBNull.Value)
                    {
                        aux.UrlImagen = "TP2Grupo1B.Properties.Resources.istockphoto_1409329028_612x612";
                    }
                    else
                    {
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    }

                    buscar.Add(aux);
                }

                return buscar;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }

        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex; // Devolvés la excepción al que llame el método
            }
            finally
            {
                datos.cerrarConexion();
            }
        }



    }




}

