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

        public static string transactionType;

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
            transactionType = "Venda";
            frmVendas Vendas = new frmVendas();
            Vendas.ShowDialog();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionType = "Compra";
            frmVendas Compras = new frmVendas();
            Compras.ShowDialog();

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin trocarUser = new frmLogin();
            trocarUser.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
