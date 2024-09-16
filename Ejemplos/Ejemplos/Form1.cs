namespace Ejemplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            lblDisplay.Location = new Point(Convert.ToInt32(txtX), Convert.ToInt32(txtY));
        }
    }
}
