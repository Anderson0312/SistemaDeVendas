using Sistema_Vendas.DALDados;
using SistemaDeVendas.DALDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVendas.FormulariosUI
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        categoriaDAL categoriaDAL = new categoriaDAL();
        produtoDAL produtoDAL = new produtoDAL();
        private void frmInventario_Load(object sender, EventArgs e)
        {
            DataTable catdt = categoriaDAL.Select();
            cmbSearchCateg.DataSource = catdt;

            cmbSearchCateg.DisplayMember = "title";
            cmbSearchCateg.ValueMember = "title";

            DataTable pdt = produtoDAL.Select();
            dvgInventario.DataSource = pdt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSearchCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeCat = cmbSearchCateg.Text;
            DataTable dt = produtoDAL.ShowProductForCat(nomeCat);

            dvgInventario.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = produtoDAL.Select();
            dvgInventario.DataSource = dt;
        }
    }
}
