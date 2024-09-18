using System.ComponentModel.DataAnnotations;

namespace Ejemplo3
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        /* Versi�n A
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

        //Versi�n B
        private void btnCifrar_click(object sender, EventArgs e)
        {
            //string letras = "abcdefghijklmn�opqrstuvwxyz";

            int desp = Convert.ToInt32(txtShift.Text);
            string texto = txtInput.Text;
            string resultado = "";

            bool _error = false;

            foreach (char c in texto) {
                if (!Char.IsLetter(c) && !_error)
                {
                    MessageBox.Show("Contiene caracteres no v�lidos");
                    _error = true;
                    continue;
                }

                if (!_error) continue;

                if (Char.IsUpper(c) && desp >= 90 - c)
                {
                    resultado += Convert.ToChar((char)'A' + (desp - (90 - c) - 1));
                }
                else if (Char.IsLower(c) && desp >= 122 - c)
                {
                    resultado += Convert.ToChar((char)'a' + (desp - (122 - c) - 1));
                }
                else if (c == ' ')
                {
                    resultado += ' ';
                }
                else
                {
                    resultado += (char)(c + desp);
                }
            }

            lblResult.Text = resultado;

            /*
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
            */
        }
    }
}
