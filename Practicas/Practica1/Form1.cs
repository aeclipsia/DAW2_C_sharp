namespace Practica1
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            txtResultado.Text=(Convert.ToDouble(txtHoras.Text)*Convert.ToDouble(txtSalario.Text)).ToString();
        }
    }
}
