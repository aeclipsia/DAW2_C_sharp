using Ej1.Modules;

namespace Practica2
{
    public partial class frmMain : Form
    {

        Persona[] personas = new Persona[5];
        int index = 0;
        int viewIndex = 0;
        char letraDNI;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            addPages();

            //Check de condiciones
            //Cajas vacías
            if (checkNull())
            {
                MessageBox.Show("Todas las cajas son obligatorias");
                return;
            }
            //Edad correcta
            if (Convert.ToInt32(txtEdad.Text) > 70 || Convert.ToInt32(txtEdad.Text) <= 0)
            {
                MessageBox.Show("Edad tiene que ser positivo y menor que 70");
                return;
            }
            //DNI válido
            if (!validateDNI())
            {
                MessageBox.Show("DNI no válido");
            }

            string DNICombinado = txtDNI.Text[..^1] + letraDNI;

            personas[index] = new Persona(txtNombre.Text, txtApellidos.Text, Convert.ToInt32(txtEdad.Text), DNICombinado);
            index++;

        }

        public void addPages()
        {
            txtProg.Text = (viewIndex+1) + "/" + (index+1);
        }

        public bool checkNull()
        {
            foreach (TextBox item in this.Controls.OfType<TextBox>())
            {
                if (String.IsNullOrEmpty(item.Text) && item.Name != "txtProg") return true;
            }

            return false;
        }

        public bool validateDNI()
        {
            string DNI = txtDNI.Text;

            if (DNI.Length != 9) return false;

            letraDNI = Char.ToUpper(DNI[^1]);

            if (letraDNI < 65 || letraDNI > 90) return false;
            try
            {
                Convert.ToInt32(DNI[..^1]);
                return true;
            }
            catch (FormatException e)
            {
                return false;
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {

            if (btnView.Text == "Visualizar")
                viewIndex = 0;

            btnView.Text = "Siguiente";
            txtNombre.Text = personas[viewIndex].Nombre;
            txtApellidos.Text = personas[viewIndex].Apellido;
            txtEdad.Text = personas[viewIndex].Edad.ToString();
            txtDNI.Text = personas[viewIndex].Dni;

            movePages();

            viewIndex++;

            if (viewIndex == index) btnView.Text = "Visualizar";

        }

        private void movePages()
        {
            txtProg.Text = viewIndex + 1 + "/" + index;
        }
    }
}
