using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Actividad2PrograIII
{
    internal class GestionCategoria
    {

        //Agregar Categoria
        /*public void AgregarCategoria(Categoria categoria)
        {
        } */

        //Modificar Categoria
        //public bool ModificarCategoria(Categoria categoria)
        //{
        //}

        //Eliminar Categoria
        //public bool EliminarCategoria(int IdCategoria) 
        //{ 
        //}

        //Buscar Categoria
        //public Categoria BuscarCategoria(int IdCategoria)
        //{
        //}

        //Listar categoria
        //public void ListarCategoria()
        //{
        //}

        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader lector;

        public List<Categoria> listarCategoria()
        {
            List<Categoria> lista = new List<Categoria>();

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Descripcion from CATEGORIAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)lector["Id"];
                    aux.Nombre = (string)lector["Descripcion"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la tabla Categoria");
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
