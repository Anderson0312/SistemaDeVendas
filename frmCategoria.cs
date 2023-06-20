using Sistema_Vendas.BLLClasses;
using Sistema_Vendas.DALDados;
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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        categoriaBLL catBLL = new categoriaBLL();
        categoriaDAL catDAL = new categoriaDAL();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            catBLL.title = txtTituloCatego.Text;
            catBLL.description = txtDesc.Text;
            catBLL.added_date = DateTime.Now;
            catBLL.added_by = 1;

            if (catBLL.title == "" || catBLL.description == "")
            {
                MessageBox.Show("Digite os Dados Para Inserir o Usuario");
            }
            else
            {
                bool success = catDAL.Insert(catBLL);
                if (success)
                {
                    MessageBox.Show("Categoria Cadastrado Com Sucesso!");
                    limparform();
                }
                else
                {
                    MessageBox.Show("Não Foi Possível Cadastrar a Categoria");
                }
            }
            DataTable dt = catDAL.Select();
            dtgView.DataSource = dt;
        }

        private void limparform()
        {
            txtTituloCatego.Text = "";
            txtDesc.Text = "";
            txtCategoriaID.Text = "";
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            DataTable dt = catDAL.Select();
            dtgView.DataSource = dt;
            dtgView.Columns[0].HeaderText = "ID_Categoria";
            dtgView.Columns[1].HeaderText = "Titulo";
            dtgView.Columns[2].HeaderText = "Descrição";
            dtgView.Columns[3].HeaderText = "added_date";
            dtgView.Columns[4].HeaderText = "added_by";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparform();
        }

        private void dtgView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtCategoriaID.Text = dtgView.Rows[rowIndex].Cells[0].Value.ToString();
            txtTituloCatego.Text = dtgView.Rows[rowIndex].Cells[1].Value.ToString();
            txtDesc.Text = dtgView.Rows[rowIndex].Cells[2].Value.ToString();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //convertentdo o id para int porque vem como txt do form
            catBLL.id = Convert.ToInt32(txtCategoriaID.Text);
            catBLL.title = txtTituloCatego.Text;
            catBLL.description = txtDesc.Text;
            catBLL.added_date = DateTime.Now;
            catBLL.added_by = 1;

            bool success = catDAL.Update(catBLL);
            if (success == true)
            {
                MessageBox.Show("Categoria Atualizado Com Sucesso");
                limparform();
            }
            else
            {
                MessageBox.Show("Não Foi Possível Atualizar o Categoria");
            }
            DataTable dt = catDAL.Select();
            dtgView.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //convertentdo o id para int porque vem como txt do form
            catBLL.id = Convert.ToInt32(txtCategoriaID.Text);

            bool success = catDAL.Deletar(catBLL);
            if (success == true)
            {
                MessageBox.Show("Categoria Deletado Com Sucesso");
            }
            else
            {
                MessageBox.Show("Não Foi Possível Deletar o Categoria");
            }
            DataTable dt = catDAL.Select();
            dtgView.DataSource = dt;
            limparform();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable dt = catDAL.Search(keywords);
                dtgView.DataSource = dt;
            }
            else
            {
                DataTable dt = catDAL.Search();
                dtgView.DataSource = dt;
            }
        }
    }
}
