using SistemaDeVendas.BLLClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas.DALDados
{
    internal class transactionDetailDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Inserir dados no banco de dados
        public static bool InsertTransactionDatail(transactionDetailBLL transD)
        {
            bool isSuccess = false; 
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbl_transaction_dateil(product_id, rate, dty, total, dea_cust_id, added_date, added_by) VALUES (@product_id, @rate, @dty, @total, @dea_cust_id, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@product_id", transD.product_id);
                cmd.Parameters.AddWithValue("@rate", transD.rate);
                cmd.Parameters.AddWithValue("@dty", transD.dty);
                cmd.Parameters.AddWithValue("@total", transD.total);
                cmd.Parameters.AddWithValue("@dea_cust_id", transD.dea_cust_id);
                cmd.Parameters.AddWithValue("@added_date", transD.added_date);
                cmd.Parameters.AddWithValue("@added_by", transD.added_by);

                conn.Open();

                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {

                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }
        #endregion

    }
}
