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
    public partial class SeccionCategorias : Form
    {
        public SeccionCategorias()
        {
            InitializeComponent();
        }

        private void SeccionCategorias_Load(object sender, EventArgs e)
        {
            cargar();

            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");

        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            SeccionAgregarCategoria agregarCat = new SeccionAgregarCategoria();
            agregarCat.ShowDialog();
            cargar();
        }

        private void cargar()
        {
            GestionCategoria categoria = new GestionCategoria();
            dgvCategorias.DataSource = categoria.listarCategoria();
            dgvCategorias.Columns["Id"].Visible = false;
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            Categoria seleccionada;
            seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            SeccionAgregarCategoria editarCat = new SeccionAgregarCategoria(seleccionada);
            editarCat.ShowDialog();
            cargar();
        }

        private void btnEliminarCategoriaFisico_Click(object sender, EventArgs e)
        {

            GestionCategoria categoria = new GestionCategoria();
            Categoria seleccionado;


            try
            {
                DialogResult resultado = MessageBox.Show("¿Estas seguro que queres eliminar esta categoría?", "Eliminado", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    categoria.eliminarCategoria(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
