using Practica3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quesos
{
    public partial class frmAlta : Form
    {
        public frmAlta()
        {
            InitializeComponent();
        }

        public void btnAcc_Click(object sender, EventArgs e)
        {
            this.Hide();

            frm1 fr1 = new frm1();
            fr1.ShowDialog();
        }
    }
}
