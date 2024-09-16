namespace Ejemplos
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            lblDisplay.Location = new Point(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtY.Text));
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            
            int r = Convert.ToInt32(txtR.Text);
            int g = Convert.ToInt32(txtG.Text);
            int b = Convert.ToInt32(txtB.Text);

            if (r < 0 || g < 0 || b < 0 || r > 255 || g > 255 || b > 255)
            {
                MessageBox.Show("Sólo acepta valores de 0 a 255");
            }
            else
            {
                lblDisplay.BackColor = Color.FromArgb(r, g, b);
            }
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            validarTxtBox(txtR);
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            validarTxtBox(txtG);
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            validarTxtBox(txtB);
        }

        private void validarTxtBox(TextBox textBox)
        {
            if (int.TryParse(textBox.Text, out int text))
            {
                if (text < 0 || text > 255)
                {
                    textBox.BackColor = Color.LightPink;
                }
                else textBox.BackColor = Color.White;
            }
            else textBox.BackColor = Color.LightPink;
        }
    }
}
