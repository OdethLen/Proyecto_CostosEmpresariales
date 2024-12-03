using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_F._Costos_Empresariales
{
    public partial class frmCedula4 : Form
    {
        public frmCedula4()
        {
            InitializeComponent();
        }

        private void btnGranTotal_Click(object sender, EventArgs e)
        {

            try
            {
                double CostoProduccionTerminada;
                double CostoInventarioFinal;
                double GranTotal;

                CostoProduccionTerminada = ObtainedData.TotalProduccionTerminada;
                CostoInventarioFinal = ObtainedData.TotalProduccionTerminada;

                txtProduccionTerminada.Text = Convert.ToString(CostoProduccionTerminada);
                txtCostoInvertarioFinal.Text = Convert.ToString(CostoInventarioFinal);

                GranTotal = CostoProduccionTerminada + CostoInventarioFinal;

                txtGranTotal.Text = Convert.ToString(GranTotal);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            frmCedula4 frmCedula = new frmCedula4();
            this.Close();
        }
    }
}
