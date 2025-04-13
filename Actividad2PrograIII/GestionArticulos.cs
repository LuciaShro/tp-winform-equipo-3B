using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2PrograIII
{
    internal class GestionArticulos
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;

        //Agregar articulos
        /*public void AgregarArticulos (Articulo articulo)
        {
        }*/

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

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio from ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader(); //tabla 

                while (lector.Read())
                {
                    Articulo aux = new Articulo(); //Lo empezamos a cargar con los datos del lector de ese registro
                    //aux.IDArticulo = lector.GetInt32(0); 
                    aux.IDArticulo = (int)lector["Id"]; //Lo mismo que la linea de arriba
                    aux.codArticulo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca.Id = (int)lector["IdMarca"];
                    aux.Categoria.Id = (int)lector["IdCategoria"];
                    aux.Precio = (decimal)lector["Precio"];

                    lista.Add(aux);
                } 
               
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw;
            } 
            finally
            {
                conexion.Close();
            }
         
        }


    }
}
