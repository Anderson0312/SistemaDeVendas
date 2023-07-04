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
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        transactionDAL transDAL = new transactionDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            DataTable dt = transDAL.ShowTransaction();
            dvgTransaction.DataSource = dt;

        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbSearch.Text;
            DataTable dt = transDAL.ShowTransactionForType(tipo);
            dvgTransaction.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = transDAL.ShowTransaction();
            dvgTransaction.DataSource = dt;
        }
    }
}
