using System.Collections.Generic;
using Practica2.Modelos;
using Practica2.Exceptions;

namespace EjemploColecciones
{
    public partial class frmBase : Form
    {
        private List<Pais> l_Paises = new List<Pais>();
        private int posicion;
        public frmBase()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkNull();

            l_Paises.Add(new Pais(txtPais.Text, txtSaludo.Text));
            lstPaises.Items.Add(txtPais.Text);
        }

        private void checkNull()
        {
            try
            {

                if (String.IsNullOrEmpty(txtPais.Text) || String.IsNullOrEmpty(txtSaludo.Text))
                {
                    throw new NullCampoException("Campo Vacio");
                }
            }
            catch (NullCampoException ex) {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void lstPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPaises.SelectedIndex == -1) return;
            //Versión larga
            posicion = buscarPais(lstPaises.Text);

            txtPais.Text = l_Paises[posicion].Nombre;
            txtSaludo.Text = l_Paises[posicion].Saludo;


            /*
            //Versión corta
            int posicion = lstPaises.SelectedIndex;
            txtPais.Text = l_Paises[posicion].Nombre;
            txtSaludo.Text = l_Paises[posicion].Saludo;
            */
        }

        private int buscarPais(string nombre)
        {
            Pais p = new Pais(lstPaises.Text);
            return l_Paises.IndexOf(p);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            l_Paises.RemoveAt(posicion);
            lstPaises.Items.RemoveAt(posicion);
            txtPais.Clear();
            txtSaludo.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            l_Paises[posicion].Saludo = txtSaludo.Text;
            
            l_Paises[posicion].Nombre = txtPais.Text;
            lstPaises.Items[posicion] = txtPais.Text;

            MessageBox.Show("Success!", "Practica 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
