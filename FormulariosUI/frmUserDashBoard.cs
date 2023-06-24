using SistemaDeVendas.FormulariosUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVendas
{
    public partial class frmUserDashBoard : Form
    {
        public frmUserDashBoard()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            this.lbDateTime.Text = date.ToString();
        }

        private void frmUserDashBoard_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendas frmVendas = new frmVendas();  
            frmVendas.ShowDialog(); 
        }
    }
}
