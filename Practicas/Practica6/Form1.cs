namespace Practica6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtAcertada.Text);
            double f = Convert.ToDouble(txtFallada.Text);
            double b = Convert.ToDouble(txtBlanco.Text);
            double res = (a * 4) - (f * 1.5) - (b * 0.5);
            double total = (a + f + b) * 4;

            MessageBox.Show("Tiene una puntuación de "+res+" puntos sobre "+total,"Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
