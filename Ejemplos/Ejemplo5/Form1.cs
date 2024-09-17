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
    }
}
