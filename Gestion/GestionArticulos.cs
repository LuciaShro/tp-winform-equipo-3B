using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Gestion
{
    public class GestionArticulos
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
             
                datos.setearConsulta("SELECT a.Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio, ImagenUrl from ARTICULOS A, IMAGENES I where a.Id = i.IdArticulo");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo(); //Lo empezamos a cargar con los datos del lector de ese registro
                    //aux.IDArticulo = lector.GetInt32(0); 
                    aux.IDArticulo = (int)datos.Lector["Id"]; //Lo mismo que la linea de arriba
                    aux.codArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Imagen = new Imagen();
                    aux.Imagen.ImagenURL = (string)datos.Lector["ImagenUrl"];

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

        public void AgregarArticulos(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +"VALUES ('" + articulo.codArticulo + "','" + articulo.Nombre + "','" + articulo.Descripcion + "'," + articulo.Marca.Id + "," + articulo.Categoria.Id + "," + articulo.Precio + ")");
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

    }
}

//Modificar articulos
//public bool ModificarArticulo(int codArticulo)
//{
//}

//Eliminar articulos
//public bool EliminarArticulo(int codArticulo) 
//{ 
//}

//Buscar articulos
//public Articulo BuscarArticulo(int codArticulo)
//{
//}

//Listar articulo
//public void ListarArticulos()
//{
//}