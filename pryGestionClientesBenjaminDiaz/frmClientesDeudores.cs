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
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }
        private void Listar(object sender, EventArgs e)
        {
            // Inicializo el total y el contador de deudores
            Decimal Total = 0;
            Int32 cantDeudores = 0; 
            dgvDatos.Rows.Clear();

            
            for (Int32 i = 0; i < Vectores.IND; i++)
            {
                if (Vectores.Clientes[i].Deuda > 0)
                {
                    dgvDatos.Rows.Add(
                        Vectores.Clientes[i].Codigo,
                        Vectores.Clientes[i].Usuario,
                        Vectores.Clientes[i].Limite,
                        Vectores.Clientes[i].Deuda
                    );
                    Total += Vectores.Clientes[i].Deuda;
                    cantDeudores++; 
                }
            }

            label1.Text = Total.ToString();
            label1.Visible = true;

            label2.Text = cantDeudores.ToString(); // ← usás el contador
            label2.Visible = true;

           
            if (cantDeudores > 0)
            {
                Decimal Promedio = Total / cantDeudores;
                label3.Text = Promedio.ToString();
            }
        }
        
        private void frmClientesDeudores_Load(object sender, EventArgs e)
        {
           
            Listar(sender, e);
        }


    }

       
}


