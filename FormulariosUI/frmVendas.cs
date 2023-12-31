﻿using DGVPrinterHelper;
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
using System.Transactions;
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


            if (string.IsNullOrEmpty(value))
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
            if (string.IsNullOrEmpty(valuepago))
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

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtTotalGeral.Text != "")
            {
                transictionBLL transaction = new transictionBLL();
                transaction.type = lblTopo.Text;

                string distClientName = txtNomeCli.Text;
                deaCustBLL deaDLL = dcDal.SearchDealerIDName(distClientName);
                transaction.dea_cust_id = deaDLL.id;
                transaction.grandTotal = Math.Round(decimal.Parse(txtTotalGeral.Text), 2);
                transaction.transaction_date = DateTime.Now;
                transaction.tax = 0; //Valor declarado 0 pois não foi implementado imposto no sistema ainda
                transaction.discount = decimal.Parse(txtDescont.Text);

                string usuario = frmLogin.loggedIn;
                int id = userDAL.GetIDFromUserName(usuario);
                transaction.acced_by = id;
                transaction.transacaoDetalhes = transactionDT;

                bool success = false;

                using (TransactionScope scrope = new TransactionScope())
                {
                    int transacaoId = -1;

                    bool w = transactionDAL.Insert(transaction, out transacaoId);
                    for (int i = 0; i < transactionDT.Rows.Count; i++)
                    {
                        transactionDetailBLL transactionDetail = new transactionDetailBLL();
                        string produtoNome = transactionDT.Rows[i][0].ToString();
                        produtoBLL p = produtoDAL.SearchCustomerForNomeProd(produtoNome);

                        transactionDetail.product_id = p.id;
                        transactionDetail.dty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                        transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()));

                        transactionDetail.dea_cust_id = deaDLL.id;
                        transactionDetail.added_date = DateTime.Now;
                        transactionDetail.added_by = id;

                        string transactionType = lblTopo.Text;

                        bool X = false;
                        if (transactionType == "Compra")
                        {
                            X = produtoDAL.IncProduto(transactionDetail.product_id, transactionDetail.dty);
                        }
                        else if (transactionType == "Venda")
                        {
                            X = produtoDAL.DescProduto(transactionDetail.product_id, transactionDetail.dty);
                        }

                        bool y = transactionDetailDAL.InsertTransactionDatail(transactionDetail);
                        //transação = w /inserir = y
                        success = w && X && y;

                    }



                    if (success == true)
                    {
                        scrope.Complete();

                        DGVPrinter printer = new DGVPrinter();
                        printer.Title = "\r\n\r\n SISTEMA DE VENDAS";
                        printer.SubTitle = "Sua Loja Favorita \r\n Telefone : 21 989419431 \r\n\r\n";
                        printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                        printer.PageNumbers = true;
                        printer.PageNumberInHeader = false;
                        printer.PorportionalColumns = true;
                        printer.HeaderCellAlignment = StringAlignment.Near;
                        printer.Footer = "Disconto :" + txtDescont.Text + "% \r\n" + "Valor Total :" + txtTotalGeral.Text + "\r\n" + "OBRIGADO PELA COMPRA";
                        printer.FooterSpacing = 15;
                        printer.PrintDataGridView(dgvAddedProducts);





                        MessageBox.Show("DADOS SALVOS COM SUCESSO");
                        dgvAddedProducts.DataSource = null;
                        dgvAddedProducts.Rows.Clear();
                        dgvAddedProducts.Refresh();

                        txtSearchCli.Text = "";
                        txtNomeCli.Text = "";
                        txtEmailCli.Text = "";
                        txtContatoCli.Text = "";
                        txtEndercoCliente.Text = "";
                        txtNomeProd.Text = "";
                        txtInventario.Text = "";
                        txtQuanti.Text = "";
                        txtValor.Text = "";
                        txtsearchProd.Text = "";
                        txtNomeProd.Text = "";
                        txtInventario.Text = "";
                        txtValor.Text = "";
                        txtQuanti.Text = "";
                        txtSubTotal.Text = "0";
                        txtDescont.Text = "0";
                        txtTotalGeral.Text = "0";
                        txtTotalPago.Text = "0";
                        txtTroco.Text = "0";
                    }
                    else
                    {
                        MessageBox.Show("NÃO FOI POSSIVEL SALVAR OS DADOS");
                    }
                }
            }
            else
            {
                MessageBox.Show("VALOR TOTAL NECESSARIO");
            }

        }
    }
}
