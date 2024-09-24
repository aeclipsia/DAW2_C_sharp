namespace Practica7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radBtnSuma.Checked = true;
        }

        private void radBtnSuma_CheckedChanged(object sender, EventArgs e)
        {
            checkNull();
            suma();
        }

        private void radBtnResta_CheckedChanged(object sender, EventArgs e)
        {
            checkNull();
            resta();
        }

        private void radBtnProd_CheckedChanged(object sender, EventArgs e)
        {
            checkNull();
            producto();
        }

        private void radBtnDiv_CheckedChanged(object sender, EventArgs e)
        {
            checkNull();
            division();
        }

        private void txtFac1_TextChanged(object sender, EventArgs e)
        {
            checkNull();
            changeRes();
        }
        private void txtFac2_TextChanged(object sender, EventArgs e)
        {
            checkNull();
            changeRes();
        }

        private void checkNull()
        {
            if (String.IsNullOrEmpty(txtFac1.Text))
            {
                txtFac1.Text = "0";
            }
            if (String.IsNullOrEmpty(txtFac2.Text))
            {
                txtFac2.Text = "0";
            }
        }
        private void changeRes()
        {
            if (radBtnSuma.Checked)
            {
                suma();
            }

            if (radBtnResta.Checked)
            {
                resta();
            }

            if (radBtnProd.Checked)
            {
                producto();
            }

            if (radBtnDiv.Checked)
            {
                division();
            }
        }

        private void suma()
        {
            double fac1 = Convert.ToDouble(txtFac1.Text);
            double fac2 = Convert.ToDouble(txtFac2.Text);

            txtRes.Text = (fac1 + fac2).ToString();
        }

        private void resta()
        {
            double fac1 = Convert.ToDouble(txtFac1.Text);
            double fac2 = Convert.ToDouble(txtFac2.Text);

            txtRes.Text = (fac1 - fac2).ToString();
        }

        private void producto()
        {
            double fac1 = Convert.ToDouble(txtFac1.Text);
            double fac2 = Convert.ToDouble(txtFac2.Text);

            txtRes.Text = (fac1 * fac2).ToString();
        }

        private void division()
        {
            double fac1 = Convert.ToDouble(txtFac1.Text);
            double fac2 = Convert.ToDouble(txtFac2.Text);

            txtRes.Text = (fac1 / fac2).ToString();
        }
    }
}
