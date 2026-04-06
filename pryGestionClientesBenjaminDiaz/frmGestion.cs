using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionClientesBenjaminDiaz
{

    public partial class frmGestion : Form
    {
        public frmGestion()
        {
            InitializeComponent();
        }

        //Registro
        private struct RegCliente
        {
            public Int32 Codigo;
            public String Usuario;
            public Decimal Deuda;
            public Decimal Limite;
        }

        //vector 
        private RegCliente[] Clientes = new RegCliente[10];

        //Indice
        private Int32 IND = 0;



        private void btnCargar_Click(object sender, EventArgs e)
        {
            //if para validar que el indice no supere la cantidad de clientes que se pueden cargar, sino muestra un mensaje de error
            if (IND < Clientes.Length)
            {
                Clientes[IND].Codigo = Convert.ToInt32(txtCodigo.Text);
                Clientes[IND].Usuario = txtUsuario.Text;
                Clientes[IND].Deuda = Convert.ToDecimal(txtDeuda.Text);
                Clientes[IND].Limite = Convert.ToDecimal(txtLimite.Text);
                IND++; //O IND+1;
                MessageBox.Show("Cliente cargado correctamente");
                //Limpio los txt para cargar otro cliente
                txtCodigo.Text = "";
                txtDeuda.Text = "";
                txtLimite.Text = "";
                txtUsuario.Text = "";

            }
            else
            {
                MessageBox.Show("No se pueden cargar mas clientes");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Decimal Total = 0; //Variable para acumular la deuda total de los clientes
            dgvClientes.Rows.Clear(); //Limpio la grilla para mostrar los clientes cargados
            for (Int32 i = 0; i < IND; i++)
            {
                //Agrego a la grilla los clientes cargados, mostrando su codigo, usuario, deuda y limite
                dgvClientes.Rows.Add("Codigo: " + Clientes[i].Codigo + " Usuario: " + Clientes[i].Usuario + " Limite " + Clientes[i].Limite + " Deuda: " + Clientes[i].Deuda);
                Total += Total + Clientes[i].Deuda; //Acumulo la deuda total de los clientes


            }
            lblTotal.Text = Total.ToString(); //Muestro la deuda total de los clientes en el label lblTotal
            lblTotal.Visible = true;  //Hago visible el label lblTotal para mostrar la deuda total de los clientes
        }

      


        private void frmGestion_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false; //Deshabilito el boton cargar al iniciar el formulario, para evitar que se carguen clientes sin completar los campos
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if(txtCodigo.Text != "" && txtUsuario.Text != "" && txtDeuda.Text != "" && txtLimite.Text != "") //Si los campos no estan vacios, habilito el boton cargar
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false; //Si alguno de los campos esta vacio, deshabilito el boton cargar
            }
        }
    }

}