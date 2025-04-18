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

        private Articulo articulo = null;
        public SeccionAgregarArtcs()
        {
            InitializeComponent();
        }

        public SeccionAgregarArtcs(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
        }

        private void btnCancelarArt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarArt_Click(object sender, EventArgs e)
        {
            //Articulo art = new Articulo();
            GestionArticulos gestion = new GestionArticulos();

            try
            {
                if (articulo == null)
                   articulo = new Articulo();
                //art.IDArticulo = int.Parse(txbIdAart.Text);
                articulo.codArticulo = txbCodigoArt.Text;
                articulo.Nombre = txbNombreARt.Text;
                articulo.Descripcion = txbDescArt.Text;
                articulo.Precio = decimal.Parse(txbPrecioArt.Text);
                articulo.Marca = new Marca();
                articulo.Marca.Id = int.Parse(txbMarcaArt.Text);
                articulo.Categoria = new Categoria();
                articulo.Categoria.Id = int.Parse(txbCatArt.Text);
                articulo.Imagen = new Imagen();
                articulo.Imagen.ImagenURL = txbImgArt.Text;

                if (articulo.IDArticulo != 0)
                {
                    gestion.ModificarArticulo(articulo);
                    MessageBox.Show("Modificado exitosamente");
                    Close();
                }
                else
                {
                    gestion.AgregarArticulos(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
                    
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void SeccionAgregarArtcs_Load(object sender, EventArgs e)
        {
            GestionArticulos art = new GestionArticulos();

            if (articulo != null) {
                txbCodigoArt.Text = articulo.codArticulo;
                txbNombreARt.Text = articulo.Nombre;
                txbDescArt.Text = articulo.Descripcion;
                txbPrecioArt.Text = articulo.Precio.ToString();
                txbMarcaArt.Text = articulo.Marca.Id.ToString();
                txbCatArt.Text = articulo.Categoria.Id.ToString();
                txbImgArt.Text = articulo.Imagen.ImagenURL;

            }

            //try
            //{
            //    cmbboxMarca.DataSource = art.listar();
            //    cmbBoxCategoria.DataSource = art.listar();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }
    }
}
