using Dominio;
using Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Actividad2PrograIII
{
    public partial class SeccionMarca : Form
    {

        public SeccionMarca()
        {
            InitializeComponent();
        }

        private void SeccionMarca_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar ()
        {
            GestionMarca marca = new GestionMarca();

            try
            {
                dgvMarcas.DataSource = marca.listarMarca();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            SeccionAgregarMarca agregar = new SeccionAgregarMarca();
            agregar.ShowDialog();
            cargar();
        }


        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            GestionMarca gestionMarca = new GestionMarca();
            Marca seleccionado = new Marca();
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro quiere eliminar el dato?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    gestionMarca.EliminarMarca(seleccionado.Id);
                    cargar();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            
            SeccionAgregarMarca modificar = new SeccionAgregarMarca(seleccionado);
            modificar.ShowDialog();
            cargar();

        }
    }
}
