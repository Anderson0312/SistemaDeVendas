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
    internal class deaCustDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region metodo de selecionar 

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT * FROM tbl_dea_cust";
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
        public bool Insert(deaCustBLL deaC)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbl_dea_cust(type, name, email, contact, address, added_date, added_by) VALUES (@type, @name, @email, @contact, @address, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@type", deaC.type);
                cmd.Parameters.AddWithValue("@name", deaC.name);
                cmd.Parameters.AddWithValue("@email", deaC.email);
                cmd.Parameters.AddWithValue("@contact", deaC.contact);
                cmd.Parameters.AddWithValue("@address", deaC.address);
                cmd.Parameters.AddWithValue("@added_date", deaC.added_date);
                cmd.Parameters.AddWithValue("@added_by", deaC.added_by);

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

        #region atualizar os dados do banco
        public bool Update(deaCustBLL deaC)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "UPDATE tbl_dea_cust SET type =@type, name=@name ,email = @email, contact = @contact, address=@address, added_date = @added_date, added_by= @added_by WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", deaC.id);
                cmd.Parameters.AddWithValue("@type", deaC.type);
                cmd.Parameters.AddWithValue("@name", deaC.name);
                cmd.Parameters.AddWithValue("@email", deaC.email);
                cmd.Parameters.AddWithValue("@contact", deaC.contact);
                cmd.Parameters.AddWithValue("@address", deaC.address);
                cmd.Parameters.AddWithValue("@added_date", deaC.added_date);
                cmd.Parameters.AddWithValue("@added_by", deaC.added_by);


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
        public bool Deletar(deaCustBLL deaC)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "DELETE FROM tbl_dea_cust WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", deaC.id);

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
                String sql = "SELECT * FROM tbl_dea_cust WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR type LIKE '%" + keywords + "%'";
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

        #region metodo de pesquisa para pesquisar cliente
        public deaCustBLL SearchDealerCustomerForTransaction(string keywords)
        {

            deaCustBLL dc = new deaCustBLL();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT name, email, contact, address FROM tbl_dea_cust WHERE id LIKE '%" + keywords + "%' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dc.name = dt.Rows[0]["name"].ToString();
                    dc.email = dt.Rows[0]["email"].ToString();
                    dc.contact = dt.Rows[0]["contact"].ToString();
                    dc.address = dt.Rows[0]["address"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return dc;
        }
        #endregion

        #region metodo de pesquisa para pegar o id do cliente pelo nome
        public deaCustBLL SearchDealerIDName(string Nome)
        {

            deaCustBLL dc = new deaCustBLL();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT id FROM tbl_dea_cust WHERE name LIKE '%" + Nome + "%' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dc.id = int.Parse(dt.Rows[0]["id"].ToString());

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return dc;
        }
        #endregion
    }
}