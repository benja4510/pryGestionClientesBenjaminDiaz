using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            Decimal Total = 0;
            dgvDatos.Rows.Clear();

            for (Int32 i = 0; i < Vectores.IND; i++)
            {
                dgvDatos.Rows.Add(
                    Vectores.Clientes[i].Codigo,
                    Vectores.Clientes[i].Usuario,
                    Vectores.Clientes[i].Limite,
                    Vectores.Clientes[i].Deuda
                );
                Total += Vectores.Clientes[i].Deuda; 
            }

            label1.Text = Total.ToString();
            label1.Visible = true;

            label2.Text = Vectores.IND.ToString(); 
            label2.Visible = true;

            if (Vectores.IND > 0)
            {
                Decimal Promedio = Total / Vectores.IND;
                label3.Text = Promedio.ToString();
            }
        }
        
       
        private void frmClientesDeudores_Load(object sender, EventArgs e)
        {
            
            Listar(sender, e);
        }

    }
}
