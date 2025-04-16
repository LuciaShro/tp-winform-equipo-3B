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
    public partial class SeccionAgregarMarca : Form
    {
        public SeccionAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            Marca nuevamarca = new Marca();
            GestionMarca marca = new GestionMarca();
            try
            {
                nuevamarca.Nombre=txtDescripcionMarca.Text;

                marca.Agregar(nuevamarca);
                MessageBox.Show("Nueva marca agregada exitosamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
