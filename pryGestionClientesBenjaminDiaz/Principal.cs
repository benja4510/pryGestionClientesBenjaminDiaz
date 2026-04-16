using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionClientesBenjaminDiaz
{
    public partial class frmManejoClientes : Form
    {
        public frmManejoClientes()
        {
            InitializeComponent();
        }

        private void listadoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmManejoClientes();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void frmManejoClientes_Load(object sender, EventArgs e)
        {
           Vectores.precarga(); //Llamo al metodo precarga para cargar los clientes predefinidos en el vector Clientes
            
        }

        private void listadoDeClientesOrdenadosPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmListadoOrdenado();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
