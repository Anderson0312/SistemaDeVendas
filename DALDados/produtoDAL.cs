using Sistema_Vendas.BLLClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using SistemaDeVendas.BLLClasses;

namespace SistemaDeVendas.DALDados
{
    internal class produtoDAL
    {

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region metodo de selecionar 

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT * FROM tbl_product";
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
        public bool Insert(produtoBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbl_product(name, category, description, rate, gty, added_date, added_by) VALUES (@name, @category, @description, @rate, @gty, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@gty", p.gty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

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
        public bool Update(produtoBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "UPDATE tbl_product SET name =@name, category=@category ,description = @description, rate = @rate, gty=@gty, added_date = @added_date, added_by= @added_by WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", p.id);
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@gty", p.gty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);


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
                String sql = "DELETE FROM tbl_product WHERE id=@id";
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
                String sql = "SELECT * FROM tbl_product WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR description LIKE '%" + keywords + "%'";
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

        #region metodo de pesquisa para pesquisar produto
        public produtoBLL SearchDealerCustomerForTransaction(string keywords)
        {

            produtoBLL pBLL = new produtoBLL();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT name, rate, gty FROM tbl_product WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords +"%' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    pBLL.name = dt.Rows[0]["name"].ToString();
                    pBLL.rate = double.Parse(dt.Rows[0]["rate"].ToString());
                    pBLL.gty = int.Parse(dt.Rows[0]["gty"].ToString());

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return pBLL;
        }
        #endregion

        #region metodo de pesquisa para pega o id pelo nome do produto
        public static produtoBLL SearchCustomerForNomeProd(string nomeProduto)
        {

            produtoBLL pBLL = new produtoBLL();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT id FROM tbl_product WHERE name LIKE '%" + nomeProduto + "%' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    pBLL.id = int.Parse(dt.Rows[0]["id"].ToString());


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return pBLL;
        }
        #endregion


        internal DataTable Search()
        {
            throw new NotImplementedException();
        }
    }
}