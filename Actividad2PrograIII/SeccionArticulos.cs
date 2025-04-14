using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion;
using Dominio;

namespace Actividad2PrograIII
{
    
    public partial class SeccionArticulos : Form
    {
        private List<Articulo> listaArticulo;
        public SeccionArticulos()
        {
            InitializeComponent();
        }

        private void SeccionArticulos_Load(object sender, EventArgs e)
        {
            GestionArticulos gestion = new GestionArticulos();
            listaArticulo = gestion.listar(); //DataSourse -> grilla de datos
            dgvArticulos.DataSource = listaArticulo;
            //dgvArticulos.Columns["ImagenUrl"].Visible = false; // Ver por que no funciona
            cargarImagen(listaArticulo[0].Imagen.ImagenURL);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen.ImagenURL);
        }

        private void cargarImagen (string imagen)
        {
            try
            {
                pictureBoxArt.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxArt.Load("https://media.istockphoto.com/id/1415203156/es/vector/p%C3%A1gina-de-error-icono-vectorial-de-p%C3%A1gina-no-encontrada-en-el-dise%C3%B1o-de-estilo-de-l%C3%ADnea.jpg?s=612x612&w=0&k=20&c=nss_aWPtTb0hpc4oiGfFs_PGfihrNwVX06wxkWVkBfQ=");
            }
        }
    }
}
