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

namespace SistemaDeVendas.FormulariosUI
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        deaCustDAL dcDal = new deaCustDAL();
        produtoDAL pDAL = new produtoDAL();
        DataTable transactionDT = new DataTable();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            string type = frmUserDashBoard.transactionType;
            lblTopo.Text = type;
            DateTime date = DateTime.Now;
            this.cmbData.Text = date.ToString();

            //Nomeando as colunas da tabela produto
            transactionDT.Columns.Add("Nome Produto");
            transactionDT.Columns.Add("Valor");
            transactionDT.Columns.Add("Quantidade");
            transactionDT.Columns.Add("Total");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchCli.Text;
            if (keyword == "")
            {
                txtNomeCli.Text = "";
                txtEmailCli.Text = "";
                txtContatoCli.Text = "";
                txtEndercoCliente.Text = "";
                return;
            }
            deaCustBLL dc = dcDal.SearchDealerCustomerForTransaction(keyword);

            txtNomeCli.Text = dc.name;
            txtEmailCli.Text = dc.email;
            txtContatoCli.Text = dc.contact;
            txtEndercoCliente.Text = dc.address;

        }

        private void txtsearchProd_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtsearchProd.Text;
            if (keyword == "")
            {
                txtNomeProd.Text = "";
                txtInventario.Text = "";
                txtQuanti.Text = "";
                txtValor.Text = "";
                return;
            }
            produtoBLL pBLL = pDAL.SearchDealerCustomerForTransaction(keyword);

            txtNomeProd.Text = pBLL.name;
            txtInventario.Text = pBLL.gty.ToString();
            txtValor.Text = pBLL.rate.ToString();
        }

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            string produtctName = txtNomeProd.Text;
            decimal rate = decimal.Parse(txtValor.Text);
            int Qty = int.Parse(txtQuanti.Text);
            decimal Total = rate * Qty;

            decimal subtotal = decimal.Parse(txtSubTotal.Text);
            subtotal = subtotal + Total;

            if (produtctName == "")
            {
                MessageBox.Show("FAVOR DIGITAR NOME DO PRODUTO");
            }
            else
            {
                //inserindo os item na tabela doi gridview
                transactionDT.Rows.Add(produtctName, rate, Qty, Total);
                dgvAddedProducts.DataSource = transactionDT;

                //mostrando o sub total para  user
                txtSubTotal.Text = subtotal.ToString();
                //dps que inserir na tablea limpa os campos abaixo
                txtsearchProd.Text = "";
                txtNomeProd.Text = "";
                txtInventario.Text = "";
                txtValor.Text = "";
                txtQuanti.Text = "";
            }
        }

        private void txtDescont_TextChanged(object sender, EventArgs e)
        {
            string value = txtDescont.Text;
            if (value == "")
            {
                MessageBox.Show("DIGITE O DESCONTO PARA ESTÁ VENDA");

            }
            else
            {
                decimal subtotal = decimal.Parse(txtSubTotal.Text);
                decimal descount = decimal.Parse(txtDescont.Text);

                decimal grandTotal = ((100 - descount) / 100) * subtotal;
                txtTotalGeral.Text = grandTotal.ToString();
            }
        }

        private void txtTotalPago_TextChanged(object sender, EventArgs e)
        {
            string valuepago = txtTotalPago.Text;
            if (valuepago == "")
            {
                MessageBox.Show("DIGITE O TATAL PAGO PARA FINALIZAR");
            }
            else
            {
                decimal grandTotal = decimal.Parse(txtTotalGeral.Text);
                decimal totalPago = decimal.Parse(txtTotalPago.Text);

                decimal troco = totalPago - grandTotal;
                txtTroco.Text = troco.ToString();

            }
        }
    }
}
