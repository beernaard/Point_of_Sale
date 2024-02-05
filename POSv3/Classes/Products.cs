using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Classes;

namespace POSv3.Classes
{
    public class Products
    {
        public string name { get; set; }
        public int id { get; set; }
        public int categoryid { get; set; }
        public string category { get; set; }
        public int price { get; set; }
        public byte[] img { get; set; }

        public List<Products> productlist { get; set; }
        public static Products GetOneProduct(int id)
        {
            string sql = "SELECT * FROM Products WHERE Id=" + id;
            SqlConnection conn = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            Products prod = new Products();

            if (sqlDataReader != null)
            {
                while (sqlDataReader.Read())
                {
                    prod.name = sqlDataReader["pname"].ToString();
                    prod.price = Convert.ToInt32(sqlDataReader["price"].ToString());
                    prod.categoryid = Convert.ToInt32(sqlDataReader["categoryid"].ToString());
                    if (sqlDataReader["productimage"] != DBNull.Value)
                    {
                        prod.img = (byte[])sqlDataReader["productimage"];
                    }
                    else
                    {
                        prod.img = null;
                    }

                }
            }
            return prod;
        }
        public static void GetProducts(string qry, DataGridView dgv)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        public static void AddProduct(Products prod)
        {
            string qry = "INSERT INTO Products VALUES (@pname,@categoryid,@price,@productimage)";
            SqlConnection con = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand(@qry, con);
            cmd.Parameters.Add(new SqlParameter("@pname", prod.name));
            cmd.Parameters.Add(new SqlParameter("@categoryid", prod.categoryid));
            cmd.Parameters.Add(new SqlParameter("@price", prod.price));
            cmd.Parameters.Add(new SqlParameter("@productimage", prod.img));
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed to add category. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdateProduct(Products prod, int Id)
        {
            string sql = "UPDATE Products SET pname=@pname,price=@price,categoryid=@categoryid,productimage=@productimage WHERE Id=" + Id;
            SqlConnection conn = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@pname", prod.name));
            cmd.Parameters.Add(new SqlParameter("@categoryid", prod.categoryid));
            cmd.Parameters.Add(new SqlParameter("@price", prod.price));
            cmd.Parameters.Add(new SqlParameter("@productimage", prod.img));
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed to update the student. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DeleteProduct(int id)
        {
            string sql = "DELETE FROM Products WHERE Id=" + id;
            SqlConnection conn = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed to delete the student. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void CBFill(string qry, ComboBox cb)
        {
            SqlConnection conn = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }
    }
}
