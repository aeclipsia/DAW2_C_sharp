namespace EjemplosTiposDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int edad = Convert.ToInt32(txtEdad.Text);
            string nombre = txtNombre.Text;
            string dni = txtDni.Text;
            //comprobar que la última posición del DNI es una letra

            string mensaje;
            /*if (edad < 18)
            {
                mensaje = "eres menor de edad";
            }
            else
                mensaje = "eres mayor de edad";
            */

            if (char.IsLetter(dni.Substring(dni.Length - 1, 1)[0]))
            {
                mensaje = "es una letra";
            }
            else
            {
                mensaje = "no es una letra";
            }

            lblResultado.Text = mensaje;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in grpDatos.Controls)
            {
                if (c.GetType().Name == "TextBox")
                {
                    c.ForeColor = Color.Red;
                }
            }
        }
    }
}
