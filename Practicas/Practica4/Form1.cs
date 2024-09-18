namespace Practica4
{
    public partial class frm1 : Form
    {

        public frm1()
        {
            InitializeComponent();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(txtInput.Text);

            txtOutput.Text = ((input * 9) / 5 + 32).ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(txtInput.Text);

            txtOutput.Text = ((input - 32) * 9 / 5).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
