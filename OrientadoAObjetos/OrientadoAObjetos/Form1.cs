using OrientadoAObjetos.Modelos;

namespace OrientadoAObjetos

{
    public partial class Form1 : Form
    {
        Alumno[] listaClase;
        int numAlumnos;

        public Form1()
        {
            InitializeComponent();
            listaClase = new Alumno[5];
            numAlumnos = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string tel = txtTel.Text;

            if (txtNombre.Text == "" ||
                txtDNI.Text == "" ||
                txtTel.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (chkErasmus.Checked)
                {



                    try
                    {
                        listaClase[numAlumnos] = new Erasmus(txtDNI.Text, txtNombre.Text, txtTel.Text, txtPais.Text);
                        numAlumnos++;
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        MessageBox.Show("Clase Completa", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        btnAdd.Enabled = false;
                    }
                }
                else
                {
                    try
                    {
                        listaClase[numAlumnos] = new Alumno(txtDNI.Text, txtNombre.Text, txtTel.Text);
                        numAlumnos++;
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        MessageBox.Show("Clase Completa", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        btnAdd.Enabled = false;
                    }
                }
                cleanCajas(grpDatos);
                txtNombre.Focus();
            }
        }

        public void cleanCajas(GroupBox g)
        {
            foreach (Control c in g.Controls)
            {
                if (c.GetType().Name == "TextBox")
                {
                    c.Text = "";
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTel.Text))
            {
                Alumno a = buscarAlumno(txtDNI.Text);

                a.Telefono = txtTel.Text;


                btnBuscar.Text = "Buscar";
                cleanCajas(grpDatos);
                btnAdd.Enabled = true;
                txtNombre.Enabled = true;
                txtDNI.Enabled = true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //BORRAR MEDIANTE DNI
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtDNI.Enabled = false;
            btnAdd.Enabled = false;
            txtPais.Enabled = false;

            if (btnBuscar.Text == "Buscar")
            {
                if (!String.IsNullOrEmpty(txtDNI.Text))
                {
                    Alumno a = buscarAlumno(txtDNI.Text);

                    if (a == null)
                    {
                        MessageBox.Show("Alumno no encontrado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtNombre.Text = a.Nombre;
                        txtTel.Text = a.Telefono;
                        btnBuscar.Text = "Cancelar";

                        if (a.GetType().Name=="Erasmus")
                        {
                            Erasmus b = (Erasmus)a;
                            txtPais.Text = b.Pais;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Campo de DNI vacío", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                cleanCajas(grpDatos);
                btnBuscar.Text = "Buscar";
                txtNombre.Enabled = true;
                txtDNI.Enabled = true;
                txtPais.Enabled = true;
            }
        }

        private Alumno buscarAlumno(string dni)
        {
            foreach (Alumno a in listaClase)
            {
                try
                {
                    if (a.DNI == dni)
                    {
                        return a;
                    }
                }
                catch (System.NullReferenceException)
                {
                    return null;
                }
            }
            return null;
        }

        private void chkErasmus_CheckedChanged(object sender, EventArgs e)
        {
            txtPais.Enabled = chkErasmus.Checked;
        }

        //Añadir erasmus con textbox Pais
    }
}
