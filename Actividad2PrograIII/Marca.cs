using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2PrograIII
{
    internal class Marca
    {
        private int _id;
        private string _nombre;
        public Marca() { }
        
        public int Id 
        { 
            get 
            { 
                return _id; 
            } 
            set 
            { 
                if(_id > 0) _id = value; 
            } 
        }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
    }
}
