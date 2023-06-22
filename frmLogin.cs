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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL loginD = new loginDAL();
        internal static string loggedIn;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.typeuser = cmbUserType.Text.Trim();
            loggedIn = l.username;

            bool Success = loginD.loginCheck(l);
            if (Success == true)
            {
                MessageBox.Show("Bem Vindo ao Sistema! ");
                switch (l.typeuser)
                {
                    case "Administrador":
                        {
                            frmAdminDashBoard adm = new frmAdminDashBoard();
                            adm.Show();
                            adm.lblLogado.Text = l.username.ToUpper();
                            this.Hide();

                        }
                        break;
                    case "Usuario":
                        {
                            frmUserDashBoard user = new frmUserDashBoard();
                            user.Show();
                            user.lblLogado.Text = l.username.ToUpper();
                            user.lbDateTime.Text = DateTime.Now.ToString();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Tipo de Usuario Invalido.");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Não Foi Possivel Acessar!");
            }
        }

        public string ObterNomeUsuarioLogado()
        {
            // Nesse exemplo, estou usando uma variável estática para armazenar o usuário logado
            // Você pode adaptar essa lógica de acordo com sua implementação real
            // Aqui, estou apenas retornando o valor "Usuário Logado" como exemplo
            return l.username;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
        }
    }
}
