namespace Practica2
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int wins = Convert.ToInt32(txtW.Text);
            int ties = Convert.ToInt32(txtT.Text);
            int losses = Convert.ToInt32(txtL.Text);

            if (wins + ties + losses == 5) {
                MessageBox.Show("Tienes " + ((wins * 3) + (ties * 1) + (losses * 0)).ToString() + " puntos.");
            }
            else
            {
                MessageBox.Show("mierda");
            }

        }
    }
}
