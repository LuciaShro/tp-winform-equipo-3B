using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2PrograIII
{
    internal class Articulo
    {
        private int _idArticulo;
        private int _codArticulo;
        private string _descripcion;
        private float _precio;


        private Marca _marca;
        private Categoria _categoria;
        private Imagen _imagen;

        public Articulo() {}

        public int IDArticulo
        {
            get { return _idArticulo; }
            set { _idArticulo = value; }
        }

        public int codArticulo
        {
            get { return _codArticulo; }
            set { _codArticulo = value; }
        }

        public Marca Marca { get { return _marca; } set { _marca = value; } }

        public string Descripcion { get { return _descripcion; } set {  _descripcion = value; } }

        public  Categoria Categoria { get { return _categoria; } set { _categoria = value; } }

        public Imagen Imagen { get { return _imagen; } set { _imagen = value; } }

        public float Precio { get { return _precio; } set { _precio = value; } }



    }
}
