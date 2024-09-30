using Quesos;

namespace Practica3
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        public void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmAlta f2 = new frmAlta();
            f2.ShowDialog();
        }

        public void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
