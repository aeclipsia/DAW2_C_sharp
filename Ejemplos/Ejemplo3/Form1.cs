using System.ComponentModel.DataAnnotations;

namespace Ejemplo3
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        /* Versión A
        private void btnCifrar_Click(object sender, EventArgs e)
        {
            int desp = Convert.ToInt32(txtShift.Text);
            string texto = txtInput.Text;

            char[] textoSeparado = texto.ToCharArray();
            string resultado = "";
            
            foreach (char c in textoSeparado)
            {
                char res = (char)(c + desp);
                resultado += res;
            }
            lblResult.Text = resultado;
        }
        */

        //Versión B
        private void btnCifrar_click(object sender, EventArgs e)
        {
            string letras = "abcdefghijklmnñopqrstuvwxyz";

            int desp = Convert.ToInt32(txtShift.Text);
            string texto = txtInput.Text;

            char[] textoSeparado = texto.ToCharArray();
            string resultado = "";

            foreach (char c in textoSeparado)
            {

                if (letras.IndexOf(Char.ToLower(c)) == -1)
                {
                    MessageBox.Show("Introduce letras.");
                    continue;
                }

                if (Char.IsUpper(c))
                {
                    if (letras.Length - (letras.IndexOf(Char.ToLower(c))+1) <= desp)
                        resultado += Char.ToUpper(letras[(desp - (letras.Length - letras.IndexOf(Char.ToLower(c))))]);
                    else
                        resultado += Char.ToUpper(letras[letras.IndexOf(Char.ToLower(c)) + desp]);
                }
                else 
                {
                    if (letras.Length - (letras.IndexOf(c)+1) <= desp)
                        resultado += Char.ToLower(letras[(desp - (letras.Length-letras.IndexOf(c)))]);
                    else
                        resultado += Char.ToLower(letras[letras.IndexOf(c) + desp]);
                }
            }

            lblResult.Text= resultado;
        }
    }
}
