using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Classes;
using System.Data.Common;

namespace POSv3.Classes
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public static void AddCategory(Category ctg)
        {
            string qry = "INSERT INTO Category VALUES (@name)";
            SqlConnection con = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand(@qry, con);
            cmd.Parameters.Add(new SqlParameter("@name", ctg.name));
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
        public static void UpdateCategory(Category ctg, int Id)
        {
            string sql = "UPDATE Category SET name=@Name WHERE Id=" + Id;
            SqlConnection conn = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@Name", ctg.name));
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
        public static void DeleteCategory(int id)
        {
            string sql = "DELETE FROM Category WHERE Id=" + id;
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
        public static void DisplayAndSearchCategory(string query, DataGridView dgv)
        {
            string sql = query;
            SqlConnection conn = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
            conn.Close();
        }
    }
}
