namespace Arrays_Funciones
{
    public partial class Form1 : Form
    {
        int[] numeros = new int[5];

        int pos = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            numeros[pos] = Convert.ToInt32(txtInput.Text);
            pos++;

            txtInput.Text = null;
            txtInput.Focus();

            if (pos == 5)
            {
                grpDatos.Enabled = false;
                grpRes.Enabled = true;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

            show_Cuads();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            clean_Cajas(grpRes);
            grpDatos.Enabled = true;
            grpRes.Enabled = false;

            Array.Clear(numeros, 0, numeros.Length);
            pos = 0;
        }

        private void clean_Cajas(GroupBox grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c.GetType().Name == "Label")
                {
                    c.Text = "";
                }
            }
        }

        private void btnCuad_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (int n in numeros)
            {
                numeros[i] = n * n;
                i++;
            }

            show_Cuads();
        }

        private void show_Cuads()
        {
            int i = numeros.Length - 1;
            foreach (Control c in grpRes.Controls)
            {
                if (c.GetType().Name == "Label")
                {
                    c.Text = numeros[i].ToString();
                    i--;
                }
            }
        }
    }
}
