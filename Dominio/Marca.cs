using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
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


        //Ver por que no funciona

        //public override string ToString()
        //{
        //    return Nombre;
        //}
    }
}
