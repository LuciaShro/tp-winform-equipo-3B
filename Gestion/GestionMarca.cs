﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Gestion
{
    public class GestionMarca
    {



        //Modificar marca
        //public bool ModificarMarca(Marca marca)
        //{
        //}

        //Eliminar marca
        //public bool EliminarMarca(int IdMarca) 
        //{ 
        //}

        //Buscar marca
        //public Marca BuscarMarca(int IdMarca)
        //{
        //}

        //Listar marca
        public List<Marca> listarMarca()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];


                    // forma de realizar validacion null
                    /*
                    if(!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Descripcion"))))
                    aux.Nombre = (string)datos.Lector["Descripcion"]; 
                    */
                    if (!(datos.Lector["Descripcion"] is DBNull))
                      aux.Nombre = (string)datos.Lector["Descripcion"];


                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally { 
                datos.cerrarConexion();
            }
        }

        public void Agregar(Marca marca) {

            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta("Insert into MARCAS (Descripcion) values ('" + marca.Nombre + "')");
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        
        }
    }
}
