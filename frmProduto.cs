using SistemaDeVendas.BLLClasses;
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

namespace SistemaDeVendas
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        produtoBLL prodBLL = new produtoBLL();
        produtoDAL prodDAL = new produtoDAL();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            prodBLL.name = txtNomeProd.Text;
            prodBLL.category = Convert.ToInt32(txtCatProd.Text);
            prodBLL.description = txtDescProd.Text;
            prodBLL.rate = Convert.ToDouble(txtPrecoProd.Text);
            prodBLL.gty = Convert.ToInt32(txtQuanti.Text);
            prodBLL.added_date = DateTime.Now;
            prodBLL.added_by = 1;

            if (prodBLL.name == "" || prodBLL.description == "")
            {
                MessageBox.Show("Digite os Dados Para Inserir o Produto");
            }
            else
            {
                bool success = prodDAL.Insert(prodBLL);
                if (success)
                {
                    MessageBox.Show("Produto Cadastrado Com Sucesso!");
                    limparform();
                }
                else
                {
                    MessageBox.Show("Não Foi Possível Cadastrar a Produto");
                }
            }
            DataTable dt = prodDAL.Select();
            dtgView.DataSource = dt;
        }

        private void limparform()
        {
            txtNomeProd.Text = "";
            txtCatProd.Text = "";
            txtDescProd.Text = "";
            txtPrecoProd.Text = "";
            txtQuanti.Text = "";
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            DataTable dt = prodDAL.Select();
            dtgView.DataSource = dt;
            dtgView.Columns[0].HeaderText = "ID_Produto";
            dtgView.Columns[1].HeaderText = "Nome";
            dtgView.Columns[2].HeaderText = "Categoria";
            dtgView.Columns[3].HeaderText = "Descrição";
            dtgView.Columns[4].HeaderText = "rate";
            dtgView.Columns[5].HeaderText = "qty";
            dtgView.Columns[6].HeaderText = "added_date";
            dtgView.Columns[7].HeaderText = "added_by";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparform();
        }
    }
}
