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
    public partial class frmListadoOrdenado : Form
    {
        public frmListadoOrdenado()
        {
            InitializeComponent();
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gboConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Ordeno el vector dependiendo del campo y el modo seleccionado
            switch (cmbCampo.SelectedIndex)
            {
                case 0:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        Vectores.OrdenarCodigoAscendente();

                    }
                    else
                    {
                        Vectores.OrdenarCodigoDescendente();
                    }
                    break;
                case 1:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        Vectores.OrdenarUsuarioAscendente();

                    }
                    else
                    {
                        Vectores.OrdenarUsuarioDescendente();
                    }
                    break;
                case 2:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        Vectores.OrdenarLimiteAscendente();

                    }
                    else
                    {
                        Vectores.OrdenarLimiteDescendente();
                    }
                    break;
                case 3:
                    if (cmbModo.SelectedIndex == 0)
                    {
                        Vectores.OrdenarDeudaAscendente();
                    }
                    else
                    {
                        Vectores.OrdenarDeudaDescendente();
                    }
                    break;

            }

            // limpio el datagridview
            gboConsulta.Rows.Clear();



            // vectores ordenados, los cargo en el datagridview
            for (Int32 i = 0; i < Vectores.IND; i++)
            {
                gboConsulta.Rows.Add(Vectores.Clientes[i].Codigo, Vectores.Clientes[i].Usuario, Vectores.Clientes[i].Limite, Vectores.Clientes[i].Deuda);

            }
        }

        private void dgvConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void frmListadoOrdenado_Load(object sender, EventArgs e)
        {
            Vectores.precarga();
        }
    }
}