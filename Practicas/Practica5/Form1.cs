namespace Practica5
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEuros.Text) && !String.IsNullOrEmpty(txtPesetas.Text))
            {
                MessageBox.Show("Los dos campos no pueden estar rellenados");
            }
            else {
                if (!String.IsNullOrEmpty(txtEuros.Text))
                {
                    txtPesetas.Text = (Convert.ToDouble(txtEuros.Text) * 166386).ToString();
                }
                else
                {
                    txtEuros.Text = (Convert.ToDouble(txtPesetas.Text) / 166386).ToString();
                }
            }
        }
    }
}
