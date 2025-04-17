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
    public partial class SeccionAgregarCategoria : Form
    {
        public SeccionAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            GestionCategoria gestionCat = new GestionCategoria();
            try
            {
                cat.Nombre = txtAgregarCategoria.Text;

                gestionCat.agregarCategoria(cat);
                MessageBox.Show("Agregado Exitosamente");
                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
