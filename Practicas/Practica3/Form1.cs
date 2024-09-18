namespace Practica3
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string letras = "TRWAGMVFPDXBNJZSQUHLCKE";

            string dni_input = txtDNI.Text;

            MessageBox.Show(Char.ToUpper(letras[(Convert.ToInt32(dni_input[..^1]) % 23)]).ToString());
            MessageBox.Show(Char.ToUpper(dni_input[dni_input.Length - 1]).ToString());

            if (Char.ToUpper(letras[(Convert.ToInt32(dni_input[..^1]) % 23)]).ToString() ==
                Char.ToUpper(dni_input[dni_input.Length - 1]).ToString())
            {
                MessageBox.Show("Sí");
            }
            else {
                MessageBox.Show("No");
            }

        }
    }
}
