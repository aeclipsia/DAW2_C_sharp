namespace Hola_Mundo
{
    public partial class FrmHola : Form
    {
        public FrmHola()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmHola_Load(object sender, EventArgs e)
        {
            lblHola.Visible = false;
        }

        private void btnDale_Click(object sender, EventArgs e)
        {
            if (lblHola.Visible == false)
            {
                lblHola.Visible = true;
            }
            else
            {
                lblHola.Visible = false;
            }
        }
    }
}
