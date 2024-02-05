using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Classes;
using POSv3.Components;

namespace POSv3.Classes
{
    public class Orders
    {
        public DateTime orderdate { get; set; }
        public string ordertype { get; set; }
        public string status { get; set; }
        public int productid { get; set; }
        public int qty { get; set; }
        public float price { get; set; }
        public float amount { get; set; }
        public float total { get; set; }
        public float received { get; set; }
        public float change { get; set; }
        public int orderid { get; set; }
        public int odid { get; set; }
        public static void AddOrders(Orders order, Panel panel)
        {

            string qry = "INSERT INTO Orders VALUES (@orderId,@orderdate,@ordertype,@total,@received,@change,@status)";
            SqlConnection con = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand(@qry, con);
            cmd.Parameters.Add(new SqlParameter("@orderId", order.orderid));
            cmd.Parameters.Add(new SqlParameter("@orderdate", order.orderdate));
            cmd.Parameters.Add(new SqlParameter("@ordertype", order.ordertype));
            cmd.Parameters.Add(new SqlParameter("@total", order.total));
            cmd.Parameters.Add(new SqlParameter("@received", order.received));
            cmd.Parameters.Add(new SqlParameter("@change", order.change));
            cmd.Parameters.Add(new SqlParameter("@status", order.status));
            cmd.ExecuteNonQuery();
            foreach (UCprodcheckout uc in panel.Controls)
            {
                    string qry2 = "INSERT INTO OrderDetails VALUES (@productid,@qty,@price,@amount,@OrderId)";
                    using (SqlCommand cmd2 = new SqlCommand(qry2, con))
                    {
                        cmd2.Parameters.AddWithValue("@productid",uc.prodid);
                        cmd2.Parameters.AddWithValue("@qty",int.Parse(uc.productqty));
                        cmd2.Parameters.AddWithValue("@price", uc.price);
                        cmd2.Parameters.AddWithValue("@amount", int.Parse(uc.productamt));
                        cmd2.Parameters.AddWithValue("@OrderId", order.orderid);
                        cmd2.ExecuteNonQuery();
                    }
            }
            con.Close();
        }

        public static void UpdateOrders(Orders orders)
        {
            string qry = "UPDATE Orders set received=@received, change=@change WHERE orderId=" + orders.orderid;
            SqlConnection con = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand(@qry, con);
            cmd.Parameters.Add(new SqlParameter("@received", orders.received));
            cmd.Parameters.Add(new SqlParameter("@change", orders.change));
            int rowsaffected = cmd.ExecuteNonQuery();
            if (rowsaffected > 0)
            {
                MessageBox.Show("Update successful!");
            }
            else
            {
                MessageBox.Show("No records updated.");
            }
            con.Close();
        }

        public static void DisplayAndSearchOrders(string query, DataGridView dgv)
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
