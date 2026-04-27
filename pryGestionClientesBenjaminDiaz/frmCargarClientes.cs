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
    public partial class frmCargarClientes : Form
    {
        public frmCargarClientes()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // 1. CARGAMOS LOS DATOS AL VECTOR
            // Convertimos lo que escribimos en los cuadritos a números
            Vectores.Clientes[Vectores.IND].Codigo = Convert.ToInt32(txtCodigo.Text);
            Vectores.Clientes[Vectores.IND].NombreyApellido = txtNombreyApellido.Text;
            Vectores.Clientes[Vectores.IND].Deuda = Convert.ToDecimal(txtDeuda.Text);
            Vectores.Clientes[Vectores.IND].Limite = Convert.ToDecimal(txtLimite.Text);

            // 2. SUMAMOS 1 AL INDICE PARA EL PRÓXIMO CLIENTE
            Vectores.IND = Vectores.IND + 1;

            // 3. MENSAJE Y LIMPIAR CUADRITOS
            MessageBox.Show("Cliente Guardado");

            txtCodigo.Text = "";
            txtNombreyApellido.Text = "";
            txtDeuda.Text = "";
            txtLimite.Text = "";

            // Ponemos el palito para escribir en el primer cuadro
            txtCodigo.Focus();
        }
    }
}
    

