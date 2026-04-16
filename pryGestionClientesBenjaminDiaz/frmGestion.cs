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

        


        private void btnCargar_Click(object sender, EventArgs e)
        {
            //if para validar que el indice no supere la cantidad de clientes que se pueden cargar, sino muestra un mensaje de error
            if (Vectores.IND < Vectores.Clientes.Length)
            {
                Int32 i = 0; 
                while (Vectores.Clientes[Vectores.IND].Codigo != Convert.ToInt32(txtCodigo.Text) &&  i < Vectores.IND)
                {
                    i++;
                }
                
                if(i==Vectores.IND)
                {

                    Vectores.Clientes[Vectores.IND].Codigo = Convert.ToInt32(txtCodigo.Text);
                    Vectores.Clientes[Vectores.IND].Usuario = txtUsuario.Text;
                    Vectores.Clientes[Vectores.IND].Deuda = Convert.ToDecimal(txtDeuda.Text);
                    Vectores.Clientes[Vectores.IND].Limite = Convert.ToDecimal(txtLimite.Text);
                    Vectores.IND++; //O IND+1;
                           //Limpio los txt para cargar otro cliente
                    txtCodigo.Text = "";
                    txtDeuda.Text = "";
                    txtLimite.Text = "";
                    txtUsuario.Text = "";
                    MessageBox.Show("Cliente cargado correctamente");

                }
                else
                {
                    MessageBox.Show("El codigo ingresado ya existe, ingrese otro codigo");
                }

            }
            else
            {
                MessageBox.Show("No se pueden cargar mas clientes");
            }
        }

        private void Listar(object sender, EventArgs e)
        {
            Decimal Total = 0; //Variable para acumular la deuda total de los clientes
            dgvClientes.Rows.Clear(); //Limpio la grilla para mostrar los clientes cargados
            for (Int32 i = 0; i < Vectores.IND; i++)
            {
                //Agrego a la grilla los clientes cargados, mostrando su codigo, usuario, deuda y limite
                dgvClientes.Rows.Add("Codigo: " + Vectores.Clientes[i].Codigo + " Usuario: " + Vectores.Clientes[i].Usuario + " Limite " + Vectores.Clientes[i].Limite + " Deuda: " + Vectores.Clientes[i].Deuda);
                Total += Total + Vectores.Clientes[i].Deuda; //Acumulo la deuda total de los clientes


            }
            lblTotal.Text = Total.ToString(); //Muestro la deuda total de los clientes en el label lblTotal
            lblTotal.Visible = true;  //Hago visible el label lblTotal para mostrar la deuda total de los clientes
            MessageBox.Show("Clientes listados correctamente");
        }




        private void frmGestion_Load(object sender, EventArgs e)
        {
            
            Vectores.precarga(); //Llamo a la funcion precarga para cargar algunos clientes de ejemplo al iniciar el formulario
            Listar(); //Llamo a la funcion btnListar para mostrar los clientes cargados en la grilla al iniciar el formulario
        }

        private void Listar()
        {
            
        }

        private void comprobar()
        {
            if (txtCodigo.Text != "" && txtUsuario.Text != "" && txtDeuda.Text != "" && txtLimite.Text != "") //Si los campos no estan vacios, habilito el boton cargar
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false; //Si alguno de los campos esta vacio, deshabilito el boton cargar
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void precarga()
        {
            Vectores.Clientes[Vectores.IND].Codigo = 10;
            Vectores.Clientes[Vectores.IND].Usuario = "Benjamin Diaz";
            Vectores.Clientes[Vectores.IND].Deuda = 1000;
            Vectores.Clientes[Vectores.IND].Limite = 10000;
            Vectores.IND++; //Actualizo el indice para que se puedan cargar mas clientes despues de la precarga
            Vectores.Clientes[Vectores.IND].Codigo = 20;
            Vectores.Clientes[Vectores.IND].Usuario = "Maria Gomez";
            Vectores.Clientes[Vectores.IND].Deuda = 0;
            Vectores.Clientes[Vectores.IND].Limite = 20000;
            Vectores.IND++; //Actualizo el indice para que se puedan cargar mas clientes despues de la precarga
            Vectores.Clientes[Vectores.IND].Codigo = 30;
            Vectores.Clientes[Vectores.IND].Usuario = "Juan Perez";
            Vectores.Clientes[Vectores.IND].Deuda = 3000;
            Vectores.Clientes[Vectores.IND].Limite = 30000;
            Vectores.IND++; //Actualizo el indice para que se puedan cargar mas clientes despues de la precarga
        }

        private void btnDeudores_Click(object sender, EventArgs e)
        {

            Decimal Total = 0; //Variable para acumular la deuda total de los clientes
            dgvClientes.Rows.Clear(); //Limpio la grilla para mostrar los clientes cargados
            for (Int32 i = 0; i < Vectores.IND; i++)
            {
                if (Vectores.Clientes[i].Deuda > 0)
                {
                    dgvClientes.Rows.Add("Codigo: " + Vectores.Clientes[i].Codigo + " Usuario: " + Vectores.Clientes[i].Usuario + " Limite " + Vectores.Clientes[i].Limite + " Deuda: " + Vectores.Clientes[i].Deuda);
                    Total += Total + Vectores.Clientes[i].Deuda; //Acumulo la deuda total de los clientes

                }   
            }
            lblTotal.Text = Total.ToString(); //Muestro la deuda total de los clientes en el label lblTotal
            lblTotal.Visible = true;  
            MessageBox.Show("Clientes deudores listados correctamente");
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void txtLimite_TextChanged(object sender, EventArgs e)
        {
            comprobar();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }   }