using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2PrograIII
{
    internal class Categoria
    {
        private int _id;
        private string _nombre;

        public Categoria()
        {
            _id = 0;
            _nombre = "categoria";
        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
    }
} 
