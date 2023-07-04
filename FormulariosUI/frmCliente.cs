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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        clienteBLL clienteBLL = new clienteBLL();
        clienteDAL clienteDAL = new clienteDAL();

        private void frmCliente_Load(object sender, EventArgs e)
        {
            DataTable dt = clienteDAL.Select();
            dtgView.DataSource = dt;
            dtgView.Columns[0].HeaderText = "ID_Cliente";
            dtgView.Columns[1].HeaderText = "Tipo";
            dtgView.Columns[2].HeaderText = "Nome";
            dtgView.Columns[3].HeaderText = "Email";
            dtgView.Columns[4].HeaderText = "Contato";
            dtgView.Columns[5].HeaderText = "Endereço";
            dtgView.Columns[6].HeaderText = "Adicionado_em";
            dtgView.Columns[7].HeaderText = "Cadastrado_Por";

        }

        public void limparForm()
        {
            txtClientID.Text = "";
            txtClientName.Text = "";
            txtEmail.Text = "";
            txtContac.Text = "";
            txtAdrress.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparForm();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            clienteBLL.type = cmbtype.Text;
            clienteBLL.name = txtClientName.Text;
            clienteBLL.email = txtEmail.Text;
            clienteBLL.contact = txtContac.Text;
            clienteBLL.address = txtAdrress.Text;
            clienteBLL.added_date = DateTime.Now;

            string loggedUser = frmLogin.loggedIn;
            int user = userDAL.GetIDFromUserName(loggedUser);
            clienteBLL.added_by = user;

            if (clienteBLL.name == "" || clienteBLL.email == "")
            {
                MessageBox.Show("Digite os Dados Para Inserir o Cliente");
            }
            else
            {
                bool success = clienteDAL.Insert(clienteBLL);
                if (success)
                {
                    MessageBox.Show("Cliente Cadastrado Com Sucesso!");
                    limparForm();
                }
                else
                {
                    MessageBox.Show("Não Foi Possível Cadastrar o Cliente");
                }
            }
            DataTable dt = clienteDAL.Select();
            dtgView.DataSource = dt;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //convertentdo o id para int porque vem como txt do form
            clienteBLL.id = Convert.ToInt32(txtClientID.Text);
            clienteBLL.type = cmbtype.Text;
            clienteBLL.name = txtClientName.Text;
            clienteBLL.email = txtEmail.Text;
            clienteBLL.contact = txtContac.Text;
            clienteBLL.address = txtAdrress.Text;
            clienteBLL.added_date = DateTime.Now;


            string loggedUser = frmLogin.loggedIn;
            int user = userDAL.GetIDFromUserName(loggedUser);
            clienteBLL.added_by = user;

            bool success = clienteDAL.Update(clienteBLL);
            if (success == true)
            {
                MessageBox.Show("Cliente Atualizado Com Sucesso");
                limparForm();
            }
            else
            {
                MessageBox.Show("Não Foi Possível Atualizar o Cliente");
            }
            DataTable dt = clienteDAL.Select();
            dtgView.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //convertentdo o id para int porque vem como txt do form
            clienteBLL.id = Convert.ToInt32(txtClientID.Text);

            bool success = clienteDAL.Deletar(clienteBLL);
            if (success == true)
            {
                MessageBox.Show("Cliente Deletado Com Sucesso");
            }
            else
            {
                MessageBox.Show("Não Foi Possível Deletar o Cliente");
            }
            DataTable dt = clienteDAL.Select();
            dtgView.DataSource = dt;
            limparForm();
        }

        private void dtgView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtClientID.Text = dtgView.Rows[rowIndex].Cells[0].Value.ToString();
            cmbtype.Text = dtgView.Rows[rowIndex].Cells[1].Value.ToString();
            txtClientName.Text = dtgView.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dtgView.Rows[rowIndex].Cells[3].Value.ToString();
            txtContac.Text = dtgView.Rows[rowIndex].Cells[4].Value.ToString();
            txtAdrress.Text = dtgView.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable dt = clienteDAL.Search(keywords);
                dtgView.DataSource = dt;
            }
            else
            {
                DataTable dt = clienteDAL.Search();
                dtgView.DataSource = dt;
            }
        }
    }
}
