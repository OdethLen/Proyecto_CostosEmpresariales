namespace Proyecto_F._Costos_Empresariales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ObtainedData.MateriaPrima = double.Parse(txtMateriaPrima.Text);
                ObtainedData.GradoDeAvanceMP = double.Parse(txtGradoAvanceMP.Text);
                ObtainedData.VolumenProducido = double.Parse(txtVolumenProducido.Text);
                ObtainedData.ManoDeObra = double.Parse(txtManoDeObra.Text);
                ObtainedData.GradoDeAvanceMO = double.Parse(txtGradoAvanceMO.Text);
                ObtainedData.VolumenTerminado = double.Parse(TxtVolumenTerminado.Text);
                ObtainedData.CostosIndirectos = double.Parse(txtCostosIndirectos.Text);
                ObtainedData.GradoDeAvanceCI = double.Parse(txtGradoAvanceCI.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }

            MessageBox.Show("Datos Guardados Correctamente ");


        }
        private void btnC�dula2_Click(object sender, EventArgs e)
        {
            Cedula2 formCedula2 = new Cedula2();
            formCedula2.Show();
        }
        private void btnC�dula3_Click(object sender, EventArgs e)
        {
            Cedula3 formCedula3 = new Cedula3();
            formCedula3.Show();
        }

        private void btnC�dula4_Click(object sender, EventArgs e)
        {
            frmCedula4 frmCedula4 = new frmCedula4();
            frmCedula4.Show();
        }
    }
}
