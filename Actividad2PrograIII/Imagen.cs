using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2PrograIII
{
    internal class Imagen
    {
        private int _idImagen;
        private string _ImagenURL;

        public Imagen()
        {
           _idImagen = 0;
            _ImagenURL = "url";
        }

        public int IDImagen { get { return _idImagen;} set { _idImagen = value; } }
        public string ImagenURL {get { return _ImagenURL;} set { _ImagenURL = value; } }

    }
}
