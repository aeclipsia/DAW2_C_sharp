namespace Ejemplo1
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                int suma = Convert.ToInt32(txt1.Text) + Convert.ToInt32(txt2.Text);
                MessageBox.Show("La suma de " + txt1.Text + " y " + txt2.Text + " es " + suma);
            }
            catch (FormatException){
                MessageBox.Show("Has introducido un dato incorrecto.");
            }
        }
    }
}
