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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUserName.Text;
            u.password = txtPassword.Text;
            u.contact = txtPhoneNumber.Text;
            u.address = txtAdrress.Text;
            u.gender = cmbSex.Text;
            u.user_type = cmbTypeUser.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            if (u.first_name == "" || u.last_name == "" || u.email == "" || u.username == "" || u.password == "" || u.user_type == "")
            {
                MessageBox.Show("Digit os Dados Para Inserir o Usuario");
            }
            else
            {
                bool success = dal.Insert(u);
                if (success)
                {
                    MessageBox.Show("Usuario Cadastrado Com Sucesso!");
                    limparform();
                }
                else
                {
                    MessageBox.Show("Não Foi Possível Cadastrar o Usuario");
                }
            }
            DataTable dt = dal.Select();
            dtgView.DataSource = dt;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparform();
        }

        private void limparform()
        {
            txtUserID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtPhoneNumber.Text = "";
            txtAdrress.Text = "";
            cmbSex.Text = "";
            cmbTypeUser.Text = "";
        }

        private void dtgView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtUserID.Text = dtgView.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dtgView.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dtgView.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dtgView.Rows[rowIndex].Cells[3].Value.ToString();
            txtUserName.Text = dtgView.Rows[rowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dtgView.Rows[rowIndex].Cells[5].Value.ToString();
            txtPhoneNumber.Text = dtgView.Rows[rowIndex].Cells[6].Value.ToString();
            txtAdrress.Text = dtgView.Rows[rowIndex].Cells[7].Value.ToString();
            cmbSex.Text = dtgView.Rows[rowIndex].Cells[8].Value.ToString();
            cmbTypeUser.Text = dtgView.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //convertentdo o id para int porque vem como txt do form
            u.id = Convert.ToInt32(txtUserID.Text);
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUserName.Text;
            u.password = txtPassword.Text;
            u.contact = txtPhoneNumber.Text;
            u.address = txtAdrress.Text;
            u.gender = cmbSex.Text;
            u.user_type = cmbTypeUser.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            bool success = dal.Update(u);
            if (success == true)
            {
                MessageBox.Show("Usuario Atualizado Com Sucesso");
                limparform();
            }
            else
            {
                MessageBox.Show("Não Foi Possível Atualizar o Usuario");
            }
            DataTable dt = dal.Select();
            dtgView.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //convertentdo o id para int porque vem como txt do form
            u.id = Convert.ToInt32(txtUserID.Text);

            bool success = dal.Deletar(u);
            if (success == true)
            {
                MessageBox.Show("Usuario Deletado Com Sucesso");
            }
            else
            {
                MessageBox.Show("Não Foi Possível Deletar o Usuario");
            }
            DataTable dt = dal.Select();
            dtgView.DataSource = dt;
            limparform();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dtgView.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Search();
                dtgView.DataSource = dt;
            }
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dtgView.DataSource = dt;
            dtgView.Columns[0].HeaderText = "ID_Usuario";
            dtgView.Columns[1].HeaderText = "Nome";
            dtgView.Columns[2].HeaderText = "S_Nome";
            dtgView.Columns[3].HeaderText = "Email";
            dtgView.Columns[4].HeaderText = "username";
            dtgView.Columns[5].HeaderText = "Senha";
            dtgView.Columns[6].HeaderText = "Telefone";
            dtgView.Columns[7].HeaderText = "Endereço";
            dtgView.Columns[8].HeaderText = "Sexo";
            dtgView.Columns[9].HeaderText = "Tipo_Usuario";
            dtgView.Columns[10].HeaderText = "Data_Hora";
            dtgView.Columns[11].HeaderText = "Cadastrado_Por";
        }
    }
}
