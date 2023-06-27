using SistemaDeVendas.BLLClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas.DALDados
{
    internal class transactionDAL
    {

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region metodo de selecionar 

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT * FROM tbl_transaction";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        #endregion

        #region Inserir dados no banco de dados
        public static bool Insert(transictionBLL trans, out int transactionID)
        {
            bool isSuccess = false;
            transactionID = -1;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbl_transaction(type, dea_cust_id, grandTotal, transaction_date, tax, discount, acced_by) VALUES (@type, @dea_cust_id, @grandTotal, @transaction_date, @tax, @discount, @acced_by);SELECT @@IDENTITY";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@type", trans.type);
                cmd.Parameters.AddWithValue("@dea_cust_id", trans.dea_cust_id);
                cmd.Parameters.AddWithValue("@grandTotal", trans.grandTotal);
                cmd.Parameters.AddWithValue("@transaction_date", trans.transaction_date);
                cmd.Parameters.AddWithValue("@tax", trans.tax);
                cmd.Parameters.AddWithValue("@discount", trans.discount);
                cmd.Parameters.AddWithValue("@acced_by", trans.acced_by);

                conn.Open();

                object o = cmd.ExecuteScalar();

                if (o != null)
                {
                    transactionID = int.Parse(o.ToString());
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

        #region atualizar os dados do banco
        public bool Update(transictionBLL trans)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "UPDATE tbl_transaction SET type =@type, dea_cust_id=@dea_cust_id ,grandTotal = @grandTotal, transaction_date = @transaction_date, tax=@tax, discount = @discount, acced_by= @acced_by WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", trans.id);
                cmd.Parameters.AddWithValue("@type", trans.type);
                cmd.Parameters.AddWithValue("@dea_cust_id", trans.dea_cust_id);
                cmd.Parameters.AddWithValue("@grandTotal", trans.grandTotal);
                cmd.Parameters.AddWithValue("@transaction_date", trans.transaction_date);
                cmd.Parameters.AddWithValue("@tax", trans.tax);
                cmd.Parameters.AddWithValue("@discount", trans.discount);
                cmd.Parameters.AddWithValue("@acced_by", trans.acced_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
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

        #region Deleta os dados do banco
        public bool Deletar(produtoBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "DELETE FROM tbl_transaction WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", p.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
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

        #region metodo de pesquisa
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbl_transaction WHERE id LIKE '%" + keywords + "%' OR type LIKE '%" + keywords + "%' OR dea_cust_id LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return dt;
            #endregion

        }
    }
}