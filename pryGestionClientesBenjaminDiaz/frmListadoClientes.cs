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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Listar(object sender, EventArgs e)
        {
            Decimal Total = 0; //Variable para acumular la deuda total de los clientes
            dgvDatos.Rows.Clear(); //Limpio la grilla para mostrar los clientes cargados
            for (Int32 i = 0; i < Vectores.IND; i++)
            {
                //Agrego a la grilla los clientes cargados, mostrando su codigo, usuario, deuda y limite
                dgvDatos.Rows.Add(Vectores.Clientes[i].Codigo, Vectores.Clientes[i].Usuario ,Vectores.Clientes[i].Limite , Vectores.Clientes[i].Deuda);
                Total += Total + Vectores.Clientes[i].Deuda; //Acumulo la deuda total de los clientes


            }
            label1.Text = Total.ToString(); //Muestro la deuda total de los clientes en el label lblTotal
            label1.Visible = true;  //Hago visible el label lblTotal para mostrar la deuda total de los clientes
            MessageBox.Show("Clientes listados correctamente");
        }
        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
           Vectores.precarga(); //Llamo al metodo precarga para cargar los clientes predefinidos en el vector Clientes
           Listar(sender, e); //Llamo al metodo Listar para mostrar los clientes cargados en la grilla y la deuda total de los clientes en el label lblTotal
        }
    }
}
