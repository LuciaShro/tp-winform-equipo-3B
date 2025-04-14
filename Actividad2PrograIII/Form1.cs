using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2PrograIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            
            foreach(var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(SeccionArticulos))
                    return;
            }
            
            SeccionArticulos ventana = new SeccionArticulos();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(SeccionCategorias)) 
                return;
            }

            SeccionCategorias ventana = new SeccionCategorias();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
