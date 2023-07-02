using Sistema_Vendas.BLLClasses;
using Sistema_Vendas.DALDados;
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
        userDAL userDAL = new userDAL();

        categoriaDAL categoriaDAL = new categoriaDAL();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            prodBLL.name = txtNomeProd.Text;
            prodBLL.category = txtCatProd.Text;
            prodBLL.description = txtDescProd.Text;
            prodBLL.rate = Convert.ToDouble(txtPrecoProd.Text);
            prodBLL.gty = Convert.ToInt32(txtQuanti.Text);
            prodBLL.added_date = DateTime.Now;

            //frmLogin frmLogin = new frmLogin();
            string loggedUser = frmLogin.loggedIn;
            int user = userDAL.GetIDFromUserName(loggedUser);
            prodBLL.added_by = user;

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
            txtIDProd.Text = "";
            txtNomeProd.Text = "";
            txtCatProd.Text = "";
            txtDescProd.Text = "";
            txtPrecoProd.Text = "";
            txtQuanti.Text = "";
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            DataTable categoriaDT = categoriaDAL.Select();
            txtCatProd.DataSource = categoriaDT;
            txtCatProd.DisplayMember = "title";
            txtCatProd.ValueMember = "title";

            DataTable dt = prodDAL.Select();
            dtgView.DataSource = dt;
            dtgView.Columns[0].HeaderText = "ID_Produto";
            dtgView.Columns[1].HeaderText = "Nome";
            dtgView.Columns[2].HeaderText = "Categoria";
            dtgView.Columns[3].HeaderText = "Descrição";
            dtgView.Columns[4].HeaderText = "Preço";
            dtgView.Columns[5].HeaderText = "Quantidade";
            dtgView.Columns[6].HeaderText = "Hora_data";
            dtgView.Columns[7].HeaderText = "Adicionado_Por";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparform();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //convertentdo o id para int porque vem como txt do form
            prodBLL.id = Convert.ToInt32(txtIDProd.Text);
            prodBLL.name = txtNomeProd.Text;
            prodBLL.category = txtCatProd.Text;
            prodBLL.description = txtDescProd.Text;
            prodBLL.rate = Convert.ToDouble(txtPrecoProd.Text);
            prodBLL.gty = Convert.ToInt32(txtQuanti.Text);
            prodBLL.added_date = DateTime.Now;

            string loggedUser = frmLogin.loggedIn;
            int user = userDAL.GetIDFromUserName(loggedUser);
            prodBLL.added_by = user;

            bool success = prodDAL.Update(prodBLL);
            if (success == true)
            {
                MessageBox.Show("Produto Atualizado Com Sucesso");
                limparform();
            }
            else
            {
                MessageBox.Show("Não Foi Possível Atualizar o Produto");
            }
            DataTable dt = prodDAL.Select();
            dtgView.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //convertentdo o id para int porque vem como txt do form
            prodBLL.id = Convert.ToInt32(txtIDProd.Text);

            bool success = prodDAL.Deletar(prodBLL);
            if (success == true)
            {
                MessageBox.Show("Produto Deletado Com Sucesso");
            }
            else
            {
                MessageBox.Show("Não Foi Possível Deletar o Produto");
            }
            DataTable dt = prodDAL.Select();
            dtgView.DataSource = dt;
            limparform();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable dt = prodDAL.Search(keywords);
                dtgView.DataSource = dt;
            }
            else
            {
                DataTable dt = prodDAL.Search();
                dtgView.DataSource = dt;
            }
        }

        private void dtgView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int rowIndex = e.RowIndex;
            txtIDProd.Text = dtgView.Rows[rowIndex].Cells[0].Value.ToString();
            txtNomeProd.Text = dtgView.Rows[rowIndex].Cells[1].Value.ToString();
            txtCatProd.Text = dtgView.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescProd.Text = dtgView.Rows[rowIndex].Cells[3].Value.ToString();
            txtPrecoProd.Text = dtgView.Rows[rowIndex].Cells[4].Value.ToString();
            txtQuanti.Text = dtgView.Rows[rowIndex].Cells[5].Value.ToString();
        }
    }
}
