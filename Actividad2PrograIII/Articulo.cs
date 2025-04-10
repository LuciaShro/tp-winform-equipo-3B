using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2PrograIII
{
    internal class Articulo
    {
        private int _codArticulo;
        private string _descripcion;
        private float _precio;
        //imagen?

        private Marca _marca;
        private Categoria _categoria;

        public Articulo() {}

        public int codArticulo
        {
            get { return _codArticulo; }
            set { _codArticulo = value; }
        }

        public Marca Marca { get { return Marca; } set { _marca = value; } }

        public string DescripciOn { get { return _descripcion; } set {  _descripcion = value; } }

        public  Categoria Categoria { get { return _categoria; } set { _categoria = value; } }

        public float Precio { get { return _precio; } set { _precio = value; } }


    }
}
