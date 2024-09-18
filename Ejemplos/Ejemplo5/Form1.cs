namespace Ejemplo5
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Parse(txtInput.Text).DayOfWeek.ToString());
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtInput.Text)) {

                if (String.IsNullOrEmpty(txtPlus.Text)) {
                    MessageBox.Show("Anota el número de incremento");
                }

                DateTime fecha = DateTime.Parse(txtInput.Text);
                DateTime result = DateTime.MinValue;
                if (radDay.Checked)
                {
                    result = fecha.AddDays(Convert.ToDouble(txtPlus.Text));
                }
                else if (radMos.Checked)
                {
                    result = fecha.AddMonths(Convert.ToInt32(txtPlus.Text));
                }
                else if (radYear.Checked)
                {
                    result = fecha.AddYears(Convert.ToInt32(txtPlus.Text));
                }
                MessageBox.Show(result.ToString());
            }
            else
            {
                MessageBox.Show("Anota una fecha");
            }
        }
    }
}
