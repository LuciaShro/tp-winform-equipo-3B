using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Gestion;

namespace Actividad2PrograIII
{
    public partial class SeccionAgregarArtcs : Form
    {
        public SeccionAgregarArtcs()
        {
            InitializeComponent();
        }

        private void btnCancelarArt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarArt_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            GestionArticulos gestion = new GestionArticulos();

            try
            {
                art.IDArticulo = int.Parse(txbIdAart.Text);
                art.codArticulo = txbCodigoArt.Text;
                art.Nombre = txbNombreARt.Text;
                art.Descripcion = txbDescArt.Text;
                art.Precio = decimal.Parse(txbPrecioArt.Text);
                art.Marca = new Marca();
                art.Marca.Id = int.Parse(txbMarcaArt.Text);
                art.Categoria = new Categoria();
                art.Categoria.Id = int.Parse(txbCatArt.Text);
                art.Imagen = new Imagen();
                art.Imagen.ImagenURL = txbImgArt.Text;

                gestion.AgregarArticulos(art);
                MessageBox.Show("Agregado exitosamente");
                Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
