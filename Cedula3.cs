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
    public partial class Cedula3 : Form
    {
        public Cedula3()
        {
            InitializeComponent();
            this.Load += new EventHandler(Cedula3_Load);
        }


        private void Cedula3_Load(object sender, EventArgs e)
        {
            CalcularCostos();
        }

        private void CalcularCostos()
        {

            double volIF = ObtainedData.VolumenProducido - ObtainedData.VolumenTerminado;
            double grdAMP = ObtainedData.GradoDeAvanceMP;
            double grdAMO = ObtainedData.GradoDeAvanceMO;
            double grdACI = ObtainedData.GradoDeAvanceCI;

            double costoUMP = ObtainedData.MateriaPrima / ObtainedData.VolumenProducido;
            double costoUMO = ObtainedData.ManoDeObra / ObtainedData.VolumenProducido;
            double costoUCI = ObtainedData.CostosIndirectos / ObtainedData.VolumenProducido;

            double costoTMP = volIF * costoUMP * grdAMP;
            double costoTMO = volIF * costoUMO * grdAMO;
            double costoTCI = volIF * costoUCI * grdACI;
            double costoIF = costoTMP + costoTMO + costoTCI;


            txtCostoTMP.Text = costoTMP.ToString("N2");
            txtCostoTMO.Text = costoTMO.ToString("N2");
            txtCostoTCI.Text = costoTCI.ToString("N2");
            txtCostoTIF.Text = costoIF.ToString("N2");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double invFinal = Convert.ToDouble(txtCostoTIF.Text);
                ObtainedData.TotalInvFinal = invFinal;

                this.Close();

            }



            catch
            {
                MessageBox.Show("Error Con el Inventario Final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 formP = (Form1)Application.OpenForms["Form1"];
            formP.Show();
            this.Close();
        }
    }
}


